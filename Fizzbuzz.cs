using System;

namespace fizzBuzz
{
  class FizzBuzz
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }

    public static bool DivisibleBy(int num, int divisor)
    {
      return num % divisor == 0;
    }

  }
}
