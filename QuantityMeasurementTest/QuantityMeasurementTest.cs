using NUnit.Framework;
using QuantityMeasurementProblem;
using System;

namespace QuantityMeasurementTest
{
    public class Tests
    {
        //readonly Length length = new Length();
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
            //Instance of Feet
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length feet2 = new Length(Length.Unit.FEET, 0.0);
            //Checking first  type and second type values are equal or not. If it returns true test 
            bool equals = feet1.Equals(feet2);
            Assert.IsTrue(equals);
        }
        /// <summary>
        /// Test Case 1.2 Given null Feet Should Return False.
        /// </summary>
        [Test]
        public void GivenNullFeetValue_ShouldReturnFalse()
        {
            bool equals = Length.Equals(Length.Unit.FEET, null);
            Assert.IsFalse(equals);
        }
        /// <summary>
        /// Test Case 1.3 Given same Reference when check reference Should Return Equal.
        /// </summary>
        [Test]
        public void GivenSameReference_WhenCheckRefenece_ShouldReturnTrue()
        {
            //Instance of Feet
            Length referanceFeet1 = new Length(Length.Unit.FEET, 0.0);
            Length referanceFeet2 = referanceFeet1;
            //Checking first reference value and second reference values are equal or not. If it returns true test 
            Boolean equals = (referanceFeet1.Equals(referanceFeet2));
            Assert.IsTrue(equals);
        }
        /// <summary>
        /// Test Case 1.4 Given Feet type data same Should Return Equal.
        /// </summary>
        [Test]
        public void GivenFeet1TypeAndFeet2SameType_ShouldReturnEqual()
        {
            //Instance of Feet
            Length feetValue1 = new Length(Length.Unit.FEET, 0.0);
            Length feetValue2 = new Length(Length.Unit.FEET, 0.0);
            Type typeFeet1 = feetValue1.GetType();
            Type typeFeet2 = feetValue2.GetType();
            //Checking first  type and second type values are equal or not. If it returns true test 
            Assert.AreEqual(typeFeet1, typeFeet2);
        }
        /// <summary>
        /// Test Case 1.5 Given 1 Feet And 1 Feet Should Return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenEqual_ShouldReturnEqual()
        {
            //Instance of Feet
            Length feetValue1 = new Length(Length.Unit.FEET, 1.0);
            Length feetValue2 = new Length(Length.Unit.FEET, 1.0);
            //Checking first and second values are equal or not. If it returns true test 
            bool equals = feetValue1.Equals(feetValue2);
            Assert.IsTrue(equals);
        }
        /// <summary>
        /// Test Case 1.6 Given 1 Feet And 10 Feet when check Should Return not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd10Feet_WhenNotEqual_ShouldReturnNotEqual()
        {
            //Instance of Feet
            Length feetValue1 = new Length(Length.Unit.FEET, 1.0);
            Length feetValue2 = new Length(Length.Unit.FEET, 10.0);
            //Checking first and second values are equal or not. If it returns false test Pass
            bool equals = feetValue1.Equals(feetValue2);
            Assert.IsFalse(equals);
        }
        /// <summary>
        /// Test Case 1.7 Given null Inch Should Return false.
        /// </summary>
        [Test]
        public void GivenNullInchValue_ShouldReturnFalse()
        {
            //Instance of Inch
            bool equals = Length.Equals(Length.Unit.INCH, null);
            Assert.IsFalse(equals);
        }
        /// <summary>
        /// Test Case 1.8 Given inch same Reference when check reference Should Return Equal.
        /// </summary>
        [Test]
        public void GivenInchReference_WhenCheckRefenece_ShouldReturnTrue()
        {
            //Instance of Inch
            Length referanceInch1 = new Length(Length.Unit.INCH, 0.0);
            Length referanceInch2 = referanceInch1;
            ////Checking first reference and second reference values are equal or not. If it returns true test 
            Boolean equals = (referanceInch1.Equals(referanceInch2));
            Assert.IsTrue(equals);
        }
        /// <summary>
        /// Test Case 1.9 Given Inch type data same Should Return Equal.
        /// </summary>
        [Test]
        public void GivenInch1TypeAndInch2SameType_ShouldReturnEqual()
        {
            //Instance of Inch
            Length InchValue1 = new Length(Length.Unit.INCH, 0.0);
            Length InchValue2 = new Length(Length.Unit.INCH, 0.0);
            Type typeFeet1 = InchValue1.GetType();
            Type typeFeet2 = InchValue2.GetType();
            //Checking first  type and second type values are equal or not. If it returns true test 
            Assert.AreEqual(typeFeet1, typeFeet2);
        }
        /// <summary>
        /// Test Case 1.10 Given 0 Inch And 0 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given0InchAnd0Inch_WhenEqual_ShouldReturnEqual()
        {
            //Instance of Inch
            Length Inch1 = new Length(Length.Unit.INCH, 0.0);
            Length Inch2 = new Length(Length.Unit.INCH, 0.0);
            //Checking first and second values are equal or not. If it returns true test 
            bool equals = Inch1.Equals(Inch2);
            Assert.IsTrue(equals);
        }
        /// <summary>
        /// Test Case 1.11 Given 1 Inch And 1 Inch when equal Should Return Equal.
        /// </summary>
        [Test]
        public void Given1InchAnd1Inch_WhenEqual_ShouldReturnEqual()
        {
            //Instance of Inch
            Length Inch1 = new Length(Length.Unit.INCH, 1.0);
            Length Inch2 = new Length(Length.Unit.INCH, 1.0);
            //Checking first and second values are equal or not. If it returns true test 
            bool equals = Inch1.Equals(Inch2);
            Assert.IsTrue(equals);
        }
        /// <summary>
        /// Test Case 1.12 Given 1 Feet And 10 Feet when check Should Return not Equal.
        /// </summary>
        [Test]
        public void Given1InchAnd10Inch_WhenNotEqual_ShouldReturnNotEqual()
        {
            //Instance of Inch
            Length InchValue1 = new Length(Length.Unit.INCH, 1.0);
            Length InchValue2 = new Length(Length.Unit.INCH, 10.0);
            //Checking first and second values are equal or not. If it returns false test 
            bool equals = InchValue1.Equals(InchValue2);
            Assert.IsFalse(equals);
        }
        /// <summary>
        /// Test Case 1.13 Given 0 Feet and 0 Inch when check Should Return Equal.
        /// </summary>
        [Test]
        public void Given0FeetAnd0Inch_ShouldReturnEqual()
        {
            //Creating Length Instances For Feet and Inch
            Length feet = new Length(Length.Unit.FEET, 0.0);
            Length inch = new Length(Length.Unit.INCH, 0.0);
            //Asserting Values.
            Assert.AreEqual(feet, inch);
        }
        /// <summary>
        /// Test Case 1.14 Given 1 Feet And 1 Inch Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1InchShouldReturnNotEqual()
        {
            //Creating Length Instances For Feet and Inch
            Length feet = new Length(Length.Unit.FEET, 1.0);
            Length inch = new Length(Length.Unit.INCH, 1.0);
            //Asserting Values.
            Assert.AreNotEqual(feet, inch);
        }
        /// <summary>
        /// Test Case 1.15 Given 1 inch And 1 feet Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1inchAnd1feetShouldReturnNotEqual()
        {
            //Creating Length Instances For Feet and Inch
            Length feet = new Length(Length.Unit.INCH, 1.0);
            Length inch = new Length(Length.Unit.FEET, 1.0);
            //Asserting Values.
            Assert.AreNotEqual(feet, inch);
        }
        /// <summary>
        /// Test Case 1.16 Given 1 feet And 12 inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd12Inch_ShouldReturnEqual()
        {
            //Creating Length Instances For Feet and Inch
            Length feet = new Length(Length.Unit.FEET, 1.0);
            Length inch = new Length(Length.Unit.INCH, 12.0);
            //Asserting Values.
            Assert.AreEqual(feet, inch);
        }
    }
}