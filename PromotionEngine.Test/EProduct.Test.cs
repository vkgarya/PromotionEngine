using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Services;

namespace PromotionEngine.Test
{
    [TestClass]
    public class EProductTest
    {
        [TestMethod]
        public void GetPrice_Success()
        {
            EProduct eProduct = new EProduct
            {
                ProductsCount = 1
            };

            decimal finalPrice = eProduct.GetPrice();
            Assert.AreEqual(70, finalPrice);
        }
    }
}
