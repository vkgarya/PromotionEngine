using PromotionEngine.Interfaces;

namespace PromotionEngine.Services
{
    /// <summary>
    /// EProduct
    /// Rule - Active Promotions: 30% off on E
    /// </summary>
    public class EProduct : IPromotion
    {
        public int ProductsCount { get; set; }
        public decimal GetPrice() => ProductsCount * 100 * (100 - 30) / 100;
    }
}
