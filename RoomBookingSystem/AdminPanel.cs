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

            string[] file = System.IO.File.ReadAllLines(@"C:\tmp\info.txt");

            var server = file[0];
            var database = file[1];
            var user = file[2];
            var password = file[3];
            var port = file[4];

            ConnectionString = String.Format($"server={server};port={port};user id={user}; password={password}; database={database};");
        }
        public string ConnectionString { get; set; }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var hashedPassword = new Password.Password(txtAddPassword.Text);
            var hashBytes = hashedPassword.ToArray();
            var hashedPasswordToStore = Convert.ToBase64String(hashBytes);
            var usernameToStore = txtAddUsername.Text;
        }
    }
}
