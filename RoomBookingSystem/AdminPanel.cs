using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomBookingSystem.Password;

namespace RoomBookingSystem
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            var initialiseConnection = new InitialiseConnection();
            var connectionString = initialiseConnection.InitialiseConnectionInfo();
            ConnectionString = connectionString;
            GetAllUsers();
        }
        public string ConnectionString { get; set; }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var hashedPassword = new Password.Password(txtAddPassword.Text);
            var hashBytes = hashedPassword.ToArray();
            var hashedPasswordToStore = Convert.ToBase64String(hashBytes);
            var usernameToStore = txtAddUsername.Text;
            var databaseFunctions = new DatabaseFunctions.DatabaseFunctions();
            databaseFunctions.AddUser(ConnectionString, usernameToStore, hashedPasswordToStore);
        }

        private void GetAllUsers()
        {
            var databaseFunctions = new DatabaseFunctions.DatabaseFunctions();
            var listOfUsers = databaseFunctions.GetAllUsers(ConnectionString);
            foreach (var user in listOfUsers)
            {
                string[] row = {user.Username, user.Password};
                var listViewItem = new ListViewItem(row);
                lstUsers.Items.Add(listViewItem);
            }
        }
    }
}
