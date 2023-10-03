namespace Application.Domain.ValueObjects;

public record ChoiceId(Guid Val) : BaseGuidId(Val);