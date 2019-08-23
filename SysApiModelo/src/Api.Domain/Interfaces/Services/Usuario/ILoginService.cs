using Api.Domain.Dtos;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Usuario
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto usuario);
    }
}
