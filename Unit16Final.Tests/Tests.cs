using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit16Final.Tests
{
    public class Calculator
    {
        //сложение

        public int Additional(int a, int b)
        {
            return a + b;
        }
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(30, 10) == 40);
        }

        // разность
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(30, 10) == 20);
        }

        //умноение
        public int Miltiplication(int a, int b)
        {
            return a * b;
        }
        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(30, 10) == 300);
        }


        //деление
        public int Division(int a, int b)
        {
            return a / b;
        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(25, 5) == 5);
        }
        [Test]
        public void Division_ByZero()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(220, 0));
        }
    }
}

