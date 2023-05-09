using Microsoft.AspNetCore.Mvc;
using WebApplication13.Dtos;
using WebApplication13.Services;

namespace WebApplication13.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class GetUserDetailsController : ControllerBase
	{
		public readonly IUserRepository _userRepository;
		public GetUserDetailsController(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
		[HttpGet("GetAllUserDetails")]
		public IEnumerable<UserDetailsDto> GetAllUserDetails()
		{
			return _userRepository.GetAllUserDetails();
		}
	}
}
