﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProblem
{
    public class Volume
    {
        Unit unit;
        readonly private double value;
        /// <summary>
        /// 
        /// </summary>
        public enum Unit
        {
            GALLON,
            LITRE
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
                default:
                    Console.WriteLine("Invalid Conversion");
                    return 0;
            }
        }
    }
}
