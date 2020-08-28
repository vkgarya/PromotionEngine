using PromotionEngine.Interfaces;
using PromotionEngine.Models;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Services
{
    /// <summary>
    /// CDProduct
    ///  Rule - Active Promotions: C & D for 30
    /// </summary>
    public class CDProduct : IPromotion
    {
        public List<Product> Products { get; set; }
        public decimal GetPrice() => Products.Select(p => p.ProductCount).Sum() % 2 == 0 ? (Products.Select(p => p.ProductCount).Sum() / 2) * 30  // if Count(C) = Count(D)
                                                                : Products.Where(p => p.ProductName == "C").FirstOrDefault().ProductCount > Products.Where(p => p.ProductName == "D").FirstOrDefault().ProductCount ?
                                                                        (Products.Select(p => p.ProductCount).Sum() / 2) * 30 + 20 // if Count(C) > Count(D)
                                                                        : (Products.Select(p => p.ProductCount).Sum() / 2) * 30 + 15;
    }
}
