namespace dsExercicioBet.Domain.Entities;

public class Evento
{
    public int Id { get; private set; }
    public List<Aposta> Apostas { get; private set; }
    public string Nome { get; private set; }
    public DateTime DataEvento { get; private set; }
    public Status Status { get; private set; }

    public Evento(string nome)
    {
        Nome = nome;
        DataEvento = DateTime.Now;
        Status = Status.ABERTO;
    }
}