using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace WindowsFormsApp1
{
    public partial class Verbindungen : Form
    {
        List<string> fromStationId = new List<string>();
        List<Station> stationList = new List<Station>();
        Transport transport = new Transport();
        string departureTime = null;
        string departureDate = null;
        int isArrivalTime = 1;

        public Verbindungen()
        {
            InitializeComponent();
        }

        //Events

        private void buttonsuchen_Click(object sender, EventArgs e)
        {
            string from = comboBoxvon.Text;
            string to = comboBoxnach.Text;

                     
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            comboBoxvon.Text = null;
            comboBoxnach.Text = null;

            comboBoxnach.Items.Clear();
            comboBoxvon.Items.Clear();
        }

        private void comborefresh(object sender, EventArgs e)
        {
            comboBoxvon.Items.Clear();
            
        }

        //Funktionen

        private void vonStation(string location, ComboBox comboBoxvon)
        {
            //Lokale Variablen
            Stations station = transport.GetStations(location);
            List<string> vonStationList = new List<string>();
            foreach (var item in station.StationList)
            {
                if (!string.IsNullOrEmpty(item.Name))
                {
                    vonStationList.Add(item.Name);
                }
            }
            foreach (var item in vonStationList)
            {
                comboBoxvon.Items.Add(item);
            }
            if (comboBoxvon.Items.Count > 0)
            {
                comboBoxvon.SelectedIndex = 0;
            }
        }

        private void nachStation(string location, ComboBox comBoxnach)
        {
            //Lokale Variabeln
            Stations station = transport.GetStations(location);
            List<string> toStationList = new List<string>();
            foreach (var item in station.StationList)
            {
                if (!string.IsNullOrEmpty(item.Name))
                {
                    toStationList.Add(item.Name);
                }
            }
            foreach (var item in toStationList)
            {
                comboBoxnach.Items.Add(item);
            }
            if (comboBoxnach.Items.Count > 0)
            {
                comboBoxnach.SelectedIndex = 0;
            }
        }
    }
}
