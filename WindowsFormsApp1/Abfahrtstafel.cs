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
        List<string> fromStationId = new List<string>();
        List<Station> stationList = new List<Station>();
        Transport transport = new Transport();
        string departureTime = null;
        string departureDate = null;
        bool isArrivalTime = true;

        public Abfahrtstafel()
        {
            InitializeComponent();
        }

        private void textchanged(object sender, EventArgs e)
        {
            StationSuchen(listStation, textBoxAbfahrtstabelle, textBoxAbfahrtstabelle.Text);
        }

        //Funktion
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

        private void ltstationclick(object sender, EventArgs e)
        {
            textBoxAbfahrtstabelle.Text = listStation.GetItemText(listStation.SelectedItem);
        }
    }
}
