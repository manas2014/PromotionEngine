using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Services.Models
{
    public class CartItem : IEquatable<CartItem>
    {
        #region Properties

        public int Quantity { get; set; }

        private int _productId;
        public int ProductId
        {
            get { return _productId; }
            set
            {
                _product = null;
                _productId = value;
            }
        }

        private Product _product = null;
        public Product Prod
        {
            get
            {
                if (_product == null)
                {
                    _product = new Product(ProductId);
                }
                return _product;
            }
        }

        public string Description
        {
            get { return Prod.Description; }
        }

        public decimal UnitPrice
        {
            get { return Prod.Price; }
        }

        public decimal TotalPrice
        {
            get { return UnitPrice * Quantity; }
        }

        #endregion

        public CartItem(int productId)
        {
            this.ProductId = productId;
        }

        public bool Equals(CartItem item)
        {
            return item.ProductId == this.ProductId;
        }
    }
}
