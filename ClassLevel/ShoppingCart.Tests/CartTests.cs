using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
        private static CartItem _cartItem;
        private static CartManager _cartManager;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500
                },
                Quantity = 1
            };
            _cartManager.Add(_cartItem);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _cartManager.Clear();
        }

        [TestMethod]
        public void AddToCartAndIncrementCount()
        {
            //Arrange
            int totalCount = _cartManager.TotalQuantity;
            int totalNumberOfElements = _cartManager.TotalItems;

            //Act
            _cartManager.Add(new CartItem
            {
                Product = new Product
                {
                    ProductId = 2,
                    ProductName = "Mouse",
                    UnitPrice = 10
                },
                Quantity = 1
            });

            //Assert
            Assert.AreEqual(totalCount + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(totalNumberOfElements + 1, _cartManager.TotalItems);
        }

        [TestMethod]
        public void AddToCartAndRemainingCount()
        {
            //Arrange
            int totalCount = _cartManager.TotalQuantity;
            int totalNumberOfElements = _cartManager.TotalItems;

            //Act
            _cartManager.Add(_cartItem);

            //Assert
            Assert.AreEqual(totalCount + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(totalNumberOfElements, _cartManager.TotalItems);
        }
    }
}