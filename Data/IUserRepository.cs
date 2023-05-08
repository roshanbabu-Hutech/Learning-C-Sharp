using WebApplication13.Models;

namespace WebApplication13.Data
{
	public interface IUserRepository
	{
		public bool SaveChanges();
		public void AddRecord<T>(T addRecord);
		public IEnumerable<User> GetUsers();


	}
}
