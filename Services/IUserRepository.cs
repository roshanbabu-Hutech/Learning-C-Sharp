using WebApplication13.Dtos;
using WebApplication13.Models;

namespace WebApplication13.Services
{
    public interface IUserRepository
    {
        public bool SaveChanges();
        public void AddRecord<T>(T addRecord);
        public IEnumerable<User> GetUsers();
        public void AddUserDetails(UserDetails userDetails);
		public void DeleteRecord<T>(T UserId);
        public void UpdateRecord(User user);
        public User GetSingleUser(int UserId);
        public void UpdateUserDetails(UserDetails details);
        public UserDetails GetSingleUserDetail(int UserId);
        public IEnumerable<UserDetailsDto> GetAllUserDetails();



		//public void AddUserDetails(UserDetails userDetails);

	}
}
