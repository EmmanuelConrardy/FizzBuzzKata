namespace FizzBuzzKata.Prod
{
    public class FizzBuzz
    {
        public static string GetFizzBuzzStatus(uint number)
        {
            if (IsDivisibleBy3(number))
            {
                return string.Empty;
            }
            return "Fizz";
        }

        private static bool IsDivisibleBy3(uint number)
        {
            return number % 3 != 0;
        }
    }
}