namespace ProgFundExtLoops
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            // ChooseADrink();
            // ChooseDrink2();
            //RestaurantDiscount();
            // Hotel();
            // WordInPlural();
            // IntervalOfNums();
            // CakeIngredients();
            //CalCounter();
            // CountOfInt();
            //TriangleOfNums();
            //DiffNums();
            //TestNumbers();
            //GameOfNums();
            //MagicLetter();
        }

        private static void MagicLetter()
        {
            var firstLetter = Char.Parse(Console.ReadLine());
            var secondLetter = Char.Parse(Console.ReadLine());
            var bannedLetter = Char.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char h = firstLetter; h <= secondLetter; h++)
                    {
                        if (i == bannedLetter || j == bannedLetter || h == bannedLetter)
                        {
                            continue;
                        }
                        else
                        {
                            sb.Append($"{i}{j}{h} ");
                        }
                    }
                }
            }

            sb.Length -= 1;
            Console.WriteLine(sb.ToString());
        }

        private static void GameOfNums()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int maxNum = Math.Max(num1, num2);
            int minNum = Math.Min(num1, num2);
            bool isExist = false;
            int combinationsNumber = 0;

            for (int i = maxNum; i >= minNum; i--)
            {
                for (int j = maxNum; j >= minNum; j--)
                {
                    var currentSum = i + j;
                    combinationsNumber++;
                    if (currentSum == magicNum)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNum}");
                        isExist = true;
                        break;
                    }
                }
                if (isExist)
                {
                    break;
                }
            }

            if (!isExist)
            {
                Console.WriteLine($"{combinationsNumber} combinations - neither equals {magicNum}");
            }
        }

        private static void TestNumbers()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            bool isPrinted = false;
            int combinations = 0;
            int currentSum = 0;
            for (int firstDigit = n; firstDigit >= 1; firstDigit--)
            {
                for (int secondDigit = 1; secondDigit <= m; secondDigit++)
                {
                    currentSum += firstDigit * secondDigit * 3;
                    combinations++;
                    if (currentSum >= maxSum)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {currentSum} >= {maxSum}");
                        isPrinted = true;
                        break;
                    }
                }
                if (isPrinted)
                {
                    break;
                }
            }

            if (!isPrinted)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {currentSum}");
            }
        }

        private static void DiffNums()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 - num1 < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = num1; i <= num2 - 4; i++)
            {
                for (int j = i + 1; j <= num2 - 3; j++)
                {
                    for (int k = j + 1; k <= num2 - 2; k++)
                    {
                        for (int m = k + 1; m <= num2 - 1; m++)
                        {
                            for (int n = m + 1; n <= num2; n++)
                            {
                                Console.WriteLine($"{i} {j} {k} {m} {n}");
                            }

                        }
                    }
                }
            }
        }

        private static void TriangleOfNums()
        {
            int num = int.Parse(Console.ReadLine());
            for (int rowIndex = 1; rowIndex <= num; rowIndex++)
            {
                for (int colIndex = 1; colIndex <= rowIndex; colIndex++)
                {
                    Console.Write(rowIndex + " ");
                }
                Console.WriteLine();
            }
        }

        private static void CountOfInt()
        {
            var input = Console.ReadLine();
            var count = 0;
            while (int.TryParse(input, out int result))
            {
                count++;
                input = Console.ReadLine();
            }
            Console.WriteLine(count);
        }

        private static void CalCounter()
        {
            var pizzaRecipe = new Dictionary<string, int>()
           {
               {"cheese",500 },
               {"tomato sauce",150 },
               {"salami",600 },
               {"pepper",50 }
           };

            int ingredientsNums = int.Parse(Console.ReadLine());
            int totalCal = 0;

            for (int i = 0; i < ingredientsNums; i++)
            {
                var currentIngredient = Console.ReadLine().ToLower();
                if (pizzaRecipe.ContainsKey(currentIngredient))
                {
                    totalCal += pizzaRecipe[currentIngredient];
                }
            }

            Console.WriteLine($"Total calories: {totalCal}");
        }

        private static void CakeIngredients()
        {
            var input = Console.ReadLine();
            int count = 0;

            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                count++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }

        private static void IntervalOfNums()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            if (firstNum > secNum)
            {
                for (int i = secNum; i <= firstNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = firstNum; i <= secNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void WordInPlural()
        {
            string noun = Console.ReadLine();
            var result = string.Empty;
            if (noun.EndsWith("y"))
            {
                result = noun.Remove(noun.Length - 1);
                result += "ies";

            }
            else if (noun.EndsWith("o") || noun.EndsWith("x") || noun.EndsWith("z") || noun.EndsWith("ch") || noun.EndsWith("sh") || noun.EndsWith("s"))
            {
                result = noun + "es";
            }
            else
            {
                result = noun + "s";
            }

            Console.WriteLine(result);
        }

        private static void Hotel()
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double discount = 0;
            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50 * nightsCount;
                doublePrice = 65 * nightsCount;
                suitePrice = 75 * nightsCount;
                if (nightsCount > 7)
                {
                    discount = (double)5 / 100;
                    studioPrice -= (double)studioPrice * discount;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60 * nightsCount;
                doublePrice = 72 * nightsCount;
                suitePrice = 82 * nightsCount;
                if (nightsCount > 7)
                {
                    studioPrice = studioPrice - 60;
                }
                if (nightsCount > 14)
                {
                    discount = (double)10 / 100;
                    doublePrice -= (double)doublePrice * discount;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68 * nightsCount;
                doublePrice = 77 * nightsCount;
                suitePrice = 89 * nightsCount;

                if (nightsCount > 14)
                {
                    discount = (double)15 / 100;
                    suitePrice -= (double)suitePrice * discount;
                }
            }
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }

        private static void RestaurantDiscount()
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string packageName = Console.ReadLine();

            string hallName = string.Empty;
            double priceOfHall = 0;
            if (countOfPeople <= 50)
            {
                hallName = "Small Hall";
                priceOfHall = 2500;
            }
            else if (countOfPeople <= 100)
            {
                hallName = "Terrace";
                priceOfHall = 5000;
            }
            else if (countOfPeople <= 120)
            {
                hallName = "Great Hall";
                priceOfHall = 7500;
            }

            double totalPrice = priceOfHall;
            double discountSum = 0;
            switch (packageName)
            {
                case "Normal":
                    totalPrice = totalPrice + 500;
                    discountSum = totalPrice * 5 / 100.0;
                    break;
                case "Gold":
                    totalPrice = totalPrice + 750;
                    discountSum = totalPrice * 10 / 100.0; break;
                case "Platinium":
                    totalPrice = totalPrice + 1000;
                    discountSum = totalPrice * 15 / 100.0; break;
            }

            if (countOfPeople > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                double pricePerPerson = (totalPrice - discountSum) / countOfPeople;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
        }

        private static void ChooseDrink2()
        {
            var professionType = Console.ReadLine();
            string result = string.Empty;
            decimal price = 0;
            switch (professionType)
            {
                case "Athlete":
                    result = "Water";
                    price = 0.70m;
                    break;
                case "Businessman":
                case "Businesswoman":
                    result = "Coffee";
                    price = 1;
                    break;
                case "SoftUni Student":
                    result = "Beer";
                    price = 1.7m;
                    break;
                default:
                    result = "Tea";
                    price = 1.2m;
                    break;
            }

            int quantity = int.Parse(Console.ReadLine());
            decimal totalPrice = price * quantity;
            Console.WriteLine($"The {professionType} has to pay {totalPrice:f2}.");
        }

        private static void ChooseADrink()
        {
            var professionType = Console.ReadLine();
            string result = string.Empty;
            switch (professionType)
            {
                case "Athlete":
                    result = "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    result = "Coffee";
                    break;
                case "SoftUni Student":
                    result = "Beer";
                    break;
                default:
                    result = "Tea";
                    break;

            }

            Console.WriteLine(result);
        }

    }
}
