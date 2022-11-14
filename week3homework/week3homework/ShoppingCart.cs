using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3homework
{
    public class ShoppingCart
    {
        private List<CartItem> cartList;

        public ShoppingCart()
        {
            cartList = new List<CartItem>();
        }


        // POST Create
        public void Add(CartItem item)
        {
            cartList.Add(item);
            Console.WriteLine($"Item added! {item.Product.ProductName}");
        }

        // GET/id GetBalance
        public decimal GetBalance(int id)
        {
            return (decimal)(cartList[id].Quantity * cartList[id].Product.Price);
        }

        // GET
        public List<CartItem> GetList()
        {
            return cartList;
        }

        // DELETE
        public CartItem Remove(int id)
        {
            var cartItem = cartList.Where(cart => cart.CartId == id).First();
            if (cartItem == null)
                throw new Exception("Item not found!");
            cartList.Remove(cartItem);
            return cartItem;
        }
    }
}
