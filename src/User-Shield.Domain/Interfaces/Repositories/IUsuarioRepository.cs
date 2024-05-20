using User_Shield.Domain.Entities;

namespace User_Shield.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        #region Public Methods

        Task<bool> VerificarDuplicidadeAsync(Guid id, string nome, string email);

        #endregion Public Methods
    }
}
