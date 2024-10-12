namespace dsExercicioBet.Domain.Entities;

public class Aposta
{
    public int Id { get; private set; }
    public float Valor { get; private set; }
    public float Odd { get; private set; }
    public Status Status { get; private set; }
    public int IdUsuario { get; private set; }
    public Usuario Usuario { get; private set; }

    public Aposta(float valor, float odd, Status status, int idUsuario, Usuario usuario)
    {
        Valor = valor;
        Odd = odd;
        Status = status;
        IdUsuario = idUsuario;
        Usuario = usuario;
    }
}