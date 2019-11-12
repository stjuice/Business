using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Business.Tests
{
    [TestClass]
    public class RegularFractionTest
    {
        [TestMethod]
        public void MyTestMethod()
        {
            var dic = new Dictionary<int, int>
            {
                [1] = 3,
                [2] = 2,
                [3] = 5
            };
            var result = dic.Select(x => x.Value * 10);
        }
        [TestMethod]
        public void RegularFractionTest_Get()
        {
            var fraction = new Fraction(2, 3);
            Assert.AreEqual("2/3", fraction.ToString());

            var fraction2 = new Fraction(3, 5);
            Assert.AreEqual("3/5", fraction2.ToString());
        }

        [TestMethod]
        public void RegularFractionTest_Addition()
        {
            var fraction1 = new Fraction(2, 3);
            var fraction2 = new Fraction(3, 5);

            var res = fraction1 + fraction2;

            Assert.AreEqual("1 4/15", res.ToString());
        }

        [TestMethod]
        public void RegularFractionTest_Substract()
        {
            var fraction1 = new Fraction(2, 3);
            var fraction2 = new Fraction(1, 2);

            var res = fraction1 - fraction2;

            Assert.AreEqual("1/6", res.ToString());
        }

        [TestMethod]
        public void RegularFractionTest_Multiplication()
        {
            var fraction1 = new Fraction(2, 3);
            var fraction2 = new Fraction(3, 4);

            var res = fraction1 * fraction2;

            Assert.AreEqual("1/2", res.ToString());
        }

        [TestMethod]
        public void RegularFractionTest_Division()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(3, 4);

            var res = fraction1 / fraction2;

            Assert.AreEqual("2/3", res.ToString());
        }

        [TestMethod]
        public void RegularFractionTest_Comparing_Bigger()
        {
            var fraction1 = new Fraction(3, 4);
            var fraction2 = new Fraction(2, 4);

            var res = fraction1 > fraction2;

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void RegularFractionTest_Comparing_Less()
        {
            var fraction1 = new Fraction(4, 17); 
            var fraction2 = new Fraction(5, 18);

            var res = fraction1 < fraction2;

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void RegularFractionTest_Comparing_Equal()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(2, 4);

            var res = fraction1 == fraction2;

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void RegularFractionTest_Comparing_NotEqual()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(2, 5);

            var res = fraction1 != fraction2;

            Assert.AreEqual(true, res);
        }
    }
}
