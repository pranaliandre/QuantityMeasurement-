using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProblem
{
    public class Length
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public Length() { }
        /// <summary>
        /// Enum For Length Unit.
        /// </summary>
        public enum Unit
        {
            FEET,
            INCH,
            CENTIMETER,
        };

        //Variables.
        readonly Unit unit;
        readonly private double value;

        /// <summary>
        /// Parameter Constructor To Set Unit And Value.
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public Length(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// Overriding Equals Function.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Length))
            {
                return false;
            }
            return (this.unit == ((Length)obj).unit) && (this.value == ((Length)obj).value) ||
                   (this.unit.Equals(Unit.FEET) && ((Length)obj).unit.Equals(Unit.INCH) &&
                   this.value == 0 && ((Length)obj).value == 0) ||
                   (this.unit.Equals(Unit.FEET) && ((Length)obj).unit.Equals(Unit.INCH) &&
                   this.value == 1 && ((Length)obj).value == 12) ||
                   (this.unit.Equals(Unit.INCH) && ((Length)obj).unit.Equals(Unit.FEET) &&
                   this.value == 12 && ((Length)obj).value == 1);
        }
        /// <summary>
        /// Method for conversion
        /// </summary>
        /// <param name="conversion"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double CompareLength(string conversion, double value)
        {
            switch (conversion)
            {
                case "FEET_TO_INCH":
                    double feetToInch = value * 12.0;
                    return feetToInch;
                case "INCH_TO_FEET":
                    double inchToFeet = value / 12.0;
                    return inchToFeet;
                case "FEET_TO_YARD":
                    double feetToyard = value / 3.0;
                    return feetToyard;
                case "YARD_TO_FEET":
                    double yardToFeet = value * 3.0;
                    return yardToFeet;
                case "INCH_TO_YARD":
                    double inchToYard = value / 36.0;
                    return inchToYard;
                case "YARD_TO_INCH":
                    double yardToInch = value * 36.0;
                    return yardToInch;
                case "INCH_TO_CENTIMETER":
                    double inchToCentimeter = value * 2.5;
                    return inchToCentimeter;
                case "CENTIMETER_TO_INCH":
                    double centimeterToInch = value / 2.5;
                    return centimeterToInch;
                default:
                    Console.WriteLine("Invalid Conversion");
                    return 0;
            }
        }

        /// <summary>
        /// Method for add two length in inch
        /// </summary>
        /// <param name="unitOne"></param>
        /// <param name="valueOne"></param>
        /// <param name="unitTwo"></param>
        /// <param name="valueTwo"></param>
        /// <returns></returns>
        public double AddTwoLenghtsInInch(Unit unitOne, double valueOne, Unit unitTwo, double valueTwo)
        {
            double firstValueInInch = valueOne;
            double secondValueInInch = valueTwo;
            //
            if (unitOne == Unit.INCH && unitTwo == Unit.INCH)
                return firstValueInInch + secondValueInInch;
            if (unitOne == Unit.FEET)
            {
                firstValueInInch = CompareLength("FEET_TO_INCH", valueOne);
            }
            else if (unitOne == Unit.CENTIMETER)
            {
                firstValueInInch = CompareLength("CENTIMETER_TO_INCH", valueOne);
            }
            if (unitTwo == Unit.FEET)
            {
                secondValueInInch = CompareLength("FEET_TO_INCH", valueTwo);
            }
            else if (unitTwo == Unit.CENTIMETER)
            {
                secondValueInInch = CompareLength("CENTIMETER_TO_INCH", valueTwo);
            }
            return firstValueInInch + secondValueInInch;
        }
        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
