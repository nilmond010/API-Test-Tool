using API.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace API.Core
{
    public class ProcessRequest
    {
        public ApiResponseStatus ProcessWebRequest(string apiUrl, string httpVerb, string json, 
            Dictionary<string, string> headerParameters, string token)
        {
            var responseStatus = new ApiResponseStatus();

            var result = string.Empty;
            var request = new WwwPostRequest(apiUrl);
            headerParameters.ToList().ForEach(x => request.AddParmeter(x.Key, x.Value));

            #region Create web request and Retry logic
            try
            {
                if (string.IsNullOrEmpty(token))
                {
                    responseStatus.Result = request.Send();
                }
                else
                {
                    responseStatus.Result = request.Send(token, json, httpVerb);
                }

                responseStatus.StatusCode = HttpStatusCode.OK;
            }
            catch (WebException exception)
            {
                if (exception.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = exception.Response as HttpWebResponse;
                    if (response != null)
                    {
                        responseStatus.StatusCode = response.StatusCode;
                    }
                }
                if (exception.Response != null && exception.Response.GetResponseStream() != null)
                {
                    var resp = new StreamReader(exception.Response.GetResponseStream()).ReadToEnd();
                    result = (string.IsNullOrEmpty(resp) ? exception.Message : resp);
                }
                else
                {
                    result = exception.Message;
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            #endregion

            responseStatus.Message = result;
            return responseStatus;
        }
    }
}
