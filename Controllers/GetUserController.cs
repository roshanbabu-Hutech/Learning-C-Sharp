using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Dtos;
using WebApplication13.Models;
using WebApplication13.Services;

namespace WebApplication13.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class GetUserController : ControllerBase
	{
		public readonly IUserRepository _userRepository;
		public readonly IMapper _mapper;
		public GetUserController(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = new Mapper(new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<User, UserDto>();
			}));
		}
		[HttpGet("getUser/{UserId}")]
		public User GetUser(int UserId)
		{
			Console.WriteLine("The User Id is" + UserId);

			return _userRepository.GetSingleUser(UserId);

		}
	}
}
