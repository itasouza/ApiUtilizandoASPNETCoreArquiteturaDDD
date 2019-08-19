using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.Usuario
{
    public interface IUsuarioService
    {
        Task<UsuarioEntity> Get(Guid id);
        Task<IEnumerable<UsuarioEntity>> GetAll();
        Task<UsuarioEntity> Post(UsuarioEntity user);
        Task<UsuarioEntity> Put(UsuarioEntity user);
        Task<bool> Delete(Guid id);
    }
}
