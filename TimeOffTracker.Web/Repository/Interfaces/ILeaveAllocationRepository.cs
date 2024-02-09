using TimeOffTracker.Web.Data;
using TimeOffTracker.Web.Models;
using TimeOffTracker.Web.Repository.Interface;

namespace TimeOffTracker.Web.Repository.Interfaces
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
       Task LeaveAllocation (int leaveTyeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationViewModel> GetEmployeeAllocation(string employeeId);
        Task<leaveAllocationEditModel> GetEmployeeAllocation(int id);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationViewModel model);
    }
}
