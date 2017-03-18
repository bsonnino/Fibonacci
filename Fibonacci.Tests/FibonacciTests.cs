using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(2, 1)]
        [DataRow(80, 23416728348467685)]
        [DataTestMethod]
        public void GivenDataFibonacciReturnsResultsOk(int number, Int64 result)
        {
            var fib = new Fib();
            var actual = fib.Fibonacci(number);
            Assert.AreEqual(result, actual);
        }

    }
}
