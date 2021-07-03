using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class GlobalResponse 
    {
        public object RequestData { get; set; }
                
        public object  ResponseData { get; set; }

        public HttpStatusCode Status { get; set; }

        public string Message { get; set; }
    }
}
