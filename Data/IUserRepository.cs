using WebApplication13.Models;

namespace WebApplication13.Data
{
	public interface IUserRepository
	{
		public bool SaveChanges();
		public void AddRecord<T>(T addRecord);
		public IEnumerable<User> GetUsers();

		public void DeleteRecord<T>(T UserId);
		public User GetSingleUser(int UserId);
		public void UpdateRecord(User user);

	}
}
