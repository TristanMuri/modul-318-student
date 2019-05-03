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
    public partial class Abfahrtstafel : Form
    {
        //Variabeln
        List<string> fromStationId = new List<string>();
        List<Station> stationList = new List<Station>();
        Transport transport = new Transport();
        string departureTime = null;
        string departureDate = null;


        public Abfahrtstafel()
        {
            InitializeComponent();
        }

        private void textchanged(object sender, EventArgs e)
        {
            StationSuchen(listStation, textBoxAbfahrtstabelle, textBoxAbfahrtstabelle.Text);

            if (this.listStation.Items.Count > 0)
                this.listStation.SelectedIndex = 0;
        }

        //Funktionen 
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

        //StationWaehlen
        public ListViewItem[] GetStationBoard(string fromStation)
        {
            Stations stations = new Stations();
            stations = transport.GetStations(fromStation);
            string stationId = stations.StationList.First().Id;
            StationBoardRoot stationBoard = null;
            try
            {
                stationBoard = transport.GetStationBoard(fromStation, stationId);
            }
            catch (Exception e)
            {
                ListViewItem[] errorListView = new ListViewItem[1];
                errorListView[0] = new ListViewItem("FEHLER");
                errorListView[0].SubItems.Add(e.Message);
                return errorListView;

            }
            ListViewItem[] stationListView = new ListViewItem[stationBoard.Entries.Count];
            int i = 0;
            foreach (StationBoard item in stationBoard.Entries)
            {
                stationListView[i] = new ListViewItem(item.Name);
                stationListView[i].SubItems.Add(item.Stop.Departure.ToShortTimeString());
                stationListView[i].SubItems.Add(item.To);
                i++;
            }
            if (stationListView == null)
            {
                stationListView[0] = new ListViewItem("Keine Abfahrtstafel vorhanden");
            }

            return stationListView;
        }

        public void setListItemView()
        {
            lvAbfahrt.Items.Clear();
            Abfahrtstafel mainForm = new Abfahrtstafel();
            lvAbfahrt.Items.AddRange(mainForm.GetStationBoard(listStation.Text));
        }

        //Such Button
        private void buttonabfahrtsuchen_Click(object sender, EventArgs e)
        {
            Stations S = transport.GetStations(listStation.Text);
            if (listStation.SelectedIndex >= 0)
            {
                Station WantedStation = S.StationList[listStation.SelectedIndex];
                StationBoardRoot SB = transport.GetStationBoard(WantedStation.Name, WantedStation.Id);
                lvAbfahrt.Items.Clear();
                foreach (StationBoard STemp in SB.Entries)
                {
                    ListViewItem connection1 = new ListViewItem();

                    connection1.SubItems.Add(STemp.Category);
                    connection1.SubItems.Add(STemp.Number);
                    connection1.SubItems.Add(STemp.To);
                    connection1.SubItems.Add(STemp.Operator);
                    connection1.SubItems.Add(STemp.Stop.Departure.ToShortTimeString());

                    lvAbfahrt.Items.Add(connection1);
                }
            }
            else
            {
                MessageBox.Show("Keine Station ausgewählt");
            }

            lvAbfahrt.Items.Clear();
            Abfahrtstafel mainForm = new Abfahrtstafel();
            lvAbfahrt.Items.AddRange(mainForm.GetStationBoard(listStation.Text));
        }

        private void buttonabfahrtsuchen_Click_1(object sender, EventArgs e)
        {
            lvAbfahrt.Items.Clear();
            lvAbfahrt.Items.AddRange(GetStationBoard(listStation.Text));
        }

        private void liststationclick(object sender, EventArgs e)
        {
            textBoxAbfahrtstabelle.Text = listStation.GetItemText(listStation.SelectedItem);
        }
    }
}
