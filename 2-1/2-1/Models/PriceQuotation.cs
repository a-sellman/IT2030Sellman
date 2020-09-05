namespace _2_1.Models
{
    public class PriceQuotation
    {
        public decimal DiscountAmount { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }

        public void Reset()
        {
            DiscountAmount = 0;
            DiscountPercent = 0;
            Subtotal = 0;
            Total = 0;
        }
    }
}