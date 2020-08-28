using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Interfaces;
using PromotionEngine.Models;
using PromotionEngine.Services;
using System.Collections.Generic;

namespace PromotionEngine.Test
{
    [TestClass]
    public class ProgramTest
    {
        /// <summary>
        /// Sceanario A => 1 A, 1 B, 1 C
        /// </summary>
        [TestMethod]
        public void GetFinalPrice_ProductA_Count_1_ProductB_Count_1_ProductC_Count_1_Success()
        {
            AProduct aProduct = new AProduct
            {
                ProductsCount = 1
            };

            BProduct bProduct = new BProduct
            {
                ProductsCount = 1
            };
            CProduct cProduct = new CProduct
            {
                ProductsCount = 1
            };

            IEnumerable<IPromotion> orders = new List<IPromotion> { aProduct, bProduct, cProduct };
            decimal finalPrice = Program.GetFinalPrice(orders);
            Assert.AreEqual(100, finalPrice);
        }

        /// <summary>
        /// Sceanario A => 1 A, 1 B, 1 C
        /// </summary>
        [TestMethod]
        public void GetFinalPrice_ProductA_Count_1_ProductB_Count_1_ProductC_Count_1_Failure()
        {
            AProduct aProduct = new AProduct
            {
                ProductsCount = 1
            };

            BProduct bProduct = new BProduct
            {
                ProductsCount = 1
            };
            CProduct cProduct = new CProduct
            {
                ProductsCount = 1
            };

            IEnumerable<IPromotion> orders = new List<IPromotion> { aProduct, bProduct, cProduct };
            decimal finalPrice = Program.GetFinalPrice(orders);
            Assert.AreNotEqual(0, finalPrice);
        }

        /// <summary>
        ///Sceanario B => 5 A, 5 B, 1 C
        /// </summary>
        [TestMethod]
        public void GetFinalPrice_ProductA_Count_5_ProductB_Count_5_ProductC_Count_1_Success()
        {
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
            decimal finalPrice = Program.GetFinalPrice(orders);
            Assert.AreEqual(370, finalPrice);
        }

        /// <summary>
        ///Sceanario B => 5 A, 5 B, 1 C
        /// </summary>
        [TestMethod]
        public void GetFinalPrice_ProductA_Count_5_ProductB_Count_5_ProductC_Count_1_Failure()
        {
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
            decimal finalPrice = Program.GetFinalPrice(orders);
            Assert.AreNotEqual(420, finalPrice);
        }

        /// <summary>
        ///Sceanario C => 3 A, 5 B, 1 C, 1 D
        /// </summary>
        [TestMethod]
        public void GetFinalPrice_ProductA_Count_3_ProductB_Count_5_ProductC_Count_1_ProductD_Count_1_Success()
        {
            AProduct aProduct = new AProduct
            {
                ProductsCount = 3
            };

            BProduct bProduct = new BProduct
            {
                ProductsCount = 5
            };
            CDProduct cdProduct = new CDProduct
            {
                Products = new List<Product>
                {
                    new Product{ ProductName = "C", ProductCount = 1},
                    new Product{ ProductName = "D", ProductCount = 1}
                }
            };

            IEnumerable<IPromotion> orders = new List<IPromotion> { aProduct, bProduct, cdProduct };
            decimal finalPrice = Program.GetFinalPrice(orders);
            Assert.AreEqual(280, finalPrice);
        }

        /// <summary>
        ///Sceanario C => 3 A, 5 B, 1 C, 1 D
        /// </summary>
        [TestMethod]
        public void GetFinalPrice_ProductA_Count_3_ProductB_Count_5_ProductC_Count_1_ProductD_Count_1_Failure()
        {
            AProduct aProduct = new AProduct
            {
                ProductsCount = 3
            };

            BProduct bProduct = new BProduct
            {
                ProductsCount = 5
            };
            CDProduct cdProduct = new CDProduct
            {
                Products = new List<Product>
                {
                    new Product{ ProductName = "C", ProductCount = 1},
                    new Product{ ProductName = "D", ProductCount = 1}
                }
            };

            IEnumerable<IPromotion> orders = new List<IPromotion> { aProduct, bProduct, cdProduct };
            decimal finalPrice = Program.GetFinalPrice(orders);
            Assert.AreNotEqual(335, finalPrice);
        }
    }
}
