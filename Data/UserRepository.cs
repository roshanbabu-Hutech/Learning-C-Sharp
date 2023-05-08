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
			return users;
		}
	}
}
