using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class AuthRequest
    {
        [Required(ErrorMessage = "Ingrese un correo")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese un correo válido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Ingrese una contraseña.")]
        public string Password { get; set; }
    }
}
