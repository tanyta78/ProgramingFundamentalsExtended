namespace ProgFundExtArraysMore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MoreArrays
    {
        public static void Main()
        {
            int[] powerPlants = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int numberPlants = powerPlants.Length;
            int season = 0;
            bool allDead = false;

        }

        public static void CharRotation()
        {
            char[] chArr = Console.ReadLine().ToCharArray();
            int[] intArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < chArr.Length; i++)
            {
                int chAsciiCode = chArr[i];
                char toPrint = Char.MinValue;
                if (intArr[i] % 2 == 1)
                {
                    toPrint = (char)(chAsciiCode + intArr[i]);
                }
                else
                {
                    toPrint = (char)(chAsciiCode - intArr[i]);
                }

                Console.Write(toPrint);
            }
            Console.WriteLine();
        }

        public static void Phone()
        {
            string[] phones = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] names = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] commandInfo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (!commandInfo[0].Equals("done"))
            {
                if (commandInfo[0].Equals("call"))
                {
                    MakeCall(commandInfo, phones, names);
                }
                else
                {
                    SendMessage(commandInfo, phones, names);
                }

                commandInfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
        }

        private static void SendMessage(string[] commandInfo, string[] phones, string[] names)
        {

            string toSum = commandInfo[1];
            if (names.Contains(commandInfo[1]))
            {
                int index = Array.IndexOf(names, commandInfo[1]);
                toSum = phones[index];
                Console.WriteLine("sending sms to {0}...", toSum);
            }
            else
            {
                int index = Array.IndexOf(phones, commandInfo[1]);
                Console.WriteLine("sending sms to {0}...", names[index]);
            }
            int sumOfPhoneDigits = 0;
            foreach (var ch in toSum)
            {
                if (Char.IsDigit(ch))
                {
                    sumOfPhoneDigits += ch - '0';
                }
            }
            if (sumOfPhoneDigits % 2 == 1)
            {
                Console.WriteLine("busy");
            }
            else
            {
                Console.WriteLine("meet me there");
            }
        }

        private static void MakeCall(string[] commandInfo, string[] phones, string[] names)
        {

            string toSum = commandInfo[1];
            if (names.Contains(commandInfo[1]))
            {
                int index = Array.IndexOf(names, commandInfo[1]);
                toSum = phones[index];
                Console.WriteLine("calling {0}...", toSum);
            }
            else
            {
                int index = Array.IndexOf(phones, commandInfo[1]);
                Console.WriteLine("calling {0}...", names[index]);
            }
            int sumOfPhoneDigits = 0;
            foreach (var ch in toSum)
            {
                if (Char.IsDigit(ch))
                {
                    sumOfPhoneDigits += ch - '0';
                }
            }
            if (sumOfPhoneDigits % 2 == 1)
            {
                Console.WriteLine("no answer");
            }
            else
            {
                int minutes = sumOfPhoneDigits / 60;
                int seconds = sumOfPhoneDigits % 60;
                Console.WriteLine("call ended. duration: {0:00}:{1:00}", minutes, seconds);
            }
        }

        public static void Phonebook()
        {
            string[] phones = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] names = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string command = Console.ReadLine();
            while (!command.Equals("done"))
            {
                int index = Array.IndexOf(names, command);
                Console.WriteLine("{0} -> {1}", command, phones[index]);
                command = Console.ReadLine();
            }
        }

        public static void ElementsEqualsToIndex()
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == i)
                {
                    Console.Write(i);
                    if (i != input.Length - 1)
                    {
                        Console.Write(" ");
                    }
                }

            }
        }

        public static void FindLastThreeConsecEqualsStrins()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int count = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }

                if (count == 2)
                {
                    Console.WriteLine("{0} {0} {0}", input[i]);
                    break;
                }
            }
        }
    }
}
