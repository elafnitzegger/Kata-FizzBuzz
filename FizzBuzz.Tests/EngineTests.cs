using System;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Tests
{
    public class EngineTests
    {

        [Fact]
        public void ShouldReturnFizzForDivBy3()
        {
            for (int i = 1; i * 3 < 100; i++)
            {
                Assert.Contains("Fizz", FizzBuzz.Engine.Map(i * 3));
            }
        }

        [Fact]
        public void ShouldReturnBuzzForDivBy5()
        {
            for (int i = 1; i * 5 < 100; i++)
            {
                Assert.Contains("Buzz", FizzBuzz.Engine.Map(i * 5));
            }
        }

        [Fact]
        public void ShouldReturnFizzBuzzForDivBy3And5()
        {
            for (int i = 1; i * 3 * 5 < 100; i++)
            {
                Assert.Contains("FizzBuzz", FizzBuzz.Engine.Map(i * 3 * 5));
            }
        }

        [Fact]
        public void ShouldReturnNumberStringWnenNotDivBy3or5()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Assert.Equal(i.ToString(), FizzBuzz.Engine.Map(i));
                }
            }
        }
    }
}