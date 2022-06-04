﻿using System;
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
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Nom d'Utilisateur" && txtUsername.ForeColor == Color.Gray)
            {
                txtUsername.ForeColor = Color.Black;
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtUsername.ForeColor == Color.Black)
            {
                txtUsername.ForeColor = Color.Gray;
                txtUsername.Text = "Nom d'Utilisateur";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mot de passe" && txtPassword.ForeColor == Color.Gray)
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" && txtPassword.ForeColor == Color.Black)
            {
                txtPassword.Text = "Mot de passe";
                txtPassword.ForeColor = Color.Gray;
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

        private void PageConnexion_Load(object sender, EventArgs e)
        {
            List<Station> list = new List<Station>();
            list = getStations();

            foreach (Station stat in list)
                Console.WriteLine(stat.ToString());
        }
    }
}