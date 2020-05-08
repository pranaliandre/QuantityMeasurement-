using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProblem
{
    public class Volume
    {
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
        public Volume(){ }
        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public Volume(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }
        /// <summary>
        /// Method for compare Volume
        /// </summary>
        /// <param name="conversion"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double CompareVolume(string conversion, double value)
        {
            switch (conversion)
            {
                case "GALLON_TO_LITRE":
                    double gallonToLitre = value * 3.78;
                    return gallonToLitre;
                case "LITRE_TO_MILLILITER":
                    double litreToMililitre = value * 1000;
                    return litreToMililitre;
                case "MILILITRE_TO_LITER":
                    double mililitreToLitre = value / 1000;
                    return mililitreToLitre;
                default:
                    Console.WriteLine("Invalid Conversion");
                    return 0;
            }
        }
        /// <summary>
        /// Method to add volume in litres
        /// </summary>
        /// <param name="unitOne"></param>
        /// <param name="valueOne"></param>
        /// <param name="unitTwo"></param>
        /// <param name="valueTwo"></param>
        /// <returns></returns>
        public double AddTwoVolumesInLitres(Unit unitOne, double valueOne, Unit unitTwo, double valueTwo)
        {
            double firstValueInLitre = valueOne;
            double secondValueInLitre = valueTwo;

            if (unitOne == Unit.GALLON)
            {
                firstValueInLitre = CompareVolume("GALLON_TO_LITRE", valueOne);
            }
            else if (unitTwo == Unit.MILLILITER)
            {
                secondValueInLitre = CompareVolume("MILILITRE_TO_LITER", valueTwo);
            }
            return firstValueInLitre + secondValueInLitre;
        }
    }
}
