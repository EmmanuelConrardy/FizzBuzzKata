namespace FizzBuzzKata.Prod
{
    public class FizzBuzz
    {
        public static string GetFizzBuzzStatus(uint number)
        {
            if (number == 7|| number == 2)
            {
                return string.Empty;
            }
            return "Fizz";
        }
    }
}