using dsExercicioBet.Domain.Auth;
using dsExercicioBet.Domain.DTO;
using dsExercicioBet.Domain.Repository;
using MediatR;

namespace dsExercicioBet.Application.Queries.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, LoginViewModel>
{
    private readonly IUsuarioRepository _userRepository;
    private readonly IAuthService _authService;
    private readonly IPerfil _perfil;

    public LoginQueryHandler(IUsuarioRepository userRepository, IAuthService authService, IPerfil perfil)
    {
        _userRepository = userRepository;
        _authService = authService;
        _perfil = perfil;
    }

    public async Task<LoginViewModel> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var psdHash = _authService.ComputedHashPassword(request.Senha);
        var login = await _userRepository.LogandoUsuarioPeloEmaileSenha(request.Email, psdHash);
        var token = _authService.GenerateToken(login.Email,login.Cargo);
        _perfil.ObterEmail(login.Email);
        return new LoginViewModel(){Email = login.Email, Token = token};
    }
}