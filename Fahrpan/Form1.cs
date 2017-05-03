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
    public partial class Form1 : Form
    {
        private ITransport testee;
        public Form1()
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
                
                for (int i = 0; i <= 4; i++)
                {
                    var testee = new Transport();
                    var station = testee.GetConnections(textBox4.Text, textBox3.Text);


                    Connection result = station.ConnectionList[i];
                    ConnectionPoint from = result.From;
                    ConnectionPoint to = result.To;

                    MessageBox.Show("Von: " + from.Station.Name + "\n"
                        + "Abfahrt um: " + result.From.Departure + "\n"
                        + "Nach: " + to.Station.Name + "\n"
                        + "Ankunft an: " + result.To.Arrival + "n"
                        + "Dauer: " + result.Duration
                        );
                }
            }
        }

        private void Los_Click(object sender, EventArgs e)
        {
           /* testee = new Transport();
            var stationBoard = testee.GetStationBoard("Sursee", "8502007");
            var station = station.ConnectionPoint[0];
            MessageBox.Show(stationBoard.Station); */
        }
    }
}
