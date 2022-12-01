namespace BlazorAds.Client.Services.PosterService
{
    public class PosterService : IPosterService
    {
        private readonly HttpClient _http;
        public PosterService(HttpClient http)
        {
            _http = http;
        }
        public List<Poster> Posters { get; set; } = new List<Poster>();

        public async Task<ServiceResponse<Poster>> GetPoster(int posterId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Poster>>($"api/poster/{posterId}");
            return result;
        }

        public async Task GetPosters()
        {
            var result =
                await _http.GetFromJsonAsync<ServiceResponse<List<Poster>>>("api/Poster");
            if (result != null && result.Data != null)
                Posters = result.Data;  
        }
    }
}
