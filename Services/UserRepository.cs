using AutoMapper;
using WebApplication13.Data;
using WebApplication13.Dtos;
using WebApplication13.Models;
using Microsoft.Extensions.Configuration;

namespace WebApplication13.Services
{
    public class UserRepository : IUserRepository
    {
        public readonly ApplicationDbContext _Db;
        public readonly IMapper _mapper;
        public UserRepository(IConfiguration config, IMapper mapper)
        {
            _Db = new ApplicationDbContext(config);
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDto, User>();
            }));
        }
        public bool SaveChanges()
        {
            return _Db.SaveChanges() > 0;
        }
        public void AddRecord<T>(T addRecord)
        {
            if (addRecord != null)
            {
                Console.WriteLine(addRecord.ToString());
                Console.WriteLine(addRecord.GetHashCode());
                Console.WriteLine(addRecord);
                _Db.Add(addRecord);
            }
        }
        public IEnumerable<User> GetUsers()
        {
            IEnumerable<User> users = _Db.Users.ToList();
            if (users != null)
            {
                return users;
            }
            else
            {
                throw new Exception("There are no user records in the database");
            }
        }
        public void DeleteRecord<T>(T User)
        {
            if (User != null)
            {
                Console.WriteLine(User);
                Console.WriteLine(User.ToString());
                _Db.Remove(User);
                //_Db.Users.Where(t => t.Name == Convert.ToString(User));
                //var UserToDelete = _Db.Set<User>().FirstOrDefault(t => t.Email == User.ToString());
                //_Db.Set<User>().Remove(UserToDelete);
            }
        }
        public User GetSingleUser(int UserId)
        {
            User? userRecord = _Db.Users.Where(t => t.UserId == UserId).FirstOrDefault();
            if (userRecord != null)
            {
                //UserDto user = _mapper.Map<UserDto>(userRecord);
                Console.WriteLine(userRecord.UserId);
                Console.WriteLine(userRecord.Name);
                Console.WriteLine(userRecord.Email);
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
            if (userRecord != null)
            {
                userRecord.Name = user.Name;
                userRecord.Email = user.Email;
                string password = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password);
                userRecord.Password = password;
                _Db.Update(userRecord);
            }
        }
        public void AddUserDetails(UserDetails userDetails)
        {
            Console.WriteLine("Under the User Repository");
            Console.WriteLine(userDetails);
            _Db.Add(userDetails);
        }
        //public UserDetails GetSingleUserDetails(int UserId)
        //{
        //    UserDetails user = _Db.UsersDetails.Where(t=>t.UserId == UserId).FirstOrDefault();
        //    if (user != null)
        //    {
        //        return user;
        //    }
        //    else
        //    {
        //        throw new Exception($"There's no User record with the UserId {UserId}");
        //    }
        //}
        //public void UpdateUserDetails<T>(T user)
        //{
        //    user.
        //}
        public void UpdateUserDetails(UserDetails details)
        {
            if(details != null)
            {
				UserDetails? user = _Db.UsersDetails.Where(t => t.UserId == details.UserId).FirstOrDefault();
                if (user != null)
                {
                    _Db.UsersDetails.Update(user);
                }
                else
                {
                    throw new Exception($"There's no record with the given id {details.UserId}");
                }
            }
            else
            {
                throw new Exception();
            }
		}
    }
}
