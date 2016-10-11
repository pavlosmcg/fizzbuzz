namespace FizzBuzz
{
    public class BasicFizzBuzzRules : IFizzBuzzRules
    {
        public string TakeTurn(int input)
        {
            if (input%3 == 0)
                return "Fizz";

            return input.ToString();
        }
    }
}
