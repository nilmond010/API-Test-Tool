using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Model
{
    public class RequestParam
    {
        public string Title { get; set; }
        public Guid Guid { get; set; }
        public string RequestBody { get; set; }
        public string RequestType { get; set; }
        public string Url { get; set; }
        public Dictionary<string,string> Parameters { get; set; }
    }
}
