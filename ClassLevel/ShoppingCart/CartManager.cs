using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    //Requirements
    //1. Ability to add items to the cart.
    //2. Ability to remove items from the cart.
    //3. Ability to clear the cart.

    //4. When adding 1 unit of a product already in the cart, the total quantity of products in the cart should increase by one while the number of distinct items remains the same.
    //5. When adding 1 unit of a different product to the cart, both the total quantity of products and the number of distinct items in the cart should increase by one.
    public class CartManager
    {
        private readonly List<CartItem> _cartItems;
        public CartManager()
        {
            _cartItems = new List<CartItem>();
        }

        public void Add(CartItem item)
        {
            var cartItem = _cartItems.SingleOrDefault(x => x.Product.ProductId == item.Product.ProductId);

            if (cartItem == null)
            {
                _cartItems.Add(item);
            }
            else
            {
                cartItem.Quantity += item.Quantity;
            }
        }
        public void Remove(int productId)
        {
            var product = _cartItems.FirstOrDefault(x => x.Product.ProductId == productId);
            _cartItems.Remove(product);
        }

        public List<CartItem> CartItems
        {
            get { return _cartItems; }
        }
        public void Clear()
        {
            _cartItems.Clear();
        }

        public decimal TotalPrice
        {
            get
            {
                return _cartItems.Sum(x => x.Quantity * x.Product.UnitPrice);
            }
        }
        public int TotalQuantity
        {
            get
            {
                return _cartItems.Sum(x => x.Quantity);
            }
        }
        public int TotalItems
        {
            get { return _cartItems.Count; }
        }
    }
}