namespace ProgFundExtendet_Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MethodsEx
    {
        public static void Main()
        {
            StringEncryption();
        }

        
        public static void StringEncryption()
        {
            int numberOfChar = int.Parse(Console.ReadLine());
            string result = String.Empty;
            for (int i = 0; i < numberOfChar; i++)
            {
                string currentChar = Console.ReadLine();
                Console.Write(Encrypt(currentChar));
            }
            Console.WriteLine();
        }

        private static string Encrypt(string currentChar)
        {
            string charAsCrypt = String.Empty;
            int asciiCode = currentChar[0] - 'A' + 65;
            bool part = true;
            int index = asciiCode.ToString().Length - 1;
            int lastDigit = (int)(asciiCode.ToString()[index] - '0');
            int firstDigit = asciiCode.ToString()[0] - '0';
            string firstPart = Char.ConvertFromUtf32(asciiCode + lastDigit);
            string lastPart = Char.ConvertFromUtf32(asciiCode - firstDigit);
            charAsCrypt = firstPart + firstDigit.ToString() + lastDigit.ToString() + lastPart;
            return charAsCrypt;
        }

        public static void NumberToWords()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > 999)
                {
                    Console.WriteLine("too large");
                    continue;
                }
                else if (currentNumber < -999)
                {
                    Console.WriteLine("too small");
                    continue;
                }
                else if (currentNumber >= 0 && currentNumber < 100)
                {
                    continue;
                }
                else
                {
                    Letterize(currentNumber);
                }
            }
        }

        private static void Letterize(int currentNumber)
        {
            char firstDigit = currentNumber.ToString()[0];
            char secondDigit = currentNumber.ToString()[1];
            char thirdDigit = currentNumber.ToString()[2];
            if (currentNumber < 0)
            {
                Console.Write("minus ");
                firstDigit = currentNumber.ToString()[1];
                secondDigit = currentNumber.ToString()[2];
                thirdDigit = currentNumber.ToString()[3];
            }
           
            switch (firstDigit)
            {
                case '1':Console.Write("one-hundred");break;
                case '2': Console.Write("two-hundred"); break;
                case '3': Console.Write("three-hundred"); break;
                case '4': Console.Write("four-hundred"); break;
                case '5': Console.Write("five-hundred"); break;
                case '6': Console.Write("six-hundred"); break;
                case '7': Console.Write("seven-hundred"); break;
                case '8': Console.Write("eight-hundred"); break;
                case '9': Console.Write("nine-hundred"); break;
            }
            switch (secondDigit)
            {
                case '0': Console.Write(""); break;
                case '1':
                    switch (thirdDigit)
                    {
                        case '0': Console.Write(" and ten"); break;
                        case '1': Console.Write(" and eleven"); break;
                        case '2': Console.Write(" and twelve"); break;
                        case '3': Console.Write(" and thirteen"); break;
                        case '4': Console.Write(" and fourteen"); break;
                        case '5': Console.Write(" and fifteen"); break;
                        case '6': Console.Write(" and sixteen"); break;
                        case '7': Console.Write(" and seventeen"); break;
                        case '8': Console.Write(" and eighteen"); break;
                        case '9': Console.Write(" and nineteen"); break;
                    }
                    break;
                case '2': Console.Write(" and twenty"); break;
                case '3': Console.Write(" and thirty"); break;
                case '4': Console.Write(" and fourty"); break;
                case '5': Console.Write(" and fifty"); break;
                case '6': Console.Write(" and sixty"); break;
                case '7': Console.Write(" and seventy"); break;
                case '8': Console.Write(" and eighty"); break;
                case '9': Console.Write(" and ninety"); break;
            }
            if (!secondDigit.Equals('1') )
            {
                if (secondDigit.Equals('0') && !thirdDigit.Equals('0'))
                {
                    Console.Write(" and");
                }
                switch (thirdDigit)
                {
                    case '0': Console.Write(""); break;
                    case '1': Console.Write(" one"); break;
                    case '2': Console.Write(" two"); break;
                    case '3': Console.Write(" three"); break;
                    case '4': Console.Write(" four"); break;
                    case '5': Console.Write(" five"); break;
                    case '6': Console.Write(" six"); break;
                    case '7': Console.Write(" seven"); break;
                    case '8': Console.Write(" eight"); break;
                    case '9': Console.Write(" nine"); break;
                }
            }
            Console.WriteLine();

        }

        public static void Notification()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string result = Console.ReadLine();
                if (result.Equals("success"))
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }
                else if (result.Equals("error"))
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);
                }
            }
        }

        private static void ShowError(string operation, int code)
        {
            Console.WriteLine("Error: Failed to execute {0}.", operation);
            Console.WriteLine("==============================");
            Console.WriteLine("Error Code: {0}.", code);
            if (code > 0)
            {
                Console.WriteLine("Reason: Invalid Client Data.");
            }
            else
            {
                Console.WriteLine("Reason: Internal System Failure.");
            }
        }

        private static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine("Successfully executed {0}.", operation);
            Console.WriteLine("==============================");
            Console.WriteLine("Message: {0}.", message);

        }

        public static void ConvertIntToBase()
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            IntegerToBase(number, toBase);
        }

        private static void IntegerToBase(long number, int toBase)
        {
            var result = string.Empty;
            while (number != 0)
            {
                result = (number % toBase).ToString() + result;
                number = number / toBase;
            }

            Console.WriteLine(result);
        }

        public static void NthDigit()
        {
            string number = Console.ReadLine();
            int index = int.Parse(Console.ReadLine());
            FindNthDigit(number, index);
        }

        private static void FindNthDigit(string number, int index)
        {
            char result = number[number.Length - index];
            Console.WriteLine(result);
        }

        public static void StringRepeater()
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(str, count);
            Console.WriteLine(result);
        }

        private static string RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
            }

            return repeatedString;
        }


        public static void HelloName()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }

        public static void MinMethod()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            GetMin(a, b, c);
        }
        private static void GetMin(double d, double d1, double d2)
        {
            Console.WriteLine(Math.Min(d, Math.Min(d1, d2)));
        }
    }
}
