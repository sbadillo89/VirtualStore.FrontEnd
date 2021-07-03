using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class AuthResponse
    {
        public Guid userId { get; set; }
        public string userName { get; set; }
        public string email { get; set; }

        public string token { get; set; } 

        public DateTime ExpireDate { get; set; }
        public bool IsAdmin { get; set; }
    }
}
