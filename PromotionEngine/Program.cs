using PromotionEngine.Interfaces;
using PromotionEngine.Models;
using PromotionEngine.Services;
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
            // Unit Price for SKU IDs
            // A-50, B-30, C-20, D-15, E-100

            decimal finalPrice = 0M;

            // Please run test cases of Program.Test.cs for below all scenarios 
            // Sceanario A => 1 A, 1 B, 1 C
            // Sceanario B => 5 A, 5 B, 1 C
            // Sceanario C => 3 A, 5 B, (1 C, 1 D)

            // Here, Execution of Sceanario B => 5 A, 5 B, 1 C 
            // Data Preparation
            AProduct aProduct = new AProduct
            {
                ProductsCount = 5
            };

            BProduct bProduct = new BProduct
            {
                ProductsCount = 5
            };

            CProduct cProduct = new CProduct
            {
                ProductsCount = 1
            };

            IEnumerable<IPromotion> orders = new List<IPromotion> { aProduct, bProduct, cProduct };  
            finalPrice = GetFinalPrice(orders); // 370
            Console.WriteLine($"Final Price - {finalPrice}");
            Console.Read();
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
