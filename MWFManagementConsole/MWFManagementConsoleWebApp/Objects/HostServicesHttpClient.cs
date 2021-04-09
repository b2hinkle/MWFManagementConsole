using System;
using System.Net.Http;


namespace MWFManagementConsoleWebApp
{
    public class HostServicesHttpClient
    {
        private readonly HttpClient httpClient;

        public HostServicesHttpClient(HttpClient inHttpClient)
        {
            inHttpClient.BaseAddress = new Uri("https://localhost:5001/api/");
            this.httpClient = inHttpClient;
        }

        public HttpClient GetClient()
        {
            return httpClient;
        }
    }
}