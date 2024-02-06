using TimeOffTracker.Web.Data;
using TimeOffTracker.Web.Repository.Interfaces;

namespace TimeOffTracker.Web.Repository
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
