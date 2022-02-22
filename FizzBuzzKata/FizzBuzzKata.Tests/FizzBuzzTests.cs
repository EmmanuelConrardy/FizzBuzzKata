using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzTests
    {        
        [Test]
        public void Should_Return_Fizz_For_9()
        {
            int number = 9;

            string result = FizzBuzz.GetFizzBuzzStatus(number);
            
            Assert.AreEqual("Fizz", result);
        }
    }
}