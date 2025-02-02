﻿using AutoMapper;
using Win.Fmp.Data;

namespace Win.Fmp
{
    public class FmpApplicationAutoMapperProfile : Profile
    {
        public FmpApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Person, PersonDto>().ReverseMap();
        }
    }
}
