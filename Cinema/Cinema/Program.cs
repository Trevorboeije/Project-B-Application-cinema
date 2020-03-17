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
        }
    }

    class Zaal
    {
        readonly char[,] layout;
        readonly int chairs;
        public Zaal(string l)
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
    }
}
