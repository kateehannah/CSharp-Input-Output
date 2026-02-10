using System;

namespace InterestCalculatorApp
{
    class InterestCalculator
    {
        static void Main(string[] args)
        {
            // Input principal amount
            Console.Write("Enter principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            // Input rate of interest
            Console.Write("Enter rate of interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            // Input time in years
            Console.Write("Enter time in years: ");
            double time = Convert.ToDouble(Console.ReadLine());

            // Calculate simple interest
            double simpleInterest = (principal * rate * time) / 100;

            // Display result
            Console.WriteLine("Simple Interest: " + simpleInterest.ToString("F2"));
        }
    }
}
