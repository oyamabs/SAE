namespace SAE
{
    partial class PageRechercheLigne
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
            this.txtStationDep = new System.Windows.Forms.TextBox();
            this.lblStationsFavoritesDe = new System.Windows.Forms.Label();
            this.comboSatationsFavoritesDep = new System.Windows.Forms.ComboBox();
            this.listResultatsDep = new System.Windows.Forms.ListBox();
            this.lblResultatsDep = new System.Windows.Forms.Label();
            this.lblStationSelectionneeDep = new System.Windows.Forms.Label();
            this.lblStationSelectionneeArr = new System.Windows.Forms.Label();
            this.lblResultatsArr = new System.Windows.Forms.Label();
            this.listResultatsArr = new System.Windows.Forms.ListBox();
            this.comboStationsFavoritesArr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStationArr = new System.Windows.Forms.TextBox();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.lblSeparationHorizontale = new System.Windows.Forms.Label();
            this.lblSeperationVerticale = new System.Windows.Forms.Label();
            this.lblHoraire = new System.Windows.Forms.Label();
            this.lblEtapes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStationDep
            // 
            this.txtStationDep.ForeColor = System.Drawing.Color.Gray;
            this.txtStationDep.Location = new System.Drawing.Point(9, 10);
            this.txtStationDep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStationDep.Name = "txtStationDep";
            this.txtStationDep.Size = new System.Drawing.Size(284, 20);
            this.txtStationDep.TabIndex = 0;
            this.txtStationDep.Text = "Saisir une station de départ";
            this.txtStationDep.Enter += new System.EventHandler(this.textBoxEnter);
            this.txtStationDep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.recherche);
            this.txtStationDep.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // lblStationsFavoritesDe
            // 
            this.lblStationsFavoritesDe.AutoSize = true;
            this.lblStationsFavoritesDe.Location = new System.Drawing.Point(9, 44);
            this.lblStationsFavoritesDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStationsFavoritesDe.Name = "lblStationsFavoritesDe";
            this.lblStationsFavoritesDe.Size = new System.Drawing.Size(88, 13);
            this.lblStationsFavoritesDe.TabIndex = 2;
            this.lblStationsFavoritesDe.Text = "Stations favorites";
            // 
            // comboSatationsFavoritesDep
            // 
            this.comboSatationsFavoritesDep.Enabled = false;
            this.comboSatationsFavoritesDep.FormattingEnabled = true;
            this.comboSatationsFavoritesDep.Items.AddRange(new object[] {
            "Ajouter une station favorite"});
            this.comboSatationsFavoritesDep.Location = new System.Drawing.Point(95, 41);
            this.comboSatationsFavoritesDep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboSatationsFavoritesDep.Name = "comboSatationsFavoritesDep";
            this.comboSatationsFavoritesDep.Size = new System.Drawing.Size(198, 21);
            this.comboSatationsFavoritesDep.TabIndex = 3;
            this.comboSatationsFavoritesDep.Text = "--Selectionner--";
            this.comboSatationsFavoritesDep.SelectedIndexChanged += new System.EventHandler(this.comboSatationsFavorites_SelectedIndexChanged);
            // 
            // listResultatsDep
            // 
            this.listResultatsDep.FormattingEnabled = true;
            this.listResultatsDep.Location = new System.Drawing.Point(11, 91);
            this.listResultatsDep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listResultatsDep.Name = "listResultatsDep";
            this.listResultatsDep.Size = new System.Drawing.Size(282, 95);
            this.listResultatsDep.TabIndex = 4;
            this.listResultatsDep.SelectedIndexChanged += new System.EventHandler(this.listResultatsDep_SelectedIndexChanged);
            // 
            // lblResultatsDep
            // 
            this.lblResultatsDep.AutoSize = true;
            this.lblResultatsDep.Location = new System.Drawing.Point(9, 76);
            this.lblResultatsDep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultatsDep.Name = "lblResultatsDep";
            this.lblResultatsDep.Size = new System.Drawing.Size(117, 13);
            this.lblResultatsDep.TabIndex = 5;
            this.lblResultatsDep.Text = "Résultats de recherche";
            // 
            // lblStationSelectionneeDep
            // 
            this.lblStationSelectionneeDep.AutoSize = true;
            this.lblStationSelectionneeDep.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStationSelectionneeDep.Location = new System.Drawing.Point(9, 199);
            this.lblStationSelectionneeDep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStationSelectionneeDep.Name = "lblStationSelectionneeDep";
            this.lblStationSelectionneeDep.Size = new System.Drawing.Size(109, 13);
            this.lblStationSelectionneeDep.TabIndex = 6;
            this.lblStationSelectionneeDep.Text = "Station sélectionnée: ";
            // 
            // lblStationSelectionneeArr
            // 
            this.lblStationSelectionneeArr.AutoSize = true;
            this.lblStationSelectionneeArr.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStationSelectionneeArr.Location = new System.Drawing.Point(308, 199);
            this.lblStationSelectionneeArr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStationSelectionneeArr.Name = "lblStationSelectionneeArr";
            this.lblStationSelectionneeArr.Size = new System.Drawing.Size(109, 13);
            this.lblStationSelectionneeArr.TabIndex = 13;
            this.lblStationSelectionneeArr.Text = "Station sélectionnée: ";
            // 
            // lblResultatsArr
            // 
            this.lblResultatsArr.AutoSize = true;
            this.lblResultatsArr.Location = new System.Drawing.Point(308, 76);
            this.lblResultatsArr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultatsArr.Name = "lblResultatsArr";
            this.lblResultatsArr.Size = new System.Drawing.Size(117, 13);
            this.lblResultatsArr.TabIndex = 12;
            this.lblResultatsArr.Text = "Résultats de recherche";
            // 
            // listResultatsArr
            // 
            this.listResultatsArr.FormattingEnabled = true;
            this.listResultatsArr.Location = new System.Drawing.Point(310, 91);
            this.listResultatsArr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listResultatsArr.Name = "listResultatsArr";
            this.listResultatsArr.Size = new System.Drawing.Size(282, 95);
            this.listResultatsArr.TabIndex = 11;
            this.listResultatsArr.SelectedIndexChanged += new System.EventHandler(this.listResultatsArr_SelectedIndexChanged);
            // 
            // comboStationsFavoritesArr
            // 
            this.comboStationsFavoritesArr.Enabled = false;
            this.comboStationsFavoritesArr.FormattingEnabled = true;
            this.comboStationsFavoritesArr.Items.AddRange(new object[] {
            "Ajouter une station favorite"});
            this.comboStationsFavoritesArr.Location = new System.Drawing.Point(394, 41);
            this.comboStationsFavoritesArr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboStationsFavoritesArr.Name = "comboStationsFavoritesArr";
            this.comboStationsFavoritesArr.Size = new System.Drawing.Size(198, 21);
            this.comboStationsFavoritesArr.TabIndex = 10;
            this.comboStationsFavoritesArr.Text = "--Selectionner--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stations favorites";
            // 
            // txtStationArr
            // 
            this.txtStationArr.ForeColor = System.Drawing.Color.Gray;
            this.txtStationArr.Location = new System.Drawing.Point(308, 10);
            this.txtStationArr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStationArr.Name = "txtStationArr";
            this.txtStationArr.Size = new System.Drawing.Size(284, 20);
            this.txtStationArr.TabIndex = 7;
            this.txtStationArr.Text = "Saisir une station d\'arrivée";
            this.txtStationArr.Enter += new System.EventHandler(this.textBoxEnter);
            this.txtStationArr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.recherche);
            this.txtStationArr.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.ForeColor = System.Drawing.Color.Blue;
            this.lblAdminPanel.Location = new System.Drawing.Point(419, 346);
            this.lblAdminPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(182, 13);
            this.lblAdminPanel.TabIndex = 14;
            this.lblAdminPanel.Text = "Accéder au panneau d\'administration";
            this.lblAdminPanel.Click += new System.EventHandler(this.lblAdminPanel_Click);
            // 
            // lblSeparationHorizontale
            // 
            this.lblSeparationHorizontale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparationHorizontale.Location = new System.Drawing.Point(-5, 245);
            this.lblSeparationHorizontale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeparationHorizontale.Name = "lblSeparationHorizontale";
            this.lblSeparationHorizontale.Size = new System.Drawing.Size(609, 2);
            this.lblSeparationHorizontale.TabIndex = 15;
            // 
            // lblSeperationVerticale
            // 
            this.lblSeperationVerticale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeperationVerticale.Location = new System.Drawing.Point(300, -2);
            this.lblSeperationVerticale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeperationVerticale.Name = "lblSeperationVerticale";
            this.lblSeperationVerticale.Size = new System.Drawing.Size(2, 249);
            this.lblSeperationVerticale.TabIndex = 16;
            // 
            // lblHoraire
            // 
            this.lblHoraire.AutoSize = true;
            this.lblHoraire.Location = new System.Drawing.Point(7, 258);
            this.lblHoraire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraire.Name = "lblHoraire";
            this.lblHoraire.Size = new System.Drawing.Size(130, 13);
            this.lblHoraire.TabIndex = 17;
            this.lblHoraire.Text = "Horaire du train de départ:";
            // 
            // lblEtapes
            // 
            this.lblEtapes.AutoSize = true;
            this.lblEtapes.Location = new System.Drawing.Point(7, 280);
            this.lblEtapes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEtapes.Name = "lblEtapes";
            this.lblEtapes.Size = new System.Drawing.Size(43, 13);
            this.lblEtapes.TabIndex = 18;
            this.lblEtapes.Text = "Étapes:";
            // 
            // PageRechercheLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblEtapes);
            this.Controls.Add(this.lblHoraire);
            this.Controls.Add(this.lblSeperationVerticale);
            this.Controls.Add(this.lblSeparationHorizontale);
            this.Controls.Add(this.lblAdminPanel);
            this.Controls.Add(this.lblStationSelectionneeArr);
            this.Controls.Add(this.lblResultatsArr);
            this.Controls.Add(this.listResultatsArr);
            this.Controls.Add(this.comboStationsFavoritesArr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStationArr);
            this.Controls.Add(this.lblStationSelectionneeDep);
            this.Controls.Add(this.lblResultatsDep);
            this.Controls.Add(this.listResultatsDep);
            this.Controls.Add(this.comboSatationsFavoritesDep);
            this.Controls.Add(this.lblStationsFavoritesDe);
            this.Controls.Add(this.txtStationDep);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PageRechercheLigne";
            this.Text = "Métro de Montréal - Recherche de trajet";
            this.Load += new System.EventHandler(this.PageRechercheLigne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStationDep;
        private System.Windows.Forms.Label lblStationsFavoritesDe;
        private System.Windows.Forms.ComboBox comboSatationsFavoritesDep;
        private System.Windows.Forms.ListBox listResultatsDep;
        private System.Windows.Forms.Label lblResultatsDep;
        private System.Windows.Forms.Label lblStationSelectionneeDep;
        private System.Windows.Forms.Label lblStationSelectionneeArr;
        private System.Windows.Forms.Label lblResultatsArr;
        private System.Windows.Forms.ListBox listResultatsArr;
        private System.Windows.Forms.ComboBox comboStationsFavoritesArr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStationArr;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Label lblSeparationHorizontale;
        private System.Windows.Forms.Label lblSeperationVerticale;
        private System.Windows.Forms.Label lblHoraire;
        private System.Windows.Forms.Label lblEtapes;
    }
}