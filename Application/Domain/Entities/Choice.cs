using Application.Domain.ValueObjects;

namespace Application.Domain.Entities;

public class Choice : BaseEntity<ChoiceId>
{
    public required bool IsCorrect { get; set; }

    #region ForeignKeys

    public required QuestionId QuestionId { get; init; }

    #endregion
    
    #region RelationShips

    public Question? Question { get; init; }

    #endregion
}