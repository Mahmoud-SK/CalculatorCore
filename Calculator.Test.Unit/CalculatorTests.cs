using NUnit.Framework;

namespace Calculator.Unit.Test
{
	public class CalculatorTests
	{
		private CalculatorClass uut;
		[SetUp]
		public void Setup()
		{
			uut = new CalculatorClass();
		}

		[TestCase(2, 4, 6)]
		[TestCase(-25, 55, 30)]
		[TestCase(5, -5, 0)]
		[TestCase(15, -5, 10)]
		public void Add_AddPositiveAndNegativeNumbers_ReturnCorrectResult(double a, double b, double result)
		{

			Assert.That(uut.Add(a, b), Is.EqualTo(result));

		}

		[TestCase(-4, 2, -6)]
		[TestCase(55, -25, 80)]
		[TestCase(-5, 5, -10)]
		[TestCase(-15, 5, -20)]
		public void Substract_SubstractTwoNumbersBothPosAndNeg_ReturnCorrectResult(double a, double b, double result)
		{
			Assert.That(uut.Substract(a, b), Is.EqualTo(result));
		}

		[TestCase(-4, 2, -8)]
		[TestCase(5, -5, -25)]
		[TestCase(-75, 25, -1875)]
		[TestCase(-15, 75, -1125)]
		public void Multiply_MultiplyTwoNumbersBothPosAndNeg_ReturnsCorrect(double a, double b, double result)
		{
			Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
		}

		[TestCase(-4, 2, 16)]
		[TestCase(3, 1, 3)]
		[TestCase(-5, 5, -3125)]
		[TestCase(-15, 5, -759375)]
		public void Power_PowerTwoNumbersBothPosAndNeg_ReturnsCorrect(double a, double b, double result)
		{
			Assert.That(uut.Power(a, b), Is.EqualTo(result));
		}



	}
}