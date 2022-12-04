using BlazorAds.Shared;

namespace BlazorAds.Server.Services.PosterService
{
    public class PosterService : IPosterService
    {
        private readonly DataContext  _context;

        public PosterService(DataContext context)
        {
             _context = context;
        }
        public async Task<ServiceResponse<List<Poster>>> GetPostersAsync()
        {
            var response = new ServiceResponse<List<Poster>>
            {
                Data = await _context.Posters.ToListAsync(),
            };
            return response;
        }

        public async Task<ServiceResponse<Poster>> GetPostersAsync(int posterId)
        {
            var response = new ServiceResponse<Poster>();
            var poster = await _context.Posters.FindAsync(posterId);
            if(poster == null)
            {
                response.Success = false;
                response.Message = "Этого объявления больше не существует :(";
            }
            else
            {
                response.Data = poster;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Poster>>> GetPostersByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Poster>>
            {
                Data = await _context.Posters
                     .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                     .ToListAsync()

            };
            return response;
        }
    }
}
