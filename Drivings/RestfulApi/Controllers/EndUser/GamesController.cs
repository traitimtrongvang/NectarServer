using Application.Drivings.UseCases.EndUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RestfulApi.Controllers.EndUser;

public class GamesController : ControllerBase
{
    private readonly IMediator _mediator;

    public GamesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> CreateGameAsync()
    {
        var gamePreview = await _mediator.Send(new CreateGameCommand
        {
            Body = new CreateGameBody("xxx"),
            AccessToken = "null"
        });

        return Ok(gamePreview);
    }
}