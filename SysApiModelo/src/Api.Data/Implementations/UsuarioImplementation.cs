using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Data.Implementations
{
    public class UsuarioImplementation: BaseRepository<UsuarioEntity>, IUsuarioRepository
    {
        private DbSet<UsuarioEntity> _dataset;

        public UsuarioImplementation(MyContext context): base(context)
        {
            _dataset = context.Set<UsuarioEntity>();
        }

        public async Task<UsuarioEntity> FindByLogin(string login, string senha)
        {
            return await _dataset.FirstOrDefaultAsync(u => u.Login.Equals(login) && u.Senha.Equals(senha));
        }

    }
}
