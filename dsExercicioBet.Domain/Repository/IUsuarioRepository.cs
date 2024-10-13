using dsExercicioBet.Domain.Entities;

namespace dsExercicioBet.Domain.Repository;

public interface IUsuarioRepository
{
    Task<Usuario> LogandoUsuarioPeloEmaileSenha(string requestEmail, string psdHash);
}