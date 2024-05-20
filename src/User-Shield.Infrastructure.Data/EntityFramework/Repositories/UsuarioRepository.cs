using Microsoft.EntityFrameworkCore;
using User_Shield.Domain.Entities;
using User_Shield.Domain.Interfaces.Repositories;
using User_Shield.Infrastructure.Data.EntityFramework.Context;

namespace User_Shield.Infrastructure.Data.EntityFramework.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Usuario product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Usuario product)
        {
            throw new NotImplementedException();
        }
    }
}
