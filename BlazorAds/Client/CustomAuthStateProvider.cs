using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorAds.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {       
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
