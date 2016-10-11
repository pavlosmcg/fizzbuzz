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

            try
            {
                var runner = new FizzBuzzRunner();
                runner.Run(start, end);
                // TODO iterate through results here
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
