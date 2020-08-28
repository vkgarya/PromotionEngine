using PromotionEngine.Interfaces;

namespace PromotionEngine.Services
{
    /// <summary>
    /// CProduct
    /// </summary>
    public class CProduct : IPromotion
    {
        public int ProductsCount { get; set; }
        public decimal GetPrice() => 20 * ProductsCount;
    }
}
