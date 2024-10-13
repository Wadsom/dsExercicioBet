namespace dsExercicioBet.Domain.DTO;

public interface IPerfil
{
    string Email { get; set; }
   void ObterEmail(string email);
}