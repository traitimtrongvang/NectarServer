using Application.Domain.Entities;
using Application.Domain.Exceptions;
using Application.Domain.ValueObjects;
using Application.Drivens.IdentityService.Enums;
using Application.Drivens.IdentityService.Storages;

namespace Application.Domain.Services;

public interface IGameService
{
    Task<Game> CreateGameAsync(
        UserId creatorUserId, 
        GameTitle title, 
        CancellationToken stopToken = default);
}

public class GameService : IGameService
{
    private readonly IUserStorage _userStorage;

    public GameService(IUserStorage userStorage)
    {
        _userStorage = userStorage;
    }

    public async Task<Game> CreateGameAsync(
        UserId creatorUserId, 
        GameTitle title, 
        CancellationToken stopToken = default)
    {
        var endUser = await _userStorage.FindByIdAsync(creatorUserId.Val, RoleEnum.EndUser, stopToken);
        if (endUser is null)
            throw new NotFoundCreatorUserExc();
        
        return new Game
        {
            Title = title,
            Status = GameStatusEnum.Private,
            CreatorUserId = creatorUserId,
            QuestionList = new ()
        };
    }
}