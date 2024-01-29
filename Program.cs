using System.Collections.Generic;

namespace Module_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            Task_3();
            Task_4();
            Task_5();
        }
        static void Task_1()
        {
            Console.WriteLine("Enter number;");

            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Not even");
        }
        static void Task_2()
        {
            Console.WriteLine("How much is the card in you hands?;");
            int iterNumber = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < iterNumber; i++)
            {
                Console.WriteLine("Enter cards ");
                string cardNumber = Console.ReadLine().ToUpper();   

                if (cardNumber.Equals("Q") || cardNumber.Equals("J") || cardNumber.Equals("T") || cardNumber.Equals("K"))
                {
                    result += 10;
                    continue;
                }
                int currentNumber = int.Parse(cardNumber);
                result += currentNumber;
            }
            Console.WriteLine($"Sum card = {result}");
        }
        static void Task_3()
        {
            Console.WriteLine("Enter Number ");
            int number = int.Parse(Console.ReadLine());

            List<int> listPrimeNumbers = new List<int>();

            List<int> listCompositeNumbers = new List<int>();

            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j != 0)
                    {
                        count += 1;
                    }
                }
                if (count == (i - 2)) listPrimeNumbers.Add(i);
                else listCompositeNumbers.Add(i);

                count = 0;
            }
            Console.WriteLine("PrimeNumbers " + string.Join("\t", listPrimeNumbers));
            Console.WriteLine("CompositeNumbers " + string.Join("\t", listCompositeNumbers));
        }
        static void Task_4()
        {
            Console.WriteLine("Enter the length;");
            int iterNumber = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;

            for (int i = 0; i < iterNumber; i++)
            {
                Console.WriteLine("Enter number");
                int Number = int.Parse(Console.ReadLine());

                if (minNumber > Number) minNumber = Number; 
            }
            Console.WriteLine($"Min number  {minNumber}");
        }
        static void Task_5()
        {
            Console.WriteLine("Enter max values;");
            int iterNumber = int.Parse(Console.ReadLine());

            int secretNum = new Random().Next(0, iterNumber);
            
            while(true)
            {
                Console.WriteLine("Enter variant;");
                int variantNumber = int.Parse(Console.ReadLine());

                if (variantNumber > secretNum)
                {
                    Console.WriteLine("-");
                }
                else if (variantNumber < secretNum)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine($"Done!!! Secret number {secretNum}");
                    break;
                }
            }
        }
    }
}
