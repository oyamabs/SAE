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
            this.txtStationDep.Location = new System.Drawing.Point(12, 12);
            this.txtStationDep.Name = "txtStationDep";
            this.txtStationDep.Size = new System.Drawing.Size(377, 22);
            this.txtStationDep.TabIndex = 0;
            this.txtStationDep.Text = "Saisir une station de départ";
            this.txtStationDep.Enter += new System.EventHandler(this.textBoxEnter);
            this.txtStationDep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStationDep_KeyDown);
            this.txtStationDep.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // lblStationsFavoritesDe
            // 
            this.lblStationsFavoritesDe.AutoSize = true;
            this.lblStationsFavoritesDe.Location = new System.Drawing.Point(12, 54);
            this.lblStationsFavoritesDe.Name = "lblStationsFavoritesDe";
            this.lblStationsFavoritesDe.Size = new System.Drawing.Size(109, 16);
            this.lblStationsFavoritesDe.TabIndex = 2;
            this.lblStationsFavoritesDe.Text = "Stations favorites";
            // 
            // comboSatationsFavoritesDep
            // 
            this.comboSatationsFavoritesDep.FormattingEnabled = true;
            this.comboSatationsFavoritesDep.Items.AddRange(new object[] {
            "Ajouter une station favorite"});
            this.comboSatationsFavoritesDep.Location = new System.Drawing.Point(127, 51);
            this.comboSatationsFavoritesDep.Name = "comboSatationsFavoritesDep";
            this.comboSatationsFavoritesDep.Size = new System.Drawing.Size(262, 24);
            this.comboSatationsFavoritesDep.TabIndex = 3;
            this.comboSatationsFavoritesDep.Text = "--Selectionner--";
            this.comboSatationsFavoritesDep.SelectedIndexChanged += new System.EventHandler(this.comboSatationsFavorites_SelectedIndexChanged);
            // 
            // listResultatsDep
            // 
            this.listResultatsDep.FormattingEnabled = true;
            this.listResultatsDep.ItemHeight = 16;
            this.listResultatsDep.Location = new System.Drawing.Point(15, 112);
            this.listResultatsDep.Name = "listResultatsDep";
            this.listResultatsDep.Size = new System.Drawing.Size(374, 116);
            this.listResultatsDep.TabIndex = 4;
            this.listResultatsDep.SelectedIndexChanged += new System.EventHandler(this.listResultatsDep_SelectedIndexChanged);
            // 
            // lblResultatsDep
            // 
            this.lblResultatsDep.AutoSize = true;
            this.lblResultatsDep.Location = new System.Drawing.Point(12, 93);
            this.lblResultatsDep.Name = "lblResultatsDep";
            this.lblResultatsDep.Size = new System.Drawing.Size(145, 16);
            this.lblResultatsDep.TabIndex = 5;
            this.lblResultatsDep.Text = "Résultats de recherche";
            // 
            // lblStationSelectionneeDep
            // 
            this.lblStationSelectionneeDep.AutoSize = true;
            this.lblStationSelectionneeDep.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStationSelectionneeDep.Location = new System.Drawing.Point(12, 245);
            this.lblStationSelectionneeDep.Name = "lblStationSelectionneeDep";
            this.lblStationSelectionneeDep.Size = new System.Drawing.Size(134, 16);
            this.lblStationSelectionneeDep.TabIndex = 6;
            this.lblStationSelectionneeDep.Text = "Station sélectionnée: ";
            // 
            // lblStationSelectionneeArr
            // 
            this.lblStationSelectionneeArr.AutoSize = true;
            this.lblStationSelectionneeArr.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStationSelectionneeArr.Location = new System.Drawing.Point(411, 245);
            this.lblStationSelectionneeArr.Name = "lblStationSelectionneeArr";
            this.lblStationSelectionneeArr.Size = new System.Drawing.Size(134, 16);
            this.lblStationSelectionneeArr.TabIndex = 13;
            this.lblStationSelectionneeArr.Text = "Station sélectionnée: ";
            // 
            // lblResultatsArr
            // 
            this.lblResultatsArr.AutoSize = true;
            this.lblResultatsArr.Location = new System.Drawing.Point(411, 93);
            this.lblResultatsArr.Name = "lblResultatsArr";
            this.lblResultatsArr.Size = new System.Drawing.Size(145, 16);
            this.lblResultatsArr.TabIndex = 12;
            this.lblResultatsArr.Text = "Résultats de recherche";
            // 
            // listResultatsArr
            // 
            this.listResultatsArr.FormattingEnabled = true;
            this.listResultatsArr.ItemHeight = 16;
            this.listResultatsArr.Location = new System.Drawing.Point(414, 112);
            this.listResultatsArr.Name = "listResultatsArr";
            this.listResultatsArr.Size = new System.Drawing.Size(374, 116);
            this.listResultatsArr.TabIndex = 11;
            // 
            // comboStationsFavoritesArr
            // 
            this.comboStationsFavoritesArr.FormattingEnabled = true;
            this.comboStationsFavoritesArr.Items.AddRange(new object[] {
            "Ajouter une station favorite"});
            this.comboStationsFavoritesArr.Location = new System.Drawing.Point(526, 51);
            this.comboStationsFavoritesArr.Name = "comboStationsFavoritesArr";
            this.comboStationsFavoritesArr.Size = new System.Drawing.Size(262, 24);
            this.comboStationsFavoritesArr.TabIndex = 10;
            this.comboStationsFavoritesArr.Text = "--Selectionner--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stations favorites";
            // 
            // txtStationArr
            // 
            this.txtStationArr.ForeColor = System.Drawing.Color.Gray;
            this.txtStationArr.Location = new System.Drawing.Point(411, 12);
            this.txtStationArr.Name = "txtStationArr";
            this.txtStationArr.Size = new System.Drawing.Size(377, 22);
            this.txtStationArr.TabIndex = 7;
            this.txtStationArr.Text = "Saisir une station d\'arrivée";
            this.txtStationArr.Enter += new System.EventHandler(this.textBoxEnter);
            this.txtStationArr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStationArr_KeyDown);
            this.txtStationArr.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.ForeColor = System.Drawing.Color.Blue;
            this.lblAdminPanel.Location = new System.Drawing.Point(559, 426);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(229, 16);
            this.lblAdminPanel.TabIndex = 14;
            this.lblAdminPanel.Text = "Accéder au panneau d\'administration";
            this.lblAdminPanel.Click += new System.EventHandler(this.lblAdminPanel_Click);
            // 
            // lblSeparationHorizontale
            // 
            this.lblSeparationHorizontale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparationHorizontale.Location = new System.Drawing.Point(-7, 302);
            this.lblSeparationHorizontale.Name = "lblSeparationHorizontale";
            this.lblSeparationHorizontale.Size = new System.Drawing.Size(812, 2);
            this.lblSeparationHorizontale.TabIndex = 15;
            // 
            // lblSeperationVerticale
            // 
            this.lblSeperationVerticale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeperationVerticale.Location = new System.Drawing.Point(400, -2);
            this.lblSeperationVerticale.Name = "lblSeperationVerticale";
            this.lblSeperationVerticale.Size = new System.Drawing.Size(2, 306);
            this.lblSeperationVerticale.TabIndex = 16;
            // 
            // lblHoraire
            // 
            this.lblHoraire.AutoSize = true;
            this.lblHoraire.Location = new System.Drawing.Point(9, 317);
            this.lblHoraire.Name = "lblHoraire";
            this.lblHoraire.Size = new System.Drawing.Size(162, 16);
            this.lblHoraire.TabIndex = 17;
            this.lblHoraire.Text = "Horaire du train de départ:";
            // 
            // lblEtapes
            // 
            this.lblEtapes.AutoSize = true;
            this.lblEtapes.Location = new System.Drawing.Point(9, 344);
            this.lblEtapes.Name = "lblEtapes";
            this.lblEtapes.Size = new System.Drawing.Size(53, 16);
            this.lblEtapes.TabIndex = 18;
            this.lblEtapes.Text = "Étapes:";
            // 
            // PageRechercheLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
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