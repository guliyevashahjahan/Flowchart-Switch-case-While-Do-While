using System.Diagnostics.Metrics;

namespace Task2024._05._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(number + " is not a prime number");
                    return;
                }

            }
            Console.WriteLine(number + " is a prime number");
           

            /////////////////////////////////////////////////////

            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while (num > 0)
            {
                num /= 10;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
