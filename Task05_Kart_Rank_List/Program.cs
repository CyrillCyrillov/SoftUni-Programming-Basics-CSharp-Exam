using System;

namespace Task05_Kart_Rank_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold = 0;
            int silver = 0;
            int bronze = 0;
            string winnerName = " ";
            int winerTime = int.MaxValue;
            // string stop = "no"

            while (true)
            {
                string nextName = Console.ReadLine();
                
                if (nextName == "Finish") break;
                
                int minutes = int.Parse(Console.ReadLine());
                int seconds = int.Parse(Console.ReadLine());
                
                int timeInSeconds = 60 * minutes + seconds;
                
                if (timeInSeconds < winerTime)
                {
                    winerTime = timeInSeconds;
                    winnerName = nextName;
                }

                if (timeInSeconds < 55) gold += 1;
                else if (55 <= timeInSeconds && timeInSeconds <= 85) silver += 1;
                else if (85 < timeInSeconds && timeInSeconds <= 120) bronze += 1;
            }

            Console.WriteLine($"With {(winerTime / 60)} minutes and {(winerTime % 60)} seconds {winnerName} is the winner of the day!");
            Console.WriteLine($"Today's prizes are {gold} Gold {silver} Silver and {bronze} Bronze cards!");
        }
    }
}
