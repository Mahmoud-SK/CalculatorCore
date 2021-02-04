using System;

namespace Calculator
{
	public class CalculatorClass
	{
        static void Main(string[] args)
		{
			CalculatorClass calc = new CalculatorClass();

			Console.WriteLine("Testing Addition - calc.Add(x,x)");
			Console.WriteLine($"8 + 2 = {calc.Add(8, 2)}");
			Console.WriteLine($"909 + 525 = {calc.Add(909, 525)}");
			Console.WriteLine($"352 + 86 = {calc.Add(352, 86)}");
			Console.WriteLine($"155 + 35 = {calc.Add(155, 35)}\n");


			Console.WriteLine("Testing Substract - calc.Substract(x,x)");
			Console.WriteLine($"8 - 2 = {calc.Substract(8, 2)}");
			Console.WriteLine($"55 - 5 = {calc.Substract(55, 5)}");
			Console.WriteLine($"25 - 86 = {calc.Substract(25, 86)}");
			Console.WriteLine($"155 - 5 = {calc.Substract(155, 5)}\n");


			Console.WriteLine("Testing Multiply - calc.Multiply(x,x)");
			Console.WriteLine($"8 * 2 = {calc.Multiply(8, 2)}");
			Console.WriteLine($"9 * 5 = {calc.Multiply(9, 5)}");
			Console.WriteLine($"2 * 86 = {calc.Multiply(2, 86)}");
			Console.WriteLine($"54 * 5 = {calc.Multiply(54, 5)}\n");


			Console.WriteLine("Testing Power - calc.Power(x,x)");
			Console.WriteLine($"5 power 2 = {calc.Power(5, 2)}");
			Console.WriteLine($"25 power 4 = {calc.Power(25, 4)}");
			Console.WriteLine($"25 power 6 = {calc.Power(25, 6)}");
			Console.WriteLine($"14 power 2 = {calc.Power(14, 2)}\n");
		}

		public double Accumulator { get; private set; }

		public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
		}

		public double Substract(double a, double b)
		{
            Accumulator = a - b;
			return Accumulator;
		}

		public double Multiply(double a, double b)
		{
            Accumulator = a * b;
            return Accumulator;
		}

		public double Power(double x, double exp)
		{
            Accumulator = Math.Pow(x,exp);
            return Accumulator;
        }
	}
}
