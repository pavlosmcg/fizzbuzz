using System;
using System.Collections.Generic;
using System.Linq;

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
                var runner =
                    new FizzBuzzRunner(
                        new LuckyFizzBuzzRules(
                            new BasicFizzBuzzRules()));
                var results = runner.Run(start, end).ToArray();
                foreach (string item in results)
                    Console.WriteLine(item);

                var report = new ResultsReporter().CreateReport(results);
                foreach (var kvp in report)
                    Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
