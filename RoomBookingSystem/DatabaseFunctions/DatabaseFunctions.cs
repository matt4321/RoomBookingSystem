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
                    var queryString = "select * from rooms";
                    connection.Open();
                    var command = new MySqlCommand(queryString, connection);
                    var results = command.ExecuteReader();
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

        public void InsertRoom(string connectionString, int hasProjector, int roomCapacity, int hasToiletFacilities, string roomName)
        {
            using (var connection = new MySqlConnection(connectionString))
                try
                {
                    var queryString = String.Format($"insert into rooms (room_max_capacity, has_projector, has_toilet_facilities, room_name) values ({roomCapacity}, {hasProjector}, {hasToiletFacilities}, '{roomName}')");
                    //var queryString = "insert into rooms (room_max_capacity, has_projector, has_toilet_facilities, room_name) values (" + roomCapacity + ", " + hasProjector + ", " + hasToiletFacilities + ", '" + roomName + "')";
                    connection.Open();
                    var command = new MySqlCommand(queryString, connection);
                    var results = command.ExecuteReader();
                    connection.Close();
                }
                catch
                {
                    throw new Exception();
                }
        }

        public Rooms GetSingleRoom(string connectionString, int roomId)
        {
            Rooms singleroom = new Rooms();
            using (var connection = new MySqlConnection(connectionString))                
            try
                {
                    var queryString = String.Format($"select * from rooms where room_id={roomId}");

                    connection.Open();
                    var command = new MySqlCommand(queryString, connection);
                    var results = command.ExecuteReader();
                    if (results.Read())
                    {
                        singleroom.RoomId = Int32.Parse(results["room_id"].ToString());
                        singleroom.RoomMaxCapacity = Int32.Parse(results["room_max_capacity"].ToString());
                        singleroom.HasProjector = Boolean.Parse(results["has_projector"].ToString());
                        singleroom.HasToilet = Boolean.Parse(results["has_toilet_facilities"].ToString());
                        singleroom.RoomName = results["room_name"].ToString();
                    }
                    connection.Close();
                }
                catch
                {
                    throw new Exception();
                }
            return (singleroom);
        }
    }
}
