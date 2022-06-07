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
    public partial class PagePanneauAdministration : Form
    {
        private int selectedStationChange = -1;
        private int selectedStationSuppr = -1;
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

        private void cmdAjoutStation_Click(object sender, EventArgs e)
        {
            if (txtAjoutStation.Text == "Saisir le nom de la station" && txtAjoutStation.ForeColor == Color.Gray)
            {
                MessageBox.Show("Veuillez entrer le nom de la station", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BD.BD.addStation(new Station(0, txtAjoutStation.Text, chkAscenceurAjout.Checked, chkStationnementAjout.Checked));
        }

        private void PagePanneauAdministration_Load(object sender, EventArgs e)
        {
            List<Station> stations = BD.BD.getStations();

            foreach (Station station in stations)
            {
                comboSelectStationModif.Items.Add(station.stationName);
                comboSelectStationSuppr.Items.Add(station.stationName);
            }
        }

        private void comboSelectStationModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Station> stations = BD.BD.getStations();

            foreach (Station station in stations)
            {
                if (station.stationName == comboSelectStationModif.SelectedItem.ToString())
                {
                    chkAscenceurModif.Checked = station.hasElevator;
                    chkStationnementModif.Checked = station.hasParking;

                    selectedStationChange = station.stationId;
                }
            }
        }

        private void cmdModifStation_Click(object sender, EventArgs e)
        {
            try
            {
                BD.BD.updateStation(selectedStationChange, chkAscenceurModif.Checked, chkStationnementModif.Checked);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur, sélectionnez une station");
            }
        }

        private void comboSelectStationSuppr_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Station> stations = BD.BD.getStations();
            
            foreach (Station station in stations)
            {
                if (station.stationName == comboSelectStationSuppr.Text)
                    selectedStationSuppr = station.stationId;

            }
        }

        private void cmdSupprStation_Click(object sender, EventArgs e)
        {
            try
            {
                BD.BD.deleteStation(selectedStationSuppr);
            }
            catch (Exception)
            {
                MessageBox.Show("Selectionnez une station");
            }
        }
    }
}
