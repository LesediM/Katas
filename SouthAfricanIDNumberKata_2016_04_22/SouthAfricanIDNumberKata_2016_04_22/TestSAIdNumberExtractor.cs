﻿using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_22
{
    [TestFixture]
    public class TestSAIdNumberExtractor
    {
        [Test]
        public void ExtractDateOfBirth_GivenIDNumber_ShouldReturnDateOfBirthDDMMYYYY()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = "01-01-1980";
            var saIdNumberExtractor = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberExtractor.ExtractDateOfBirth(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractGender_GivenIDNumber_ShouldReturnGender()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = "Male";
            var saIdNumberExtractor = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberExtractor.ExtractGender(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractCitizenshipStatus_GivenIDNumber_ShouldReturnCitizenshipStatus()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = "SA";
            var saIdNumberExtractor = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberExtractor.ExtractCitizenshipStatus(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractIDParts_GivenIDNumber_ShouldReturnDateOfBirthGenderCitizenshipStatus()
        {
            //---------------Set up test pack-------------------
            var idNumber = "8001015009087";
            var expected = "01-01-1980, Male SA";
            var saIdNumberExtractor = CreateSaIdNumberExtractor();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = saIdNumberExtractor.ExtractIDParts(idNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private SAIdNumberExtractor CreateSaIdNumberExtractor()
        {
            return new SAIdNumberExtractor();
        }
    }
}
