namespace dsExercicioBet.Domain.Auth;

public interface IAuthService
{
    string GenerateToken(string email, string cargo);
    string ComputedHashPassword(string senha);
}