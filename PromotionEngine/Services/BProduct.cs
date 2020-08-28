using PromotionEngine.Interfaces;

namespace PromotionEngine.Services
{
    //// <summary>
    /// BProduct
    /// Rule - Active Promotions: 2 of B's for 45
    /// </summary>
    public class BProduct : IPromotion
    {
        public int ProductsCount { get; set; }
        public decimal GetPrice() => 45 * (ProductsCount / 2) + 30 * (ProductsCount % 2);
    }
}
