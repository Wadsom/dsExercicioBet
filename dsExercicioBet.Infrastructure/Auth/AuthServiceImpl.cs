using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using dsExercicioBet.Domain.Auth;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace dsExercicioBet.Infrastructure.Auth;

public class AuthServiceImpl : IAuthService
{
    private readonly IConfiguration _configuration;

    public AuthServiceImpl(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GenerateToken(string email, string cargo)
    {
        var issuer = _configuration["Auth:Issuer"];
        var audience = _configuration["Auth:Audience"];
        var secretKey = _configuration["Auth:SecretKey"];

        var SSK = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var SC = new SigningCredentials(SSK,SecurityAlgorithms.HmacSha512);
        var claim = new List<Claim>
        {
            new Claim("Username", email),
            new Claim(ClaimTypes.Role, cargo)
        };
        var jht = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            expires: DateTime.Now.AddHours(8),
            signingCredentials: SC,
            claims: claim
            );
        var jwtHandler = new JwtSecurityTokenHandler();
        return jwtHandler.WriteToken(jht);
    }

    public string ComputedHashPassword(string senha)
    {
        using (SHA512 sha512 = SHA512.Create())
        {
            byte[] bytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(senha));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }

}