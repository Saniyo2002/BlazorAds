using BlazorAds.Shared;

namespace BlazorAds.Server.Services.PosterService
{
    public interface IPosterService
    {
        Task<ServiceResponse<List<Poster>>> GetPostersAsync();
        Task<ServiceResponse<Poster>> GetPostersAsync(int posterId);
        Task<ServiceResponse<List<Poster>>> GetPostersByCategory(string categoryUrl);

    }
}
