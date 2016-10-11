using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzRunner
    {
        private readonly string _errorMessage =
            "Please enter two valid integers, with the start value less than or equal to the end value";

        public IEnumerable<string> Run(string startInput, string endInput)
        {
            if (startInput == null || endInput == null)
                throw new ArgumentNullException(_errorMessage);

            int start, end;
            if (!int.TryParse(startInput, out start) || !int.TryParse(endInput, out end))
                throw new ArgumentException(_errorMessage);

            if (start > end || start <= 0)
                throw new ArgumentOutOfRangeException(_errorMessage);

            return null;
        }
    }
}
