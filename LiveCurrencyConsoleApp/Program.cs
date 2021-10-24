using LiveCurrencyConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrencyConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fromCurrency = "EUR";
            string toCurrency = "USD";
            string amount = "1";

            //
            // STEP 1 : Print all avaiable currencies on screen
            //

            // Get all available currency tags
            string[] availableCurrency = CurrencyConverter.GetCurrencyTags();
            // Print currency tags comma seperated
            Console.WriteLine("Available Currencies");
            Console.WriteLine(string.Join(",", availableCurrency));
            Console.WriteLine("\n");

            //
            // STEP 2 : Allow the User to input the currency rates
            //

            Console.WriteLine("Insert Currency you want to convert FROM");
            fromCurrency = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Insert Currency you want to convert TO");
            toCurrency = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Insert Amount you want to convert TO");
            amount = Console.ReadLine();
            Console.WriteLine("\n");
            //
            // STEP 3 : Calculate and display the currency exchange rate
            //

            // Calls a method to get the exchange rate between 2 currencies
            float value = CurrencyConverter.GetExchangeRate(fromCurrency, toCurrency, 1);
            float exchangeRate = CurrencyConverter.GetExchangeRate(fromCurrency, toCurrency, Convert.ToInt32(amount));
            // Print result of currency exchange
            Console.WriteLine("FROM " + 1 + " " + fromCurrency.ToUpper() + " TO " + toCurrency.ToUpper() + " = " + value);
            Console.WriteLine("FROM " + amount + " " + fromCurrency.ToUpper() + " TO " + toCurrency.ToUpper() + " = " + exchangeRate);

            // Wait for key press to close console window
            Console.ReadLine();
        }
    }
}
