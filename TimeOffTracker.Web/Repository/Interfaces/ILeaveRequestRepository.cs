using TimeOffTracker.Web.Data;
using TimeOffTracker.Web.Models;
using TimeOffTracker.Web.Repository.Interface;

namespace TimeOffTracker.Web.Repository.Interfaces
{
    public interface ILeaveRequestRepository :IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveReques(LeaveRequestsCreateViewModel mode);
    }
}
