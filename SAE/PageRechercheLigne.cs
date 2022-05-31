using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE
{
    public partial class PageRechercheLigne : Form
    {
        private bool isAdmin = false;
        public PageRechercheLigne(bool isAdmin)
        {
            InitializeComponent();

            this.isAdmin = isAdmin;
        }

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
        }

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
    }
}
