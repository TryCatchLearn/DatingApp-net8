using API.Entities;

namespace API;

public interface ITokenService
{
    Task<string> CreateToken(AppUser user);
}
