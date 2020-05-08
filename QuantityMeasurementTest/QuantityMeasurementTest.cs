using NUnit.Framework;
using QuantityMeasurementProblem;
using System;

namespace QuantityMeasurementTest
{
    public class Tests
    {
        readonly Length compareLength = new Length();
        readonly Volume compareVolume = new Volume();
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
        /// <summary>
        /// Test Case 1.17 Given 12 inch And 1 feet Should Return Equal.
        /// </summary>
        [Test]
        public void Given12InchAnd1Feet_ShouldReturnEqual()
        {
            //Creating Length Instances For Feet and Inch
            Length feet = new Length(Length.Unit.INCH, 12.0);
            Length inch = new Length(Length.Unit.FEET, 1.0);
            //Asserting Values.
            Assert.AreEqual(feet, inch);
        }
        /// <summary>
        /// Test Case 1.18 Given 3 Feet And 1 Yard Should Return Equal.
        /// </summary>
        [Test]
        public void Given3FeetAnd1Yard_ShouldReturnEqual()
        {
            double threeFeet = compareLength.CompareLength("FEET_TO_YARD", 3.0);
            double oneYard = 1.0;
            Assert.AreEqual(oneYard, threeFeet);
        }
        /// <summary>
        /// Test Case 1.19 Given 1 Feet And 1 Yard Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1FeetAnd1Yard_ShouldReturnEqual()
        {
            double oneFeet = compareLength.CompareLength("FEET_TO_YARD", 1.0);
            double oneYard = 1.0;
            Assert.AreNotEqual(oneYard, oneFeet);
        }
        /// <summary>
        /// Test Case 1.20 Given 1 inch And 1 Yard Should Return Not Equal.
        /// </summary>
        [Test]
        public void Given1InchAnd1Yard_ShouldReturnNotEqual()
        {
            double oneFeet = compareLength.CompareLength("INCH_TO_YARD", 1.0);
            double oneYard = 1.0;
            Assert.AreNotEqual(oneYard, oneFeet);
        }
        /// <summary>
        /// Test Case 1.21 Given 1 yard And 36 inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given1YardAnd36Inch_ShouldReturnEqual()
        {
            double oneYard = compareLength.CompareLength("YARD_TO_INCH", 1.0);
            double thirtySixInch = 36.0;
            Assert.AreEqual(oneYard, thirtySixInch);
        }
        /// <summary>
        /// Test Case 1.22 Given 36 inch and 1 Yard Should Return Equal.
        /// </summary>
        [Test]
        public void Given36InchAnd1Yard_ShouldReturnEqual()
        {
            double thirtySixInch = compareLength.CompareLength("INCH_TO_YARD", 36.0);
            double oneYard = 1.0;
            Assert.AreEqual(thirtySixInch, oneYard);
        }
        /// <summary>
        /// Test Case 1.23 Given 1 yard and 3 ft Should Return Equal.
        /// </summary>
        [Test]
        public void Given1InchAnd3Feet_ShouldReturnEqual()
        {
            double oneYard = compareLength.CompareLength("YARD_TO_FEET", 1.0);
            double threeFeet = 3.0;
            Assert.AreEqual(oneYard, threeFeet);
        }
        /// <summary>
        /// Test Case 1.24 Given 2 inch and 5 cm Should Return Equal.
        /// </summary>
        [Test]
        public void Given2InchAnd5Centimeter_ShouldReturnEqual()
        {
            double twoInch = compareLength.CompareLength("INCH_TO_CENTIMETER", 2.0);
            double fiveCentimeter = 5.0;
            Assert.AreEqual(twoInch, fiveCentimeter);
        }
        /// <summary>
        /// Test case 1.25 Given 2 Inch addition to 2 Inch Equal to 4 inch
        /// </summary>
        [Test]
        public void GivenTwoLengthsInInch_ForAddition_ReturnInInch()
        {
            double twoInch = compareLength.AddTwoLenghtsInInch(Length.Unit.INCH, 2, Length.Unit.INCH, 2);
            double addTwoInch = 4.0;
            Assert.AreEqual(twoInch, addTwoInch);
        }
        /// <summary>
        /// Test case 1.26 Given 1 Feet addition to 2 Inch Equal to 14 inch
        /// </summary>
        public void GivenTwoLengthsOneInFeetAndSecondInInch_ShouldReturnAdditionInInch()
        {
            double oneFeetOneInch = compareLength.AddTwoLenghtsInInch(Length.Unit.FEET, 1, Length.Unit.INCH, 2);
            double addTwoInch = 14.0;
            Assert.AreEqual(addTwoInch, oneFeetOneInch);
        }
        /// <summary>
        /// Test case 1.27 Given 1 Feet addition to 1 Feet Equal to 24 inch
        /// </summary>
        [Test]
        public void GivenTwoLengthsInFeet_ReturnAdditionInInch()
        {
            double addTwoFeet = compareLength.AddTwoLenghtsInInch(Length.Unit.FEET, 1, Length.Unit.FEET, 1);
            double addTwoInch = 24.0;
            Assert.AreEqual(addTwoInch, addTwoFeet);
        }
        /// <summary>
        /// Test case 1.28 Given 1 inch addition to 1 Feet Equal to 24 inch
        /// </summary>
        [Test]
        public void GivenTwoLengthsOneInInchAndOneInCentimeter_ReturnAdditionInInch()
        {
            double oneInchOneCentimeter = compareLength.AddTwoLenghtsInInch(Length.Unit.INCH, 2, Length.Unit.CENTIMETER, 2.5);
            double addTwoInch = 3.0;
            Assert.AreEqual(addTwoInch, oneInchOneCentimeter);
        }
        /// <summary>
        /// Test Case 1.29 Given 1 gallon And 3.78 milliliters Should Return Equal.
        /// </summary>
        [Test]
        public void Given1GallonToLiters_ShouldReturnEqual()
        {
            double oneGallon = compareVolume.CompareVolume("GALLON_TO_LITRE", 1.0);
            double oneLiters = 3.78;
            Assert.AreEqual(oneLiters, oneGallon);
        }
        /// <summary>
        /// Test Case 1.30 Given 1 liter And 100 millitre Should Return Equal.
        /// </summary>
        [Test]
        public void Given1LitersAndOneThousandMiliLitre_ShouldReturnEqual()
        {
            double oneLiter = compareVolume.CompareVolume("LITRE_TO_MILLILITER", 1.0);
            double oneThousandMiliLitre = 1000;
            Assert.AreEqual(oneThousandMiliLitre, oneLiter);
        }
        /// <summary>
        /// Test Case 1.31 Given 1 gallon And 3.78 litre Should Return Equal.
        /// </summary>
        [Test]
        public void GivenGallonAndLiters_ReturnAdditionInLiters()
        {
            double addTwo = compareVolume.AddTwoVolumesInLitres(Volume.Unit.GALLON, 1, Volume.Unit.LITRE, 3.78);
            double addTwoInch = 7.56;
            Assert.AreEqual(addTwoInch, addTwo,0.0);
        }
        /// <summary>
        /// Test Case 1.32 Given 1 liter And 1000 millitre Should Return Equal.
        /// </summary>
        [Test]
        public void GivenOneLitreAndOneThousandMiliLitre_ReturnAddInLitre()
        {
            double oneLitreOneThousandMiliLitre = compareVolume.AddTwoVolumesInLitres(Volume.Unit.LITRE, 1.0, Volume.Unit.MILLILITER, 1000);
            double addInLitre = 2;
            Assert.AreEqual(addInLitre, oneLitreOneThousandMiliLitre);
        }
    }
}