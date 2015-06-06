using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
	[TestClass]
    public class CalculatorTests
	{
		Calculator _calculator;

		[TestInitialize]
		public void TestInitialize()
		{
			_calculator = new Calculator();
		}

		[TestMethod]
		public void TestCalculatorInitialization()
		{
			Assert.AreEqual(1, _calculator.Value);
		}

		[TestMethod]
		public void TestCalculatorAddition()
		{
			_calculator.Add(99);

			Assert.AreEqual(99, _calculator.Value);
		}

		[TestMethod]
		public void TestCalculatorAdditionWith2Number()
		{
			_calculator.Add(3);
			_calculator.Add(5);

			Assert.AreEqual(8, _calculator.Value);
		}

		[TestMethod]
		public void TestCalculatorReset()
		{
			_calculator.Add(3);			
			_calculator.Reset();
			Assert.AreEqual(0, _calculator.Value);
		}
    }
}
