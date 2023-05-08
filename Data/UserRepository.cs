using WebApplication13.Models;

namespace WebApplication13.Data
{
	public class UserRepository : IUserRepository
	{
		ApplicationDbContext _Db;
		public UserRepository(IConfiguration config) 
		{
			_Db = new ApplicationDbContext(config);
		}
		public bool SaveChanges()
		{
			return _Db.SaveChanges() > 0;
		}
		public void AddRecord<T>(T addRecord)
		{
			if(addRecord!= null)
			{
				_Db.Add(addRecord);
			}
		}
		public IEnumerable<User> GetUsers()
		{
			IEnumerable<User> users = _Db.Users.ToList<User>();
			if(users!= null)
			{
				return users;
			}
			else
			{
				throw new Exception("There are no user records in the database");
			}
		}
		public void DeleteRecord<T>(T UserId)
		{
			if(UserId != null)
			{
				_Db.Remove(UserId);
			}
		}
		public User GetSingleUser(int UserId)
		{
			User? userRecord = _Db.Users.Where(t => t.UserId == UserId).FirstOrDefault();
			if(userRecord != null)
			{
				return userRecord;
			}
			else
			{
				throw new Exception("There's No record with this User Id");
			}
		}
		public void UpdateRecord(User user)
		{
			User? userRecord = _Db.Users.Where(t => t.UserId == user.UserId).FirstOrDefault();
			if(userRecord != null)
			{
				userRecord.Name = user.Name;
				userRecord.Email = user.Email;
				string password = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password);
				userRecord.Password = password;
				_Db.Update(userRecord);
			}
		}
	}
}
