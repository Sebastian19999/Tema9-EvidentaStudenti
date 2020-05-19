
namespace InterfataUtilizator
{
    partial class FormularStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.gpbProgrameStudiu = new System.Windows.Forms.GroupBox();
            this.rdbInginerieE = new System.Windows.Forms.RadioButton();
            this.rdbElectronica = new System.Windows.Forms.RadioButton();
            this.rdbElectrotehnica = new System.Windows.Forms.RadioButton();
            this.rdbCalculatoare = new System.Windows.Forms.RadioButton();
            this.rdbAutomatica = new System.Windows.Forms.RadioButton();
            this.lblSpecializare = new System.Windows.Forms.Label();
            this.ckbPIU = new System.Windows.Forms.CheckBox();
            this.ckbPOO = new System.Windows.Forms.CheckBox();
            this.ckbPCLP = new System.Windows.Forms.CheckBox();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.ckbDEEA2 = new System.Windows.Forms.CheckBox();
            this.ckbED = new System.Windows.Forms.CheckBox();
            this.ckbMEST = new System.Windows.Forms.CheckBox();
            this.gpbDiscipline = new System.Windows.Forms.GroupBox();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAnStudiu = new System.Windows.Forms.Label();
            this.cmbAnStudiu = new System.Windows.Forms.ComboBox();
            this.gpbProgrameStudiu.SuspendLayout();
            this.gpbDiscipline.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(25, 38);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(45, 17);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(25, 74);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(65, 17);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(25, 345);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(38, 17);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Note";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(129, 396);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(124, 28);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(129, 30);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(277, 22);
            this.txtNume.TabIndex = 4;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(129, 65);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(277, 22);
            this.txtPrenume.TabIndex = 5;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(129, 345);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(277, 22);
            this.txtNote.TabIndex = 6;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(269, 396);
            this.btnAfiseaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(139, 28);
            this.btnAfiseaza.TabIndex = 10;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(129, 441);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(124, 28);
            this.btnCauta.TabIndex = 12;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(125, 443);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 17);
            this.lblMesaj.TabIndex = 13;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(269, 441);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(139, 28);
            this.btnModifica.TabIndex = 14;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // gpbProgrameStudiu
            // 
            this.gpbProgrameStudiu.Controls.Add(this.rdbInginerieE);
            this.gpbProgrameStudiu.Controls.Add(this.rdbElectronica);
            this.gpbProgrameStudiu.Controls.Add(this.rdbElectrotehnica);
            this.gpbProgrameStudiu.Controls.Add(this.rdbCalculatoare);
            this.gpbProgrameStudiu.Controls.Add(this.rdbAutomatica);
            this.gpbProgrameStudiu.Location = new System.Drawing.Point(129, 107);
            this.gpbProgrameStudiu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbProgrameStudiu.Name = "gpbProgrameStudiu";
            this.gpbProgrameStudiu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbProgrameStudiu.Size = new System.Drawing.Size(277, 123);
            this.gpbProgrameStudiu.TabIndex = 18;
            this.gpbProgrameStudiu.TabStop = false;
            // 
            // rdbInginerieE
            // 
            this.rdbInginerieE.AutoSize = true;
            this.rdbInginerieE.Location = new System.Drawing.Point(20, 69);
            this.rdbInginerieE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbInginerieE.Name = "rdbInginerieE";
            this.rdbInginerieE.Size = new System.Drawing.Size(152, 21);
            this.rdbInginerieE.TabIndex = 12;
            this.rdbInginerieE.TabStop = true;
            this.rdbInginerieE.Text = "InginerieEconomica";
            this.rdbInginerieE.UseVisualStyleBackColor = true;
            // 
            // rdbElectronica
            // 
            this.rdbElectronica.AutoSize = true;
            this.rdbElectronica.Location = new System.Drawing.Point(20, 39);
            this.rdbElectronica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbElectronica.Name = "rdbElectronica";
            this.rdbElectronica.Size = new System.Drawing.Size(99, 21);
            this.rdbElectronica.TabIndex = 10;
            this.rdbElectronica.TabStop = true;
            this.rdbElectronica.Text = "Electronica";
            this.rdbElectronica.UseVisualStyleBackColor = true;
            // 
            // rdbElectrotehnica
            // 
            this.rdbElectrotehnica.AutoSize = true;
            this.rdbElectrotehnica.Location = new System.Drawing.Point(140, 39);
            this.rdbElectrotehnica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbElectrotehnica.Name = "rdbElectrotehnica";
            this.rdbElectrotehnica.Size = new System.Drawing.Size(119, 21);
            this.rdbElectrotehnica.TabIndex = 11;
            this.rdbElectrotehnica.TabStop = true;
            this.rdbElectrotehnica.Text = "Electrotehnica";
            this.rdbElectrotehnica.UseVisualStyleBackColor = true;
            // 
            // rdbCalculatoare
            // 
            this.rdbCalculatoare.AutoSize = true;
            this.rdbCalculatoare.Location = new System.Drawing.Point(20, 11);
            this.rdbCalculatoare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbCalculatoare.Name = "rdbCalculatoare";
            this.rdbCalculatoare.Size = new System.Drawing.Size(108, 21);
            this.rdbCalculatoare.TabIndex = 8;
            this.rdbCalculatoare.TabStop = true;
            this.rdbCalculatoare.Text = "Calculatoare";
            this.rdbCalculatoare.UseVisualStyleBackColor = true;
            // 
            // rdbAutomatica
            // 
            this.rdbAutomatica.AutoSize = true;
            this.rdbAutomatica.Location = new System.Drawing.Point(140, 11);
            this.rdbAutomatica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbAutomatica.Name = "rdbAutomatica";
            this.rdbAutomatica.Size = new System.Drawing.Size(99, 21);
            this.rdbAutomatica.TabIndex = 9;
            this.rdbAutomatica.TabStop = true;
            this.rdbAutomatica.Text = "Automatica";
            this.rdbAutomatica.UseVisualStyleBackColor = true;
            // 
            // lblSpecializare
            // 
            this.lblSpecializare.AutoSize = true;
            this.lblSpecializare.Location = new System.Drawing.Point(25, 121);
            this.lblSpecializare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecializare.Name = "lblSpecializare";
            this.lblSpecializare.Size = new System.Drawing.Size(93, 17);
            this.lblSpecializare.TabIndex = 17;
            this.lblSpecializare.Text = "Specializarea";
            // 
            // ckbPIU
            // 
            this.ckbPIU.AutoSize = true;
            this.ckbPIU.Location = new System.Drawing.Point(205, 16);
            this.ckbPIU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbPIU.Name = "ckbPIU";
            this.ckbPIU.Size = new System.Drawing.Size(52, 21);
            this.ckbPIU.TabIndex = 22;
            this.ckbPIU.Text = "PIU";
            this.ckbPIU.UseVisualStyleBackColor = true;
            this.ckbPIU.CheckedChanged += new System.EventHandler(this.ckbDiscipline_CheckedChanged);
            // 
            // ckbPOO
            // 
            this.ckbPOO.AutoSize = true;
            this.ckbPOO.Location = new System.Drawing.Point(120, 15);
            this.ckbPOO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbPOO.Name = "ckbPOO";
            this.ckbPOO.Size = new System.Drawing.Size(61, 21);
            this.ckbPOO.TabIndex = 21;
            this.ckbPOO.Text = "POO";
            this.ckbPOO.UseVisualStyleBackColor = true;
            this.ckbPOO.CheckedChanged += new System.EventHandler(this.ckbDiscipline_CheckedChanged);
            // 
            // ckbPCLP
            // 
            this.ckbPCLP.AutoSize = true;
            this.ckbPCLP.Location = new System.Drawing.Point(16, 14);
            this.ckbPCLP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbPCLP.Name = "ckbPCLP";
            this.ckbPCLP.Size = new System.Drawing.Size(65, 21);
            this.ckbPCLP.TabIndex = 20;
            this.ckbPCLP.Text = "PCLP";
            this.ckbPCLP.UseVisualStyleBackColor = true;
            this.ckbPCLP.CheckedChanged += new System.EventHandler(this.ckbDiscipline_CheckedChanged);
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(25, 272);
            this.lblDiscipline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(68, 17);
            this.lblDiscipline.TabIndex = 19;
            this.lblDiscipline.Text = "Discipline";
            // 
            // ckbDEEA2
            // 
            this.ckbDEEA2.AutoSize = true;
            this.ckbDEEA2.Location = new System.Drawing.Point(16, 43);
            this.ckbDEEA2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbDEEA2.Name = "ckbDEEA2";
            this.ckbDEEA2.Size = new System.Drawing.Size(75, 21);
            this.ckbDEEA2.TabIndex = 23;
            this.ckbDEEA2.Text = "DEEA2";
            this.ckbDEEA2.UseVisualStyleBackColor = true;
            this.ckbDEEA2.CheckedChanged += new System.EventHandler(this.ckbDiscipline_CheckedChanged);
            // 
            // ckbED
            // 
            this.ckbED.AutoSize = true;
            this.ckbED.Location = new System.Drawing.Point(120, 44);
            this.ckbED.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbED.Name = "ckbED";
            this.ckbED.Size = new System.Drawing.Size(49, 21);
            this.ckbED.TabIndex = 24;
            this.ckbED.Text = "ED";
            this.ckbED.UseVisualStyleBackColor = true;
            this.ckbED.CheckedChanged += new System.EventHandler(this.ckbDiscipline_CheckedChanged);
            // 
            // ckbMEST
            // 
            this.ckbMEST.AutoSize = true;
            this.ckbMEST.Location = new System.Drawing.Point(204, 44);
            this.ckbMEST.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbMEST.Name = "ckbMEST";
            this.ckbMEST.Size = new System.Drawing.Size(68, 21);
            this.ckbMEST.TabIndex = 25;
            this.ckbMEST.Text = "MEST";
            this.ckbMEST.UseVisualStyleBackColor = true;
            this.ckbMEST.CheckedChanged += new System.EventHandler(this.ckbDiscipline_CheckedChanged);
            // 
            // gpbDiscipline
            // 
            this.gpbDiscipline.Controls.Add(this.ckbMEST);
            this.gpbDiscipline.Controls.Add(this.ckbPCLP);
            this.gpbDiscipline.Controls.Add(this.ckbED);
            this.gpbDiscipline.Controls.Add(this.ckbPOO);
            this.gpbDiscipline.Controls.Add(this.ckbDEEA2);
            this.gpbDiscipline.Controls.Add(this.ckbPIU);
            this.gpbDiscipline.Location = new System.Drawing.Point(129, 271);
            this.gpbDiscipline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbDiscipline.Name = "gpbDiscipline";
            this.gpbDiscipline.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbDiscipline.Size = new System.Drawing.Size(279, 69);
            this.gpbDiscipline.TabIndex = 26;
            this.gpbDiscipline.TabStop = false;
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 16;
            this.lstAfisare.Location = new System.Drawing.Point(477, 30);
            this.lstAfisare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(473, 324);
            this.lstAfisare.TabIndex = 27;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.lstAfisare_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(25, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 17);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "label1";
            this.lblID.Visible = false;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblAnStudiu
            // 
            this.lblAnStudiu.AutoSize = true;
            this.lblAnStudiu.Location = new System.Drawing.Point(25, 233);
            this.lblAnStudiu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnStudiu.Name = "lblAnStudiu";
            this.lblAnStudiu.Size = new System.Drawing.Size(67, 17);
            this.lblAnStudiu.TabIndex = 29;
            this.lblAnStudiu.Text = "An studiu";
            // 
            // cmbAnStudiu
            // 
            this.cmbAnStudiu.FormattingEnabled = true;
            this.cmbAnStudiu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbAnStudiu.Location = new System.Drawing.Point(129, 233);
            this.cmbAnStudiu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAnStudiu.Name = "cmbAnStudiu";
            this.cmbAnStudiu.Size = new System.Drawing.Size(277, 24);
            this.cmbAnStudiu.TabIndex = 30;
            this.cmbAnStudiu.SelectedIndexChanged += new System.EventHandler(this.cmbAnStudiu_SelectedIndexChanged);
            // 
            // FormularStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 498);
            this.Controls.Add(this.cmbAnStudiu);
            this.Controls.Add(this.lblAnStudiu);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.gpbDiscipline);
            this.Controls.Add(this.lblDiscipline);
            this.Controls.Add(this.gpbProgrameStudiu);
            this.Controls.Add(this.lblSpecializare);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularStudent";
            this.Text = "Administrare studenti";
            this.gpbProgrameStudiu.ResumeLayout(false);
            this.gpbProgrameStudiu.PerformLayout();
            this.gpbDiscipline.ResumeLayout(false);
            this.gpbDiscipline.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblAdauga;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.GroupBox gpbProgrameStudiu;
        private System.Windows.Forms.RadioButton rdbCalculatoare;
        private System.Windows.Forms.RadioButton rdbAutomatica;
        private System.Windows.Forms.Label lblSpecializare;
        private System.Windows.Forms.CheckBox ckbPIU;
        private System.Windows.Forms.CheckBox ckbPOO;
        private System.Windows.Forms.CheckBox ckbPCLP;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.RadioButton rdbInginerieE;
        private System.Windows.Forms.RadioButton rdbElectronica;
        private System.Windows.Forms.RadioButton rdbElectrotehnica;
        private System.Windows.Forms.CheckBox ckbDEEA2;
        private System.Windows.Forms.CheckBox ckbED;
        private System.Windows.Forms.CheckBox ckbMEST;
        private System.Windows.Forms.GroupBox gpbDiscipline;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAnStudiu;
        private System.Windows.Forms.ComboBox cmbAnStudiu;
    }
}

