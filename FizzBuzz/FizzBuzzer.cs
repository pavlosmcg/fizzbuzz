using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public IEnumerable<string> Run(string startInput, string endInput)
        {
            if (startInput == null || endInput == null)
                throw new ArgumentNullException();

            int start, end;
            if (!int.TryParse(startInput, out start) || !int.TryParse(endInput, out end))
                throw new ArgumentException();

            if (start > end || start <= 0)
                throw new ArgumentOutOfRangeException();

            return null;
        }
    }
}
