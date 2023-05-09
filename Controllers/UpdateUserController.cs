using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;
using WebApplication13.Services;

namespace WebApplication13.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class UpdateUserController : ControllerBase
	{
		public readonly IUserRepository _userRepository;
		public readonly IMapper _mapper;
		public UpdateUserController(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = mapper;
		}
		[HttpPut("updateUser/{UserId}")]
		public IActionResult UpdateUser(User User)
		{
			_userRepository.UpdateRecord(User);
			if (_userRepository.SaveChanges())
			{
				return Ok("User Record Updated Succussfully");
			}
			else
			{
				throw new Exception("There's an error while Updating the User Record");
			}

		}
	}
}
