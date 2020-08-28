using PromotionEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static decimal GetFinalPrice(IEnumerable<IPromotion> orders)
        {
            decimal finalPrice = 0M;
            foreach (var order in orders)
            {
                finalPrice += order.GetPrice();
            }

            return finalPrice;
        }
    }
}
