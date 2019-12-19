using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Reflection;

// using Microsoft.SqlServer.Management.Smo;

namespace FormulaOneDll
{
    public class DbTools
    {
        public const string pathname = @"C:\Users\h.selimbasic.0518\Desktop\FormulaOneSolution\ClientJS";
        /*
        public void createCountriesWithSmo()
        {
            string sqlConnectionString = "connection string here";
            FileInfo file = new FileInfo(@"filepath to script.sql");
            string script = file.OpenText().ReadToEnd();
            SqlConnection conn = new SqlConnection(sqlConnectionString);
            Server server = new Server(new ServerConnection(conn));
            try
            {
                server.ConnectionContext.ExecuteNonQuery(script);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.InnerException.Message);
            }

            file.OpenText().Close();
            conn.Close();
            Console.WriteLine("createCountries: SUCCESS!");
        }
        */

        public const string WORKINGPATH = @"C:\Dati\";
        public const string CONNSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dati\FormulaOne.mdf;Integrated Security=True";

        private Dictionary<string, Country> countries;
        private Dictionary<int, Driver> drivers;

        public void ExecuteSqlScript(string sqlScriptName)
        {
            var fileContent = File.ReadAllText(WORKINGPATH + sqlScriptName);
            fileContent = fileContent.Replace("\r\n", "");
            fileContent = fileContent.Replace("\r", "");
            fileContent = fileContent.Replace("\n", "");
            fileContent = fileContent.Replace("\t", "");
            var sqlqueries = fileContent.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            var con = new SqlConnection(CONNSTR);
            var cmd = new SqlCommand("query", con);
            con.Open();
            int i = 0;
            foreach (var query in sqlqueries)
            {
                cmd.CommandText = query;
                i++;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException err)
                {
                    Console.WriteLine("Errore in esecuzione della query numero: " + i);
                    Console.WriteLine($"\tErrore: {err.Number} - {err.Message}");
                }
            }
            con.Close();
        }

        public void DropTable(string tableName)
        {
            var con = new SqlConnection(CONNSTR);
            var cmd = new SqlCommand($"Drop Table {tableName};", con);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException err)
            {
                Console.WriteLine($"\tErrore SQL: {err.Number} - {err.Message}");
            }
            con.Close();
        }

        public Dictionary<string, Country> GetCountries()
        {
            if (countries == null)
            {
                countries = new Dictionary<string, Country>();
                var con = new SqlConnection(CONNSTR);

                using (con)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Countries;", con);
                    con.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string countryIsoCode = reader.GetString(0);
                        Country country = new Country(countryIsoCode, reader.GetString(1));
                        countries.Add(countryIsoCode, country);
                    }
                    reader.Close();
                }
            }
            return countries;
        }

        private Dictionary<int, Driver> GetDrivers(bool forceReload = false)
        {
            if (forceReload || drivers == null)
            {
                drivers = new Dictionary<int, Driver>();
                var con = new SqlConnection(CONNSTR);

                using (con)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Drivers", con);
                    con.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Driver d = new Driver(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetDateTime(3),
                            reader.GetString(4),
                            GetCountries()[reader.GetString(5)]
                        );
                        drivers.Add(d.Id, d);
                    }
                }
            }
            return drivers;
        }

        public BindingList<Team> LoadTeams()
        {
            BindingList<Team> retVal = new BindingList<Team>();

            var con = new SqlConnection(CONNSTR);

            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Teams;", con);
                con.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string teamCountryCode = reader.GetString(3);
                    // Country teamCountry = GetCountries().Find(item => item.CountryCode == teamCountryCode);
                    Country teamCountry = GetCountries()[teamCountryCode];
                    Driver firstDriver = GetDrivers()[reader.GetInt32(7)];
                    Driver secondDriver = GetDrivers()[reader.GetInt32(8)];

                    Team t = new Team(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        teamCountry,
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                        firstDriver,
                        secondDriver
                    );
                    retVal.Add(t);
                }
                reader.Close();
            }

            return retVal;
        }

        public static IEnumerable<string> ToCsv<T>(IEnumerable<T> objectlist, string separator = "|")
        {
            foreach (var o in objectlist)
            {
                FieldInfo[] fields = o.GetType().GetFields();
                PropertyInfo[] properties = o.GetType().GetProperties();

                yield return string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Concat(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray());
            }
        }

        public static void SerializeToJson<T>(IEnumerable<T> objectlist, string pathName)
        {
            string json = JsonConvert.SerializeObject(objectlist, Formatting.Indented);
            File.WriteAllText(pathName, json);
        }

        public static void SerializeToCsv<T>(IEnumerable<T> objectlist, string pathName, string separator = "|")
        {
            IEnumerable<string> dataToSave = DbTools.ToCsv(objectlist, separator);
            File.WriteAllLines(pathName, dataToSave);
        }
    }
}
