namespace FizzBuzzKata.Prod
{
    public class FizzBuzz
    {
        public static string GetFizzBuzzMessage(uint number)
        {
            FizzBuzzStatus status = GetFizzBuzzStatus(number);

            if (status == FizzBuzzStatus.NoStatus)
            {
                return number.ToString();
            }
            else
            {
                return status.ToString();
            }
        }

        public static FizzBuzzStatus GetFizzBuzzStatus(uint number)
        {
            if (IsDivisibleBy3(number) && IsDivisibleBy5(number))
            {
                return FizzBuzzStatus.FizzBuzz;
            }
            else if (IsDivisibleBy5(number))
            {
                return FizzBuzzStatus.Buzz;
            }
            else if (!IsDivisibleBy3(number))
            {
                return FizzBuzzStatus.NoStatus;
            }            
            return FizzBuzzStatus.Fizz;
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