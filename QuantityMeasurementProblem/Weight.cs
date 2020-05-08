using System;
namespace QuantityMeasurementProblem
{
    public class Weight
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
            KILOGRAM,
            GRAM,
            TONNE,
            KILOGRAM_TO_GRAM,
            TONNE_TO_KILOGRAM,
            GRAM_TO_KILOGRAM
        };
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Weight() { }
        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public Weight(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }
        /// <summary>
        /// Method for compare Weight
        /// </summary>
        /// <param name="conversion"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double CompareWeight(Unit unit, double value)
        {
            switch (unit)
            {
                case Unit.KILOGRAM_TO_GRAM:
                    double kilogramToGram = value * 1000;
                    return kilogramToGram;
                case Unit.TONNE_TO_KILOGRAM:
                    double tonneToKilogram = value * 1000;
                    return tonneToKilogram;
                case Unit.GRAM_TO_KILOGRAM:
                    double gramToKilogram = value / 1000;
                    return gramToKilogram;
                default:
                    Console.WriteLine("Invalid Conversion");
                    return 0;
            }
        }
        /// <summary>
        /// Method to two volume add in weights
        /// </summary>
        /// <param name="unitOne"></param>
        /// <param name="valueOne"></param>
        /// <param name="unitTwo"></param>
        /// <param name="valueTwo"></param>
        /// <returns></returns>
        public double AddTwoWeightInWeights(Unit unitOne, double valueOne, Unit unitTwo, double valueTwo)
        {
            double firstValueInGrams = valueOne;
            double secondValueInGrams = valueTwo;
            if (unitOne == Unit.TONNE)
            {
                firstValueInGrams = CompareWeight(Unit.TONNE_TO_KILOGRAM, valueOne);
            }
            if (unitTwo == Unit.GRAM)
            {
                secondValueInGrams = CompareWeight(Unit.GRAM_TO_KILOGRAM, valueTwo);
            }
            return firstValueInGrams + secondValueInGrams;
        }
    }
}
