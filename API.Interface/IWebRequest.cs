using API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Interface
{
    public interface IWebRequest
    {
        ApiResponseStatus ProcessRequest(RequestParam requestParam, string token);
        void SaveRequest(RequestParam requestModel);
        RequestParam GetSavedRequest(Guid id);
        IDictionary<Guid,string> GetAllNodes();
    }
}
