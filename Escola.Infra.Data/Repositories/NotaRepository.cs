using Escola.Domain.Entities;
using Escola.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Infra.Data.Repositories
{
    internal class NotaRepository : INotaRepository
    {
        public Task<Nota> AddAsync(Nota nota)
        {
            throw new NotImplementedException();
        }

        public Task<Nota> DeleteAssync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Nota>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Nota> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Nota> UpdateAsync(Nota nota)
        {
            throw new NotImplementedException();
        }
    }
}
