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

    public static bool DivisibleByThreeAndFive(int num)
    {
      return num % 15 == 0;
    }

    public static string GetOutput(int num)
    {
      if (DivisibleByThreeAndFive(num))
      {
        return "FizzBuzz";
      }
      else if (DivisibleByThree(num))
      {
        return "Fizz";
      }
      else
      {
        return num.ToString();

      }
    }
  }
}
