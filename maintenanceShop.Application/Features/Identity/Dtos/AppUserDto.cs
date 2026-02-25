using System.Security.Claims;

namespace maintenanceShop.Application.Features.Identity.Dtos;

public sealed record AppUserDto(string UserId, string Email, IList<string> Roles, IList<Claim> Claims);