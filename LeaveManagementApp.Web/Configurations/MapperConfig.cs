using AutoMapper;
using LeaveManagementApp.Web.Data;
using LeaveManagementApp.Web.Models;

namespace LeaveManagementApp.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
        }
    }
}
