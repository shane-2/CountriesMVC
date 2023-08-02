using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesMVC_Lab
{
    public class CountryListView
    {
        public List<Country> AllCountries { get; set; }

        //constructors
        public CountryListView(List<Country> _allCountries)
        {
            AllCountries = _allCountries;
        }

        //methods
        public void Display()
        {
            for (int i = 0; i < AllCountries.Count; i++)
            {
                Console.WriteLine($"{i}. {AllCountries[i].Name}");
            }
        }
    }
}
