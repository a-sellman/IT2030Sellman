using _2_2.Models;

namespace _2_2.Services
{
    public class TipCalculator : ITipCalculator
    {
        public TipCalculation Calculate(decimal costOfMeal)
        {
            return new TipCalculation()
            {
                CostOfMeal = costOfMeal,
                Tip15Percent = costOfMeal * 0.15m,
                Tip20Percent = costOfMeal * 0.20m,
                Tip25Percent = costOfMeal * 0.25m,
            };
        }
    }
}