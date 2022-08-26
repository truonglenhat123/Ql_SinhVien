using AutoMapper;
using QL_SinhVien.Data.Entity;
using QL_SinhVien.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_SinhVien.Service.Mappers
{
    public class AutoMappers: Profile
    {
        public AutoMappers()
        {
            CreateMap<StudentDTO, SinhVienEntities>()
                .ReverseMap();
        }
    }
}
