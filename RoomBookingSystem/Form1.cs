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
using RoomBookingSystem.DTOs;

namespace RoomBookingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var initialiseConnection = new InitialiseConnection();
            var connectionString = initialiseConnection.InitialiseConnectionInfo();
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            var databaseFunctions = new DatabaseFunctions.DatabaseFunctions();
            var allrooms = databaseFunctions.GetAllRooms(ConnectionString);

            roomsListBox.DisplayMember = "RoomName";
            roomsListBox.ValueMember = "RoomId";
            roomsListBox.DataSource = allrooms;
            lblRoomInfo.Text = "Please select a room";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var databaseFunctions = new DatabaseFunctions.DatabaseFunctions();
            int roomCapacity = Convert.ToInt32(numRoomCapacity.Value);
            int hasProjector = Convert.ToInt32(chBxProjector.Checked);
            int hasToiletFacilities = Convert.ToInt32(chBxToiletFacilities.Checked);
            string roomName = txBxRoomName.Text;
            databaseFunctions.InsertRoom(ConnectionString, hasProjector, roomCapacity, hasToiletFacilities, roomName);
            var allrooms = databaseFunctions.GetAllRooms(ConnectionString);

            roomsListBox.DisplayMember = "RoomName";
            roomsListBox.ValueMember = "RoomId";
            roomsListBox.DataSource = allrooms;
        }

        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var roomInfo = roomsListBox.SelectedItem as Rooms;
            lblRoomInfo.Text = Convert.ToString(roomInfo.RoomId);
            lblRoomInfo.Text = Convert.ToString(roomInfo.RoomName);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminPanel();
            adminForm.Show();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            var roomInfo = roomsListBox.SelectedItem as Rooms;
            var databaseFunctions = new DatabaseFunctions.DatabaseFunctions();
            int roomId = roomInfo.RoomId;
            databaseFunctions.RemoveRoom(ConnectionString, roomId);
            MessageBox.Show(roomInfo.RoomName + " Removed");
            var allrooms = databaseFunctions.GetAllRooms(ConnectionString);

            roomsListBox.DisplayMember = "RoomName";
            roomsListBox.ValueMember = "RoomId";
            roomsListBox.DataSource = allrooms;
        }
    }
}
