using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace RoomBookingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] file = System.IO.File.ReadAllLines(@"C:\tmp\info.txt");

            var server = file[0];
            var database = file[1];
            var user = file[2];
            var password = file[3];
            var port = file[4];

            ConnectionString = String.Format($"server={server};port={port};user id={user}; password={password}; database={database};");
        }

        public string ConnectionString { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            var databaseFunctions = new DatabaseFunctions.DatabaseFunctions();
            var allrooms = databaseFunctions.GetAllRooms(ConnectionString);


            listBox1.DisplayMember = "RoomName";
            listBox1.ValueMember = "RoomId";
            listBox1.DataSource = allrooms;
            lblRoomInfo.Text = ("Please select a room");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var databaseFunctions = new DatabaseFunctions.DatabaseFunctions();
            int roomCapacity = Convert.ToInt32(numRoomCapacity.Value);
            int hasProjector = Convert.ToInt32(chBxProjector.Checked);
            int hasToiletFacilities = Convert.ToInt32(chBxToiletFacilities.Checked);
            string roomName = txBxRoomName.Text;
            databaseFunctions.InsertRoom(ConnectionString, hasProjector, roomCapacity, hasToiletFacilities, roomName);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lbl = listBox1.SelectedItem.RoomName;
            lblRoomInfo.Text = (lbl);
        }
    }
}
