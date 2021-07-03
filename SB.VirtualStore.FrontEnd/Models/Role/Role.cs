using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class Role
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool Active { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

    }
}
