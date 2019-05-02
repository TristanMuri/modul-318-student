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
        bool isArrivalTime = true;


        public Verbindungen()
        {
            InitializeComponent();


            this.comboBoxvon.FormattingEnabled = true;
           

            
        }

    //Events

    private void buttonsuchen_Click(object sender, EventArgs e)
        {
            SetIsArrivalTime();
            SetDepartureDate();
            SetDepartureTime();
            lvConnections.Items.Clear();
            lvConnections.Items.AddRange(GetConnection(comboBoxvon.Text, comboBoxnach.Text));

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
            List<string> nachStationList = new List<string>();
            foreach (var item in station.StationList)
            {
                if (!string.IsNullOrEmpty(item.Name))
                {
                    nachStationList.Add(item.Name);
                }
            }
            foreach (var item in nachStationList)
            {
                comboBoxnach.Items.Add(item);
            }
            if (comboBoxnach.Items.Count > 0)
            {
                comboBoxnach.SelectedIndex = 0;
            }
        }

        //Function to set the membervariable departureTime
        private void SetDepartureTime()
        {
            departureTime = (TimePicker.Value.Hour) + ":" + TimePicker.Value.Minute;
        }
        //Function to set the memvervariable departureDate
        private void SetDepartureDate()
        {
            departureDate = datePicker.Value.Year + "-" + datePicker.Value.Month + "-" + datePicker.Value.Day;
        }
        //Funtion to set the membervariable IsArrivalTime, 0 = false, 1 = true. 1 is default value
        private void SetIsArrivalTime()
        {
            if (radioButtonabfahrt.Checked == true)
            {
                isArrivalTime = true;
            }
            else if (radioButtonAnkunft.Checked == true)
            {
                isArrivalTime = false;
            }
        }
        //Function to get all connections into the ListView
        private ListViewItem[] GetConnection(string vonStation, string nachStation)
        {
            Connections ConnectionListView;
            try
            {
                ConnectionListView = transport.GetConnections(vonStation, nachStation, departureDate, departureTime, isArrivalTime);
            }
            catch (Exception e)
            {
                ListViewItem[] errorListItemView = new ListViewItem[1];
                errorListItemView[0] = new ListViewItem("Fehler:\n");
                errorListItemView[0].SubItems.Add(e.Message);
                return errorListItemView;

            }
            ListViewItem[] listView = new ListViewItem[ConnectionListView.ConnectionList.Count];
            for (int i = 0; i < ConnectionListView.ConnectionList.Count; i++)
            {
                listView[i] = new ListViewItem(ConnectionListView.ConnectionList[i].From.Station.Name);
                listView[i].SubItems.Add(ConnectionListView.ConnectionList[i].To.Station.Name);
                listView[i].SubItems.Add(DateTime.Parse(ConnectionListView.ConnectionList[i].From.Departure).ToShortTimeString());
                listView[i].SubItems.Add(DateTime.Parse(ConnectionListView.ConnectionList[i].To.Arrival).ToShortTimeString());
                listView[i].SubItems.Add(TimeSpan.Parse(ConnectionListView.ConnectionList[i].Duration.Substring(3)).TotalMinutes.ToString() + " Min");
            }
            return listView;
        }

        private void buttonswitch_Click(object sender, EventArgs e)
        {
            string bswitch = comboBoxnach.Text;
            comboBoxnach.Text = comboBoxvon.Text;
            comboBoxvon.Text = bswitch;
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void autocomplete(object sender, EventArgs e)
        {
           // comboBoxvon.Items.Clear();
           // nachStation(comboBoxvon.Text, comboBoxvon);
        }

        private void buttonabfahrtstafel_Click(object sender, EventArgs e)
        {
            Abfahrtstafel f2 = new Abfahrtstafel();
            f2.ShowDialog();
        }
    }
}
