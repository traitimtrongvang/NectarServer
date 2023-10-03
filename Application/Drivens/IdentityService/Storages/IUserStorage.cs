using Application.Drivens.IdentityService.Dtos;
using Application.Drivens.IdentityService.Enums;

namespace Application.Drivens.IdentityService.Storages;

public interface IUserStorage
{
    Task<IDictionary<string, UserRes>> FindByManyIdsAsync(
        HashSet<string> idSet,
        RoleEnum? role = null,
        CancellationToken stopToken = default);

    Task<UserRes?> FindByIdAsync(
        string id, 
        RoleEnum? role = null,
        CancellationToken stopToken = default);
}