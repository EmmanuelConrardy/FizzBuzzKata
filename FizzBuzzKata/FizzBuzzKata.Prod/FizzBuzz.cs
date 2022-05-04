namespace FizzBuzzKata.Prod
{
    public class FizzBuzz
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string Bazz = "Bazz";

        public static string GetFizzBuzz(uint number)
        {
            var moduloFizzBuzz = new Dictionary<int, string>();
            moduloFizzBuzz.Add(35, Buzz + Bazz);
            moduloFizzBuzz.Add(21, Fizz + Bazz);
            moduloFizzBuzz.Add(15, Fizz + Buzz);
            moduloFizzBuzz.Add(7, Bazz);
            moduloFizzBuzz.Add(5, Buzz);
            moduloFizzBuzz.Add(3, Fizz);

            foreach (var modulo in moduloFizzBuzz.Keys)
            {
                if(number % modulo == 0)
                {
                    return moduloFizzBuzz[modulo];
                }
            }; 

            return number.ToString();
        }       
    }
}