using System;
using System.Net.Http;

namespace MWFManagementConsoleWebApp
{
    public class DatabaseServicesHttpClient
    {
        private readonly HttpClient httpClient;

        public DatabaseServicesHttpClient(HttpClient inHttpClient)
        {
            inHttpClient.BaseAddress = new Uri("http://localhost:7071/api/");
            this.httpClient = inHttpClient;
        }

        public HttpClient GetClient()
        {
            return httpClient;
        }
    }
}