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
    public partial class mainform : Form
    {
        //Member Variabeln
        List<string> fromStationId = new List<string>();
        List<Station> stationList = new List<Station>();
        Transport transport = new Transport();
        string departureTime = null;
        string departureDate = null;
        int isArrivalTime = 1;

        public mainform()
        {
            InitializeComponent();
            
        }

        //Events
        private void buttonsuchen_Click(object sender, EventArgs e)
        {

        }
    }
}
