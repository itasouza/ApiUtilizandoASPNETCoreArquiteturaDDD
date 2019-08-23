using Api.Domain.Entities;
using Api.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Repository
{
    public interface IUsuarioRepository:IRepository<UsuarioEntity>
    {
        Task<UsuarioEntity> FindByLogin(string login, string senha);
    }
}
