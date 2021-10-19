using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeDancin.Domain.Entities.Helpers.API
{
    public class APIResponse
    {
        public string Message { get; set; }
        public bool Erro { get; set; }
        public HttpStatusCode status { get; set; }
        public object result { get; set; }
    }
}
