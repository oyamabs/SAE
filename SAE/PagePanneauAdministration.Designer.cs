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
            this.lblFleche = new System.Windows.Forms.Label();
            this.txtTerminus1 = new System.Windows.Forms.TextBox();
            this.tabModifLigne = new System.Windows.Forms.TabPage();
            this.tabSupprLigne = new System.Windows.Forms.TabPage();
            this.tabAjoutStation = new System.Windows.Forms.TabPage();
            this.tabModifStation = new System.Windows.Forms.TabPage();
            this.tabSupprStation = new System.Windows.Forms.TabPage();
            this.txtTerminus2 = new System.Windows.Forms.TextBox();
            this.lblAjoutStation = new System.Windows.Forms.Label();
            this.txtRechercheStations = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.lblStations = new System.Windows.Forms.Label();
            this.lblSeperationVerticale = new System.Windows.Forms.Label();
            this.listResultatsRecherche = new System.Windows.Forms.ListBox();
            this.listStations = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabAjoutLigne.SuspendLayout();
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
            this.tabAjoutLigne.Controls.Add(this.listStations);
            this.tabAjoutLigne.Controls.Add(this.listResultatsRecherche);
            this.tabAjoutLigne.Controls.Add(this.lblSeperationVerticale);
            this.tabAjoutLigne.Controls.Add(this.lblStations);
            this.tabAjoutLigne.Controls.Add(this.lblRecherche);
            this.tabAjoutLigne.Controls.Add(this.txtRechercheStations);
            this.tabAjoutLigne.Controls.Add(this.lblAjoutStation);
            this.tabAjoutLigne.Controls.Add(this.txtTerminus2);
            this.tabAjoutLigne.Controls.Add(this.lblFleche);
            this.tabAjoutLigne.Controls.Add(this.txtTerminus1);
            this.tabAjoutLigne.Location = new System.Drawing.Point(4, 25);
            this.tabAjoutLigne.Name = "tabAjoutLigne";
            this.tabAjoutLigne.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjoutLigne.Size = new System.Drawing.Size(1026, 393);
            this.tabAjoutLigne.TabIndex = 0;
            this.tabAjoutLigne.Text = "Ajouter une ligne";
            this.tabAjoutLigne.UseVisualStyleBackColor = true;
            // 
            // lblFleche
            // 
            this.lblFleche.AutoSize = true;
            this.lblFleche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFleche.Location = new System.Drawing.Point(454, 6);
            this.lblFleche.Name = "lblFleche";
            this.lblFleche.Size = new System.Drawing.Size(118, 32);
            this.lblFleche.TabIndex = 1;
            this.lblFleche.Text = "←———→";
            // 
            // txtTerminus1
            // 
            this.txtTerminus1.ForeColor = System.Drawing.Color.Gray;
            this.txtTerminus1.Location = new System.Drawing.Point(8, 16);
            this.txtTerminus1.Name = "txtTerminus1";
            this.txtTerminus1.Size = new System.Drawing.Size(440, 22);
            this.txtTerminus1.TabIndex = 0;
            this.txtTerminus1.Text = "Saisir terminus 1";
            this.txtTerminus1.Enter += new System.EventHandler(this.txtTerminus1_Enter);
            this.txtTerminus1.Leave += new System.EventHandler(this.txtTerminus1_Leave);
            // 
            // tabModifLigne
            // 
            this.tabModifLigne.Location = new System.Drawing.Point(4, 25);
            this.tabModifLigne.Name = "tabModifLigne";
            this.tabModifLigne.Padding = new System.Windows.Forms.Padding(3);
            this.tabModifLigne.Size = new System.Drawing.Size(1026, 393);
            this.tabModifLigne.TabIndex = 1;
            this.tabModifLigne.Text = "Modifier une ligne";
            this.tabModifLigne.UseVisualStyleBackColor = true;
            // 
            // tabSupprLigne
            // 
            this.tabSupprLigne.Location = new System.Drawing.Point(4, 25);
            this.tabSupprLigne.Name = "tabSupprLigne";
            this.tabSupprLigne.Size = new System.Drawing.Size(1026, 393);
            this.tabSupprLigne.TabIndex = 2;
            this.tabSupprLigne.Text = "Supprimer une ligne";
            this.tabSupprLigne.UseVisualStyleBackColor = true;
            // 
            // tabAjoutStation
            // 
            this.tabAjoutStation.Location = new System.Drawing.Point(4, 25);
            this.tabAjoutStation.Name = "tabAjoutStation";
            this.tabAjoutStation.Size = new System.Drawing.Size(1026, 393);
            this.tabAjoutStation.TabIndex = 3;
            this.tabAjoutStation.Text = "Ajouter une station";
            this.tabAjoutStation.UseVisualStyleBackColor = true;
            // 
            // tabModifStation
            // 
            this.tabModifStation.Location = new System.Drawing.Point(4, 25);
            this.tabModifStation.Name = "tabModifStation";
            this.tabModifStation.Size = new System.Drawing.Size(1026, 393);
            this.tabModifStation.TabIndex = 4;
            this.tabModifStation.Text = "Modifier une station";
            this.tabModifStation.UseVisualStyleBackColor = true;
            // 
            // tabSupprStation
            // 
            this.tabSupprStation.Location = new System.Drawing.Point(4, 25);
            this.tabSupprStation.Name = "tabSupprStation";
            this.tabSupprStation.Size = new System.Drawing.Size(1026, 393);
            this.tabSupprStation.TabIndex = 5;
            this.tabSupprStation.Text = "Supprimer une station";
            this.tabSupprStation.UseVisualStyleBackColor = true;
            // 
            // txtTerminus2
            // 
            this.txtTerminus2.ForeColor = System.Drawing.Color.Gray;
            this.txtTerminus2.Location = new System.Drawing.Point(578, 16);
            this.txtTerminus2.Name = "txtTerminus2";
            this.txtTerminus2.Size = new System.Drawing.Size(441, 22);
            this.txtTerminus2.TabIndex = 2;
            this.txtTerminus2.Text = "Saisir terminus 2";
            this.txtTerminus2.Enter += new System.EventHandler(this.txtTerminus2_Enter);
            this.txtTerminus2.Leave += new System.EventHandler(this.txtTerminus2_Leave);
            // 
            // lblAjoutStation
            // 
            this.lblAjoutStation.AutoSize = true;
            this.lblAjoutStation.Location = new System.Drawing.Point(6, 90);
            this.lblAjoutStation.Name = "lblAjoutStation";
            this.lblAjoutStation.Size = new System.Drawing.Size(116, 16);
            this.lblAjoutStation.TabIndex = 3;
            this.lblAjoutStation.Text = "Ajouter une station";
            // 
            // txtRechercheStations
            // 
            this.txtRechercheStations.Location = new System.Drawing.Point(128, 87);
            this.txtRechercheStations.Name = "txtRechercheStations";
            this.txtRechercheStations.Size = new System.Drawing.Size(891, 22);
            this.txtRechercheStations.TabIndex = 4;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(8, 159);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(145, 16);
            this.lblRecherche.TabIndex = 5;
            this.lblRecherche.Text = "Résultats de recherche";
            // 
            // lblStations
            // 
            this.lblStations.AutoSize = true;
            this.lblStations.Location = new System.Drawing.Point(520, 159);
            this.lblStations.Name = "lblStations";
            this.lblStations.Size = new System.Drawing.Size(110, 16);
            this.lblStations.TabIndex = 6;
            this.lblStations.Text = "Stations ajoutées";
            // 
            // lblSeperationVerticale
            // 
            this.lblSeperationVerticale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeperationVerticale.Location = new System.Drawing.Point(512, 112);
            this.lblSeperationVerticale.Name = "lblSeperationVerticale";
            this.lblSeperationVerticale.Size = new System.Drawing.Size(2, 281);
            this.lblSeperationVerticale.TabIndex = 17;
            // 
            // listResultatsRecherche
            // 
            this.listResultatsRecherche.FormattingEnabled = true;
            this.listResultatsRecherche.ItemHeight = 16;
            this.listResultatsRecherche.Location = new System.Drawing.Point(11, 178);
            this.listResultatsRecherche.Name = "listResultatsRecherche";
            this.listResultatsRecherche.Size = new System.Drawing.Size(495, 196);
            this.listResultatsRecherche.TabIndex = 18;
            // 
            // listStations
            // 
            this.listStations.FormattingEnabled = true;
            this.listStations.ItemHeight = 16;
            this.listStations.Location = new System.Drawing.Point(520, 178);
            this.listStations.Name = "listStations";
            this.listStations.Size = new System.Drawing.Size(495, 196);
            this.listStations.TabIndex = 19;
            // 
            // PagePanneauAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 420);
            this.Controls.Add(this.tabControl1);
            this.Name = "PagePanneauAdministration";
            this.Text = "Métro de Montréal - Panneau d\'administration";
            this.tabControl1.ResumeLayout(false);
            this.tabAjoutLigne.ResumeLayout(false);
            this.tabAjoutLigne.PerformLayout();
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
        private System.Windows.Forms.Label lblFleche;
        private System.Windows.Forms.TextBox txtTerminus1;
        private System.Windows.Forms.TextBox txtTerminus2;
        private System.Windows.Forms.Label lblStations;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox txtRechercheStations;
        private System.Windows.Forms.Label lblAjoutStation;
        private System.Windows.Forms.Label lblSeperationVerticale;
        private System.Windows.Forms.ListBox listStations;
        private System.Windows.Forms.ListBox listResultatsRecherche;
    }
}