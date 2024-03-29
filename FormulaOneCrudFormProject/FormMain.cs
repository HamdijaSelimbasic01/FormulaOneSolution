﻿using System;
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
        private DbTools db;
        BindingList<Team> teams;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            db = new DbTools();
            teams = db.LoadTeams();
            listBoxTeam.DataSource = teams;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Team t = new Team(9999,"Test","Team di Test",new Country("IT","Italy"),"Ferrari","Belliardo","Test Chassis",null,null);
            teams.Add(t);
            listBoxTeam.DataSource = null;
            listBoxTeam.DataSource = teams;
        }
    }
}
