namespace FormulaOneCrudFormProject
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTeam = new System.Windows.Forms.TabPage();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChief = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChassis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameTeam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.listBoxTeam = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nuovoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.apriToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stampaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tagliaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.incollaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabPageDriver = new System.Windows.Forms.TabPage();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnExportJSON = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageTeam.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageTeam);
            this.tabControlMain.Controls.Add(this.tabPageDriver);
            this.tabControlMain.Controls.Add(this.tabPageServices);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(940, 519);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageTeam
            // 
            this.tabPageTeam.Controls.Add(this.btnExportJSON);
            this.tabPageTeam.Controls.Add(this.btnExportCSV);
            this.tabPageTeam.Controls.Add(this.txtName);
            this.tabPageTeam.Controls.Add(this.label9);
            this.tabPageTeam.Controls.Add(this.txtID);
            this.tabPageTeam.Controls.Add(this.label8);
            this.tabPageTeam.Controls.Add(this.txtUnit);
            this.tabPageTeam.Controls.Add(this.label5);
            this.tabPageTeam.Controls.Add(this.txtChief);
            this.tabPageTeam.Controls.Add(this.label4);
            this.tabPageTeam.Controls.Add(this.txtChassis);
            this.tabPageTeam.Controls.Add(this.label3);
            this.tabPageTeam.Controls.Add(this.txtCountry);
            this.tabPageTeam.Controls.Add(this.label2);
            this.tabPageTeam.Controls.Add(this.txtNameTeam);
            this.tabPageTeam.Controls.Add(this.label1);
            this.tabPageTeam.Controls.Add(this.btnTest);
            this.tabPageTeam.Controls.Add(this.listBoxTeam);
            this.tabPageTeam.Controls.Add(this.toolStrip1);
            this.tabPageTeam.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeam.Name = "tabPageTeam";
            this.tabPageTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeam.Size = new System.Drawing.Size(932, 493);
            this.tabPageTeam.TabIndex = 0;
            this.tabPageTeam.Text = "TEAM";
            this.tabPageTeam.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(330, 127);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(127, 20);
            this.txtName.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(172, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(330, 56);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(127, 20);
            this.txtID.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(330, 275);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(127, 20);
            this.txtUnit.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Power Unit";
            // 
            // txtChief
            // 
            this.txtChief.Location = new System.Drawing.Point(330, 203);
            this.txtChief.Name = "txtChief";
            this.txtChief.ReadOnly = true;
            this.txtChief.Size = new System.Drawing.Size(127, 20);
            this.txtChief.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Technical Chief";
            // 
            // txtChassis
            // 
            this.txtChassis.Location = new System.Drawing.Point(330, 239);
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.ReadOnly = true;
            this.txtChassis.Size = new System.Drawing.Size(127, 20);
            this.txtChassis.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chassis";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(330, 166);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(127, 20);
            this.txtCountry.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Country";
            // 
            // txtNameTeam
            // 
            this.txtNameTeam.Location = new System.Drawing.Point(330, 89);
            this.txtNameTeam.Name = "txtNameTeam";
            this.txtNameTeam.ReadOnly = true;
            this.txtNameTeam.Size = new System.Drawing.Size(127, 20);
            this.txtNameTeam.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name Team";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(213, 3);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // listBoxTeam
            // 
            this.listBoxTeam.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxTeam.FormattingEnabled = true;
            this.listBoxTeam.Location = new System.Drawing.Point(3, 28);
            this.listBoxTeam.Name = "listBoxTeam";
            this.listBoxTeam.Size = new System.Drawing.Size(120, 462);
            this.listBoxTeam.TabIndex = 1;
            this.listBoxTeam.SelectedIndexChanged += new System.EventHandler(this.listBoxTeam_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripButton,
            this.apriToolStripButton,
            this.salvaToolStripButton,
            this.stampaToolStripButton,
            this.toolStripSeparator,
            this.tagliaToolStripButton,
            this.copiaToolStripButton,
            this.incollaToolStripButton,
            this.toolStripSeparator1,
            this.ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(926, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nuovoToolStripButton
            // 
            this.nuovoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuovoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuovoToolStripButton.Image")));
            this.nuovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuovoToolStripButton.Name = "nuovoToolStripButton";
            this.nuovoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nuovoToolStripButton.Text = "&Nuovo";
            // 
            // apriToolStripButton
            // 
            this.apriToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.apriToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("apriToolStripButton.Image")));
            this.apriToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.apriToolStripButton.Name = "apriToolStripButton";
            this.apriToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.apriToolStripButton.Text = "&Apri";
            // 
            // salvaToolStripButton
            // 
            this.salvaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvaToolStripButton.Image")));
            this.salvaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvaToolStripButton.Name = "salvaToolStripButton";
            this.salvaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvaToolStripButton.Text = "&Salva";
            // 
            // stampaToolStripButton
            // 
            this.stampaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stampaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stampaToolStripButton.Image")));
            this.stampaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stampaToolStripButton.Name = "stampaToolStripButton";
            this.stampaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.stampaToolStripButton.Text = "&Stampa";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tagliaToolStripButton
            // 
            this.tagliaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tagliaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("tagliaToolStripButton.Image")));
            this.tagliaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tagliaToolStripButton.Name = "tagliaToolStripButton";
            this.tagliaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.tagliaToolStripButton.Text = "&Taglia";
            // 
            // copiaToolStripButton
            // 
            this.copiaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiaToolStripButton.Image")));
            this.copiaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiaToolStripButton.Name = "copiaToolStripButton";
            this.copiaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copiaToolStripButton.Text = "&Copia";
            // 
            // incollaToolStripButton
            // 
            this.incollaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.incollaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("incollaToolStripButton.Image")));
            this.incollaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.incollaToolStripButton.Name = "incollaToolStripButton";
            this.incollaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.incollaToolStripButton.Text = "&Incolla";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton
            // 
            this.ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton.Image")));
            this.ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton.Name = "ToolStripButton";
            this.ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton.Text = "&?";
            // 
            // tabPageDriver
            // 
            this.tabPageDriver.Location = new System.Drawing.Point(4, 22);
            this.tabPageDriver.Name = "tabPageDriver";
            this.tabPageDriver.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDriver.Size = new System.Drawing.Size(932, 493);
            this.tabPageDriver.TabIndex = 1;
            this.tabPageDriver.Text = "DRIVER";
            this.tabPageDriver.UseVisualStyleBackColor = true;
            // 
            // tabPageServices
            // 
            this.tabPageServices.Location = new System.Drawing.Point(4, 22);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Size = new System.Drawing.Size(932, 493);
            this.tabPageServices.TabIndex = 2;
            this.tabPageServices.Text = "-- Services --";
            this.tabPageServices.UseVisualStyleBackColor = true;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(838, 3);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(75, 23);
            this.btnExportCSV.TabIndex = 22;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            // 
            // btnExportJSON
            // 
            this.btnExportJSON.Location = new System.Drawing.Point(748, 3);
            this.btnExportJSON.Name = "btnExportJSON";
            this.btnExportJSON.Size = new System.Drawing.Size(84, 23);
            this.btnExportJSON.TabIndex = 23;
            this.btnExportJSON.Text = "Export JSON";
            this.btnExportJSON.UseVisualStyleBackColor = true;
            this.btnExportJSON.Click += new System.EventHandler(this.btnExportJSON_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 519);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "Formula One CRUD";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTeam.ResumeLayout(false);
            this.tabPageTeam.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTeam;
        private System.Windows.Forms.ListBox listBoxTeam;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton nuovoToolStripButton;
        private System.Windows.Forms.ToolStripButton apriToolStripButton;
        private System.Windows.Forms.ToolStripButton salvaToolStripButton;
        private System.Windows.Forms.ToolStripButton stampaToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tagliaToolStripButton;
        private System.Windows.Forms.ToolStripButton copiaToolStripButton;
        private System.Windows.Forms.ToolStripButton incollaToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButton;
        private System.Windows.Forms.TabPage tabPageDriver;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChief;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChassis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExportJSON;
        private System.Windows.Forms.Button btnExportCSV;
    }
}

