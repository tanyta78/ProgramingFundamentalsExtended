namespace ProgFundamentalsExtended
{
    using System;
    using System.Globalization;
    using System.Linq;

    public class DataTypes
    {
        private static void Main()
        {
            //number of strings
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;
            string lastStr = string.Empty;

            bool addToEnd = true;

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();

                if (str.Equals(lastStr))
                {
                    result = string.Empty;
                    if (str.Equals("spin"))
                    {
                        i--;
                    }
                    continue;
                }

                lastStr = str;

                if (str.Equals("spin"))
                {
                    addToEnd = !addToEnd;
                    i--;
                }
                else if (addToEnd == true)
                {
                    result += str;
                }
                else if (addToEnd == false)
                {
                    result = str + result;
                }
            }

            Console.WriteLine(result);
        }

        public void PracticeIntegerNumbers()
        {
            sbyte num1 = -100;
            byte num2 = 128;
            short num3 = -3540;
            ushort num4 = 64876;
            uint num5 = 2147483648;
            int num6 = -1141583228;
            long num7 = -1223372036854775808;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.WriteLine(num7);
        }

        public void PracticeFloatingPointNumbers()
        {
            decimal num1 = 3.141592653589793238m;
            double num2 = 1.60217657;
            decimal num3 = 7.8184261974584555216535342341m;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }

        public void FloatOrInteger()
        {
            string a = Console.ReadLine();

            if (a.Contains('.'))
            {
                var result = Math.Round(double.Parse(a));
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(int.Parse(a));
            }
        }

        public void ScientificNotation()
        {
            decimal proxima = 4.22m * 9460000000000m;
            decimal milkyWay = 26000M * 9450000000000m;
            decimal radiusMilkyWay = 100000M * 9450000000000m;
            decimal distanceEarth = 46500000000M * 9450000000000M;

            Console.WriteLine(proxima.ToString("e2"));
            Console.WriteLine(milkyWay.ToString("e2"));
            Console.WriteLine(radiusMilkyWay.ToString("e2"));
            Console.WriteLine(distanceEarth.ToString("e2"));
        }

        public void Overfloats()
        {
            int n = int.Parse(Console.ReadLine());
            int overflows = 0;
            byte number = 0;

            for (int i = 0; i < n; i++)
            {
                number++;

                if (number == 0)

                    overflows++;
            }
            Console.WriteLine(number);

            if (overflows > 0)
            {
                Console.WriteLine("Overflowed " + overflows + " times");
            }
        }

        public void TerabytesToBytes()
        {
            double num = double.Parse(Console.ReadLine());
            decimal result = 1024m * 1024 * 1024 * 1024 * 8 * (decimal)num;
            Console.WriteLine("{0:0}", result);
        }

        public void TimeSpanLigthYears()
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal total = (9450000000000M / 300000M) * lightYears;

            TimeSpan diff = TimeSpan.FromSeconds((double)total);
            string formatted = string.Format(
                CultureInfo.CurrentCulture,
                "{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds\n",
                diff.Days / 7,
                diff.Days % 7,
                diff.Hours,
                diff.Minutes,
                diff.Seconds);

            Console.WriteLine(formatted);
        }

        public void TriangleFormations()
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());
            bool isValidTriangle = false;
            bool isRightTriangle = false;
            if ((sideA + sideB) > sideC && (sideC + sideB) > sideA && (sideA + sideC) > sideB)
            {
                isValidTriangle = true;
            }
            if (isValidTriangle)
            {
                Console.WriteLine("Triangle is valid.");
                if (sideA * sideA + sideB * sideB == sideC * sideC)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (sideC * sideC + sideB * sideB == sideA * sideA)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (sideC * sideC + sideA * sideA == sideB * sideB)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }

        public void DataOverflow()
        {
            ulong firstNum = ulong.Parse(Console.ReadLine());
            ulong secondNum = ulong.Parse(Console.ReadLine());
            ulong biggerNumber = Math.Max(firstNum, secondNum);
            ulong smallerNumber = Math.Min(firstNum, secondNum);
            string biggerType = "byte";
            if (biggerNumber <= ulong.MaxValue && biggerNumber > uint.MaxValue)
            {
                biggerType = "ulong";
            }
            else if (biggerNumber > ushort.MaxValue)
            {
                biggerType = "uint";
            }
            else if (biggerNumber > byte.MaxValue)
            {
                biggerType = "ushort";
            }

            string smallerType = "byte";
            if (smallerNumber <= ulong.MaxValue && smallerNumber > uint.MaxValue)
            {
                smallerType = "ulong";
            }
            else if (smallerNumber > ushort.MaxValue)
            {
                smallerType = "uint";
            }
            else if (smallerNumber > byte.MaxValue)
            {
                smallerType = "ushort";
            }

            var result = 0m;

            switch (smallerType)
            {
                case "ulong": result = Math.Round((decimal)biggerNumber / ulong.MaxValue); break;
                case "uint": result = Math.Round((decimal)biggerNumber / uint.MaxValue); break;
                case "ushort": result = Math.Round((decimal)biggerNumber / ushort.MaxValue); break;
                case "byte": result = Math.Round((decimal)biggerNumber / byte.MaxValue); break;
            }
            Console.WriteLine("bigger type: {0}", biggerType);
            Console.WriteLine("smaller type: {0}", smallerType);
            Console.WriteLine("{0} can overflow {1} {2} times", biggerNumber, smallerType, result);
        }

        public void VariableInHexadecimal()
        {
            var number = Console.ReadLine();
            var result = Convert.ToInt32(number, 16);
            Console.WriteLine(result);
        }

        public void DigitsWithWords()
        {
            string digit = Console.ReadLine().ToLower();
            switch (digit)
            {
                case "zero": Console.WriteLine("0"); break;
                case "one":
                    Console.WriteLine("1"); break;
                case "two":
                    Console.WriteLine("2"); break;
                case "three":
                    Console.WriteLine("3"); break;
                case "four":
                    Console.WriteLine("4"); break;
                case "five":
                    Console.WriteLine("5"); break;
                case "six":
                    Console.WriteLine("6"); break;
                case "seven":
                    Console.WriteLine("7"); break;
                case "eight":
                    Console.WriteLine("8"); break;
                case "nine":
                    Console.WriteLine("9"); break;
            }
        }

        public void AsciiString()
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                char currentChar = Convert.ToChar(currentNum);
                result += currentChar;
            }
            Console.WriteLine(result);
        }

        public void Calculator()
        {
            int firstOperand = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int secondOperand = int.Parse(Console.ReadLine());
            double result = 0;
            switch (sign)
            {
                case "*": result = firstOperand * secondOperand; break;
                case "+": result = firstOperand + secondOperand; break;
                case "-": result = firstOperand - secondOperand; break;
                case "/": result = (double)(firstOperand / secondOperand); break;
            }

            Console.WriteLine("{0} {1} {2} = {3}", firstOperand, sign, secondOperand, result);
        }

        public void TrickyStrings()
        {
            string delimiter = Console.ReadLine();
            int numbeOfStrings = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < numbeOfStrings; i++)
            {
                string currentWord = Console.ReadLine();
                if (i == numbeOfStrings - 1)
                {
                    result += currentWord;
                    break;
                }
                result += currentWord + delimiter;
            }
            Console.WriteLine(result);
        }

        public void CypherRoulette()
        {
        }
    }
}