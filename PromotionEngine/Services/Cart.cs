using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PromotionEngine.Services.Models;

namespace PromotionEngine.Services
{
    class Cart
    {
        public List<CartItem> Items { get; private set; }

        public static readonly Cart _Cart;
        static Cart()
        {
           _Cart = new Cart();
        }

        public void AddItem(int productId)
        {
            // Create a new item to add to the cart
            CartItem newItem = new CartItem(productId);

            // If this item already exists in our list of items, increase the quantity
            // Otherwise, add the new item to the list
            if (Items.Contains(newItem))
            {
                foreach (CartItem item in Items)
                {
                    if (item.Equals(newItem))
                    {
                        item.Quantity++;
                        return;
                    }
                }
            }
            else
            {
                newItem.Quantity = 1;
                Items.Add(newItem);
            }
        }
    }
}
