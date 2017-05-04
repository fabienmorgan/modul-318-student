﻿using SwissTransport;
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
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy | HH:mm";
            textBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
        private void tbVon_TextChanged(object sender, EventArgs e)
        {
         
            input = textBox4.Text;

            if (input.Length > 3)
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
                this.textBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.textBox4.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }

        }
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
    }
}