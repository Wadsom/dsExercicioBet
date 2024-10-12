namespace dsExercicioBet.Domain.Entities;

public class Transacao
{
    public int Id { get; private set; }
    public int IdCliente { get; private set; }
    public Usuario Cliente { get; private set; }
    public double Valor { get; private set; }
    public DateTime DataTransferencia { get; private set; }
    
}