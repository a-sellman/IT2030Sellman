using _2_2.Models;

namespace _2_2.Services
{
    public interface ITipCalculator
    {
        TipCalculation Calculate(decimal costOfMeal);
    }
}