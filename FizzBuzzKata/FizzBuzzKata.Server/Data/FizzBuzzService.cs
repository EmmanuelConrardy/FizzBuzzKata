using FizzBuzzKata.Prod;
using System.Threading.Tasks;

namespace FizzBuzzKata.Server.Data
{
    public class FizzBuzzService
    {
        public Task<string[]> GetFizzBuzzAsync(uint number)
        {
            var result = new string[number];

            for (uint i = 1; i < number; i++)
            {
                result[i] = FizzBuzz.GetFizzBuzz(i);
            }

            return Task.FromResult(result);
        }
    }
}
