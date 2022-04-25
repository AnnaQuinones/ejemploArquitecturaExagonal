using AutoMapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weelo2.Models;

namespace Weelo2.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OwnerRequest, Owner>().ReverseMap();
            CreateMap<Owner, OwnerResponse>().ReverseMap();
            CreateMap<PropertyRequest, Property>().ReverseMap();
            CreateMap<PropertyImageRequest, PropertyImage>().ReverseMap();
            CreateMap<Property, PropertyResponse>().ReverseMap();
        }
    }
}
