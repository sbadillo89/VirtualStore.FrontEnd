using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class Product
    {
        public Product()
        {

        }
        public Product( ProductCreate productCreate)
        {
            Name = productCreate.Name;
            Description = productCreate.Description;
            Image = productCreate.Image;
            CategoryId = productCreate.CategoryId;
            Reference = productCreate.Reference;
            Barcode = productCreate.Barcode;
            Cost = productCreate.Cost;
            Price = productCreate.Price;
            Discount = productCreate.Discount;
            Color = productCreate.Color;
            Talla = productCreate.Talla;
            GenreId = productCreate.GenreId;
            Active = productCreate.Active;
        }

        public Guid Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }

        public string Image { get; set; } 
        public Guid CategoryId { get; set; }

        public string Reference { get; set; } 

        public string Barcode { get; set; }

        public double Cost { get; set; }

        public double Price { get; set; }

        public double? Discount { get; set; }

        public string Color { get; set; }
        public string Talla { get; set; }
        public bool Active { get; set; }
        public Guid GenreId { get; set; }

        public virtual Gender  Gender { get; set; }
        public virtual Category Category { get; set; }
    }
}
