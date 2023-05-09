using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication13.Models;
using AutoMapper;
using WebApplication13.Dtos;
using WebApplication13.Services;

namespace WebApplication13.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		IMapper _mapper;
		IUserRepository _userRepository;
		public UserController(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = new Mapper(new MapperConfiguration(cfg=>{
				cfg.CreateMap<UserDto,User>();
			}));
		}

		//[HttpGet("users")]
		//public IEnumerable<User> GetUsers()
		//{
		//	IEnumerable<User> users = _userRepository.GetUsers();
		//	//IEnumerable<UserDto> usersDto = _mapper.Map<User,UserDto>(users);
		//		return users;
			
		//	//Response.WriteAsync("Succussfully fetched all the user records");
		//} 
		//[HttpPost("addUser")]
		//public IActionResult AddUser(User user)
		//{
		//	_userRepository.AddRecord(user);
		//	if(_userRepository.SaveChanges())
		//	{
		//		Console.WriteLine(user.Email);
		//		Console.WriteLine(user.Name);
		//		Console.WriteLine(user.UserId);
		//		return Ok("User Record Succussfully added to the database");
		//	}
		//	else
		//	{
		//		throw new Exception("There's an errror while storing your data");
		//	}
		//}
		//[HttpDelete("deleteUser/{UserId}")]
		//public IActionResult DeleteUser(int UserId)
		//{
		//		User user = _userRepository.GetSingleUser(UserId);
		//		if(user != null)
		//		{
		//			_userRepository.DeleteRecord(user);
		//			if (_userRepository.SaveChanges())
		//			{
		//				return Ok("User Deleted Succussfully");
		//			}
		//			else
		//			{
		//				throw new Exception("Failed to delete the User");
		//			}
		//		}
		//		else
		//		{
		//			throw new Exception($"Unable to Get user {UserId}");
		//		}
			
			
		//}
		//[HttpPut("updateUser/{UserId}")]
		//public IActionResult UpdateUser(User User)
		//{
		//	_userRepository.UpdateRecord(User);
		//	if (_userRepository.SaveChanges())
		//	{
		//		return Ok("User Record Updated Succussfully");
		//	}
		//	else
		//	{
		//		throw new Exception("There's an error while Updating the User Record");
		//	}
			
		//	}
		//[HttpGet("Getuser/{UserId}")]
		//public User GetUser(int UserId)
		//{
		//	Console.WriteLine("The User Id is"+UserId);

		//	return _userRepository.GetSingleUser(UserId);
			
		//}
	}
}
