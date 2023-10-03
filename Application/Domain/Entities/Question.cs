using Application.Domain.ValueObjects;

namespace Application.Domain.Entities;

public class Question : BaseEntity<QuestionId>
{
    public required QuestionContent Content { get; set; }
    
    public required QuestionMediaUri MediaUri { get; set; }
    
    public required QuestionPoint Point { get; set; }
    
    public required QuestionTime Time { get; set; }
    
    public required QuestionTypeEnum Type { get; init; }
    
    #region ForeignKeys

    public required GameId GameId { get; init; }
    
    #endregion
    
    #region RelationShips

    public Game? Game { get; init; }
    
    public List<Choice>? ChoiceList { get; init; }

    #endregion
}