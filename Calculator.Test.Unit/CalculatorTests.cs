using System;
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
		[TestCase(5, 5, 10)]
		[TestCase(5, 10, 15)]
		[TestCase(15, -5, 10)]
		public void Add_AddTwoNumbers(double a, double b, double result)
		{

			Assert.That(uut.Add(a, b), Is.EqualTo(result));

		}

		[TestCase(-4, 2, -6)]
		[TestCase(55, -25, 80)]
		[TestCase(-5, 5, -10)]
		[TestCase(-15, 5, -20)]
		public void Subtract_SubtractTwoNumbers(double a, double b, double result)
		{
			Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
		}

		[TestCase(-4, 2, -8)]
		[TestCase(5, -5, -25)]
		[TestCase(-75, 25, -1875)]
		[TestCase(-15, 75, -1125)]
		public void Multiply_MultiplyTwoNumbers(double a, double b, double result)
		{
			Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
		}

		[TestCase(-4, 2, 16)]
		[TestCase(3, 1, 3)]
		[TestCase(-5, 5, -3125)]
		[TestCase(-15, 5, -759375)]
		public void Power_PowerPosAndNegNumbers(double a, double b, double result)
		{
			Assert.That(uut.Power(a, b), Is.EqualTo(result));
		}

		[TestCase(4, 2, 2)]
		public void Division_DivideTwoNumbers(double a, double b, double result)
		{
			Assert.That(uut.Divide(a, b), Is.EqualTo(result));
		}

		[TestCase(5, 0, 0)]
		public void Division_DivideByZero_ExceptionTest(double a, double b, double result)
		{
			Assert.That(() => uut.Divide(a, b), Throws.TypeOf<DivideByZeroException>());
		}

		[Test]
		public void ctor_AccumulatorInitialValue_ValueZero()
		{
			Assert.That(uut.Accumulator, Is.Zero);
		}

		[Test]
		public void add_AccumulatorTest_AccumulatorValue8()
		{
			uut.Add(4, 4);
			Assert.That(uut.Accumulator, Is.EqualTo(8));
		}

		[Test]
		public void subtract_AccumulatorTest_AccumulatorValue2()
		{
			uut.Subtract(5, 3);
			Assert.That(uut.Accumulator, Is.EqualTo(2));
		}

		[Test]
		public void multiply_AccumulatorTest_AccumulatorValue16()
		{
			uut.Multiply(4, 4);
			Assert.That(uut.Accumulator, Is.EqualTo(16));
		}

		[Test]
		public void Power_AccumulatorTest_AccumulatorValue8()
		{
			uut.Power(2, 3);
			Assert.That(uut.Accumulator, Is.EqualTo(8));
		}

		[Test]
		public void Divide_AccumulatorTest_AccumulatorValue5()
		{
			//Tom Ændring
			uut.Divide(10, 2);
			Assert.That(uut.Accumulator, Is.EqualTo(5));
		}


		//Nye test på de nye funktioner 

		[TestCase(5,5)]
		[TestCase(10.2, 10.2)]
		[TestCase(-15, -15)]
		public void Add_SingleParameterTest_AccumulatorResult(double a, double result)
		{
			uut.Add(a);
			Assert.That(uut.Accumulator, Is.EqualTo(result));
		}

        [TestCase(5, -5)]
        [TestCase(10.2, -10.2)]
        [TestCase(-15, 15)]
		public void Subtract_SingleParameterTest_AccumulatorValue(double a, double result)
		{
			uut.Subtract(a);
			Assert.That(uut.Accumulator, Is.EqualTo(result));
		}

        [TestCase(2, 5, 10)]
        [TestCase(2, 10.2, 20.4)]
        [TestCase(2, -15, -30)]
		public void Multiply_SingleParameterTest_AccumulatorValue24(double a, double b, double result)
		{
			uut.Add(a);
			uut.Multiply(b);
			Assert.That(uut.Accumulator, Is.EqualTo(result));
		}

        [TestCase(2, 5, 32)]
        [TestCase(2, 10, 1024)]
        [TestCase(2, -1, 0.5)]
		public void Power_SingleParameterTest_AccumulatorValue8(double a, double b, double result)
		{
			uut.Add(a);
			uut.Power(b);
			Assert.That(uut.Accumulator, Is.EqualTo(result));
		}

        [TestCase(10,5, 2)]
        [TestCase(10, 10, 1)]
        [TestCase(10, -10, -1)]
		public void Divide_SingleParameterTest_AccumulatorValue5(double a, double b, double result)
		{
			uut.Add(a);
			uut.Divide(b);
			Assert.That(uut.Accumulator, Is.EqualTo(result));
		}

		[Test]
		public void Clear_AccumulatorTest()
		{
			uut.Add(69);
			uut.Multiply(5);
			uut.Clear();
			Assert.That(uut.Accumulator, Is.EqualTo(0));
		}
	   
		[Test]
		public void Power_NegativeRootDecimalExp_ExceptionTest()
		{
			Assert.That(() => uut.Power(-4, 5.5), Throws.TypeOf<ArgumentException>());
		}

	}
}