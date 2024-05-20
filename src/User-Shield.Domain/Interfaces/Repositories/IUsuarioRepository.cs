using User_Shield.Domain.Entities;

namespace User_Shield.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetByIdAsync(int id);
        Task<IEnumerable<Usuario>> GetAllAsync();
        Task AddAsync(Usuario product);
        Task UpdateAsync(Usuario product);
        Task DeleteAsync(int id);
    }
}
