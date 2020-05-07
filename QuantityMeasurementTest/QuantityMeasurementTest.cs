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
        /// <summary>
        /// Test Case 1.4 Given Feet type data same Should Return Equal.
        /// </summary>
        [Test]
        public void GivenFeet1TypeAndFeet2SameType_ShouldReturnEqual()
        {
            double type1 = qualityMeasurement.GetFeet(1.0);
            double type2 = qualityMeasurement.GetFeet(0.0);
            Type typeFeet1 = type1.GetType();
            Type typeFeet2 = type2.GetType();
            Assert.AreEqual(typeFeet1, typeFeet2);

        }
        /// <summary>
        /// Test Case 1.5 Given 1 Feet And 1 Feet Should Return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenEqual_ShouldReturnEqual()
        {
            double value1 = qualityMeasurement.GetFeet(1.0);
            double value2 = qualityMeasurement.GetFeet(1.0);
            Assert.AreEqual(value1, value2);
        }
        /// <summary>
        /// Test Case 1.6 Given 1 Feet And 10 Feet when check Should Return not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd10Feet_WhenNotEqual_ShouldReturnNotEqual()
        {
            double feet1 = qualityMeasurement.GetFeet(1.0);
            double feet2 = qualityMeasurement.GetFeet(10.0);
            Assert.AreNotEqual(feet1, feet2);
        }
        /// <summary>
        /// Test Case 1.7 Given null Inch Should Return false.
        /// </summary>
        [Test]
        public void GivenNullInchValue_ShouldReturnFalse()
        {
            Assert.IsFalse(qualityMeasurement.Equals(null));
        }
        /// <summary>
        /// Test Case 1.8 Given inch same Reference when check reference Should Return Equal.
        /// </summary>
        [Test]
        public void GivenInchReference_WhenCheckRefenece_ShouldReturnTrue()
        {
            double inch1 = qualityMeasurement.GetInch(0.0);
            QuantityMeasurement inch2 = new QuantityMeasurement();
            double referenceFeet = inch2.GetInch(0.0);
            Boolean equals = (inch1.Equals(referenceFeet));
            Assert.IsTrue(equals);
        }
    }
}