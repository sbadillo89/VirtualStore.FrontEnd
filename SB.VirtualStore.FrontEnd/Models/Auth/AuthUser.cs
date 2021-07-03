using System;
using System.ComponentModel.DataAnnotations;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class AuthUser
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Ingrese un nombre de usuario")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Ingrese un correo")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Ingrese un correo válido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Ingrese una contraseña.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Ingrese una contraseña.")]
        public string ConfirmPassword { get; set; }

    }
}
