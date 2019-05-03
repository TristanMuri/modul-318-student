using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace WindowsFormsApp1
{
    public partial class Verbindungen : Form
    {
        //Variabeln
        List<string> fromStationId = new List<string>();
        List<Station> stationList = new List<Station>();
        Transport transport = new Transport();
        string departureTime = null;
        string departureDate = null;


        public Verbindungen()
        {
            InitializeComponent();
            
        }

    //Events

    private void buttonsuchen_Click(object sender, EventArgs e)
        {
            SetDepartureDate();
            SetDepartureTime();
            lvConnections.Items.Clear();
            lvConnections.Items.AddRange(GetConnection(listvonStation.Text, listnachstation.Text));

        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBoxvon.Text = null;
            textBoxnach.Text = null;

            listnachstation.Items.Clear();
            listvonStation.Items.Clear();
        }

        private void comborefresh(object sender, EventArgs e)
        {
            listvonStation.Items.Clear();
            
        }

        //Funktionen

        private void vonStation(string location, ListBox listvonstation)
        {
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
                listvonStation.Items.Add(item);
            }
            if (listvonStation.Items.Count > 0)
            {
                listvonStation.SelectedIndex = 0;
            }
        }

        private void nachStation(string location, ComboBox comBoxnach)
        {
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
                listnachstation.Items.Add(item);
            }
            if (listnachstation.Items.Count > 0)
            {
                listnachstation.SelectedIndex = 0;
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
        
        //Function to get all connections into the ListView
        private ListViewItem[] GetConnection(string vonStation, string nachStation)
        {
            Connections ConnectionListView;
            try
            {
                ConnectionListView = transport.GetConnections(vonStation, nachStation, departureTime, departureDate);
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
        private void StationSuchen(ListBox aktuelleListBox, TextBox aktuelleTextBox, string gesuchteStation)
        {
            Stations Station = transport.GetStations(gesuchteStation);

            aktuelleListBox.Items.Clear();
            //aktuelleTextBox.Select(aktuelleTextBox.Text.Length, 0);

            foreach (Station s in Station.StationList)
            {
                try
                {
                    if (s.Id != null)
                    {
                        aktuelleListBox.Items.Add(s.Name);
                    }
                }
                catch
                {
                    ListViewItem verbindungsTabelle = new ListViewItem("Verbindung konnte nicht angezeigt werden", 0);
                }
            }
        }

        //Wechsel von VonStation und Nachstation
        private void buttonswitch_Click(object sender, EventArgs e)
        {
            string bswitch = textBoxnach.Text;
            textBoxnach.Text = textBoxvon.Text;
            textBoxvon.Text = bswitch;
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Öffnet Abfahrtstaffel Form
        private void buttonabfahrtstafel_Click(object sender, EventArgs e)
        {
            Abfahrtstafel f2 = new Abfahrtstafel();
            f2.ShowDialog();
        }

        //Auto complete und Auto fill

        private void txtchangevonstation(object sender, EventArgs e)
        {
            StationSuchen(listvonStation, textBoxvon, textBoxvon.Text);

            if (this.listvonStation.Items.Count > 0)
                this.listvonStation.SelectedIndex = 0;
        }

        private void txtchangenachstation(object sender, EventArgs e)
        {
            StationSuchen(listnachstation, textBoxnach, textBoxnach.Text);

            if (this.listnachstation.Items.Count > 0)
                this.listnachstation.SelectedIndex = 0;
        }

        private void listclickautocompletenach(object sender, EventArgs e)
        {
            textBoxnach.Text = listnachstation.GetItemText(listnachstation.SelectedItem);
        }

        private void listclickautocompletevon(object sender, EventArgs e)
        {
            textBoxvon.Text = listvonStation.GetItemText(listvonStation.SelectedItem);
        }

        //Mail und location

        private void buttonlocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com/maps");
        }

        private void buttonmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com/gmail");
        }
    }
}
