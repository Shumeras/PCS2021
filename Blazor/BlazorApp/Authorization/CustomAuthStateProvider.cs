using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorApp
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private string role = "";

        public void ChangeRole(string newRole)
        {
            role = newRole;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            return Task.FromResult(new AuthenticationState(
                new ClaimsPrincipal(
                        new[]{
                            new ClaimsIdentity(
                                new []{
                                    new Claim(ClaimTypes.Role, role)
                                }
                            )
                        }
                    )
                ));
        }
    }
}