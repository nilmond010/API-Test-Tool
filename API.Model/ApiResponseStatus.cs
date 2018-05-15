using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace API.Model
{
    public class ApiResponseStatus
    {
        public string Message { get; set; }
        public string Result { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
