using System;

namespace fizzBuzz
{
  class FizzBuzz
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }

    public static bool DivisibleByThree(int num)
    {
      return num % 3 == 0;
    }

    public static bool DivisibleByFive(int num)
    {
      return num % 5 == 0;
    }

  }
}
