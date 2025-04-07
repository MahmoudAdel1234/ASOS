using ASOS.BL.DTOs.UserDto;

namespace ASOS.BL.Managers.Users
{
	public interface IUserManager
	{
		Task<TokenDto> Login(LoginCredentials credentials);
		Task Register(RegisterDto registerDto);

	}
}
