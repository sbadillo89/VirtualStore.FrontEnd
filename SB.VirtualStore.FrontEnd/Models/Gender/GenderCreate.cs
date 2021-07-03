using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class GenderCreate
    { 
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

    }
}
