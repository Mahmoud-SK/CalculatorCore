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
		public void Substract_SubstractTwoNumbers(double a, double b, double result)
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
			uut.Divide(10, 2);
			Assert.That(uut.Accumulator, Is.EqualTo(5));
		}


		//Nye test på de nye funktioner 
	   
		[Test]
		public void add2_AccumulatorTest_AccumulatorValue4()
		{
			uut.Add(4);
			Assert.That(uut.Accumulator, Is.EqualTo(4));
		}

		[Test]
		public void subtract2_AccumulatorTest_AccumulatorValue_minu5()
		{
			uut.Subtract(5);
			Assert.That(uut.Accumulator, Is.EqualTo(-5));
		}

		[Test]
		public void multiply2_AccumulatorTest_AccumulatorValue24()
		{
			uut.Add(6);
			uut.Multiply(4);
			Assert.That(uut.Accumulator, Is.EqualTo(24));
		}

		[Test]
		public void Power2_AccumulatorTest_AccumulatorValue8()
		{
			uut.Add(2);
			uut.Power(3);
			Assert.That(uut.Accumulator, Is.EqualTo(8));
		}

		[Test]
		public void Divide2_AccumulatorTest_AccumulatorValue5()
		{
			uut.Add(10);
			uut.Divide(2);
			Assert.That(uut.Accumulator, Is.EqualTo(5));
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