using Microsoft.AspNetCore.Mvc;
using Nasa_Open_API.Models;
using Nasa_Open_API.Service;

namespace Nasa_Open_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APODController : ControllerBase
    {
        private readonly APODClient _client;

        public APODController(APODClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<APOD?> GetAPOD()
        {
            return await _client.GetAPOD();
        }
    }
}
