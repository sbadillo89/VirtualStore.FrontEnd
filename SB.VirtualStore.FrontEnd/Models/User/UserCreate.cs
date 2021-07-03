using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class UserCreate
    {
        public UserCreate()
        {

        }

        public UserCreate(User user)
        {
            UserName = user.UserName;
            Email = user.Email;
            Password = user.Password;
            RolId = user.RolId;
            Active = user.Active;
        }

        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        public Guid? RolId { get; set; }
        public bool Active { get; set; }
    }
}
