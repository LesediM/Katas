﻿using System;
using NUnit.Framework;

namespace StringCalculator_2016_04_18
{
    [TestFixture]
    public class TestStringCalculator

    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturn0()
        {
            //---------------Set up test pack-------------------
            var expected = 0;
            var numbers = "";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenSingleNumber_ShouldReturnSingleNumber()
        {
            //---------------Set up test pack-------------------
            var expected = 1;
            var numbers = "1";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }


        [Test]
        public void Add_GivenLargeSingleNumber_ShouldReturnLargeSingleNumber()
        {
            //---------------Set up test pack-------------------
            var expected = 120;
            var numbers = "120";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenTwoNumbers_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 3;
            var numbers = "1,2";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenNumberStringWithNewlines_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "1\n2,3";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenNumberStringWithNewDelimiterAndline_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 3;
            var numbers = "//;\n1;2";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenNumberStringWithNegative_ShouldThrowArgException()
        {
            //---------------Set up test pack-------------------
            var expected = "negatives not allowed: -2";
            var numbers = "1,-2,3";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var ex = Assert.Throws<ArgumentException>(() => stringcalculator.Add(numbers));
            //---------------Test Result -----------------------

            Assert.AreEqual(expected, ex.Message);
        }

        [Test]
        public void Add_GivenNumberStringWithMultipleNegativeNumbers_ShouldThrowArgException()
        {
            //---------------Set up test pack-------------------
            var expected = "negatives not allowed: -1,-2";
            var numbers = "-1,-2,3";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var ex = Assert.Throws<ArgumentException>(() => stringcalculator.Add(numbers));
            //---------------Test Result -----------------------

            Assert.AreEqual(expected, ex.Message);
        }

        [Test]
        public void Add_GivenNumberStringWithANumberGreaterThan1000_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "1,2,3,1001";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenNumberStringWithANumberLessAndEqualTo1000_ShouldReturn1006()
        {
            //---------------Set up test pack-------------------
            var expected = 1006;
            var numbers = "1,2,3,1000";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenNumberStringWithDelimtersOfAnyLength_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "//[***]\n1***2***3";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenNumberStringWithManyDelimiters_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "//[****][%]1****2%3";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private static StringCalculator CreateStringcalculator()
        {
            return new StringCalculator();
        }
    }
}
