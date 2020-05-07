using NUnit.Framework;
using QuantityMeasurementProblem;
using System;

namespace QuantityMeasurementTest
{
    public class Tests
    {
        readonly QuantityMeasurement qualityMeasurement = new QuantityMeasurement();
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// Test Case 1.1 Given 0 Feet And 0 Feet Should Return Equal.
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_ShouldReturnEqual()
        {
            //Creating conversion instance
            double value1 = qualityMeasurement.GetFeet(0.0);
            double value2 = qualityMeasurement.GetFeet(0.0);
            Assert.AreEqual(value1, value2, 0.0);
        }
        /// <summary>
        /// Test Case 1.2 Given null Feet Should Return False.
        /// </summary>
        [Test]
        public void GivenNullFeetValue_ShouldReturnFalse()
        {
            Assert.IsFalse(qualityMeasurement.Equals(null));
        }
        /// <summary>
        /// Test Case 1.3 Given same Reference when check reference Should Return Equal.
        /// </summary>
        [Test]
        public void GivenSameReference_WhenCheckRefenece_ShouldReturnTrue()
        {
            double feet1 = qualityMeasurement.GetFeet(0.0);
            QuantityMeasurement feet2 = new QuantityMeasurement();
            double referenceFeet = feet2.GetFeet(0.0);
            Boolean equals = (feet1.Equals(referenceFeet));
            Assert.IsTrue(equals);
        }
    }
}