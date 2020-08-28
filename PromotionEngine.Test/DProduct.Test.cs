using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Services;

namespace PromotionEngine.Test
{
    [TestClass]
    public class DProductTest
    {
        [TestMethod]
        public void GetPrice_ProductCount_3_Success()
        {
            DProduct dProduct = new DProduct
            {
                ProductsCount = 3
            };

            decimal finalPrice = dProduct.GetPrice();
            Assert.AreEqual(45, finalPrice);
        }
    }
}
