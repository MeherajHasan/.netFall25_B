using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;

namespace BLL
{
    public class MapperConfig
    {
        static MapperConfiguration config = new MapperConfiguration(cfg=>{
            cfg.CreateMap<Student,StudentDTO>().ReverseMap();
            cfg.CreateMap<Department,DepartmentDTO>().ReverseMap();
            cfg.CreateMap<Department,DepartmentStudentDTO>().ReverseMap();
            //cfg.CreateMap<Student,StudentDTO>();
            //cfg.CreateMap<Student,StudentDTO>();
            //cfg.CreateMap<Student,StudentDTO>();
            //cfg.CreateMap<Student,StudentDTO>();
        });
        public static Mapper GetMapper() {
            return new Mapper(config);
        }

    }
}
