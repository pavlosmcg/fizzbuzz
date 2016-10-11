using System;
using System.Collections.Generic;

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

            try
            {
                var runner = new FizzBuzzRunner(new BasicFizzBuzzRules());
                foreach (string result in runner.Run(start, end))
                    Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
