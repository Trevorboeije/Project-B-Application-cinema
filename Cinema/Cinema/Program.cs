using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaal zaalone = new Zaal(System.IO.File.ReadAllLines(@".\zalen\zaal1.txt"));
            Zaal zaaltwo = new Zaal(System.IO.File.ReadAllLines(@".\zalen\zaal2.txt"));
            Zaal zaalthree = new Zaal(System.IO.File.ReadAllLines(@".\zalen\zaal3.txt"));
        }
    }

    class Zaal
    {
        char[,] layout;
        int chairs;
        public Zaal(string[] l)
        {
            chairs = Convert.ToInt32(l[l.Length - 1]);
            char[,] inputMatrix = new char[l[0].Length, l.Length - 1];
            for (int i = 0; i < inputMatrix.GetLength(0); i++)
                for (int j = 0; j < inputMatrix.GetLength(1); j++)
                {
                    inputMatrix[i, j] = l[j][i];
                }
            layout = inputMatrix;
        }
    }
}
