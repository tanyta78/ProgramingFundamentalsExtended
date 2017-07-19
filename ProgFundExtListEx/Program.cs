using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgFundExtListEx
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        public void SumAfterExtraction()
        {
            var firstList = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            var resultList = new List<int>();

            foreach (var element in secondList)
            {
                if (!firstList.Contains(element))
                {
                    resultList.Add(element);
                }
            }

            if (firstList.Sum() == resultList.Sum())
            {
                Console.WriteLine($"Yes. Sum: {resultList.Sum()}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(resultList.Sum() - firstList.Sum())}");
            }
        }

        public void TrackDownloaded()
        {
            var blacklistedWords = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var result = new List<string>();
            var isBlacklisted = false;
            var filename = Console.ReadLine();
            while (!filename.Equals("end"))
            {
                foreach (var blacklistedWord in blacklistedWords)
                {
                    if (filename.Contains(blacklistedWord))
                    {
                        isBlacklisted = true;
                        break;
                    }
                }
                if (!isBlacklisted)
                {
                    result.Add(filename);
                }
                filename = Console.ReadLine();
                isBlacklisted = false;
            }

            result.Sort();
            foreach (var file in result)
            {
                Console.WriteLine(file);
            }
        }

        public void RemoveElementAtOddPosition()
        {
            var elements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = new List<string>();
            int counter = 1;

            foreach (var element in elements)
            {
                if (counter % 2 == 0)
                {
                    result.Add(element);
                }
                counter++;
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}