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
        }
    }
}
