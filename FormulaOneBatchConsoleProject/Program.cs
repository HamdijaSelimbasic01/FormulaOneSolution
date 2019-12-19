using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormulaOneDll;

namespace FormulaOneBatchConsoleProject
{
    class Program
    {
        static DbTools db = new DbTools();

        static void Main(string[] args)
        {
            char scelta = ' ';
            do
            {
                Console.WriteLine("*** FORMULA ONE - BATCH SCRIPTS ***");
                Console.WriteLine("1 - Create Countries");
                Console.WriteLine("2 - Create Teams");
                Console.WriteLine("3 - Create Drivers");
                Console.WriteLine("4 - Create Races");
                Console.WriteLine("------------------------");
                Console.WriteLine("A - DROP Countries");
                Console.WriteLine("B - DROP Teams");
                Console.WriteLine("C - DROP Drivers");
                Console.WriteLine("D - DROP Races");
                Console.WriteLine("------------------------");
                Console.WriteLine("R - Reset DB");
                Console.WriteLine("------------------------");
                Console.WriteLine("X - EXIT");
                scelta = Console.ReadKey(true).KeyChar;
                switch (scelta)
                {
                    case '1':
                        CallExecuteSqlScript("Countries");
                        break;
                    case '2':
                        CallExecuteSqlScript("Teams");
                        break;
                    case '3':
                        CallExecuteSqlScript("Drivers");
                        break;
                    case '4':
                        CallExecuteSqlScript("Races");
                        break;
                    case 'A':
                        CallDropTable("Countries");
                        break;
                    case 'B':
                        CallDropTable("Teams");
                        break;
                    case 'C':
                        CallDropTable("Drivers");
                        break;
                    case 'D':
                        CallDropTable("Races");
                        break;
                    case 'R':
                    case 'r':
                        resetDB();
                        break;
                    case 'x': case 'X':
                        Console.WriteLine("\nUscita in corso...\n");
                        break;
                    default:
                        Console.WriteLine("\nUncorrect Choice - Try Again\n");
                        break;
                }
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (scelta != 'X' && scelta != 'x');
        }

        private static void resetDB()
        {
            char scelta = ' ';
            Console.Write("ATTENIONE!!! Questo script resetterà il database. Sei sicuro di proseguire?[s/n] ");
            scelta = Console.ReadKey().KeyChar;
            if (scelta == 's' || scelta == 'S') {
                try
                {
                    bool isOk;
                    isOk = CallDropTable("Teams");
                    if (isOk) isOk = CallDropTable("Drivers");
                    if (isOk) isOk = CallDropTable("Countries");
                    if (isOk) isOk = CallDropTable("Races");
                    if (isOk) isOk = CallExecuteSqlScript("Countries");
                    if (isOk) isOk = CallExecuteSqlScript("Teams");
                    if (isOk) isOk = CallExecuteSqlScript("Drivers");
                    if (isOk) isOk = CallExecuteSqlScript("Races");
                    if (isOk) isOk = CallExecuteSqlScript("SetConstraints");
                    if (isOk) Console.WriteLine("\nDatabase resettato correttamente\n");
                    else throw new Exception();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"OPS: Qualcosa è andato storto! {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Operazione annullata");
            }
        }

        static bool CallExecuteSqlScript(string scriptName)
        {
            try
            {
                db.ExecuteSqlScript(scriptName + ".sql");
                Console.WriteLine($"\nCreate {scriptName} - SUCCESS");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nCreate {scriptName} - ERROR: {ex.Message}\n");
                return false;
            }
        }

        static bool CallDropTable(string tableName)
        {
            try
            {
                db.DropTable(tableName);
                Console.WriteLine($"\nDROP {tableName} - SUCCESS");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nDROP {tableName} - ERROR:{ex.Message}\n");
                return false;
            }
        }
    }
}
