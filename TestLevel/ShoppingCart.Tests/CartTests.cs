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
        private CartItem _cartItem;
        private CartManager _cartManager;


        [TestInitialize]
        public void TestInitialize()
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

        [TestCleanup]
        public void TestCleanup()
        {
            _cartManager.Clear();    
        }


        [TestMethod]
        public void AddItemToCart()
        {
            //Arrange 
            const int expected = 1;

            //Act
            var totalNumberOfElements = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(expected, totalNumberOfElements);
        }
        [TestMethod]
        public void RemoveItemFromCart()
        {
            //Arrange
            var numberOfElementsInTheCart = _cartManager.TotalItems;

            //Act
            _cartManager.Remove(1);
            var numberOfRemainingElementsInTheCart = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(numberOfElementsInTheCart - 1, numberOfRemainingElementsInTheCart);
        }

        [TestMethod]
        public void ClearCart()
        {
            //Arrange

            //Act
            _cartManager.Clear();

            //Assert
            Assert.AreEqual(0, _cartManager.TotalQuantity);
            Assert.AreEqual(0, _cartManager.TotalItems);
        }

    }
}