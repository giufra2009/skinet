﻿using API.Dtos;
using AutoMapper;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
               .ForMember(x=>x.ProductBrand, o=>o.MapFrom(s=>s.ProductBrand.Name))
               .ForMember(x=>x.ProductType, t=>t.MapFrom(s=>s.ProductType.Name))
               .ForMember(x=>x.PictureUrl, o=>o.MapFrom<ProductUrlResolver>());
        }
    }
}
