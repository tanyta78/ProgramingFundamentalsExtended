using System;

namespace Three_Brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double fatherFishing = double.Parse(Console.ReadLine());

            var totalTime = 1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother);
            var breakTime = totalTime * 0.15;

            totalTime += breakTime;
            var remainingTime = fatherFishing -totalTime;
            
            Console.WriteLine($"Cleaning time: {totalTime:f2}");
            if (remainingTime > 0)
                
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(remainingTime)} hours.");
            }

            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> { Math.Abs(Math.Floor(remainingTime))} hours.");
            }
        }
    }
}
