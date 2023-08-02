using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CountriesMVC_Lab.Country;

namespace CountriesMVC_Lab
{
    public class CountryController
    {
       
        public List<Country> countryDB = new List<Country>()
        {
            new Country("United States", Continent.NorthAmerica,"Red", "White", "Blue"),
            new Country("Mexico", Continent.NorthAmerica,"Red", "White", "Green"),
            new Country("Canada", Continent.NorthAmerica,"Red", "White"),
            new Country("France", Continent.NorthAmerica,"Red", "White", "Blue"),
            new Country("Germany", Continent.NorthAmerica,"Black", "Red", "Yellow"),
            
            new Country("China", Continent.Asia, "Red", "Yellow"),
            new Country("Brazil", Continent.SouthAmerica, "Green", "Yellow", "Blue"),
            new Country("Egypt", Continent.Africa, "Red", "White", "Black"),
            new Country("India", Continent.Asia, "Orange", "White", "Green"),
        };
        public void CountryAction(Country c)
        {
            CountryView list = new CountryView(c);
            list.Display();
            
        }
        public void WelcomeAction()
        {
            Console.WriteLine("Hello Welcome to the country app.");
            CountryListView listView = new CountryListView(countryDB);
            bool runProgram = true;
            while (runProgram) 
            {
            
                 Console.WriteLine("Please select a country by number from the following list:");
                listView.Display();

                 int menuChoice = 0;
                 while (int.TryParse(Console.ReadLine(), out menuChoice) == false)
                 {
                     Console.WriteLine("Incorrect Format");
                 }

                 Country c = countryDB[menuChoice];

                CountryAction(c);
                runProgram = GetContinue("Would you like to Choose another Country?");
            }


    }
    }
}
            //CountryListView listView = new CountryListView(itemDB);
            //listView.Display();
            ////ask for input
            //Console.WriteLine("Please pick an item number.");
            //int itemChoice = int.Parse(Console.ReadLine());

            //Country i = countryDB[countryChoice];
            //CountryView view = new CountryView(i);
            //view.Display();
