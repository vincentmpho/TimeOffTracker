using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Runtime.InteropServices;
using TimeOffTracker.Web.Constants;
using TimeOffTracker.Web.Constants;
using TimeOffTracker.Web.Data;
using TimeOffTracker.Web.Models;
using TimeOffTracker.Web.Repository.Interfaces;

namespace TimeOffTracker.Web.Repository
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper
            ) : base(context)
        {
            _context = context;
            _userManager = userManager;
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await _context.LeaveAllocations.AnyAsync(x => x.EmployeeId == employeeId
            && x.LeaveTypeId == leaveTypeId
            && x.Period == period);
        }

        public async Task<EmployeeAllocationViewModel> GetEmployeeAllocation(string employeeId)
        {
            var allocation = await _context.LeaveAllocations
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == employeeId)
                .ToListAsync();
        
            var employee = await _userManager.FindByIdAsync(employeeId);

            var employeeAllocationonModel = _mapper.Map<EmployeeAllocationViewModel>(employee);
            employeeAllocationonModel.LeaveAllocation = _mapper.Map<List<LeaveAllocationViewModel>>(allocation);


            return employeeAllocationonModel;
        }

        public async Task<leaveAllocationEditModel> GetEmployeeAllocation(int id)
        {
                var allocation = await _context.LeaveAllocations
                    .Include(q => q.LeaveType)
                    .FirstOrDefaultAsync(q => q.Id == id);

                if (allocation == null)
                {
                    return null;
                }

                var employee = await _userManager.FindByIdAsync(allocation.EmployeeId);

                var model = _mapper.Map<leaveAllocationEditModel>(allocation);
            model.Employee = (EmployeeAllocationViewModel)_mapper.Map<EmployeeListViewModel>(await _userManager.FindByIdAsync(allocation.EmployeeId));



            return model;

        }

        public async Task LeaveAllocation(int leaveTyeId)
        {


            var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType =  await _leaveTypeRepository.GetAsync(leaveTyeId);
            var allocations = new List<LeaveAllocation>();

            foreach (var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTyeId, period))
                    continue;
                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTyeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays

                });
                await AddRangeAsync(allocations);
   
            }
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationViewModel model)
        {
            var leaveAllocation = await GetAsync(model.Id);

            if (leaveAllocation == null)
            {
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation);

            return true;
        }
    }
}
