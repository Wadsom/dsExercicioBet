namespace dsExercicioBet.Domain.Entities;

public class Aposta
{
    public int Id { get; private set; }
    public double Valor { get; private set; }
    public double Odd { get; private set; }
    public Status Status { get; private set; }
    public int IdUsuario { get; private set; }
    public Usuario Usuario { get; private set; }
    public int IdEvento { get; private set; }
    public Evento Evento { get; private set; }
  
}