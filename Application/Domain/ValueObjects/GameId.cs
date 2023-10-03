namespace Application.Domain.ValueObjects;

public record GameId(Guid Val) : BaseGuidId(Val);