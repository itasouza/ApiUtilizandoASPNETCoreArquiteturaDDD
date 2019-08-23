using Api.Domain.Dtos;
using Api.Domain.Interfaces.Services.Usuario;
using Api.Domain.Repository;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class LoginService : ILoginService
    {
        private IUsuarioRepository _repository;

        public LoginService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<object> FindByLogin(LoginDto usuario)
        {
            if(usuario != null && 
               !string.IsNullOrWhiteSpace(usuario.Login) &&
               !string.IsNullOrWhiteSpace(usuario.Senha))
            {
                return await _repository.FindByLogin(usuario.Login, usuario.Senha);
            }
            else
            {
                return null;
            }
        }

    }
}
