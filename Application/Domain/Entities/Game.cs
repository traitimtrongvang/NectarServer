using Application.Domain.ValueObjects;

namespace Application.Domain.Entities;

public class Game : BaseEntity<GameId>
{
    public required GameTitle Title { get; set; }
    
    public required GameStatusEnum Status { get; set; }
    
    // TODO game description

    #region ForeignKeys

    public required UserId CreatorUserId { get; init; }

    #endregion

    #region RelationShips
    
    public List<Question>? QuestionList { get; init; }
    
    #endregion
}