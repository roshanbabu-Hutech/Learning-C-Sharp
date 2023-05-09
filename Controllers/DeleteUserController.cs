using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;
using WebApplication13.Dtos;
using WebApplication13.Services;

namespace WebApplication13.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class DeleteUserController : ControllerBase
	{
		public readonly IUserRepository _userRepository;
		public readonly IMapper _mapper;
		public DeleteUserController(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = new Mapper(new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<UserDto,User>();
			}));
		}
		[HttpDelete("deleteUser/{UserId}")]
		public IActionResult DeleteUser(int UserId)
		{
			User user = _userRepository.GetSingleUser(UserId);
			if (user != null)
			{
				_userRepository.DeleteRecord(user);
				if (_userRepository.SaveChanges())
				{
					return Ok("User Deleted Succussfully");
				}
				else
				{
					throw new Exception("Failed to delete the User");
				}
			}
			else
			{
				throw new Exception($"Unable to Get user {UserId}");
			}


		}
	}
}
