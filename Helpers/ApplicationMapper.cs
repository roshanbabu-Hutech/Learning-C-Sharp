using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Dtos;
using WebApplication13.Models;

namespace WebApplication13.Helpers
{
	public class ApplicationMapper : Profile
	{
		public ApplicationMapper()
		{
			CreateMap<UserDetailsDto, UserDetails>().ReverseMap();
		}
	}
}
