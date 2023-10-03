using Application.Domain.Services;
using Application.Drivens.Database.Repositories;
using Application.Drivens.IdentityService.Enums;
using Application.Drivings.Requests;
using Application.Drivings.UseCases.EndUser.Dtos;
using MediatR;

namespace Application.Drivings.UseCases.EndUser;

public record CreateGameBody(string Title);

public record CreateGameCommand : AuthorizedCommandRequest<CreateGameBody, GamePreviewRes>
{
    public override HashSet<RoleEnum> GetAllowedRoles()
        => new() { RoleEnum.EndUser };
}

public record CreateGameHandler : IRequestHandler<CreateGameCommand, GamePreviewRes>
{
    private readonly IGameService _gameService;
    private readonly IGameRepository _gameRepository;
    
    public CreateGameHandler(IGameService gameService, IGameRepository gameRepository)
    {
        _gameService = gameService;
        _gameRepository = gameRepository;
    }

    public async Task<GamePreviewRes> Handle(CreateGameCommand request, CancellationToken stopToken)
    {
        var game = await _gameService.CreateGameAsync(
            new (request.AuthorInfo.Id),
            new (request.Body.Title),
            stopToken);

        await _gameRepository.InsertAsync(game, stopToken);

        return new GamePreviewRes(
            game.Id.Val, 
            game.Title.Val);
    }
}