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
            var existingRequest = GetSavedRequest(requestModel.Guid);

            if (existingRequest == null)
            {
                var json = JsonConvert.SerializeObject(new List<RequestParam> { requestModel });
                File.AppendAllText(@"SavedTest.txt", json);
            }
            else
            {

            }
        }

        public RequestParam GetSavedRequest(Guid id)
        {
            string json = ReadFileContent();

            if (!string.IsNullOrWhiteSpace(json))
            {
                var collection = JsonConvert.DeserializeObject<IEnumerable<RequestParam>>(json);

                return collection.FirstOrDefault(node => node.Guid == id);
            }

            return null;
        }

        private string ReadFileContent()
        {
            if (File.Exists(fileName))
                return File.ReadAllText(fileName);

            return "";
        }

        public IDictionary<Guid, string> GetAllNodes()
        {
            string json = ReadFileContent();
            if (!string.IsNullOrWhiteSpace(json))
            {
                var collection = JsonConvert.DeserializeObject<IEnumerable<RequestParam>>(json);

                return collection.ToDictionary(node => node.Guid, node => node.Title);
            }

            return null;
        }
    }
}
