using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProblem
{
    public class Temperature
    {
        /// <summary>
        /// variable
        /// </summary>
        Unit unit;
        readonly private double value;
        /// <summary>
        /// enum variable
        /// </summary>
        public enum Unit
        {
            GALLON,
            LITRE,
            MILLILITER,
        };
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Temperature() { }
        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public Temperature(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }
        /// <summary>
        /// Method for compare Temperature
        /// </summary>
        /// <param name="conversion"></param>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        public double CompareTemperature(string conversion, double fahrenheit)
        {
            switch (conversion)
            {
                case "FAHRENHEIT_TO_CELCIUS":
                    double Celcius = (fahrenheit - 32) * 5 / 9;
                    return Celcius;
               
                default:
                    Console.WriteLine("Invalid Conversion");
                    return 0;
            }
        }
    }
}
