using PromotionEngine.Interfaces;

namespace PromotionEngine.Services
{
    /// <summary>
    /// DProduct
    /// </summary>
    public class DProduct : IPromotion
    {
        public int ProductsCount { get; set; }
        public decimal GetPrice() => 15 * ProductsCount;
    }
}
