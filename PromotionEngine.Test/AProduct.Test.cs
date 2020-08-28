using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Services;

namespace PromotionEngine.Test
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
    }
}
