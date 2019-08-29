using Xunit;
using fizzBuzz;

public class TestClass
{

  // numbers divisible by 3
  [Theory]
  [InlineData(3)]
  [InlineData(6)]
  [InlineData(9)]

  public void NumbersDivisibleByThreeTheory(int num)
  {
    Assert.True(FizzBuzz.DivisibleByThree(num));
  }

  // numbers divisible by 5
  [Theory]
  [InlineData(5)]
  [InlineData(10)]
  [InlineData(20)]

  public void NumbersDivisibleByFiveTheory(int num)
  {
    Assert.True(FizzBuzz.DivisibleByFive(num));
  }

  // numbers divisible by 3 & 5
  [Theory]
  [InlineData(15)]
  [InlineData(30)]
  [InlineData(45)]

  public void NumbersDivisibleByThreeAndFiveTheory(int num)
  {
    Assert.True(FizzBuzz.DivisibleByThreeAndFive(num));
  }

  // numbers NOT divisible by 3
  [Theory]
  [InlineData(2)]
  [InlineData(4)]
  [InlineData(5)]

  public void NumbersNotDivisibleByThreeTheory(int num)
  {
    Assert.False(FizzBuzz.DivisibleByThree(num));
  }

  // numbers NOT divisible by 5
  [Theory]
  [InlineData(3)]
  [InlineData(6)]
  [InlineData(8)]

  public void NumbersNotDivisibleByFiveTheory(int num)
  {
    Assert.False(FizzBuzz.DivisibleByFive(num));
  }

  // numbers NOT divisible by 3 & 5
  [Theory]
  [InlineData(3)]
  [InlineData(5)]
  [InlineData(16)]

  public void NumbersNotDivisibleByThreeAndFiveTheory(int num)
  {
    Assert.False(FizzBuzz.DivisibleByThreeAndFive(num));
  }

  // [Theory]
  // public void FizzBuzzIfNumberDivisibleByThreeAndFive()
  // {
  //   Assert.Equal("FizzBuzz", FizzBuzz.GetOutput(15));
  // }

  [Fact]
  public void ReturnNumberIfNotDivisibleFact()
  {
    Assert.Equal("7", FizzBuzz.GetOutput(7));
  }
}