using System;

namespace Task03_Kart_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string laps = Console.ReadLine();
            string haveFanCard = Console.ReadLine();
            string type = Console.ReadLine();
            double price = 0;

            if (type == "Child" && laps == "five")
            {
                price = 7;
            }
            else if (type == "Child" && laps == "ten")
            {
                price = 11;
            }
            else if (type == "Junior" && laps == "five")
            {
                price = 9;
            }
            else if (type == "Junior" && laps == "ten")
            {
                price = 16;
            }
            else if (type == "Adult" && laps == "five")
            {
                price = 12;
            }
            else if (type == "Adult" && laps == "ten")
            {
                price = 21;
            }
            else if (type == "Profi" && laps == "five")
            {
                price = 18;
            }
            else if (type == "Profi" && laps == "ten")
            {
                price = 32;
            }

            if (haveFanCard == "yes")
            {
                price *= 0.8;
            }

            if (price <= budget)
            {
                Console.WriteLine($"You bought {type} ticket for {laps} laps. Your change is {(budget - price):F2}lv.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need {(price - budget):F2}lv more.");
            }
        }
    }
}
