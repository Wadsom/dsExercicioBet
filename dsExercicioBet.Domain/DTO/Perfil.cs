namespace dsExercicioBet.Domain.DTO;

public class Perfil:IPerfil
{
    public string Email { get;  set; }
    public void ObterEmail(string email)
    {
        Email = email;
    }
}