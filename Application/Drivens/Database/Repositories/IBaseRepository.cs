using Application.Domain.Entities;
using Application.Domain.ValueObjects;

namespace Application.Drivens.Database.Repositories;

public interface IBaseRepository<TEntity, TId> 
    where TEntity : BaseEntity<TId> 
    where TId : BaseGuidId
{
    Task InsertAsync(TEntity entity, CancellationToken stopToken = default);
}