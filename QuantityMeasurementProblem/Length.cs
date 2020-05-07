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
        public enum Unit { FEET, INCH, }

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
                default:
                    Console.WriteLine("Invalid Conversion");
                    return 0;
            }
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
