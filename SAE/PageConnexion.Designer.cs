namespace SAE
{
    partial class PageConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConnexion = new System.Windows.Forms.Label();
            this.cmdConnexionAdmin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdInvite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Location = new System.Drawing.Point(174, 111);
            this.lblConnexion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(219, 13);
            this.lblConnexion.TabIndex = 0;
            this.lblConnexion.Text = "Connexion en tant qu\'Administrateur ou invité";
            // 
            // cmdConnexionAdmin
            // 
            this.cmdConnexionAdmin.Location = new System.Drawing.Point(176, 197);
            this.cmdConnexionAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdConnexionAdmin.Name = "cmdConnexionAdmin";
            this.cmdConnexionAdmin.Size = new System.Drawing.Size(200, 19);
            this.cmdConnexionAdmin.TabIndex = 3;
            this.cmdConnexionAdmin.Text = "Connexion";
            this.cmdConnexionAdmin.UseVisualStyleBackColor = true;
            this.cmdConnexionAdmin.Click += new System.EventHandler(this.cmdConnexionAdmin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(176, 152);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(201, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Nom d\'Utilisateur";
            this.txtUsername.Enter += new System.EventHandler(this.textBoxEnter);
            this.txtUsername.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(176, 175);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(201, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Mot de passe";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.textBoxEnter);
            this.txtPassword.Leave += new System.EventHandler(this.textBoxLeave);
            // 
            // cmdInvite
            // 
            this.cmdInvite.Location = new System.Drawing.Point(176, 221);
            this.cmdInvite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdInvite.Name = "cmdInvite";
            this.cmdInvite.Size = new System.Drawing.Size(200, 19);
            this.cmdInvite.TabIndex = 4;
            this.cmdInvite.Text = "Connexion en tant qu\'invité";
            this.cmdInvite.UseVisualStyleBackColor = true;
            this.cmdInvite.Click += new System.EventHandler(this.cmdInvite_Click);
            // 
            // PageConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 351);
            this.Controls.Add(this.cmdInvite);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cmdConnexionAdmin);
            this.Controls.Add(this.lblConnexion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PageConnexion";
            this.Text = "Metro de Montréal - Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.Button cmdConnexionAdmin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdInvite;
    }
}

