using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a start number: ");
            string start = Console.ReadLine();
            Console.Write("Please enter an end number: ");
            string end = Console.ReadLine();
            Console.WriteLine("And the results are:");

            var runner = new FizzBuzzer();
            runner.Run(start, end);
            // TODO iterate through results here
        }
    }
}
