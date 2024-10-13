using MediatR;

namespace dsExercicioBet.Application.Queries.Login;

public class LoginQuery:IRequest<LoginViewModel>
{
    public string Email { get; set; }
    public string Senha { get; set; }
    
}