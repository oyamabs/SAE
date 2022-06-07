namespace SAE
{
    partial class PagePanneauAdministration
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAjoutLigne = new System.Windows.Forms.TabPage();
            this.lblFlecheAjout = new System.Windows.Forms.Label();
            this.tabModifLigne = new System.Windows.Forms.TabPage();
            this.cmdModifLigne = new System.Windows.Forms.Button();
            this.comboSelectLigne = new System.Windows.Forms.ComboBox();
            this.tabSupprLigne = new System.Windows.Forms.TabPage();
            this.cmdSupprLigne = new System.Windows.Forms.Button();
            this.chkConfirmSupprLigne = new System.Windows.Forms.CheckBox();
            this.comboSelectLigneSuppr = new System.Windows.Forms.ComboBox();
            this.tabAjoutStation = new System.Windows.Forms.TabPage();
            this.cmdAjoutStation = new System.Windows.Forms.Button();
            this.chkAscenceurAjout = new System.Windows.Forms.CheckBox();
            this.chkStationnementAjout = new System.Windows.Forms.CheckBox();
            this.txtAjoutStation = new System.Windows.Forms.TextBox();
            this.tabModifStation = new System.Windows.Forms.TabPage();
            this.cmdModifStation = new System.Windows.Forms.Button();
            this.chkAscenceurModif = new System.Windows.Forms.CheckBox();
            this.chkStationnementModif = new System.Windows.Forms.CheckBox();
            this.comboSelectStationModif = new System.Windows.Forms.ComboBox();
            this.tabSupprStation = new System.Windows.Forms.TabPage();
            this.cmdSupprStation = new System.Windows.Forms.Button();
            this.chkConfirmStationSuppr = new System.Windows.Forms.CheckBox();
            this.comboSelectStationSuppr = new System.Windows.Forms.ComboBox();
            this.txtNomLigneAjout = new System.Windows.Forms.TextBox();
            this.cmdAjoutLigne = new System.Windows.Forms.Button();
            this.comboAjoutTerminus1 = new System.Windows.Forms.ComboBox();
            this.comboAjoutTerminus2 = new System.Windows.Forms.ComboBox();
            this.comboModifTerminus2 = new System.Windows.Forms.ComboBox();
            this.comboModifTerminus1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAjoutLigne.SuspendLayout();
            this.tabModifLigne.SuspendLayout();
            this.tabSupprLigne.SuspendLayout();
            this.tabAjoutStation.SuspendLayout();
            this.tabModifStation.SuspendLayout();
            this.tabSupprStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAjoutLigne);
            this.tabControl1.Controls.Add(this.tabModifLigne);
            this.tabControl1.Controls.Add(this.tabSupprLigne);
            this.tabControl1.Controls.Add(this.tabAjoutStation);
            this.tabControl1.Controls.Add(this.tabModifStation);
            this.tabControl1.Controls.Add(this.tabSupprStation);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1034, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAjoutLigne
            // 
            this.tabAjoutLigne.Controls.Add(this.comboAjoutTerminus2);
            this.tabAjoutLigne.Controls.Add(this.comboAjoutTerminus1);
            this.tabAjoutLigne.Controls.Add(this.cmdAjoutLigne);
            this.tabAjoutLigne.Controls.Add(this.txtNomLigneAjout);
            this.tabAjoutLigne.Controls.Add(this.lblFlecheAjout);
            this.tabAjoutLigne.Location = new System.Drawing.Point(4, 25);
            this.tabAjoutLigne.Name = "tabAjoutLigne";
            this.tabAjoutLigne.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjoutLigne.Size = new System.Drawing.Size(1026, 393);
            this.tabAjoutLigne.TabIndex = 0;
            this.tabAjoutLigne.Text = "Ajouter une ligne";
            this.tabAjoutLigne.UseVisualStyleBackColor = true;
            // 
            // lblFlecheAjout
            // 
            this.lblFlecheAjout.AutoSize = true;
            this.lblFlecheAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlecheAjout.Location = new System.Drawing.Point(458, 180);
            this.lblFlecheAjout.Name = "lblFlecheAjout";
            this.lblFlecheAjout.Size = new System.Drawing.Size(118, 32);
            this.lblFlecheAjout.TabIndex = 1;
            this.lblFlecheAjout.Text = "←———→";
            // 
            // tabModifLigne
            // 
            this.tabModifLigne.Controls.Add(this.comboModifTerminus2);
            this.tabModifLigne.Controls.Add(this.comboModifTerminus1);
            this.tabModifLigne.Controls.Add(this.label1);
            this.tabModifLigne.Controls.Add(this.cmdModifLigne);
            this.tabModifLigne.Controls.Add(this.comboSelectLigne);
            this.tabModifLigne.Location = new System.Drawing.Point(4, 25);
            this.tabModifLigne.Name = "tabModifLigne";
            this.tabModifLigne.Padding = new System.Windows.Forms.Padding(3);
            this.tabModifLigne.Size = new System.Drawing.Size(1026, 393);
            this.tabModifLigne.TabIndex = 1;
            this.tabModifLigne.Text = "Modifier une ligne";
            this.tabModifLigne.UseVisualStyleBackColor = true;
            // 
            // cmdModifLigne
            // 
            this.cmdModifLigne.Location = new System.Drawing.Point(12, 345);
            this.cmdModifLigne.Name = "cmdModifLigne";
            this.cmdModifLigne.Size = new System.Drawing.Size(1007, 36);
            this.cmdModifLigne.TabIndex = 29;
            this.cmdModifLigne.Text = "Modifier la ligne";
            this.cmdModifLigne.UseVisualStyleBackColor = true;
            this.cmdModifLigne.Click += new System.EventHandler(this.cmdModifLigne_Click);
            // 
            // comboSelectLigne
            // 
            this.comboSelectLigne.FormattingEnabled = true;
            this.comboSelectLigne.Location = new System.Drawing.Point(8, 10);
            this.comboSelectLigne.Name = "comboSelectLigne";
            this.comboSelectLigne.Size = new System.Drawing.Size(1011, 24);
            this.comboSelectLigne.TabIndex = 0;
            this.comboSelectLigne.Text = "--Sélectionner une ligne--";
            this.comboSelectLigne.SelectedIndexChanged += new System.EventHandler(this.comboSelectLigne_SelectedIndexChanged);
            // 
            // tabSupprLigne
            // 
            this.tabSupprLigne.Controls.Add(this.cmdSupprLigne);
            this.tabSupprLigne.Controls.Add(this.chkConfirmSupprLigne);
            this.tabSupprLigne.Controls.Add(this.comboSelectLigneSuppr);
            this.tabSupprLigne.Location = new System.Drawing.Point(4, 25);
            this.tabSupprLigne.Name = "tabSupprLigne";
            this.tabSupprLigne.Size = new System.Drawing.Size(1026, 393);
            this.tabSupprLigne.TabIndex = 2;
            this.tabSupprLigne.Text = "Supprimer une ligne";
            this.tabSupprLigne.UseVisualStyleBackColor = true;
            // 
            // cmdSupprLigne
            // 
            this.cmdSupprLigne.Enabled = false;
            this.cmdSupprLigne.Location = new System.Drawing.Point(8, 358);
            this.cmdSupprLigne.Name = "cmdSupprLigne";
            this.cmdSupprLigne.Size = new System.Drawing.Size(1011, 23);
            this.cmdSupprLigne.TabIndex = 2;
            this.cmdSupprLigne.Text = "Supprimer la ligne";
            this.cmdSupprLigne.UseVisualStyleBackColor = true;
            this.cmdSupprLigne.Click += new System.EventHandler(this.cmdSupprLigne_Click);
            // 
            // chkConfirmSupprLigne
            // 
            this.chkConfirmSupprLigne.AutoSize = true;
            this.chkConfirmSupprLigne.Location = new System.Drawing.Point(8, 186);
            this.chkConfirmSupprLigne.Name = "chkConfirmSupprLigne";
            this.chkConfirmSupprLigne.Size = new System.Drawing.Size(425, 20);
            this.chkConfirmSupprLigne.TabIndex = 1;
            this.chkConfirmSupprLigne.Text = "Je confirme la suppression à tout jamais de la ligne (c\'est très long)";
            this.chkConfirmSupprLigne.UseVisualStyleBackColor = true;
            this.chkConfirmSupprLigne.CheckedChanged += new System.EventHandler(this.chkConfirmSupprLigne_CheckedChanged);
            // 
            // comboSelectLigneSuppr
            // 
            this.comboSelectLigneSuppr.FormattingEnabled = true;
            this.comboSelectLigneSuppr.Location = new System.Drawing.Point(8, 3);
            this.comboSelectLigneSuppr.Name = "comboSelectLigneSuppr";
            this.comboSelectLigneSuppr.Size = new System.Drawing.Size(1011, 24);
            this.comboSelectLigneSuppr.TabIndex = 0;
            this.comboSelectLigneSuppr.Text = "--Sélectionner une ligne--";
            this.comboSelectLigneSuppr.SelectedIndexChanged += new System.EventHandler(this.comboSelectLigneSuppr_SelectedIndexChanged);
            // 
            // tabAjoutStation
            // 
            this.tabAjoutStation.Controls.Add(this.cmdAjoutStation);
            this.tabAjoutStation.Controls.Add(this.chkAscenceurAjout);
            this.tabAjoutStation.Controls.Add(this.chkStationnementAjout);
            this.tabAjoutStation.Controls.Add(this.txtAjoutStation);
            this.tabAjoutStation.Location = new System.Drawing.Point(4, 25);
            this.tabAjoutStation.Name = "tabAjoutStation";
            this.tabAjoutStation.Size = new System.Drawing.Size(1026, 393);
            this.tabAjoutStation.TabIndex = 3;
            this.tabAjoutStation.Text = "Ajouter une station";
            this.tabAjoutStation.UseVisualStyleBackColor = true;
            // 
            // cmdAjoutStation
            // 
            this.cmdAjoutStation.Location = new System.Drawing.Point(8, 358);
            this.cmdAjoutStation.Name = "cmdAjoutStation";
            this.cmdAjoutStation.Size = new System.Drawing.Size(1011, 23);
            this.cmdAjoutStation.TabIndex = 3;
            this.cmdAjoutStation.Text = "Ajouter la station";
            this.cmdAjoutStation.UseVisualStyleBackColor = true;
            this.cmdAjoutStation.Click += new System.EventHandler(this.cmdAjoutStation_Click);
            // 
            // chkAscenceurAjout
            // 
            this.chkAscenceurAjout.AutoSize = true;
            this.chkAscenceurAjout.Location = new System.Drawing.Point(862, 186);
            this.chkAscenceurAjout.Name = "chkAscenceurAjout";
            this.chkAscenceurAjout.Size = new System.Drawing.Size(157, 20);
            this.chkAscenceurAjout.TabIndex = 2;
            this.chkAscenceurAjout.Text = "Y a t\'il un ascenceur ?";
            this.chkAscenceurAjout.UseVisualStyleBackColor = true;
            // 
            // chkStationnementAjout
            // 
            this.chkStationnementAjout.AutoSize = true;
            this.chkStationnementAjout.Location = new System.Drawing.Point(8, 186);
            this.chkStationnementAjout.Name = "chkStationnementAjout";
            this.chkStationnementAjout.Size = new System.Drawing.Size(229, 20);
            this.chkStationnementAjout.TabIndex = 1;
            this.chkStationnementAjout.Text = "Stationnement près de la station ?";
            this.chkStationnementAjout.UseVisualStyleBackColor = true;
            // 
            // txtAjoutStation
            // 
            this.txtAjoutStation.ForeColor = System.Drawing.Color.Gray;
            this.txtAjoutStation.Location = new System.Drawing.Point(8, 3);
            this.txtAjoutStation.Name = "txtAjoutStation";
            this.txtAjoutStation.Size = new System.Drawing.Size(1011, 22);
            this.txtAjoutStation.TabIndex = 0;
            this.txtAjoutStation.Text = "Saisir le nom de la station";
            this.txtAjoutStation.Enter += new System.EventHandler(this.textBoxEnter);
            this.txtAjoutStation.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // tabModifStation
            // 
            this.tabModifStation.Controls.Add(this.cmdModifStation);
            this.tabModifStation.Controls.Add(this.chkAscenceurModif);
            this.tabModifStation.Controls.Add(this.chkStationnementModif);
            this.tabModifStation.Controls.Add(this.comboSelectStationModif);
            this.tabModifStation.Location = new System.Drawing.Point(4, 25);
            this.tabModifStation.Name = "tabModifStation";
            this.tabModifStation.Size = new System.Drawing.Size(1026, 393);
            this.tabModifStation.TabIndex = 4;
            this.tabModifStation.Text = "Modifier une station";
            this.tabModifStation.UseVisualStyleBackColor = true;
            // 
            // cmdModifStation
            // 
            this.cmdModifStation.Location = new System.Drawing.Point(8, 358);
            this.cmdModifStation.Name = "cmdModifStation";
            this.cmdModifStation.Size = new System.Drawing.Size(1011, 23);
            this.cmdModifStation.TabIndex = 5;
            this.cmdModifStation.Text = "Modifier la station";
            this.cmdModifStation.UseVisualStyleBackColor = true;
            this.cmdModifStation.Click += new System.EventHandler(this.cmdModifStation_Click);
            // 
            // chkAscenceurModif
            // 
            this.chkAscenceurModif.AutoSize = true;
            this.chkAscenceurModif.Location = new System.Drawing.Point(862, 186);
            this.chkAscenceurModif.Name = "chkAscenceurModif";
            this.chkAscenceurModif.Size = new System.Drawing.Size(157, 20);
            this.chkAscenceurModif.TabIndex = 4;
            this.chkAscenceurModif.Text = "Y a t\'il un ascenceur ?";
            this.chkAscenceurModif.UseVisualStyleBackColor = true;
            // 
            // chkStationnementModif
            // 
            this.chkStationnementModif.AutoSize = true;
            this.chkStationnementModif.Location = new System.Drawing.Point(8, 186);
            this.chkStationnementModif.Name = "chkStationnementModif";
            this.chkStationnementModif.Size = new System.Drawing.Size(229, 20);
            this.chkStationnementModif.TabIndex = 3;
            this.chkStationnementModif.Text = "Stationnement près de la station ?";
            this.chkStationnementModif.UseVisualStyleBackColor = true;
            // 
            // comboSelectStationModif
            // 
            this.comboSelectStationModif.FormattingEnabled = true;
            this.comboSelectStationModif.Location = new System.Drawing.Point(8, 10);
            this.comboSelectStationModif.Name = "comboSelectStationModif";
            this.comboSelectStationModif.Size = new System.Drawing.Size(1011, 24);
            this.comboSelectStationModif.TabIndex = 0;
            this.comboSelectStationModif.Text = "--Sélectionner une station--";
            this.comboSelectStationModif.SelectedIndexChanged += new System.EventHandler(this.comboSelectStationModif_SelectedIndexChanged);
            // 
            // tabSupprStation
            // 
            this.tabSupprStation.Controls.Add(this.cmdSupprStation);
            this.tabSupprStation.Controls.Add(this.chkConfirmStationSuppr);
            this.tabSupprStation.Controls.Add(this.comboSelectStationSuppr);
            this.tabSupprStation.Location = new System.Drawing.Point(4, 25);
            this.tabSupprStation.Name = "tabSupprStation";
            this.tabSupprStation.Size = new System.Drawing.Size(1026, 393);
            this.tabSupprStation.TabIndex = 5;
            this.tabSupprStation.Text = "Supprimer une station";
            this.tabSupprStation.UseVisualStyleBackColor = true;
            // 
            // cmdSupprStation
            // 
            this.cmdSupprStation.Enabled = false;
            this.cmdSupprStation.Location = new System.Drawing.Point(8, 358);
            this.cmdSupprStation.Name = "cmdSupprStation";
            this.cmdSupprStation.Size = new System.Drawing.Size(1011, 23);
            this.cmdSupprStation.TabIndex = 3;
            this.cmdSupprStation.Text = "Supprimer la station";
            this.cmdSupprStation.UseVisualStyleBackColor = true;
            this.cmdSupprStation.Click += new System.EventHandler(this.cmdSupprStation_Click);
            // 
            // chkConfirmStationSuppr
            // 
            this.chkConfirmStationSuppr.AutoSize = true;
            this.chkConfirmStationSuppr.Location = new System.Drawing.Point(8, 186);
            this.chkConfirmStationSuppr.Name = "chkConfirmStationSuppr";
            this.chkConfirmStationSuppr.Size = new System.Drawing.Size(425, 20);
            this.chkConfirmStationSuppr.TabIndex = 2;
            this.chkConfirmStationSuppr.Text = "Je confirme la suppression à tout jamais de la ligne (c\'est très long)";
            this.chkConfirmStationSuppr.UseVisualStyleBackColor = true;
            this.chkConfirmStationSuppr.CheckedChanged += new System.EventHandler(this.chkConfirmStationSuppr_CheckedChanged);
            // 
            // comboSelectStationSuppr
            // 
            this.comboSelectStationSuppr.FormattingEnabled = true;
            this.comboSelectStationSuppr.Location = new System.Drawing.Point(8, 3);
            this.comboSelectStationSuppr.Name = "comboSelectStationSuppr";
            this.comboSelectStationSuppr.Size = new System.Drawing.Size(1011, 24);
            this.comboSelectStationSuppr.TabIndex = 1;
            this.comboSelectStationSuppr.Text = "--Sélectionner une station--";
            this.comboSelectStationSuppr.SelectedIndexChanged += new System.EventHandler(this.comboSelectStationSuppr_SelectedIndexChanged);
            // 
            // txtNomLigneAjout
            // 
            this.txtNomLigneAjout.ForeColor = System.Drawing.Color.Gray;
            this.txtNomLigneAjout.Location = new System.Drawing.Point(8, 6);
            this.txtNomLigneAjout.Name = "txtNomLigneAjout";
            this.txtNomLigneAjout.Size = new System.Drawing.Size(1011, 22);
            this.txtNomLigneAjout.TabIndex = 19;
            this.txtNomLigneAjout.Text = "Saisir le nom de la ligne";
            this.txtNomLigneAjout.Enter += new System.EventHandler(this.textBoxEnter);
            this.txtNomLigneAjout.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // cmdAjoutLigne
            // 
            this.cmdAjoutLigne.Location = new System.Drawing.Point(11, 348);
            this.cmdAjoutLigne.Name = "cmdAjoutLigne";
            this.cmdAjoutLigne.Size = new System.Drawing.Size(1008, 33);
            this.cmdAjoutLigne.TabIndex = 20;
            this.cmdAjoutLigne.Text = "Créer la ligne";
            this.cmdAjoutLigne.UseVisualStyleBackColor = true;
            this.cmdAjoutLigne.Click += new System.EventHandler(this.cmdAjoutLigne_Click);
            // 
            // comboAjoutTerminus1
            // 
            this.comboAjoutTerminus1.FormattingEnabled = true;
            this.comboAjoutTerminus1.Location = new System.Drawing.Point(8, 190);
            this.comboAjoutTerminus1.Name = "comboAjoutTerminus1";
            this.comboAjoutTerminus1.Size = new System.Drawing.Size(444, 24);
            this.comboAjoutTerminus1.TabIndex = 21;
            this.comboAjoutTerminus1.Text = "--Sélectionner terminus 1--";
            this.comboAjoutTerminus1.SelectedIndexChanged += new System.EventHandler(this.selectTerminus);
            // 
            // comboAjoutTerminus2
            // 
            this.comboAjoutTerminus2.FormattingEnabled = true;
            this.comboAjoutTerminus2.Location = new System.Drawing.Point(582, 188);
            this.comboAjoutTerminus2.Name = "comboAjoutTerminus2";
            this.comboAjoutTerminus2.Size = new System.Drawing.Size(436, 24);
            this.comboAjoutTerminus2.TabIndex = 22;
            this.comboAjoutTerminus2.Text = "--Sélectionner terminus 2--";
            this.comboAjoutTerminus2.SelectedIndexChanged += new System.EventHandler(this.selectTerminus);
            // 
            // comboModifTerminus2
            // 
            this.comboModifTerminus2.FormattingEnabled = true;
            this.comboModifTerminus2.Location = new System.Drawing.Point(582, 187);
            this.comboModifTerminus2.Name = "comboModifTerminus2";
            this.comboModifTerminus2.Size = new System.Drawing.Size(436, 24);
            this.comboModifTerminus2.TabIndex = 32;
            this.comboModifTerminus2.Text = "--Sélectionner terminus 2--";
            this.comboModifTerminus2.SelectedIndexChanged += new System.EventHandler(this.selectModifCombo);
            // 
            // comboModifTerminus1
            // 
            this.comboModifTerminus1.FormattingEnabled = true;
            this.comboModifTerminus1.Location = new System.Drawing.Point(8, 189);
            this.comboModifTerminus1.Name = "comboModifTerminus1";
            this.comboModifTerminus1.Size = new System.Drawing.Size(444, 24);
            this.comboModifTerminus1.TabIndex = 31;
            this.comboModifTerminus1.Text = "--Sélectionner terminus 1--";
            this.comboModifTerminus1.SelectedIndexChanged += new System.EventHandler(this.selectModifCombo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "←———→";
            // 
            // PagePanneauAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 420);
            this.Controls.Add(this.tabControl1);
            this.Name = "PagePanneauAdministration";
            this.Text = "Métro de Montréal - Panneau d\'administration";
            this.Load += new System.EventHandler(this.PagePanneauAdministration_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAjoutLigne.ResumeLayout(false);
            this.tabAjoutLigne.PerformLayout();
            this.tabModifLigne.ResumeLayout(false);
            this.tabModifLigne.PerformLayout();
            this.tabSupprLigne.ResumeLayout(false);
            this.tabSupprLigne.PerformLayout();
            this.tabAjoutStation.ResumeLayout(false);
            this.tabAjoutStation.PerformLayout();
            this.tabModifStation.ResumeLayout(false);
            this.tabModifStation.PerformLayout();
            this.tabSupprStation.ResumeLayout(false);
            this.tabSupprStation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAjoutLigne;
        private System.Windows.Forms.TabPage tabModifLigne;
        private System.Windows.Forms.TabPage tabSupprLigne;
        private System.Windows.Forms.TabPage tabAjoutStation;
        private System.Windows.Forms.TabPage tabModifStation;
        private System.Windows.Forms.TabPage tabSupprStation;
        private System.Windows.Forms.Label lblFlecheAjout;
        private System.Windows.Forms.ComboBox comboSelectLigne;
        private System.Windows.Forms.ComboBox comboSelectLigneSuppr;
        private System.Windows.Forms.Button cmdSupprLigne;
        private System.Windows.Forms.CheckBox chkConfirmSupprLigne;
        private System.Windows.Forms.Button cmdAjoutStation;
        private System.Windows.Forms.CheckBox chkAscenceurAjout;
        private System.Windows.Forms.CheckBox chkStationnementAjout;
        private System.Windows.Forms.TextBox txtAjoutStation;
        private System.Windows.Forms.Button cmdModifStation;
        private System.Windows.Forms.CheckBox chkAscenceurModif;
        private System.Windows.Forms.CheckBox chkStationnementModif;
        private System.Windows.Forms.ComboBox comboSelectStationModif;
        private System.Windows.Forms.Button cmdSupprStation;
        private System.Windows.Forms.CheckBox chkConfirmStationSuppr;
        private System.Windows.Forms.ComboBox comboSelectStationSuppr;
        private System.Windows.Forms.Button cmdModifLigne;
        private System.Windows.Forms.TextBox txtNomLigneAjout;
        private System.Windows.Forms.Button cmdAjoutLigne;
        private System.Windows.Forms.ComboBox comboAjoutTerminus2;
        private System.Windows.Forms.ComboBox comboAjoutTerminus1;
        private System.Windows.Forms.ComboBox comboModifTerminus2;
        private System.Windows.Forms.ComboBox comboModifTerminus1;
        private System.Windows.Forms.Label label1;
    }
}