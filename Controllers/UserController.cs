using Microsoft.AspNetCore.Mvc;
using WebApplication13.Data;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		ApplicationDbContext _Db;
		public UserController(IConfiguration config)
		{
			_Db = new ApplicationDbContext(config);
		}

		[HttpGet("users")]
		public IEnumerable<User> GetUsers()
		{
			IEnumerable<User> users = _Db.Users.ToList<User>();
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
	}
}
