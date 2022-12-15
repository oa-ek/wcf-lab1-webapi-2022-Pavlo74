namespace RozkladClient.Infrastructure
{
    public abstract class HttpBaseService
    {
        protected readonly HttpClient httpClient;

        public HttpBaseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}