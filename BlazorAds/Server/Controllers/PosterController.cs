using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAds.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosterController : ControllerBase
    {   
        private readonly IPosterService  _posterService;

        public PosterController(IPosterService posterService)
        {          
             _posterService = posterService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Poster>>>> GetAds()
        {
           var result = await _posterService.GetPostersAsync();
            return Ok(result);
        }
        [HttpGet("{posterId}")]
        public async Task<ActionResult<ServiceResponse<Poster>>> GetAd(int posterId)
        {
            var result = await _posterService.GetPostersAsync(posterId);
            return Ok(result);
        }
    }
}
