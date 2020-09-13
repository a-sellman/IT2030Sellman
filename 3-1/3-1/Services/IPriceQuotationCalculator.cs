using _3_1.Models;

namespace _3_1.Services
{
    public interface IPriceQuotationCalculator
    {
        PriceQuotation Calculate(decimal subtotal, int discountPercent);
    }
}