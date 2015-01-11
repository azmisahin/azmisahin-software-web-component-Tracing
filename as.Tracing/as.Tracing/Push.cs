using System;
using System.Configuration;
using System.Net.Http;//System.Net.Http.dll
using System.Net.Http.Headers;
using System.Threading.Tasks;
namespace @as.Tracing
{
    /// <summary>
    /// Push Notification
    /// </summary>
    public class Push
    {
        #region Configuration
        /// <summary>
        /// Application Key
        /// </summary>
        /// <param name="key">appSettings Key</param>
        /// <returns>value</returns>
        private static string getAppKey(string key)
        {
            var value = ConfigurationManager.AppSettings[key].ToString();
            return value;
        }
        #endregion

        /// <summary>
        /// Notification Start
        /// </summary>
        /// <param name="message"></param>
        public async static Task StartAsync(string message)
        {
            try
            {
                string domainUri = getAppKey("Domain.Api");
                string domainServices = getAppKey("Domain.Services");
                Uri uri = new Uri(
                    string.Format(
                        "{0}Notification/Send?Message={1}",
                        domainUri, message));
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://" + uri.Host);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/html"));
                    //var data = "";
                    HttpResponseMessage response = await client.GetAsync(uri.PathAndQuery);
                    response = await client.PostAsync(uri.PathAndQuery,null);
                    if (response.IsSuccessStatusCode)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                var e = ex;
                System.Diagnostics.Trace.Write("Push Err");
            }
        }
    }
}
