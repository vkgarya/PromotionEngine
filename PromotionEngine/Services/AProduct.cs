using PromotionEngine.Interfaces;

namespace PromotionEngine.Services
{
    /// <summary>
    /// AProduct
    /// Rule - Active Promotions: 3 of A's for 130
    /// </summary>
    public class AProduct : IPromotion
    {
        public int ProductsCount { get; set; }
        public decimal GetPrice() => 130 * (ProductsCount / 3) + 50 * (ProductsCount % 3);
    }
}
