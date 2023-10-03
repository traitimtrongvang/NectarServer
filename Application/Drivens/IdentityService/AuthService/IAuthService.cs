using Application.Drivens.IdentityService.Dtos;
using Application.Drivens.IdentityService.Enums;

namespace Application.Drivens.IdentityService.AuthService;

public interface IAuthService
{
    void ThrowIfUnauthorized(string accessToken, HashSet<RoleEnum> allowedRoles, out AuthorInfo info);
}