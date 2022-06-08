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
        private int selectedTerminus1Modif = -1;
        private int selectedTerminus2Modif = -1;
        private int selectedTerminus1Ajout = -1;
        private int selectedTerminus2Ajout = -1;
        private int selectedLigneSuppr = -1;
        public PagePanneauAdministration()
        {
            InitializeComponent();
        }

        private void textBoxEnter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            
            switch (txt.Name)
            {
                case "txtAjoutStation":
                    if (txtAjoutStation.Text == "Saisir le nom de la station" && txtAjoutStation.ForeColor == Color.Gray)
                    {
                        txtAjoutStation.Text = "";
                        txtAjoutStation.ForeColor = Color.Black;
                    }
                    break;
                case "txtNomLigneAjout":
                    if (txtNomLigneAjout.Text == "Saisir le nom de la ligne" && txtNomLigneAjout.ForeColor == Color.Gray)
                    {
                        txtNomLigneAjout.Text = "";
                        txtNomLigneAjout.ForeColor = Color.Black;
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
                case "txtAjoutStation":
                    if (txtAjoutStation.Text == "" && txtAjoutStation.ForeColor == Color.Black)
                    {
                        txtAjoutStation.Text = "Saisir le nom de la station";
                        txtAjoutStation.ForeColor = Color.Gray;
                    }
                    break;
                case "txtNomLigneAjout":
                    if (txtNomLigneAjout.Text == "" && txtNomLigneAjout.ForeColor == Color.Black)
                    {
                        txtNomLigneAjout.Text = "Saisir le nom de la ligne";
                        txtNomLigneAjout.ForeColor = Color.Gray;
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
            PagePanneauAdministration_Load(sender, e);
        }

        private void PagePanneauAdministration_Load(object sender, EventArgs e)
        {
            List<Station> stations = BD.BD.getStations();
            List<Line> lines = BD.BD.getLines();

            // clear des combobox pour être sûr qu'il n'y ait aucun 'résidu' de précédentes données
            comboSelectStationModif.Items.Clear();
            comboSelectStationSuppr.Items.Clear();
            comboAjoutTerminus1.Items.Clear();
            comboAjoutTerminus2.Items.Clear();
            comboModifTerminus1.Items.Clear();
            comboModifTerminus2.Items.Clear();
            comboSelectLigne.Items.Clear();
            comboSelectLigneSuppr.Items.Clear();

            foreach (Station station in stations)
            {
                comboSelectStationModif.Items.Add(station.stationName);
                comboSelectStationSuppr.Items.Add(station.stationName);
                comboAjoutTerminus1.Items.Add(station.stationName);
                comboAjoutTerminus2.Items.Add(station.stationName);
                comboModifTerminus1.Items.Add(station.stationName);
                comboModifTerminus2.Items.Add(station.stationName);
            }

            foreach (Line line in lines)
            {
                comboSelectLigne.Items.Add(line.lineName);
                comboSelectLigneSuppr.Items.Add(line.lineName);
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
            PagePanneauAdministration_Load(sender, e);
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

            PagePanneauAdministration_Load(sender, e);
        }

        private void comboSelectLigne_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Station> stations = BD.BD.getStations();
            List<Line> lines = BD.BD.getLines();
            const int offset = 1; // les listes commencent à 0 et le premier élément pour les gares est 1
            foreach (Line line in lines)
            {
                if (line.lineName == comboSelectLigne.Text)
                {
                    
                    comboModifTerminus1.Text = stations[line.station1 - offset].stationName;
                    comboModifTerminus2.Text = stations[line.station2 - offset].stationName;
                }
            }

            foreach (Station station in stations)
            {
                if (station.stationName == comboModifTerminus1.Text)
                    selectedTerminus1Modif = station.stationId;

                if (station.stationName == comboModifTerminus2.Text)
                    selectedTerminus2Modif = station.stationId;
            }
        }

        private void cmdModifLigne_Click(object sender, EventArgs e)
        {
            Line line = new Line(0, comboSelectLigne.SelectedItem.ToString(), selectedTerminus1Modif, selectedTerminus2Modif);

            BD.BD.updateLine(line);
            PagePanneauAdministration_Load(sender, e);
        }

        private void selectTerminus(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            List<Station> stations = BD.BD.getStations();

            if (cmb.Name == "comboAjoutTerminus1")
            {
                foreach (Station station in stations)
                {
                    if (station.stationName == cmb.Text)
                        selectedTerminus1Ajout = station.stationId;
                }
            }
            else
            {
                foreach (Station station in stations)
                {
                    if (station.stationName == cmb.Text)
                        selectedTerminus2Ajout = station.stationId;
                }
            }
        }

        private void cmdAjoutLigne_Click(object sender, EventArgs e)
        {
            Line line = new Line(0, txtNomLigneAjout.Text, selectedTerminus1Ajout, selectedTerminus2Ajout);

            BD.BD.addLine(line);
            PagePanneauAdministration_Load(sender, e);

        }

        private void selectModifCombo(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            List<Station> stations = BD.BD.getStations();

            if (cmb.Name == "comboModifTerminus1")
            {
                foreach (Station station in stations)
                {
                    if (station.stationName == cmb.Text)
                        selectedTerminus1Modif = station.stationId;
                }
            }
            else
            {
                foreach (Station station in stations)
                {
                    if (station.stationName == cmb.Text)
                        selectedTerminus2Modif = station.stationId;
                }
            }
        }

        private void comboSelectLigneSuppr_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Line> lines = BD.BD.getLines();

            foreach(Line line in lines)
            {
                if (line.lineName == comboSelectLigneSuppr.Text)
                    selectedLigneSuppr = line.lineId;
            }
        }

        private void cmdSupprLigne_Click(object sender, EventArgs e)
        {
            try
            {
                BD.BD.deleteLine(selectedLigneSuppr);
            }
            catch (Exception)
            {
                MessageBox.Show("Selectionnez une ligne");
            }

            PagePanneauAdministration_Load(sender, e);
        }
    }
}
