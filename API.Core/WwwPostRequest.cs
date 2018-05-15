using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Text.RegularExpressions;

namespace API.Core
{
    /// <summary>
    /// Helper class to create, send http POST request and process the response 
    /// (Not recommended for large request)
    /// </summary>
    public class WwwPostRequest : WwwRequest
    {
        public WwwPostRequest(
            string url)
            : base(url)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9\s=,_]");
        }

        public override string Send()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
         
            // Enable TLS1.2 as well as others for compatiablity
            System.Net.ServicePointManager.SecurityProtocol =
                System.Net.SecurityProtocolType.Ssl3
                | System.Net.SecurityProtocolType.Tls
                | System.Net.SecurityProtocolType.Tls11
                | System.Net.SecurityProtocolType.Tls12;

            // Make up request in POST format
            request.Method = "POST";
            request.Timeout = 36000 * 1000;
            request.KeepAlive = false;
            request.CachePolicy = new System.Net.Cache.RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            request.Credentials = CredentialCache.DefaultNetworkCredentials;

            string postStr = GetParamString();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(postStr);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            Stream newStream = request.GetRequestStream();
            newStream.Write(data, 0, data.Length);
            newStream.Close();

            // Send request and get response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Process response and return a string of response
            return GetResponseString(response);
        }

        public string Send(string token, string json, string httpVerb)
        {
            var request = (HttpWebRequest)WebRequest.Create(_url);

            // Enable TLS1.2 as well as others for compatiablity
            System.Net.ServicePointManager.SecurityProtocol =
                System.Net.SecurityProtocolType.Ssl3
                | System.Net.SecurityProtocolType.Tls
                | System.Net.SecurityProtocolType.Tls11
                | System.Net.SecurityProtocolType.Tls12;

            request.Headers.Add(HttpRequestHeader.Authorization, "bearer " + token);

            // Make up request in POST format
            request.ContentType = "application/json";
            request.Method = httpVerb;
            request.Timeout = 36000 * 1000;
            request.KeepAlive = false;
            request.CachePolicy = new System.Net.Cache.RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            request.Credentials = CredentialCache.DefaultNetworkCredentials;

            if (!string.IsNullOrEmpty(json))
            {
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            
            var httpResponse = (HttpWebResponse)request.GetResponse();
            return GetResponseString(httpResponse); ;
        }

    }
}
