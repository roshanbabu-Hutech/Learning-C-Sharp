using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication13.Data;
using WebApplication13.Models;
using AutoMapper;
using WebApplication13.Dtos;

namespace WebApplication13.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		ApplicationDbContext _Db;
		IMapper _mapper;
		IUserRepository _userRepository;
		public UserController(IConfiguration config,IUserRepository userRepository)
		{
			_Db = new ApplicationDbContext(config);
			_userRepository = userRepository;
			_mapper = new Mapper(new MapperConfiguration(cfg=>{
				cfg.CreateMap<UserDto,User>();
			}));
		}

		[HttpGet("users")]
		public IEnumerable<User> GetUsers()
		{
			IEnumerable<User> users = _userRepository.GetUsers();
			//Response.WriteAsync("Succussfully fetched all the user records");
			return users;
		}
		[HttpPost("addUser")]
		public IActionResult AddUser(User user)
		{
			_Db.Users.Add(user);
			if(_Db.SaveChanges() > 0)
			{
				Console.WriteLine(user.Email);
				Console.WriteLine(user.Name);
				Console.WriteLine(user.UserId);
				return Ok("User Record Succussfully added to the database");
			}
			else
			{
				throw new Exception("There's an errror while storing your data");
			}
		}
		[HttpDelete("deleteUser/{UserId}")]
		public IActionResult DeleteUser(int UserId)
		{
			User? userRecord = _Db.Users.Where(t => t.UserId == UserId).FirstOrDefault();
			if (userRecord != null) { 
				_Db.Users.Remove(userRecord);
				if (_Db.SaveChanges() > 0)
				{
					Console.WriteLine(UserId);
					Console.WriteLine(userRecord);
					Console.WriteLine("User Record Succussfully deleted");
					return Ok("User Record Succussfully deleted from the database");
				}
				else
				{
					throw new Exception("There's an error while deleting the record from the database");
				}
			}
			else
			{
				throw new Exception("There's an no user record with this ID");
			}
			
		}
		[HttpPut("updateUser/{UserId}")]
		public IActionResult UpdateUser(User User)
		{
			User? userRecord = _Db.Users.Where(t => t.UserId == User.UserId).FirstOrDefault();
			if (userRecord != null)
			{
				userRecord.Email = User.Email;
				userRecord.Name = User.Name;
				string password = BCrypt.Net.BCrypt.EnhancedHashPassword(User.Password);
				userRecord.Password = password;
				if (_Db.SaveChanges() > 0)
				{
					Console.WriteLine(userRecord.Email);
					Console.WriteLine(userRecord.Name);
					Console.WriteLine(userRecord.Password);
					return Ok(userRecord);
				}
				else
				{
					throw new Exception("There's an error while updating the user data");
				}
			}
			else
			{
				throw new Exception("There's no any record with the id you provided");
			}
		}
		[HttpGet("Getuser/{UserId}")]
		public User GetUser(int UserId)
		{
			Console.WriteLine("The User Id is"+UserId);

			// Define the secret key used to sign the token
			var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Natasha Malkova"));

			// Define the signing credentials used to sign the token
			var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

			// Define the claims for the token
			var claims = new[]
			{
	new Claim(ClaimTypes.Name, "John Smith"),
	new Claim(ClaimTypes.Email, "john.smith@example.com")
};

			// Define the token descriptor
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(claims),
				Expires = DateTime.UtcNow.AddHours(1),
				SigningCredentials = signingCredentials
			};

			// Create the token handler
			var tokenHandler = new JwtSecurityTokenHandler();

			// Generate the token
			var token = tokenHandler.CreateToken(tokenDescriptor);
			Console.WriteLine(token);
			// Get the token string
			var tokenString = tokenHandler.WriteToken(token);
			Console.WriteLine(tokenString);

			User? user = _Db.Users.FirstOrDefault(t => t.UserId == UserId);
			if (user != null)
			{
				string password = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password);
				Console.WriteLine($"The User Password is {user.Password}");
				Console.WriteLine($"The hashed Password is {password}");
				return user;
			}
			else
			{
				throw new Exception("There's no User with the given id");
			}

		}
	}
}
