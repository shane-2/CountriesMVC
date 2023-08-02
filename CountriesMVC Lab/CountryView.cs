using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CountriesMVC_Lab
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country _country)
        { 
            DisplayCountry = _country;
        }
        public void Display() 
        {
            Console.Clear();
            foreach(string c in DisplayCountry.Colors)
            {
                Console.WriteLine("Hit enter.");
                if (c == "Red")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("Hit enter.");
                    Console.ReadLine();
                }
                else if (c == "White")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("Hit enter.");
                    Console.ReadLine();
                }
                else if (c == "Blue")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Hit enter.");
                    Console.ReadLine();
                }
                else if (c == "Green")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Hit enter.");
                    Console.ReadLine();
                }
                else if (c == "Yellow")
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine("Hit enter.");
                    Console.ReadLine();
                }
                else if (c == "Black")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Hit enter.");
                    Console.ReadLine();
                }
                else if (c == "Orange")
                {
                    
                    Console.WriteLine("Orange");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ReadLine();
                }

            }//colors
            Console.WriteLine($"Name: {DisplayCountry.Name}.");
            Console.WriteLine($"Continent: {DisplayCountry.CountryContinent}.");
            Console.WriteLine($"Colors: ");
            foreach (string c in DisplayCountry.Colors)
            {
                Console.Write($" {c} ");
            }
            Console.WriteLine(""); 
        }
    }
}
//Next Create a CountryView Class. In the constructor require a Country be taken 
//    in and set to DisplayCountry. Create the following property and method: 
//Public Country DisplayCountry
//Public void Display() -This method will print out the Name, Continent, and 
//    Colors of the Country DisplayCountry property