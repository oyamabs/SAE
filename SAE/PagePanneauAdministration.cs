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

        private void textBoxEnter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            
            switch (txt.Name)
            {
                case "txtTerminus1Ajout":
                    if (txtTerminus1Ajout.Text == "Saisir terminus 1" && txtTerminus1Ajout.ForeColor == Color.Gray)
                    {
                        txtTerminus1Ajout.Text = "";
                        txtTerminus1Ajout.ForeColor = Color.Black;
                    }
                    break;

                case "txtTerminus2Ajout":
                    if (txtTerminus2Ajout.Text == "Saisir terminus 2" && txtTerminus2Ajout.ForeColor == Color.Gray)
                    {
                        txtTerminus2Ajout.Text = "";
                        txtTerminus2Ajout.ForeColor = Color.Black;
                    }
                    break;

                case "txtTerminus1Modif":
                    if (txtTerminus1Modif.Text == "Saisir terminus 1" && txtTerminus1Modif.ForeColor == Color.Gray)
                    {
                        txtTerminus1Modif.Text = "";
                        txtTerminus1Modif.ForeColor = Color.Black;
                    }
                    break;
                case "txtTerminus2Modif":
                    if (txtTerminus2Modif.Text == "Saisir terminus 2" && txtTerminus2Modif.ForeColor == Color.Gray)
                    {
                        txtTerminus2Modif.Text = "";
                        txtTerminus2Modif.ForeColor = Color.Black;
                    }
                    break;
                case "txtAjoutStation":
                    if (txtAjoutStation.Text == "Saisir le nom de la station" && txtAjoutStation.ForeColor == Color.Gray)
                    {
                        txtAjoutStation.Text = "";
                        txtAjoutStation.ForeColor = Color.Black;
                    }
                    break;
                default:
                    break;
            }
        }

        private void textBoxLeave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            switch (txt.Name)
            {
                case "txtTerminus1Ajout":
                    if (txtTerminus1Ajout.Text == "" && txtTerminus1Ajout.ForeColor == Color.Black)
                    {
                        txtTerminus1Ajout.Text = "Saisir terminus 1";
                        txtTerminus1Ajout.ForeColor = Color.Gray;
                    }
                    break;

                case "txtTerminal2Ajout":
                    if (txtTerminus2Ajout.Text == "" && txtTerminus2Ajout.ForeColor == Color.Black)
                    {
                        txtTerminus2Ajout.Text = "Saisir terminus 2";
                        txtTerminus2Ajout.ForeColor = Color.Gray;
                    }
                    break;
                case "txtTerminus1Modif":
                    if (txtTerminus1Modif.Text == "" && txtTerminus1Modif.ForeColor == Color.Black)
                    {
                        txtTerminus1Modif.Text = "Saisir terminus 1";
                        txtTerminus1Modif.ForeColor = Color.Gray;
                    }
                    break;
                case "txtTerminus2Modif":
                    if (txtTerminus2Modif.Text == "" && txtTerminus2Modif.ForeColor == Color.Black)
                    {
                        txtTerminus2Modif.Text = "Saisir terminus 2";
                        txtTerminus2Modif.ForeColor = Color.Gray;
                    }
                    break;
                case "txtAjoutStation":
                    if (txtAjoutStation.Text == "" && txtAjoutStation.ForeColor == Color.Black)
                    {
                        txtAjoutStation.Text = "Saisir le nom de la station";
                        txtAjoutStation.ForeColor = Color.Gray;
                    }
                    break;
                default:
                    break;
            }
        }

        private void chkConfirmSupprLigne_CheckedChanged(object sender, EventArgs e)
        {
            cmdSupprLigne.Enabled = chkConfirmSupprLigne.Checked; // changer automatiquement l'activation du bouton en fonction de l'état de la checkbox
        }

        private void chkConfirmStationSuppr_CheckedChanged(object sender, EventArgs e)
        {
            cmdSupprStation.Enabled = chkConfirmStationSuppr.Checked;
        }
    }
}
