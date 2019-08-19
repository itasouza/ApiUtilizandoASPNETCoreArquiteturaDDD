using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Usuario;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class UsuarioService : IUsuarioService
    {

        private IRepository<UsuarioEntity> _repository;

        public UsuarioService(IRepository<UsuarioEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UsuarioEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<UsuarioEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<UsuarioEntity> Post(UsuarioEntity user)
        {
            return await _repository.InsertAsync(user);
        }

        public async Task<UsuarioEntity> Put(UsuarioEntity user)
        {
            return await _repository.UpdateAsync(user);
        }
    }
}
