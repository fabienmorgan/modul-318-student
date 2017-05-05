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
        private ITransport testee;
        private String input;
        private bool needAutoCompleteUpdate = false;
        private String Kürzungsdauer(string result)
        {
            String Dauer = result.Substring(3, 5);
            return Dauer;
        }
        public Anfangsview()
        {
            InitializeComponent();
            testee = new Transport();
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy | HH:mm";
            textBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.textBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.textBox4.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Suchen_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "" || textBox4.Text == "")
            {
                label3.Visible = true;
            }
            else
            {
                Ausgabe.Items.Clear();
                var testee = new Transport();
                string inputTime = dateTimePicker2.Text;
                var date = DateTime.Parse(inputTime.Substring(0, 10));
                String formattetDate = date.ToString("yyyy-MM-dd");
                String time = inputTime.Substring(12, 6);
                var connectionlist = testee.GetConnections(textBox4.Text, textBox3.Text, formattetDate, time);




                foreach (var connection in connectionlist.ConnectionList)
                {

                    ConnectionPoint from = connection.From;
                    ConnectionPoint to = connection.To;
                    var departure = DateTime.Parse(connection.From.Departure);
                    var arrival = DateTime.Parse(connection.To.Arrival);


                   /*AcceptButton* Ausgabe.Items.Add("Von: " + from.Station.Name + "\n"
                        + "   Abfahrt um: " + departure.ToString("hh.mm") + "\n"
                        + "   Nach: " + to.Station.Name + "\n"
                        + "   Ankunft an: " + arrival.ToString("hh.mm") + "\n"
                        + "   Dauer: " + Kürzungsdauer(connection.Duration));*/

                    var ausgabe = new ListViewItem(new[] { from.Station.Name, departure.ToString("hh.mm"), to.Station.Name, arrival.ToString("hh.mm"), Kürzungsdauer(connection.Duration) });
                    Ausgabe.Items.Add(ausgabe);
                }
            }
        }

        private void Los_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            testee = new Transport();
            Stations stations = testee.GetStations(textBox1.Text);
            Station station = stations.StationList[0];
            String id = station.Id;



            StationBoardRoot stationBoard = testee.GetStationBoard(textBox1.Text, id);


            foreach (StationBoard entries in stationBoard.Entries)
            {
                var Zeit = DateTime.Parse(entries.Stop.Departure.ToString());
                var item = new ListViewItem(new[] { Zeit.ToString("hh.mm"), entries.Category, entries.Name, entries.To });
                listView2.Items.Add(item);
            }



        }
        /*public void textbox3_Autocomplete(object sender, EventArgs e)
        {
            input = textBox4.Text;

            if (input.Length >= 3)
            {
                needAutoCompleteUpdate = true;
            }
            else
            {
                needAutoCompleteUpdate = false;
            }
            if (needAutoCompleteUpdate)
            {
                var stations = testee.GetStations(input);

                foreach (Station stationName in stations.StationList)
                {
                    textBox4.AutoCompleteCustomSource.Add(stationName.Name);
                }
                this.textBox4.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
            else
            {
                //this.textBox4.AutoCompleteMode = AutoCompleteMode.None;
            }
        }
        */

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Anfangsview_Load(object sender, EventArgs e)
        {
            listView2.Columns.Add("Zeit");
            listView2.Columns.Add("Name");
            listView2.Columns.Add("Nummer");
            listView2.Columns.Add("Nach");
            listView2.Columns[3].Width = 130;

            Ausgabe.Columns.Add("Von");
            Ausgabe.Columns.Add("Ab");
            Ausgabe.Columns.Add("Nach");
            Ausgabe.Columns.Add("An");
            Ausgabe.Columns.Add("Dauer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testee = new Transport();
            Stations stations = testee.GetStations(textBox4.Text);

            if (stations.StationList.Count > 0)
            {
                Station station = stations.StationList[0];


                System.Diagnostics.Process.Start("https://www.google.ch/maps/search/" + station.Name + " haltestelle");
            }
            else
            {
                MessageBox.Show("Geben Sie bitte eine Station ein");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testee = new Transport();
            Stations stations = testee.GetStations(textBox3.Text);

            if (stations.StationList.Count > 0)
            {
                Station station = stations.StationList[0];


                System.Diagnostics.Process.Start("https://www.google.ch/maps/search/" + station.Name + " haltestelle");
            }
            else
            {
                MessageBox.Show("Geben Sie bitte eine Station ein");
            }
        }

        private void shareEmail(String von, String abfahrtszeit, String zu, String ankunft, String dauer)
        {
            String url = "mailto:?subject=Öv%20Verbindungen&body=ÖV%20Verbindung%20zwischen%20" +
                            von + " - " + zu + "%0A" +
                            "Abfahrt: " + abfahrtszeit  + "%0A" +
                            "Ankunft: " + ankunft + "%0A" +
                            "Dauer: " + dauer;
            System.Diagnostics.Process.Start(url);

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void Ausgabe_MouseClick(object sender, MouseEventArgs e)
        {
            shareEmail(Ausgabe.SelectedItems[0].SubItems[0].Text,
                       Ausgabe.SelectedItems[0].SubItems[1].Text,
                       Ausgabe.SelectedItems[0].SubItems[2].Text,
                       Ausgabe.SelectedItems[0].SubItems[3].Text,
                       Ausgabe.SelectedItems[0].SubItems[4].Text
                       );
        }
    }
}
 
 