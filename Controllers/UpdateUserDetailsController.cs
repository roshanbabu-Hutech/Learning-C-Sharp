using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;
using WebApplication13.Services;

namespace WebApplication13.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UpdateUserDetailsController : ControllerBase
	{
		public readonly IUserRepository _userRepository;
		public UpdateUserDetailsController(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
		[HttpPut("updateUserDetails/{UserId}")]
		public ActionResult UpdateUserDetails(UserDetails details)
		{
			_userRepository.UpdateUserDetails(details);
				if (_userRepository.SaveChanges())
				{
					return Ok("User details record Updated Succussfully");
				}
				else
				{
					throw new Exception("There's an error while Updating the User Details Record");
				}
		}
	}
}
