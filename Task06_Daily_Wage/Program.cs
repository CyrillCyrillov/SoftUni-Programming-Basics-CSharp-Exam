using System;

namespace Task06_Daily_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupsStrawberry = 0;
            int cupsBlueberries = 0;

            int rows = int.Parse(Console.ReadLine());
            int positions = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int x = 1; x <= positions; x++)
                {
                    if (i % 2 != 0) cupsStrawberry += 1;
                    if (i % 2 == 0 && x % 3 != 0) cupsBlueberries += 1;
                }
            }

            double sum = ((cupsStrawberry * 3.5) + (cupsBlueberries * 5)) * 0.8;
            Console.WriteLine($"Total: {sum:F2} lv.");
        }
    }
}
