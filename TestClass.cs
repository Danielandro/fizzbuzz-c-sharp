using Xunit;
using fizzBuzz;

public class TestClass
{
  [Theory]
  [InlineData(3, 3)]
  [InlineData(6, 3)]
  [InlineData(9, 3)]

  public void NumbersDivisibleByThreeTheory(int num, int divisor)
  {
    Assert.True(FizzBuzz.DivisibleBy(num, divisor));
  }

  [Theory]
  [InlineData(5, 5)]
  [InlineData(10, 5)]
  [InlineData(20, 5)]

  public void NumbersDivisibleByFiveTheory(int num, int divisor)
  {
    Assert.True(FizzBuzz.DivisibleBy(num, divisor));
  }

}