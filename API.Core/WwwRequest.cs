using System.Collections;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;

namespace API.Core
{
    /// <summary>
    /// Abstract base class for WwwPostRequest and WwwGetRequest.
    /// </summary>
    public abstract class WwwRequest
    {
        protected string _url;
        protected Hashtable _parameters;

        public WwwRequest(string url)
        {
            // Ignore SSL certificate error for Pinging and reporting
            ServicePointManager.ServerCertificateValidationCallback +=
                new System.Net.Security.RemoteCertificateValidationCallback(IgnoreSSLCertValidation);

            _url = url;
            _parameters = new Hashtable();
        }

        /// <summary>
        /// Add parameter to http request
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="value">Parameter value</param>
        public void AddParmeter(string name, string value)
        {
            if (_parameters.ContainsKey(name))
                _parameters.Remove(name);

            _parameters.Add(name, value);
        }

        /// <summary>
        /// Clear all parameters
        /// </summary>
        public void ClearAllParameters()
        {
            _parameters.Clear();
        }

        /// <summary>
        /// Abstract method to be implemented in sub class
        /// </summary>
        /// <returns></returns>
        public abstract string Send();

        /// <summary>
        /// Convert http response to a string
        /// </summary>
        /// <param name="response">HttpWebResponse</param>
        /// <returns>string</returns>
        protected string GetResponseString(HttpWebResponse response)
        {
            StringBuilder sb = new StringBuilder();
            byte[] buf = new byte[1024];

            Stream resStream = response.GetResponseStream();
            string tempString = null;
            int count = 0;
            do
            {
                // fill the buffer with data
                count = resStream.Read(buf, 0, buf.Length);

                // make sure we read some data
                if (count != 0)
                {
                    // translate from bytes to ASCII text
                    tempString = Encoding.ASCII.GetString(buf, 0, count);

                    // continue building the string
                    sb.Append(tempString);
                }
            } while (count > 0);

            response.Close();
            return sb.ToString();
        }

        /// <summary>
        /// Generate parameter list string and encode it to comform to http
        /// </summary>
        /// <returns>string</returns>
        protected string GetParamString()
        {
            string paramStr = "";

            foreach (string key in _parameters.Keys)
            {
                if (paramStr != "")
                    paramStr += "&";
                paramStr += key + "=" + HttpUtility.UrlEncode(_parameters[key].ToString());
            }

            return paramStr;
        }

        private static bool IgnoreSSLCertValidation(
            object sender,
            X509Certificate cert,
            X509Chain chain,
            System.Net.Security.SslPolicyErrors error)
        {
            return true;
        }
    }
}
