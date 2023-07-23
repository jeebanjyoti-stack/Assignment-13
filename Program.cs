using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1
            Console.WriteLine("Hello, World!");
            //task-2
            Console.Write("please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            //Task-3
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;

            if (num2 != 0)
            {
                double division = (double)num1 / num2;
                int modulus = num1 % num2;

                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Difference: {difference}");
                Console.WriteLine($"Product: {product}");
                Console.WriteLine($"Division: {division}");
                Console.WriteLine($"Modulus: {modulus}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            //Task-4
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            //Task-5
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            //Task-6
            int[] numbers = { 10, 20, 30, 40, 50 };
            int Sum = 0;

            foreach (int Num in numbers)
            {
                Sum += Num;
            }

            double average = (double)Sum / numbers.Length;

            Console.WriteLine($"Sum: {Sum}");
            Console.WriteLine($"Average: {average}");


            //Task-8
            int age;

            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }


            //Task-7
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            long factorial = CalculateFactorial(num);
            Console.WriteLine($"Factorial of {num} is {factorial}.");

        }


        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
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
