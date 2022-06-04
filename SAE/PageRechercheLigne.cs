using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD;

namespace SAE
{
    public partial class PageRechercheLigne : Form
    {
        List<Station> stations = new List<Station>();

        private bool isAdmin = false;

        /// <summary>
        /// Affiche les resultats de recherche
        /// </summary>
        /// <param name="isDeparture">Recherche de station pour le départ</param>
        /// <param name="search">Texte à rechercher</param>
        private void searchResults(bool isDeparture, string search)
        {
            if (isDeparture)
            {
                listResultatsDep.Items.Clear();

                foreach (Station station in stations)
                {
                    if (station.stationName.ToLower().Contains(search.ToLower()))
                        listResultatsDep.Items.Add(station.stationName);
                }
            }
            else
            {
                listResultatsArr.Items.Clear();

                foreach (Station station in stations)
                {
                    if (station.stationName.ToLower().Contains(search.ToLower()))
                        listResultatsArr.Items.Add(station.stationName);
                }
            }
        }

        public PageRechercheLigne(bool isAdmin)
        {
            InitializeComponent();

            this.isAdmin = isAdmin;
        }

        // gestion stations favorites
        private void comboSatationsFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSatationsFavoritesDep.SelectedIndex == (comboSatationsFavoritesDep.Items.Count-1))
            {
                MessageBox.Show("A faire après");
            }
        }

        private void lblAdminPanel_Click(object sender, EventArgs e)
        {
            PagePanneauAdministration form = new PagePanneauAdministration();
            form.ShowDialog();
        }

        private void PageRechercheLigne_Load(object sender, EventArgs e)
        {
            if (!isAdmin)
                lblAdminPanel.Enabled = false;

            // remplissage des deux resultats de recherche
            BD.BD.initConnection();

            stations = BD.BD.getStations();

            foreach (Station station in stations)
                listResultatsDep.Items.Add(station.stationName);
            
        }

        // gestion des textbox pour éviter de faire des labels partout
        private void txtStationDep_Enter(object sender, EventArgs e)
        {
            if (txtStationDep.Text == "Saisir une station de départ" && txtStationDep.ForeColor == Color.Gray)
            {
                txtStationDep.Text = "";
                txtStationDep.ForeColor = Color.Black;
            }
        }

        private void txtStationDep_Leave(object sender, EventArgs e)
        {
            if (txtStationDep.Text == "" && txtStationDep.ForeColor == Color.Black)
            {
                txtStationDep.Text = "Saisir une station de départ";
                txtStationDep.ForeColor = Color.Gray;
            }
        }

        private void txtStationArr_Enter(object sender, EventArgs e)
        {
            if (txtStationArr.Text == "Saisir une station d'arrivée" && txtStationArr.ForeColor == Color.Gray)
            {
                txtStationArr.Text = "";
                txtStationArr.ForeColor = Color.Black;
            }
        }

        private void txtStationArr_Leave(object sender, EventArgs e)
        {
            if (txtStationArr.Text == "" && txtStationArr.ForeColor == Color.Black)
            {
                txtStationArr.Text = "Saisir une station d'arrivée";
                txtStationArr.ForeColor = Color.Gray;
            }
        }

        private void listResultatsDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Station station in stations)
            {
                if (station.stationName == listResultatsDep.Text)
                    MessageBox.Show(station.stationId.ToString());
            }
        }

        private void txtStationDep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchResults(true, txtStationDep.Text);

        }
        // fin gestion des textbox
    }
}
