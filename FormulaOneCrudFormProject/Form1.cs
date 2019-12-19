using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FormulaOneDll;

namespace FormulaOneCrudFormProject
{
    public partial class FormMain : Form
    {
        DbTools db;
        BindingList<Team> teams;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            db = new DbTools();
            teams = new BindingList<Team>(db.LoadTeams());
            listBoxTeam.DataSource = teams;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Team t = new Team(999, "test", "team di test", new Country("IT", "Italy"), "Ferrari", "Belly", "Chassis Test", null, null);
            teams.Add(t);
        }

        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(this.listBoxTeam.SelectedIndex);
            txtID.Text = (teams[pos].Id).ToString();
            txtNameTeam.Text = (teams[pos].FullTeamName).ToString();
            txtName.Text = (teams[pos].Name).ToString();
            txtCountry.Text = (teams[pos].Country).ToString();
            txtChief.Text = (teams[pos].TechnicalChief).ToString();
            txtChassis.Text = (teams[pos].Chassis).ToString();
            txtUnit.Text = (teams[pos].PowerUnit).ToString();
            

            //MessageBox.Show(team);
        }

        private void btnExportJSON_Click(object sender, EventArgs e)
        {
            try
            {
                DbTools.SerializeToJson(teams, @".\Teams.json");
                MessageBox.Show("Esportazione completata");
            }
            catch (Exception)
            {
                MessageBox.Show("Esportazione fallita");
            }
            DbTools.SerializeToJson(teams, @".\Teams.json");
        }
    }
}
