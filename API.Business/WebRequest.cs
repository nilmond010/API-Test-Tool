using API.Core;
using API.Interface;
using API.Model;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace API.Business
{
    public class WebRequest : IWebRequest
    {
        private readonly string fileName = "SavedTest.txt";
        public WebRequest()
        {
        }

        public ApiResponseStatus ProcessRequest(RequestParam requestParam, string token)
        {
            var processRequest = new ProcessRequest();
            return processRequest.ProcessWebRequest(requestParam.Url, requestParam.RequestType,
                requestParam.RequestBody, requestParam.Parameters, token);
        }

        public void SaveRequest(RequestParam requestModel)
        {
            var allRequest = GetAllRequest()?.ToList();
            var existingRequest = allRequest?.FirstOrDefault(node => node.Guid == requestModel.Guid);
            allRequest = allRequest ?? new List<RequestParam> { requestModel };

            if (existingRequest != null)
            {
                RequestParam.CopyObjectDetails(requestModel, existingRequest);
            }

            var json = JsonConvert.SerializeObject(allRequest);
            File.WriteAllText(fileName, json);
        }

        public RequestParam GetSavedRequest(Guid id)
        {
            IEnumerable<RequestParam> collection = GetAllRequest();
            return collection?.FirstOrDefault(node => node.Guid == id);
        }

        public IDictionary<Guid, string> GetAllNodes()
        {
            IEnumerable<RequestParam> collection = GetAllRequest();
            return collection?.ToDictionary(node => node.Guid, node => node.Title);
        }

        private IEnumerable<RequestParam> GetAllRequest()
        {
            string json = ReadFileContent();

            IEnumerable<RequestParam> collection = null;
            if (!string.IsNullOrWhiteSpace(json))
            {
                collection = JsonConvert.DeserializeObject<IEnumerable<RequestParam>>(json);
            }

            return collection;
        }

        private string ReadFileContent()
        {
            if (File.Exists(fileName))
                return File.ReadAllText(fileName);

            return "";
        }
    }
}
