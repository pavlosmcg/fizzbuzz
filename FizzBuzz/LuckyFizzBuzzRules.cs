namespace FizzBuzz
{
    public class LuckyFizzBuzzRules : IFizzBuzzRules
    {
        private readonly IFizzBuzzRules _wrappedFizzBuzzRules;

        public LuckyFizzBuzzRules(IFizzBuzzRules wrappedFizzBuzzRules)
        {
            _wrappedFizzBuzzRules = wrappedFizzBuzzRules;
        }

        public string TakeTurn(int input)
        {
            if (input.ToString().Contains("3"))
                return "Lucky";

            return _wrappedFizzBuzzRules.TakeTurn(input);
        }
    }
}
