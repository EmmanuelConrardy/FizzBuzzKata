namespace FizzBuzzKata.Prod
{
    public class FizzBuzz
    {
        public static string GetFizzBuzz(uint number)
        {
            bool isDivisibleBy3 = number % 3 == 0;
            bool isDivisibleBy5 = number % 5 == 0;
            bool isDivisibleBy3And5 = number % 15 == 0;

            if (isDivisibleBy3And5)
            {
                return "FizzBuzz";
            }

            if (isDivisibleBy5)
            {
                return "Buzz";
            }

            if (isDivisibleBy3)
            {
                return "Fizz";
            }          
            
            return number.ToString();
        }       
    }
}