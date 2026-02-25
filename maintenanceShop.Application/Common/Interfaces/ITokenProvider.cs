using maintenanceShop.Application.Features.Identity;
using maintenanceShop.Application.Features.Identity.Dtos;
using System.Security.Claims;

namespace maintenanceShop.Application.Common.Interfaces;

public interface ITokenProvider
{
    Task<Result<TokenResponse>> GenerateJwtTokenAsync(AppUserDto user, CancellationToken ct = default);

    ClaimsPrincipal? GetPrincipalFromExpiredToken(string token);
}