namespace FizzBuzzKata.Prod
{
    public class FizzBuzz
    {
        public static string GetFizzBuzzStatus(uint number)
        {
            if (IsDivisibleBy5(number))
            {
                return "Buzz";
            }
            else if (!IsDivisibleBy3(number))
            {
                return string.Empty;
            }            
            return "Fizz";
        }

        private static bool IsDivisibleBy3(uint number)
        {
            return number % 3 == 0;
        }

        private static bool IsDivisibleBy5(uint number)
        {
            return number % 5 == 0;
        }
    }
}