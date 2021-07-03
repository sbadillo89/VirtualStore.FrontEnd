using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class ProductCreate
    {
        public ProductCreate()
        {

        }
        public ProductCreate(Product product)
        {
            Name = product.Name;
            Description = product.Description;
            Image = product.Image;
            CategoryId = product.CategoryId;
            Reference = product.Reference;
            Barcode =  product.Barcode;
            Cost = product.Cost;
            Price = product.Price;
            Discount = (double)product.Discount;
            Color = product.Color;
            Talla = product.Talla;
            GenreId = product.GenreId;
            Active = product.Active;
        }

        [Required(ErrorMessage = "Ingrese un nombre válido")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ingrese una descripción válida")]
        [StringLength(500)]
        public string Description { get; set; }

        public string Image { get; set; }


        [Required(ErrorMessage = "Seleccione una categoria válida")]
        public string GuidCategoryIdAsSrting { get; set; }

        public Guid CategoryId
        {
            // se realiza esto para que el InputSelect
            // acepte el valor del Guid como string usando la prop GuidIdAsSrting
            get { return Guid.TryParse(GuidCategoryIdAsSrting, out Guid g) ? g : default; }
            set { GuidCategoryIdAsSrting = Convert.ToString(value); }
        }

        [StringLength(50)]
        public string Reference { get; set; }

        [StringLength(100)]
        public string Barcode { get; set; }

        [Required(ErrorMessage = "Ingrese un costo válido")]
        [Range(1, int.MaxValue, ErrorMessage = "Ingrese un valor mayor a 0.")]
        public double Cost { get; set; }

        [Required(ErrorMessage = "Ingrese un precio válido")]
        [Range(1, int.MaxValue, ErrorMessage = "Ingrese un valor mayor a 0.")] 
        public double Price { get; set; }

        public double Discount { get; set; }
        public string Color { get; set; }
        public string Talla { get; set; }


        [Required(ErrorMessage = "Seleccione un genero válido")]
        public string GuidGEnderIdAsSrting { get; set; }

        public bool Active { get; set; }
        public Guid GenreId
        {
            // se realiza esto para que el InputSelect
            // acepte el valor del Guid como string usando la prop GuidIdAsSrting
            get { return Guid.TryParse(GuidGEnderIdAsSrting, out Guid g) ? g : default; }
            set { GuidGEnderIdAsSrting = Convert.ToString(value); }
        }

    }
}
