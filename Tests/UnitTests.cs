sing System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid_Tu()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid_Tu()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null_Tu()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        
        [Test]
        public void Sub_Valid_Tu()
        {
            Assert.AreEqual(2, Program.Subtract("4", "2"));
            Assert.AreEqual(3, Program.Subtract("6", "3"));
            Assert.AreEqual(1, Program.Subtract("6", "5"));
        }

        [Test]
        public void Sub_Invalid_Tu()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Sub_Null_Tu()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }
        
        
        //MULTIPLICATION
        [Test]
        public void Mul_Valid_Tu()
        {
            Assert.AreEqual(8, Program.Multiply("4", "2"));
            Assert.AreEqual(18, Program.Multiply("6", "3"));
            Assert.AreEqual(30, Program.Multiply("5", "6"));
        }

        [Test]
        public void Mul_Invalid_Tu()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Mul_Null_Tu()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }
        
        
        //  DIVISION
        [Test]
        public void Di_Valid_Tu()
        {
            Assert.AreEqual(4, Program.Divide("8", "2"));
            Assert.AreEqual(7, Program.Divide("21", "3"));
            Assert.AreEqual(5, Program.Divide("35", "7"));
        }

        [Test]
        public void Di_Invalid_Tu()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Di_Null_Tu()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }
        
        //POWER
        [Test]
        public void Power_Valid_Tu()
        {
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(27, Program.Power("3", "3"));
            Assert.AreEqual(16, Program.Power("2", "3"));
        }

        [Test]
        public void Power_Invalid_Tu()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_Null_Tu()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
        
    }
}
