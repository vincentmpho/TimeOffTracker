namespace TimeOffTracker.Web.Models
{
    public class leaveAllocationEditModel : LeaveAllocationViewModel
    {
        public string EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public EmployeeListViewModel? Employee { get; set; } 
    }
}
