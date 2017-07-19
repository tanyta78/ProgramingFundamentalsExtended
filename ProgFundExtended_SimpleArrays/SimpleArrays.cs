namespace ProgFundExtended_SimpleArrays
{
    using System;
    using System.Linq;

    public class SimpleArrays
    {
        public static void Main()
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine().Split(' ').ToArray();

            int positionX = 0;
            int positionY = 0;
            string command = String.Empty;

            for (int i = 0; i < commands.Length; i++)
            {
                if (i % 2 == 0)
                {
                    command = commands[i];
                }
                else
                {
                    switch (command)
                    {
                        case "up":
                            positionY += int.Parse(commands[i]);
                            break;

                        case "down":
                            positionY -= int.Parse(commands[i]);
                            break;

                        case "right":
                            positionX += int.Parse(commands[i]);
                            break;

                        case "left":
                            positionX -= int.Parse(commands[i]);
                            break;
                    }
                }
            }

            Console.WriteLine("firing at [{0}, {1}]", positionX, positionY);

            if (positionY == coordinates[1] && positionX == coordinates[0])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }

        public static void Altitude()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            long altitude = long.Parse(input[0]);
            string command = String.Empty;
            bool isCrushed = false;
            if (altitude <= 0)
            {
                Console.WriteLine("crashed");
                isCrushed = true;
            }
            else
            {
                for (int i = 1; i < input.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        command = input[i];
                    }
                    else
                    {
                        switch (command)
                        {
                            case "up": altitude += long.Parse(input[i]); break;
                            case "down": altitude -= long.Parse(input[i]); break;
                        }
                    }
                    if (altitude <= 0)
                    {
                        Console.WriteLine("crashed");
                        isCrushed = true;
                        break;
                    }
                }
            }

            if (!isCrushed)
            {
                Console.WriteLine("got through safely. current altitude: {0}m", altitude);
            }
        }

        public static void ArraySymmetrySecond()
        {
            string input = Console.ReadLine();
            string[] myArr = input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string result = "Yes";
            string[] reversedMyArr = input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Array.Reverse(myArr);
            for (int i = 0; i < myArr.Length; i++)
            {
                if (!myArr[i].Equals(reversedMyArr[i]))
                {
                    result = "No";
                    break;
                }
            }

            Console.WriteLine(result);
        }

        public static void ArraySymmetryOne()
        {
            string[] myArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string result = "Yes";
            for (int i = 0; i < myArr.Length / 2; i++)
            {
                string firstEl = myArr[i];
                string lastEl = myArr[myArr.Length - 1 - i];
                if (!firstEl.Equals(lastEl))
                {
                    result = "No";
                    break;
                }
            }

            Console.WriteLine(result);
        }

        public static void CountCapitalLetters()
        {
            char[] myArr = Console.ReadLine().ToCharArray();
            int countCapitalLetters = 0;
            for (int i = 0; i < myArr.Length; i++)
            {
                char currentElement = myArr[i];
                if (Char.IsUpper(currentElement))
                {
                    countCapitalLetters++;
                }
            }
            Console.WriteLine(countCapitalLetters);
        }

        public static void EqualSequence()
        {
            int[] myArr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            string result = "Yes";
            int previousElement = myArr[0];
            for (int i = 1; i < myArr.Length; i++)
            {
                int currentElement = myArr[i];
                if (currentElement != previousElement)
                {
                    result = "No";
                    break;
                }
                previousElement = currentElement;
            }
            Console.WriteLine(result);
        }

        public static void IncreasingSequence()
        {
            int[] myArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string result = "Yes";
            int previousElement = myArr[0];
            for (int i = 1; i < myArr.Length; i++)
            {
                int currentElement = myArr[i];
                if (currentElement < previousElement)
                {
                    result = "No";
                    break;
                }
                previousElement = currentElement;
            }
            Console.WriteLine(result);
        }

        public static void CountOccurOfLargerNum()
        {
            double[] myArr = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
            double pNum = double.Parse(Console.ReadLine());
            int result = Array.FindAll(myArr, x => x > pNum).Length;
            Console.WriteLine(result);
        }

        public static void CountGivenElementInArray()
        {
            int[] myArr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int searchedNum = int.Parse(Console.ReadLine());
            int result = Array.FindAll(myArr, x => x == searchedNum).Length;
            Console.WriteLine(result);
        }

        public static void CountNegativeEements()
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] myArr = new int[numbers];
            int count = 0;
            for (int i = 0; i < numbers; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
                if (myArr[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void MaxElement()
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] myArr = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(myArr.Max());
        }
    }
}