using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class _81DictionaryVsList
    {
        public static void RunProgram()
        {
            string userChoice = "";
            Country C1 = new Country() { Name = "India", Code = "IND", Capital = "Delhi" };
            Country C2 = new Country() { Name = "Australia", Code = "AUS", Capital = "Canberra" };
            Country C3 = new Country() { Name = "United States", Code = "USA", Capital = "Washington" };
            Country C4 = new Country() { Name = "United Kingdom", Code = "UK", Capital = "London" };
            Country C5 = new Country() { Name = "Canada", Code = "CAN", Capital = "Ottawa" };

            List<Country> Countrylist = new List<Country>();
            Countrylist.Add(C1);
            Countrylist.Add(C2);
            Countrylist.Add(C3);
            Countrylist.Add(C4);
            Countrylist.Add(C5);
            //By using dictionary*********************

            Dictionary<string, Country> dict = new Dictionary<string, Country>();
            dict.Add(C1.Code, C1);
            dict.Add(C2.Code, C2);
            dict.Add(C3.Code, C3);
            dict.Add(C4.Code, C4);
            dict.Add(C5.Code, C5);


            do
            {
                Console.WriteLine("please enter Country Code");
                string countryCode = Console.ReadLine().ToUpper();

                //Country foundCountry = Countrylist.Find(country => country.Code == countryCode);
                Country foundCountry = dict.ContainsKey(countryCode) ? dict[countryCode] : null;

                if (foundCountry == null)
                {
                    Console.WriteLine("Please enter a valid code");
                }
                else
                {
                    Console.WriteLine("Name : {0} Capital : {1}", foundCountry.Name, foundCountry.Capital);
                }
                do
                {
                    Console.WriteLine("You want to continue???? - yes or no");
                    userChoice = Console.ReadLine().ToLower();
                } while (userChoice != "yes" && userChoice != "no");

            } while ((userChoice == "yes"));

        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }

}
