using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Data;
using WebApplication13.Models;
using WebApplication13.Services;

namespace WebApplication13.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class AddUserDetailsController : ControllerBase
	{
		//public readonly ApplicationDbContext _Db;
		public readonly IUserRepository _userRepository;
		public readonly IMapper _mapper;
		public AddUserDetailsController(IUserRepository userRepository, IMapper mapper)
		{
			//_Db = db;
			_mapper = mapper;
			_userRepository = userRepository;
		}
		[HttpPost("addUserDetails")]
		public IActionResult AddUserDetails(UserDetails userdetails)
		{
			if(userdetails != null)
			{
				Console.WriteLine(userdetails);
				_userRepository.AddUserDetails(userdetails);

				if(_userRepository.SaveChanges())
				{
					return Ok("User Record Succussfully added to the database");
				}
				else
				{
					throw new Exception("There's an error while storing the User record in the database");
				}
			}
			else
			{
				throw new Exception("There's an error while adding the User details to the database");
			}
		}
	}
}
