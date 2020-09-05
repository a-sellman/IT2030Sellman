using _2_1.Models;

namespace _2_1.Services
{
    public interface IPriceQuotationCalculator
    {
        PriceQuotation Calculate(decimal subtotal, decimal discountPercent);
    }
}