using dsExercicioBet.Application.Queries.Login;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dsExercicioBet.API.Controllers;
[Route("api/[controller]")]
public class UserController:ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("/login")]
    public async Task<IActionResult> Login([FromBody] LoginQuery query)
    {
        var login = await _mediator.Send(query);
        return Ok(login);
    }
   // public async Task<IActionResult> NovoUsuario([FromBody] NovoUsuarioCommand command)
    
}