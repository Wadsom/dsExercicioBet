namespace dsExercicioBet.Domain.Entities;

public class Usuario
{
    public int Id { get; private set; }
    public string  Nome { get; private set; }
    public string Email { get; private set; }
    public string  Senha { get; private set; }
    public double Saldo { get; private set; }
    public string Cargo { get; private set; }
    public List<Transacao> Transacaos { get; private set; } = new List<Transacao>();
    public List<Aposta> Apostas { get; private set; } = new List<Aposta>();


}