using System;
using System.ComponentModel.DataAnnotations;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class Category
    {
        public Category()
        {

        }
        public Category(CategoryCreate categoryCreate)
        {
            Id = categoryCreate.Id;
            Name = categoryCreate.Name;
            Active = categoryCreate.Active == "Activo";
            CreatedDate = categoryCreate.CreatedDate;
        }
        public Guid Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public bool Active { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
