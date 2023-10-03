using Application.Domain.Entities;
using Application.Domain.ValueObjects;

namespace Application.Drivens.Database.Repositories;

public interface IGameRepository : IBaseRepository<Game, GameId>
{
    
}