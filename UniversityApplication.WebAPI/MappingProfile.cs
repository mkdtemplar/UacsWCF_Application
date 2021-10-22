using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using UniversityApplication.Data.DataTransferObjects;
using UniversityApplication.Data.Models;

namespace UniversityApplication.WebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDTO>().ForMember(c => c.FullName,
                opt => opt.MapFrom(x => string.Join(' ', x.FirstName, x.LastName)));

            CreateMap<Address, AddressDTO>();

            CreateMap<StudentForCreationDto, Student>();
        }
    }
}
