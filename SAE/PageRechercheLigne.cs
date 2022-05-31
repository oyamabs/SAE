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
        public PageRechercheLigne()
        {
            InitializeComponent();
        }

        private void comboSatationsFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSatationsFavoritesDep.SelectedIndex == (comboSatationsFavoritesDep.Items.Count-1))
            {
                MessageBox.Show("A faire après");
            }
        }
    }
}
