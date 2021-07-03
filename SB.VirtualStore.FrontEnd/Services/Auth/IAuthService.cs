using SB.VirtualStore.FrontEnd.Models;
using System.Threading.Tasks;

namespace SB.VirtualStore.FrontEnd.Services
{
    public interface IAuthService<TRequest, TResponse>
    {
        Task<GlobalResponseAuth<TRequest, TResponse>> Register(string requestUri, AuthUser newUser);
        Task<GlobalResponseAuth<TRequest, TResponse>> Login(string requestUri, AuthRequest auth);
    }
}
