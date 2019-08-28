using Xunit;
using fizzBuzz;

public class TestClass
{
  [Theory]
  [InlineData(3)]
  [InlineData(6)]
  [InlineData(9)]

  public void NumbersDivisibleByThreeTheory(int num)
  {
    Assert.True(FizzBuzz.DivisibleByThree(num));
  }

  [Theory]
  [InlineData(5)]
  [InlineData(10)]
  [InlineData(20)]

  public void NumbersDivisibleByFiveTheory(int num)
  {
    Assert.True(FizzBuzz.DivisibleByFive(num));
  }


}