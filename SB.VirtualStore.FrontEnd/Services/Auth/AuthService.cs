using SB.VirtualStore.FrontEnd.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public class AuthService : IAuthService<AuthRequest, AuthResponse>
    {
        readonly HttpClient httpClient;

        public AuthService(HttpClient http)
        {
            httpClient = http;
        }

        public async Task<GlobalResponseAuth<AuthRequest, AuthResponse>> Login(string requestUri, AuthRequest auth)
        {
            using var msg = await httpClient.PostAsJsonAsync(requestUri, auth, System.Threading.CancellationToken.None);
            GlobalResponseAuth<AuthRequest, AuthResponse> result = await msg.Content.ReadFromJsonAsync<GlobalResponseAuth<AuthRequest, AuthResponse>>();
            result.Message = result.Message;

            return result;
        }
        public async Task<GlobalResponseAuth<AuthRequest, AuthResponse>> Register(string requestUri, AuthUser newUser)
        {
            using (var msg = await httpClient.PostAsJsonAsync(requestUri, newUser, System.Threading.CancellationToken.None))
            {
                var result = await msg.Content.ReadFromJsonAsync<GlobalResponseAuth<AuthRequest, AuthResponse>>();
                result.Message = result.Message;

                return result;
            }
        }
    }
}
