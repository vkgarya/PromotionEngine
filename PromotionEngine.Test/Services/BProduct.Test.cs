using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Services;

namespace PromotionEngine.Test.Services
{
    [TestClass]
    public class BProductTest
    {
        [TestMethod]
        public void GetPrice_ProductCount_2_Success()
        {
            BProduct bProduct = new BProduct
            {
                ProductsCount = 2
            };

            decimal finalPrice = bProduct.GetPrice();
            Assert.AreEqual(45, finalPrice);
        }

        [TestMethod]
        public void GetPrice_ProductCount_2_Failure()
        {
            BProduct bProduct = new BProduct
            {
                ProductsCount = 2
            };

            decimal finalPrice = bProduct.GetPrice();
            Assert.AreNotEqual(60, finalPrice);
        }

        [TestMethod]
        public void GetPrice_ProductCount_3_Success()
        {
            BProduct bProduct = new BProduct
            {
                ProductsCount = 3
            };

            decimal finalPrice = bProduct.GetPrice();
            Assert.AreEqual(75, finalPrice);
        }

        [TestMethod]
        public void GetPrice_ProductCount_3_Failure()
        {
            BProduct bProduct = new BProduct
            {
                ProductsCount = 3
            };

            decimal finalPrice = bProduct.GetPrice();
            Assert.AreNotEqual(90, finalPrice);
        }
    }
}
