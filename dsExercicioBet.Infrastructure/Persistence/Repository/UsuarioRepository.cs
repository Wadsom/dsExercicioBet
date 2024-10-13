using dsExercicioBet.Domain.Entities;
using dsExercicioBet.Domain.Exception;
using dsExercicioBet.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace dsExercicioBet.Infrastructure.Persistence.Repository;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly DsExercicioBetDbContext _db;

    public UsuarioRepository(DsExercicioBetDbContext db)
    {
        _db = db;
    }

    public async Task<Usuario> LogandoUsuarioPeloEmaileSenha(string requestEmail, string psdHash)
    {
        var user = await _db.Usuarios.SingleOrDefaultAsync(u => u.Email == requestEmail && u.Senha == psdHash);
        if (user == null) throw new UsuarioNaoEncontradoException();
        return user;
    }
}