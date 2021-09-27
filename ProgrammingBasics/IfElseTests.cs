using Xunit;

namespace ProgrammingBasics
{
	public class IfElseTests
	{
		[Theory]
		[InlineData(7.0, false)]
		[InlineData(7.000000001, true)]
		[InlineData(0, false)]
		[InlineData(8, true)]
		public void IsGreaterThanSevenTest(double number, bool expectedResult)
		{
			Assert.Equal(expectedResult, IfElse.IsGreaterThanSeven(number));
		}

		[Theory]
		[InlineData("red", "RED")]
		[InlineData("Red", "RED")]
		[InlineData("RED", "RED")]
		[InlineData("ReD", "RED")]
		[InlineData("green", "green")]
		[InlineData("Green", "green")]
		[InlineData("GREEN", "green")]
		[InlineData("Blue", null)]
		public void RedUppercaseGreenLowercaseTest(string color, string expectedResult)
		{
			Assert.Equal(expectedResult, IfElse.RedUppercaseGreenLowercase(color));
		}

		[Theory]
		[InlineData(7, false)]
		[InlineData(0, true)]
		[InlineData(1, false)]
		[InlineData(4, true)]
		[InlineData(394, true)]
		public void IsEvenTest(int number, bool expectedResult)
		{
			Assert.Equal(expectedResult, IfElse.IsEven(number));
		}

		[Theory]
		[InlineData(7, true)]
		[InlineData(0, false)]
		[InlineData(1, true)]
		[InlineData(4, false)]
		[InlineData(73, true)]
		public void IsOddTest(int number, bool expectedResult)
		{
			Assert.Equal(expectedResult, IfElse.IsOdd(number));
		}

		[Theory]
		[InlineData(4, "between")]
		[InlineData(5, "between")]
		[InlineData(6, "between")]
		[InlineData(0, null)]
		[InlineData(3, null)]
		[InlineData(7, null)]
		[InlineData(8, null)]
		public void IsBetweenThreeAndSevenTest(int number, string expectedResult)
		{
			Assert.Equal(expectedResult, IfElse.IsBetweenThreeAndSeven(number));
		}

		[Theory]
		[InlineData(3, "Potato")]
		[InlineData(8, "Carrot")]
		[InlineData(7, "Potato")]
		[InlineData(0, null)]
		[InlineData(5, "Potato")]
		public void OddPotatoEightCarrotTest(int number, string expectedResult)
		{
			Assert.Equal(expectedResult, IfElse.OddPotatoEightCarrot(number));
		}

		[Theory]
		[InlineData("Head", "INVALID!")]
		[InlineData("Heads", "Tails")]
		[InlineData("heads", "Tails")]
		[InlineData("headS", "Tails")]
		[InlineData("Tail", "INVALID!")]
		[InlineData("Tails", "Heads")]
		[InlineData("tails", "Heads")]
		[InlineData("tailS", "Heads")]
		public void FlipCoinTest(string coin, string expectedResult)
		{
			Assert.Equal(expectedResult, IfElse.FlipCoin(coin));
		}
	}
}
