namespace Application.Domain.ValueObjects;

public record QuestionId(Guid Val) : BaseGuidId(Val);