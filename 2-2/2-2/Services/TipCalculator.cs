using _2_2.Models;
using System;

namespace _2_2.Services
{
    public class TipCalculator : ITipCalculator
    {
        public TipCalculation Calculate(decimal costOfMeal)
        {
            return new TipCalculation()
            {
                CostOfMeal = costOfMeal,
                Tip15Percent = Math.Max(costOfMeal * 0.15m, 0.0m),
                Tip20Percent = Math.Max(costOfMeal * 0.20m, 0.0m),
                Tip25Percent = Math.Max(costOfMeal * 0.25m, 0.0m),
            };
        }
    }
}