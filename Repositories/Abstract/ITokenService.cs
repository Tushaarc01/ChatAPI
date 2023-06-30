using ChatAPI_.Models.DTOs;
using System.Security.Claims;

namespace ChatAPI_.Repositories.Abstract
{
    public interface ITokenService
    {
        TokenResponse GetToken(IEnumerable<Claim> claim);

        string GetRefreshToken();

        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);

    }
}
