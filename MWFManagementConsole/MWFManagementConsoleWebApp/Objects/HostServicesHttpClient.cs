using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MWFManagementConsoleWebApp
{
    public class HostServicesHttpClient
    {
        private readonly HttpClient httpClient;

        public HostServicesHttpClient(HttpClient inHttpClient)
        {
            inHttpClient.BaseAddress = new Uri("http://10.127.41.89:5000/api/");    // We are using http version (instead of https) for now since for demonstration pourposes we want something to show
            inHttpClient.DefaultRequestHeaders.Accept.Clear();
            inHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(@"application/json"));    // Just give us json (we are not looking for a web page or anything)

            this.httpClient = inHttpClient;
        }

        public HttpClient GetClient()
        {
            return httpClient;
        }
    }
}