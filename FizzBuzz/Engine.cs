using System;

namespace FizzBuzz
{
    public static class Engine
    {
        public static string Map(int value)
        {
            return (value.IsFizz() ? "Fizz" : "") + (value.IsBuzz() ? "Buzz" : "") + (!value.IsFizz() && !value.IsBuzz() ? value.ToString() : "");
        }

        public static void Display(int val, int end)
        {
            Console.WriteLine(Map(val));
            if (val != end) Display(val + 1, end);
        }
    }

    public static class Extensions
    {
        public static bool IsFizz(this int value)
        {
            return value.IsDivisibleBy(3);
        }

        public static bool IsBuzz(this int value)
        {
            return value.IsDivisibleBy(5);
        }

        public static bool IsDivisibleBy(this int numerator, int divisor)
        {
            return numerator % divisor == 0;
        }
    }
}