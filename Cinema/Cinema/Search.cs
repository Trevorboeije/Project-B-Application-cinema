using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema
{
    public class Search
    {
        public Search()
        {
            int filmChoice;
            string filmSearch;
            bool userWrong = true;

            Console.WriteLine("Waar zoek je naar?: \n [1]Film \n [2]Genre \n [3]Datum \n");
            var val = Console.ReadLine();
            filmChoice = Convert.ToInt32(val);

            while (userWrong)
            {
                if (filmChoice == 1)
                {
                    Console.WriteLine("Welke film zoek je?: ");
                    filmSearch = Console.ReadLine();

                    var match = Program.movies.FirstOrDefault(stringToCheck => stringToCheck.Contains(filmSearch));

                    if (match != null)
                    {
                        Console.WriteLine(match);
                    }
                    else
                    {
                        Console.WriteLine(filmSearch + " does not exist.");
                    }

                    userWrong = false;
                }

                else if (filmChoice == 2)
                {
                    Console.WriteLine("Welke film zoek je?: ");
                    filmSearch = Console.ReadLine();

                    var match = Program.movies.FirstOrDefault(stringToCheck => stringToCheck.Contains(filmSearch));

                    if (match != null)
                    {
                        Console.WriteLine(match);
                    }
                    else
                    {
                        Console.WriteLine(filmSearch + " does not exist.");
                    }

                    userWrong = false;
                }

                else if (filmChoice == 3)
                {
                    Console.WriteLine("Welke film zoek je?: ");
                    filmSearch = Console.ReadLine();

                    var match = Program.movies.FirstOrDefault(stringToCheck => stringToCheck.Contains(filmSearch));

                    if (match != null)
                    {
                        Console.WriteLine(match);
                    }
                    else
                    {
                        Console.WriteLine(filmSearch + " does not exist.");
                    }

                    userWrong = false;
                }

                else
                {
                    Console.WriteLine("Ongeldige keuze!");
                    Console.ReadLine();
                }
            }
        }
    }
}
