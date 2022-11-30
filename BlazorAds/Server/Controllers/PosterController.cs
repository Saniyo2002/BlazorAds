using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAds.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PosterController : ControllerBase
    {
        private readonly DataContext  _context;

        public PosterController(DataContext context)
        {
             _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Poster>>> GetAds()
        {
            var posters = await _context.Posters.ToListAsync();
            return Ok(posters);
        }
    }
}
