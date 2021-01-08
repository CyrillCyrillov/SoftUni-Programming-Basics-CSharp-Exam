using System;

namespace Task01_Shoping_For_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int pencils = int.Parse(Console.ReadLine());
            int feltTipPens = int.Parse(Console.ReadLine());
            int sketchbooksForDrawing = int.Parse(Console.ReadLine());
            int notebooks = int.Parse(Console.ReadLine());

            double sum = (pencils * 4.75 + feltTipPens * 1.80 + sketchbooksForDrawing * 6.50 + notebooks * 2.50);
            double sumAfterDiscont = sum - ((sum * 5) / 100);

            Console.WriteLine($"Your total is {sumAfterDiscont:F2}lv");
        }
    }
}
