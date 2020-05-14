using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PromotionEngine.Services.Models;

namespace PromotionEngine.Services
{
    class Cart
    {
        public static List<CartItem> Items  = new List<CartItem>();

        public static readonly Cart _Cart;
        static Cart()
        {

            Items.Add(new CartItem(1));
            Items.Add(new CartItem(2));
            Items.Add(new CartItem(3));
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
        public void SetItemQuantity(int productId, int quantity)
        {
            if (quantity == 0)
            {
                RemoveItem(productId);
                return;
            }

            CartItem updatedItem = new CartItem(productId);

            foreach (CartItem item in Items)
            {
                if (item.Equals(updatedItem))
                {
                    item.Quantity = quantity;
                    return;
                }
            }
        }
        public void RemoveItem(int productId)
        {
            CartItem removedItem = new CartItem(productId);
            Items.Remove(removedItem);
        }
        public decimal GetSubTotal()
        {
            decimal subTotal = 0;
            foreach (CartItem item in Items)
                subTotal += item.TotalPrice;

            return subTotal;
        }
    }
}
