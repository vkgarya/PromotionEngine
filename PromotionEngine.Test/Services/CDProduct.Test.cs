﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Models;
using PromotionEngine.Services;
using System.Collections.Generic;

namespace PromotionEngine.Test.Services
{
    [TestClass]
    public class CDProductTest
    {
        [TestMethod]
        public void GetPrice_CProductCount_1_DProductCount_1_Success()
        {
            CDProduct cdProduct = new CDProduct
            {
                Products = new List<Product>
                {
                    new Product{ProductCount = 1, ProductName = "C" },
                    new Product{ProductCount = 1, ProductName = "D" }
                }
            };

            decimal finalPrice = cdProduct.GetPrice();
            Assert.AreEqual(30, finalPrice);
        }

        [TestMethod]
        public void GetPrice_CProductCount_1_DProductCount_1_Failure()
        {
            CDProduct cdProduct = new CDProduct
            {
                Products = new List<Product>
                {
                    new Product{ProductCount = 1, ProductName = "C" },
                    new Product{ProductCount = 1, ProductName = "D" }
                }
            };

            decimal finalPrice = cdProduct.GetPrice();
            Assert.AreNotEqual(35, finalPrice);
        }

        [TestMethod]
        public void GetPrice_CProductCount_2_DProductCount_1_Success()
        {
            CDProduct cdProduct = new CDProduct
            {
                Products = new List<Product>
                {
                    new Product{ProductCount = 2, ProductName = "C" },
                    new Product{ProductCount = 1, ProductName = "D" }
                }
            };

            decimal finalPrice = cdProduct.GetPrice();
            Assert.AreEqual(50, finalPrice);
        }

        [TestMethod]
        public void GetPrice_CProductCount_2_DProductCount_1_Failure()
        {
            CDProduct cdProduct = new CDProduct
            {
                Products = new List<Product>
                {
                    new Product{ProductCount = 2, ProductName = "C" },
                    new Product{ProductCount = 1, ProductName = "D" }
                }
            };

            decimal finalPrice = cdProduct.GetPrice();
            Assert.AreNotEqual(55, finalPrice);
        }

        [TestMethod]
        public void GetPrice_CProductCount_1_DProductCount_2_Success()
        {
            CDProduct cdProduct = new CDProduct
            {
                Products = new List<Product>
                {
                    new Product{ProductCount = 1, ProductName = "C" },
                    new Product{ProductCount = 2, ProductName = "D" }
                }
            };

            decimal finalPrice = cdProduct.GetPrice();
            Assert.AreEqual(45, finalPrice);
        }

        [TestMethod]
        public void GetPrice_CProductCount_1_DProductCount_2_Failure()
        {
            CDProduct cdProduct = new CDProduct
            {
                Products = new List<Product>
                {
                    new Product{ProductCount = 1, ProductName = "C" },
                    new Product{ProductCount = 2, ProductName = "D" }
                }
            };

            decimal finalPrice = cdProduct.GetPrice();
            Assert.AreNotEqual(50, finalPrice);
        }
    }
}
