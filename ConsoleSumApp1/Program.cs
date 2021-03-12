using System;

namespace ConsoleSumApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;

            Console.Write("Enter the first Interger: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Interger: ");
            number2 = int.Parse(Console.ReadLine());
            sum = number1 + number2;
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
