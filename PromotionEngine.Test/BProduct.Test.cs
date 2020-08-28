using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Services;

namespace PromotionEngine.Test
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
    }
}
