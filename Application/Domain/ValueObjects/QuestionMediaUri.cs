namespace Application.Domain.ValueObjects;

// TODO validation
public record QuestionMediaUri
{
    public required string Val { get; init; }

    public string GetMediaType()
    {
        // TODO implement shit
        throw new NotImplementedException();
    }
}