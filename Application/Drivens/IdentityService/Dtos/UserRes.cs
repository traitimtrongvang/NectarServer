using Application.Drivens.IdentityService.Enums;

namespace Application.Drivens.IdentityService.Dtos;

public record UserRes
{
    public required string Id { get; init; }

    public required RoleEnum Role { get; init; }
}