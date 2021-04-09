using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MWFManagementConsoleWebApp
{
    public class DatabaseServicesHttpClient
    {
        private readonly HttpClient httpClient;

        public DatabaseServicesHttpClient(HttpClient inHttpClient)
        {
            inHttpClient.BaseAddress = new Uri("http://localhost:7071/api/");
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