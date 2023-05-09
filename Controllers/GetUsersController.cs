using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;
using WebApplication13.Dtos;
using WebApplication13.Services;

namespace WebApplication13.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class GetUsersController : ControllerBase
	{
		IMapper _mapper;
		IUserRepository _userRepository;
		public GetUsersController(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = new Mapper(new MapperConfiguration(cfg => {
				cfg.CreateMap<UserDto, User>();
			}));
		}

		[HttpGet("users")]
		public IEnumerable<User> GetUserRecords()
		{
			IEnumerable<User> users = _userRepository.GetUsers();
			//IEnumerable<UserDto> usersDto = _mapper.Map<User,UserDto>(users);
			return users;

			//Response.WriteAsync("Succussfully fetched all the user records");
		}
	}
}
