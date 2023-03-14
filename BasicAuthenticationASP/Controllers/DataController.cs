using BasicAuthenticationASP.Models;
using BasicAuthenticationASP.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAuthenticationASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DataController : ControllerBase
    {
        private readonly IDataService _dataService;

        public DataController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public async Task<IEnumerable<Data>> Get() => await _dataService.Get();
    }
}
