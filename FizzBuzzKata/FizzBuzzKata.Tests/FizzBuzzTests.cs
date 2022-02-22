using FizzBuzzKata.Prod;
using NUnit.Framework;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzTests
    {        
        [Test]
        public void Should_Return_Fizz_For_9()
        {
            uint number = 9;

            string result = FizzBuzz.GetFizzBuzzStatus(number);
            
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void Should_Return_Nothing_For_7()
        {
            uint number = 7;

            string result = FizzBuzz.GetFizzBuzzStatus(number);

            Assert.IsTrue(string.IsNullOrEmpty(result));
        }

        [Test]
        public void Should_Return_Nothing_For_2()
        {
            uint number = 2;

            string result = FizzBuzz.GetFizzBuzzStatus(number);

            Assert.IsTrue(string.IsNullOrEmpty(result));
        }

        [Test]
        public void Should_Return_Nothing_For_13()
        {
            uint number = 13;

            string result = FizzBuzz.GetFizzBuzzStatus(number);

            Assert.IsTrue(string.IsNullOrEmpty(result));
        }

        [Test]
        public void Should_Return_Buzz_For_10()
        {
            uint number = 10;

            string result = FizzBuzz.GetFizzBuzzStatus(number);

            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void Should_Return_Buzz_For_25()
        {
            uint number = 25;

            string result = FizzBuzz.GetFizzBuzzStatus(number);

            Assert.AreEqual("Buzz", result);
        }
    }
}