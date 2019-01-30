using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Hand_testing_calculator;

namespace Calculator.Test.Unit
{
    [TestFixture]
    
    public class Class1
    {
        private Hand_testing_calculator.Calculator uut;
        [SetUp]
        public void SetUp()
        {
            uut = new Hand_testing_calculator.Calculator();
        }

        [Test]
        public void Add_2_and_2_is_4()
        {
            Assert.That(uut.Add(2, 2), Is.EqualTo(4));
        }

        [Test]
        public void Add_minus2_and_minus2_is_minus4()
        {
            Assert.That(uut.Add(-2,-2), Is.EqualTo(-4));
        }

        [Test]
        public void Subtract_5_and_2_is_3()
        {
            Assert.That(uut.Subtract(5,2), Is.EqualTo(3));
        }

        [Test]
        public void Subtract_minus5_and_10_is_minus15()
        {
            Assert.That(uut.Subtract(-5,10), Is.EqualTo(-15));
        }

        [Test]
        public void Subtract_5point1_and_2point2_is_2point9()
        {
            Assert.That(uut.Subtract(5.1,2.2), Is.EqualTo(2.9).Within(0.01));
        }

        [Test]
        public void Multiply_5_and_5_is_25()
        {
            Assert.That(uut.Multiply(5,5), Is.EqualTo(25));
        }

        [Test]
        public void Multiply_2point2_and_4_is_8point8()
        {
            Assert.That(uut.Multiply(2.2,4), Is.EqualTo(8.8));
        }

        [Test]
        public void Power_2_and_3_is_8()
        {
            Assert.That(uut.Power(2,3), Is.EqualTo(8));
        }

        [Test]
        public void Power_minus2_and_3_is_minus8()
        {
            Assert.That(uut.Power(-2, 3), Is.EqualTo(-8));
        }

        [Test]
        public void Divide_4_med_2()
        {
            Assert.That(uut.Divide(4, 2), Is.EqualTo(2));
        }
    }
}
