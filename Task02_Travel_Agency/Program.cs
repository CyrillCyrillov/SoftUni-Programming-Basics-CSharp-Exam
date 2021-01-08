using System;

namespace Task02_Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTickets = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            int priceForTicket = int.Parse(Console.ReadLine());

            double sum = countOfTickets * priceForTicket;

            if (sum <= budget)
            {
                Console.WriteLine($"You can sell your client {countOfTickets} tickets for the price of {(priceForTicket * countOfTickets)}$!");
                Console.WriteLine($"Your client should become a change of {(budget - sum)}$!");
            }
            else
            {
                Console.WriteLine($"The budget of {budget}$ is not enough. Your client can't buy {countOfTickets} tickets with this budget!");
            }
            
        }
    }
}
