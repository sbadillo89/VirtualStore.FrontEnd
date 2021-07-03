using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Models
{
    public class GlobalResponseAuth<TRequest, TResponse>
    {
        public TRequest RequestData { get; set; }

        public TResponse ResponseData { get; set; }

        public HttpStatusCode Status { get; set; }

        public string Message { get; set; }
    }
}
