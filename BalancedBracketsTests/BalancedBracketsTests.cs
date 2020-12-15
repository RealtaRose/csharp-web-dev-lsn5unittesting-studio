using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {

        [TestMethod]
        public void OnlyBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void StringInBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod]
        public void StringInsideAndAfterBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch]Code"));
        }

        [TestMethod]
        public void StringInsideAndBeforeBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        [TestMethod]
        public void StringAfterBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        [TestMethod]
        public void StringBeforeBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("LaunchCode[]"));
        }

        [TestMethod]
        public void BracketBetweenString()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[]Code"));
        }




        [TestMethod]
        public void OnlyBracketsWrongWayReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void StringInWrongWayBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]LaunchCode["));
        }

        [TestMethod]
        public void StringInsideAndAfterWrongWayBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]Launch[Code"));
        }

        [TestMethod]
        public void StringInsideAndBeforeWrongWayBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        [TestMethod]
        public void StringAfterWrongWayBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][LaunchCode"));
        }

        [TestMethod]
        public void StringBeforeWrongWayBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("LaunchCode]["));
        }

        [TestMethod]
        public void WrongWayBracketBetweenString()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch][Code"));
        }


        [TestMethod]
        public void IncompleteLeftBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch[Code"));
        }

        [TestMethod]
        public void IncompleteRightBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code"));
        }

    }
}
