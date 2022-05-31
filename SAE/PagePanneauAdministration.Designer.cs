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
            this.tabModifLigne = new System.Windows.Forms.TabPage();
            this.tabSupprLigne = new System.Windows.Forms.TabPage();
            this.tabAjoutStation = new System.Windows.Forms.TabPage();
            this.tabModifStation = new System.Windows.Forms.TabPage();
            this.tabSupprStation = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.tabAjoutLigne.Location = new System.Drawing.Point(4, 25);
            this.tabAjoutLigne.Name = "tabAjoutLigne";
            this.tabAjoutLigne.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjoutLigne.Size = new System.Drawing.Size(1026, 393);
            this.tabAjoutLigne.TabIndex = 0;
            this.tabAjoutLigne.Text = "Ajouter une ligne";
            this.tabAjoutLigne.UseVisualStyleBackColor = true;
            // 
            // tabModifLigne
            // 
            this.tabModifLigne.Location = new System.Drawing.Point(4, 25);
            this.tabModifLigne.Name = "tabModifLigne";
            this.tabModifLigne.Padding = new System.Windows.Forms.Padding(3);
            this.tabModifLigne.Size = new System.Drawing.Size(742, 393);
            this.tabModifLigne.TabIndex = 1;
            this.tabModifLigne.Text = "Modifier une ligne";
            this.tabModifLigne.UseVisualStyleBackColor = true;
            // 
            // tabSupprLigne
            // 
            this.tabSupprLigne.Location = new System.Drawing.Point(4, 25);
            this.tabSupprLigne.Name = "tabSupprLigne";
            this.tabSupprLigne.Size = new System.Drawing.Size(742, 393);
            this.tabSupprLigne.TabIndex = 2;
            this.tabSupprLigne.Text = "Supprimer une ligne";
            this.tabSupprLigne.UseVisualStyleBackColor = true;
            // 
            // tabAjoutStation
            // 
            this.tabAjoutStation.Location = new System.Drawing.Point(4, 25);
            this.tabAjoutStation.Name = "tabAjoutStation";
            this.tabAjoutStation.Size = new System.Drawing.Size(742, 393);
            this.tabAjoutStation.TabIndex = 3;
            this.tabAjoutStation.Text = "Ajouter une station";
            this.tabAjoutStation.UseVisualStyleBackColor = true;
            // 
            // tabModifStation
            // 
            this.tabModifStation.Location = new System.Drawing.Point(4, 25);
            this.tabModifStation.Name = "tabModifStation";
            this.tabModifStation.Size = new System.Drawing.Size(742, 393);
            this.tabModifStation.TabIndex = 4;
            this.tabModifStation.Text = "Modifier une station";
            this.tabModifStation.UseVisualStyleBackColor = true;
            // 
            // tabSupprStation
            // 
            this.tabSupprStation.Location = new System.Drawing.Point(4, 25);
            this.tabSupprStation.Name = "tabSupprStation";
            this.tabSupprStation.Size = new System.Drawing.Size(742, 393);
            this.tabSupprStation.TabIndex = 5;
            this.tabSupprStation.Text = "Supprimer une station";
            this.tabSupprStation.UseVisualStyleBackColor = true;
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
    }
}