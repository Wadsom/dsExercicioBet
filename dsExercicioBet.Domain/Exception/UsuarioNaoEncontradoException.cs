namespace dsExercicioBet.Domain.Exception;

public class UsuarioNaoEncontradoException:System.Exception
{
    public UsuarioNaoEncontradoException(string message="Usuario não encontrado") : base(message)
    {
    }
}