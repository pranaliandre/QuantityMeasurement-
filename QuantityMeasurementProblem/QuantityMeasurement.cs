using System;
namespace QuantityMeasurementProblem
{
    public class QuantityMeasurement
    {
        /// <summary>
        /// Variable
        /// </summary>
        public double value;
        /// <summary>
        /// Method for getting inch
        /// </summary>
        /// <param name=value"></param>
        /// <returns></returns>
        public double GetInch(double value)
        {
            return value*12;
        }
        /// <summary>
        /// Method for getting feet
        /// </summary>
        /// <param name=value"></param>
        /// <returns></returns>
        public double GetFeet(double value)
        {
            return value * 12;
        }
        /// <summary>
        /// Override Equals Method.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //null check
            if (obj == null)
            {
                return false;
            }
            //Reference check
            if (obj == this)
            {
                return true;
            }
            //Equality check
            return (this.value == ((QuantityMeasurement)obj).value);
        }
        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    
    static void Main(string[] args)
        {
            Console.WriteLine("!!!Welcome to Quantity Measurement");
        }
    }
}
