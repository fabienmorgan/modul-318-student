using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrpan
{
    public partial class Anfangsview : Form
    {
        private String Kürzungsdauer(string result)
        {
            String Dauer = result.Substring(3, 5);
            return Dauer;
                    }
        public Anfangsview()
        {
            InitializeComponent();
        }

        private void Suchen_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "" || textBox4.Text == "")
            {
                label3.Visible = true;
            }
            else
            {
                listBox1.Items.Clear();
                var testee = new Transport();
                var connectionlist = testee.GetConnections(textBox4.Text, textBox3.Text);
                foreach (var connection in connectionlist.ConnectionList)
                {
                    ConnectionPoint from = connection.From;
                    ConnectionPoint to = connection.To;
                    var departure = DateTime.Parse(connection.From.Departure);
                    var arrival = DateTime.Parse(connection.To.Arrival);
             
                    listBox1.Items.Add("Von: " + from.Station.Name + "\n"
                        + "   Abfahrt um: " + departure.ToString("hh.mm") + "\n"
                        + "   Nach: " + to.Station.Name + "\n"
                        + "   Ankunft an: " + arrival.ToString("hh.mm") + "\n"
                        + "   Dauer: " + Kürzungsdauer(connection.Duration));
                }
            }
        }

        private void Los_Click(object sender, EventArgs e)
        {
           /* var station = stationList.StationList[0];
                string id = station.Id;
                var stationboard = Transport.GetStationBoard(txtStation.Text, id)
                */



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
