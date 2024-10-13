namespace dsExercicioBet.Domain.Auth;

public interface IAuthService
{
    string GenerateToken(string email, string role);
    string ComputedHashPassword(string senha);
}