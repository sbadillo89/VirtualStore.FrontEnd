using System;
using System.ComponentModel.DataAnnotations;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class CategoryCreate
    {
        public CategoryCreate()
        {

        }
        public CategoryCreate( Category category)
        {
            Id = category.Id;
            Name = category.Name;
            Active = category.Active ? "Activo" : "Inactivo";
            CreatedDate = category.CreatedDate;
        }

        public Guid Id { get; set; }
        [Required (ErrorMessage ="Ingrese un nombre de categoria.")] 
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Seleccione un estado válido.")]  
        public string Active { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
