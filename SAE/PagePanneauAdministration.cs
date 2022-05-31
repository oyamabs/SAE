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
    public partial class PagePanneauAdministration : Form
    {
        public PagePanneauAdministration()
        {
            InitializeComponent();
        }

        // début gestion des textbox
        private void txtTerminus1_Enter(object sender, EventArgs e)
        {
            if (txtTerminus1.Text == "Saisir terminus 1" && txtTerminus1.ForeColor == Color.Gray)
            {
                txtTerminus1.Text = "";
                txtTerminus1.ForeColor = Color.Black;
            }
        }

        private void txtTerminus1_Leave(object sender, EventArgs e)
        {
            if (txtTerminus1.Text == "" && txtTerminus1.ForeColor == Color.Black)
            {
                txtTerminus1.Text = "Saisir terminus 1";
                txtTerminus1.ForeColor = Color.Gray;
            }
        }

        private void txtTerminus2_Enter(object sender, EventArgs e)
        {
            if (txtTerminus2.Text == "Saisir terminus 2" && txtTerminus2.ForeColor == Color.Gray)
            {
                txtTerminus2.Text = "";
                txtTerminus2.ForeColor = Color.Black;
            }
        }

        private void txtTerminus2_Leave(object sender, EventArgs e)
        {
            if (txtTerminus2.Text == "" && txtTerminus2.ForeColor == Color.Black)
            {
                txtTerminus2.Text = "Saisir terminus 2";
                txtTerminus2.ForeColor = Color.Gray;
            }
        }
        // fin gestion des textbox
    }
}
