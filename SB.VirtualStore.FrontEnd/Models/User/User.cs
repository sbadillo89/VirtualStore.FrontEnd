using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class User
    {
        [Required(ErrorMessage = "Seleccione un Rol válido")]
        public string GuidIdAsSrting { get; set; }

        public Guid Id { get; set; }

        [Required(ErrorMessage ="Ingrese un Usuario válido")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Ingrese un Email válido")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese una Contraseña válida")]
        public string Password { get; set; }

        public Guid RolId
        {
            // se realiza esto para que el InputSelect
            // acepte el valor del Guid como string usando la prop GuidIdAsSrting
            get { return Guid.TryParse(GuidIdAsSrting, out Guid g) ? g : default; }
            set { GuidIdAsSrting = Convert.ToString(value); }
        }
        public bool Active { get; set; }


        public Role Rol { get; set; }
        public DateTime CreatedDate { get; set; }


    }
}
