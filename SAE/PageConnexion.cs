using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BD;

namespace SAE
{
    public partial class PageConnexion : Form
    {
        // a changer plus tard
        private string sample_username = "admin";
        private string sample_password = "root";
        public PageConnexion()
        {
            InitializeComponent();
        }
        
        // gestion textbox pour éviter de faire des labels partout
        private void textBoxEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            switch (textBox.Name)
            {
                case "txtUsername":
                    if (txtUsername.Text == "Nom d'Utilisateur" && txtUsername.ForeColor == Color.Gray)
                    {
                        txtUsername.ForeColor = Color.Black;
                        txtUsername.Text = "";
                    }
                    break;
                case "txtPassword":
                    if (txtPassword.Text == "Mot de passe" && txtPassword.ForeColor == Color.Gray)
                    {
                        txtPassword.Text = "";
                        txtPassword.ForeColor = Color.Black;
                    }
                    break;
            }
        }

        private void textBoxLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            switch (textBox.Name)
            {
                case "txtUsername":
                    if (txtUsername.Text == "" && txtUsername.ForeColor == Color.Black)
                    {
                        txtUsername.ForeColor = Color.Gray;
                        txtUsername.Text = "Nom d'Utilisateur";
                    }
                    break;
                case "txtPassword":
                    if (txtPassword.Text == "" && txtPassword.ForeColor == Color.Black)
                    {
                        txtPassword.Text = "Mot de passe";
                        txtPassword.ForeColor = Color.Gray;
                    }
                    break;
            }
        }
        // fin gestion labels


        // apparition du formulaire de recherche de ligne en fonction de la connexion (admin / invité)
        private void cmdConnexionAdmin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == sample_password && txtUsername.Text == sample_username)
            {
                PageRechercheLigne form = new PageRechercheLigne(true);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Identifiants incorrects!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdInvite_Click(object sender, EventArgs e)
        {
            PageRechercheLigne form = new PageRechercheLigne(false);
            form.ShowDialog();
        }
    }
}