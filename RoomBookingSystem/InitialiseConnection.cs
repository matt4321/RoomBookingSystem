using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBookingSystem
{
    public class InitialiseConnection
    {
        public string InitialiseConnectionInfo()
        {
            string[] file = System.IO.File.ReadAllLines(@"C:\tmp\info.txt");
            var server = file[0];
            var database = file[1];
            var user = file[2];
            var password = file[3];
            var port = file[4];
            var connectionString = String.Format($"server={server};port={port};user id={user}; password={password}; database={database};");
            return connectionString;
        }
    }
}
