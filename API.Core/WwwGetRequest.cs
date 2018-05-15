using System.Net;

namespace API.Core
{
    /// <summary>
    /// Helper class to create, send http POST request and process the response 
    /// (Not recommended for large request)
    /// </summary>
    public class WwwGetRequest : WwwRequest
	{
		public WwwGetRequest(string url) : base(url) {}

		public override string Send()
		{
			string parmStr = GetParamString();

			// Make up request in GET format
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url + "?" + parmStr);

            // Enable TLS1.2 as well as others for compatiablity
            System.Net.ServicePointManager.SecurityProtocol =
                System.Net.SecurityProtocolType.Ssl3
                | System.Net.SecurityProtocolType.Tls
                | System.Net.SecurityProtocolType.Tls11
                | System.Net.SecurityProtocolType.Tls12;

			request.Method = "GET";

			// Send request and get response
			HttpWebResponse response = (HttpWebResponse) request.GetResponse();
			
			// Process response and return a string of response
			return GetResponseString(response);
		}
	}
}
