using Application.Domain.ValueObjects;

namespace Application.Domain.Entities;

public abstract class BaseEntity<TId> 
    where TId : BaseGuidId
{
    public required TId Id { get; init; }

    public required DateTime CreatedAt { get; init; }

    public DateTime? UpdatedAt { get; set; } = default;
}