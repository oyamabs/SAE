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
    }
}
