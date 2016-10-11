namespace FizzBuzz
{
    public class BasicFizzBuzzRules : IFizzBuzzRules
    {
        public string TakeTurn(int input)
        {
            string result = string.Empty;

            if (input%3 == 0)
                result += "Fizz";
            if (input%5 == 0)
                result += "Buzz";

            return string.IsNullOrEmpty(result)
                ? input.ToString()
                : result;
        }
    }
}
