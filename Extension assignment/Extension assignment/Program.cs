using System;

namespace ExtensionAssignment
{
    public static class StringExtensions
    {
        public static void DisplayHelloMessage(this string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }

    

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();

            
            userName.DisplayHelloMessage();

        
            int result;
            int x = 20, y = 10;
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);
            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);

            if (y != 0)
            {
                result = (x / y);
                Console.WriteLine("Division Operator: " + result);
                result = (x % y);
                Console.WriteLine("Modulos Operator: " + result);
            }
            else
            {
                Console.WriteLine("Not divided by zero");
            }

            //task 4
            Console.WriteLine("-------------task4--------");
            Console.WriteLine("Enter a number;");

            int number = Convert.ToInt32(Console.ReadLine());

           

            Console.WriteLine("------------task 5--------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------task 6--------");
            int[] numbers = { 1, 2, 3, 4, 5 };

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);

            Console.WriteLine("Enter a positive integer:");
           

            Console.WriteLine("--------task8--------");
            bool validInput = false;
            int age = 0;

            do
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid integer for your age.");
                }
            } while (!validInput);

            if (age < 18)
            {
                Console.WriteLine("You are considered a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are considered an adult.");
            }
            else
            {
                Console.WriteLine("You are considered a senior.");
            }

            Console.ReadLine();
        }

        //  factorial
        private static int CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
    }
}
