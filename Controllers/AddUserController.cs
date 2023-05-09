using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Dtos;
using WebApplication13.Models;
using WebApplication13.Services;

namespace WebApplication13.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class AddUserController : ControllerBase
	{
		public readonly IUserRepository _userRepository;
		public readonly IMapper _mapper;
		public AddUserController(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = new Mapper(new MapperConfiguration(cfg=>{
				cfg.CreateMap<UserDto,User>();
			}));
		}
		[HttpPost("addUser")]
		public IActionResult AddUser(User user)
		{
			//UserDto userDto = _mapper.Map<UserDto>(user);
			Console.WriteLine(user);
			_userRepository.AddRecord(user);

			if (_userRepository.SaveChanges())
			{
				return Ok("User Record Succussfully added to the database");
			}
			else
			{
				throw new Exception("There's an errror while storing your data");
			}
		}

	}
}
