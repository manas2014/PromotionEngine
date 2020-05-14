using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Services.Models
{
    public class Product
    {

        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product(int id)
        {
            this.Id = id;
            switch (id)
            {
                case 1:
                    this.Price = 50;
                    this.Description = "A";
                    break;
                case 2:
                    this.Price = 30;
                    this.Description = "B";
                    break;
                case 3:
                    this.Price = 20;
                    this.Description = "C";
                    break;
                case 4:
                    this.Price = 15;
                    this.Description = "D";
                    break;
            }
        }

    }
}
