using System.Collections.Generic;
using System.IO;

namespace Cinema
{
    class Program
    {
        static public List<Room> rooms = new List<Room>();
        static void Main(string[] args)
        {
            //this line takes the file location for the JSON files, reads the entire file, and passes it to the initializer
            rooms.Add(new Room(File.ReadAllText(@".\rooms\room1.json")));
            rooms.Add(new Room(File.ReadAllText(@".\rooms\room2.json")));
            rooms.Add(new Room(File.ReadAllText(@".\rooms\room3.json")));

            rooms[2].updateCreateRoom(@".\rooms\room3.json");
        }
    }
}