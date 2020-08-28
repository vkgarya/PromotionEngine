using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Services;

namespace PromotionEngine.Test.Services
{
    [TestClass]
    public class CProductTest
    {
        [TestMethod]
        public void GetPrice_ProductCount_3_Success()
        {
            CProduct cProduct = new CProduct
            {
                ProductsCount = 3
            };

            decimal finalPrice = cProduct.GetPrice();
            Assert.AreEqual(60, finalPrice);
        }


        [TestMethod]
        public void GetPrice_ProductCount_3_Failure()
        {
            CProduct cProduct = new CProduct
            {
                ProductsCount = 3
            };

            decimal finalPrice = cProduct.GetPrice();
            Assert.AreNotEqual(10, finalPrice);
        }
    }
}
