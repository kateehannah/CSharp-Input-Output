using System;

namespace CurrencyConverterApp
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount in USD: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter exchange rate from USD to EUR: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            double convertedAmount = amount * rate;

            Console.WriteLine("Amount in EUR: " + convertedAmount.ToString("F2"));
        }
    }
}
