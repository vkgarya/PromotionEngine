using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Services;

namespace PromotionEngine.Test.Services
{
    [TestClass]
    public class AProductTest
    {
        [TestMethod]
        public void GetPrice_ProductCount_3_Success()
        {
            AProduct aProduct = new AProduct
            {
                ProductsCount = 3
            };

            decimal finalPrice = aProduct.GetPrice();
            Assert.AreEqual(130, finalPrice);
        }

        [TestMethod]
        public void GetPrice_ProductCount_3_Failure()
        {
            AProduct aProduct = new AProduct
            {
                ProductsCount = 3
            };

            decimal finalPrice = aProduct.GetPrice();
            Assert.AreNotEqual(150, finalPrice);
        }

        [TestMethod]
        public void GetPrice_ProductCount_4_Success()
        {
            AProduct aProduct = new AProduct
            {
                ProductsCount = 4
            };

            decimal finalPrice = aProduct.GetPrice();
            Assert.AreEqual(180, finalPrice);
        }

        [TestMethod]
        public void GetPrice_ProductCount_4_Failure()
        {
            AProduct aProduct = new AProduct
            {
                ProductsCount = 4
            };

            decimal finalPrice = aProduct.GetPrice();
            Assert.AreNotEqual(200, finalPrice);
        }
    }
}
