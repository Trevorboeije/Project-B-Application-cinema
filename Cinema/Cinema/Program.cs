using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaal zaalone = new Zaal(System.IO.File.ReadAllText(@".\rooms\zaal1.json"));
            Zaal zaaltwo = new Zaal(System.IO.File.ReadAllText(@".\rooms\zaal2.json"));
            Zaal zaalthree = new Zaal(System.IO.File.ReadAllText(@".\rooms\zaal3.json"));

            zaalthree.updateCreateRoom(@".\rooms\zaal3.json");
        }
    }

    class Zaal
    {
        char[,] layout;
        int chairs;
        public Zaal(string l)
        {
            Initialize(l);
        }
        public void deleteRoom()
        {
            
        }
        public void Initialize(string l)
        {
            JObject input = JObject.Parse(l);
            chairs = (int)input["chairs"];
            JArray inputJArray = JArray.Parse(input["layout"].ToString());
            char[,] inputMatrix = new char[inputJArray.First.ToString().Length, inputJArray.Count];
            for (int i = 0; i < inputMatrix.GetLength(0); i++)
                for (int j = 0; j < inputMatrix.GetLength(1); j++)
                {
                    inputMatrix[i, j] = inputJArray[j].ToString()[i];
                }
            layout = inputMatrix;
        }

        public void updateCreateRoom(string room)
        {
            string json = System.IO.File.ReadAllText(room);

            JObject fullObject = JObject.Parse(json);

            JArray layoutArray = (JArray)fullObject["layout"];



            for (int i = 0; i < layoutArray.Count; i++)
            {
                Console.WriteLine("Replace the " + (i+1) + " line? If yes give new line.");
                string newLine = Console.ReadLine();
                if (newLine != "")
                {
                    layoutArray[i] = newLine;
                } 
            }

            Console.WriteLine("How many chairs should the room have?");
            fullObject["chairs"] = Int32.Parse(Console.ReadLine());

            string updatedString = fullObject.ToString();
            Initialize(updatedString);

            System.IO.File.WriteAllText(room , updatedString);
        }
    }
}
