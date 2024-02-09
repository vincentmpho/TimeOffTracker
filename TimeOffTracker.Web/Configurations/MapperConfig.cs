using AutoMapper;
using TimeOffTracker.Web.Data;
using TimeOffTracker.Web.Models;

namespace TimeOffTracker.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeViewModel>().ReverseMap();
            CreateMap<Employee, EmployeeListViewModel>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationViewModel>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationViewModel>().ReverseMap();
            CreateMap<LeaveAllocation, leaveAllocationEditModel>().ReverseMap();
        }
    }
}
