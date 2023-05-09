using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Dtos;
using WebApplication13.Services;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class GetSingleUserDetailController : ControllerBase
	{
		public readonly IUserRepository _userRepository;
		public readonly IMapper _mapper;
		public GetSingleUserDetailController(IUserRepository userRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_mapper = mapper;
		}
		[HttpGet("GetSingleUserDetail")]
		public UserDetailsDto GetSingleUserDetail(int UserId)
		{

			UserDetails User = _userRepository.GetSingleUserDetail(UserId);
			return _mapper.Map<UserDetailsDto>(User);
		}
	}
}
