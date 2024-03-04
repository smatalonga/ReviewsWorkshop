using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoinChange.Tests
{
    [TestClass]
    public class CentsTest
    {
        [DataTestMethod]
        [DataRow(1, 1, "1 way: 100 pennies")] 
        [DataRow(15, 6, "6 ways: as mentioned in the problem statement")]
        public void TestNumberOfWaysToMakeChange(int amount, int expected, string testCaseName)
        {
            var actual = CentsPrograme.WaysToMakeChange(amount);
            Assert.AreEqual(expected, actual, testCaseName);
        }
    }
}
