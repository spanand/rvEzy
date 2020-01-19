using AutoMapper;
using RvEzy.Api.Dto;
using RvEzy.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RvEzy.Api.Profiles
{
    public class ListingProfile : Profile
    {
        public ListingProfile()
        {
            CreateMap<Listings, ListingDto>().ReverseMap();
        }
    }
}
