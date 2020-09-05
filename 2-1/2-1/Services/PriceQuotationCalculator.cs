﻿using _2_1.Models;

namespace _2_1.Services
{
    public class PriceQuotationCalculator : IPriceQuotationCalculator
    {
        public PriceQuotation Calculate(decimal subtotal, decimal discountPercent)
        {
            var discountAmount = subtotal * (discountPercent / 100);
            var total = subtotal - discountAmount;

            return new PriceQuotation()
            {
                Subtotal = subtotal,
                DiscountPercent = discountPercent,
                DiscountAmount = discountAmount,
                Total = total,
            };
        }
    }
}