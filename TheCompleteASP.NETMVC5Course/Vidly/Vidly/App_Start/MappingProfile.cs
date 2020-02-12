using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dto;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //domain to dto
            CreateMap<Movie, MovieDto>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<MembershipType, MembershipTypeDto>();
            CreateMap<Genre, GenreDto>();

            //dto to domain
            CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());

            CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            CreateMap<MembershipTypeDto, MembershipType>()
                .ForMember(m => m.Id, opt => opt.Ignore());

            CreateMap<GenreDto, Genre>()
                .ForMember(g => g.Id, opt => opt.Ignore());


        }
    }
}