using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesMVC_Lab
{
    public class Country
    {
        public enum Continent
        {
            Africa,
            Asia,
            Oceania,
            Europe,
            NorthAmerica,
            SouthAmerica,
            Antarctica

        }
        //properties
        public string Name { get; set; }
        public Continent CountryContinent { get; set; }
        public List<string> Colors { get; set; }

        //constructors
        public Country(string _name, Continent _continent, params string[] _colors)
        {
            Name = _name;
            CountryContinent = _continent;
            Colors = _colors.ToList();
        }
        public static bool GetContinue()
        {
            bool result = false;
            while (true)
            {
                Console.WriteLine("Would you like to run again? y/n");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                }
            }
            return result;
        }
        public static bool GetContinue(string message)
        {
            bool result = false;
            while (true)
            {
                Console.WriteLine($"{message} y/n");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                }
            }
            return result;
        }
    }
}
