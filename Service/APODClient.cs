using Nasa_Open_API.Models;

namespace Nasa_Open_API.Service
{
    public class APODClient
    {
        private readonly HttpClient client = new HttpClient();
       
        public async Task<APOD?> GetAPOD()
        {
            UriBuilder builder = new UriBuilder("https://api.nasa.gov")
            {
                Path = "/planetary/apod",
                Query = "?api_key=DEMO_KEY"
            };
            client.BaseAddress = builder.Uri;

            Task<APOD?> response = client.GetFromJsonAsync<APOD>("");

            return await response;
        }
    }
}
