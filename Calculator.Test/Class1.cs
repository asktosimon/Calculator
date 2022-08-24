using NUnit.Framework;
using System;

namespace Calculator.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Additional()
        {
            var cal = new Calculator();
            Assert.That(cal.Additional(30, 10) == 40);
        }

        [Test]
        public void Division()
        {
            var cal = new Calculator();
            Assert.That(cal.Division(30, 10) == 3);
        }

        [Test]
        public void Division_MustThrowException()
        {
            var cal = new Calculator();
            Assert.Throws<DivideByZeroException>(() => cal.Division(30, 0));
        }

        [Test]
        public void Subtraction()
        {
            var cal = new Calculator();
            Assert.That(() => cal.Subtraction(30, 10) == 20);
        }

        [Test]
        public void Miltiplication()
        {
            var cal = new Calculator();
            Assert.That(() => cal.Miltiplication(30, 10) == 300);
        }
    }
}
