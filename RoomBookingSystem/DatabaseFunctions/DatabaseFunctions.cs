using MySql.Data.MySqlClient;
using RoomBookingSystem.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBookingSystem.DatabaseFunctions
{
    public class DatabaseFunctions
    {
        public List<Rooms> GetAllRooms(string connectionString)
        {
            var allRooms = new List<Rooms>();
            using (var connection = new MySqlConnection(connectionString))
            try
            {
                var queryString = "select * from rooms order by room_name ASC";
                var results = SendSqlCommandWithResultsReturned(connection, queryString);
                while (results.Read())
                {
                    var room = new Rooms();
                    room.RoomId = Int32.Parse(results["room_id"].ToString());
                    room.RoomMaxCapacity = Int32.Parse(results["room_max_capacity"].ToString());
                    room.HasProjector = Boolean.Parse(results["has_projector"].ToString());
                    room.HasToilet = Boolean.Parse(results["has_toilet_facilities"].ToString());
                    room.RoomName = results["room_name"].ToString();
                    allRooms.Add(room);
                }
                connection.Close();
            }
            catch
            {
                throw new Exception();
            }
            return allRooms;
        }

        private static MySqlDataReader SendSqlCommandWithResultsReturned(MySqlConnection connection, string queryString)
        {
            connection.Open();
            var command = new MySqlCommand(queryString, connection);
            var results = command.ExecuteReader();
            return results;
        }

        public void InsertRoom(string connectionString, int hasProjector, int roomCapacity, int hasToiletFacilities, string roomName)
        {
            try
            {
                var queryString = String.Format($"insert into rooms (room_max_capacity, has_projector, has_toilet_facilities, room_name) values ({roomCapacity}, {hasProjector}, {hasToiletFacilities}, '{roomName}')");
                SendSqlCommandWithNoReturnResults(connectionString, queryString);
            }
            catch
            {
                throw new Exception();
            }
        }

        public void AddUser(string connectionString, string username, string password)
        {
            try
            {
                var queryString = String.Format($"insert into Users (Username, Password) values ('{username}', '{password}')");
                SendSqlCommandWithNoReturnResults(connectionString, queryString);
            }
            catch
            {
                throw new Exception();
            }
        }

        public void RemoveRoom(string connectionString, int roomid)
        {
            try
            {
                var queryString = String.Format($"delete from rooms where room_id = {roomid}");
                SendSqlCommandWithNoReturnResults(connectionString, queryString);
            }
            catch
            {
                throw new Exception();
            }
        }

        private static void SendSqlCommandWithNoReturnResults(string connectionString, string queryString)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand(queryString, connection);
                command.ExecuteReader();
                connection.Close();
            }
        }
    }
}
