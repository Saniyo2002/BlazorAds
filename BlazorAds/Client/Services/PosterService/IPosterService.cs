namespace BlazorAds.Client.Services.PosterService
{
    public interface IPosterService
    {
        event Action PostersChanged;
        List<Poster> Posters { get; set; }
        Task GetPosters(string? categoryUrl = null);
        Task<ServiceResponse<Poster>> GetPoster(int productId);

    }
}
