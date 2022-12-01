namespace BlazorAds.Client.Services.PosterService
{
    public interface IPosterService
    {
        List<Poster> Posters { get; set; }
        Task GetPosters();
        Task<ServiceResponse<Poster>> GetPoster(int productId);

    }
}
