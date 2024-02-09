using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TimeOffTracker.Web.Constants;
using TimeOffTracker.Web.Data;
using TimeOffTracker.Web.Models;
using TimeOffTracker.Web.Repository;
using TimeOffTracker.Web.Repository.Interfaces;

namespace TimeOffTracker.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> _userManager;
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public EmployeesController( UserManager<Employee> userManager, IMapper mapper,
            ILeaveAllocationRepository leaveAllocationRepository,
            ILeaveTypeRepository leaveTypeRepository)
        {
            _userManager = userManager;
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
            _leaveTypeRepository = leaveTypeRepository;
        }
        // GET: EmployeesController
        public async Task <IActionResult> Index()
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
            var model =  _mapper.Map<List<EmployeeListViewModel>>(employees);
            return View(model);
        }

        // GET: EmployeesController/ViewAllocations/Emplloyee Id
        public async Task <ActionResult> ViewAllocations(string id)
        {
            var model = await _leaveAllocationRepository.GetEmployeeAllocation(id);
            return View(model);
        }

        // GET: EmployeesController/EditAllocation/5
        public  async Task <ActionResult> EditAllocation(int id)
        {
            var model = await _leaveAllocationRepository.GetEmployeeAllocation(id);

            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: EmployeesController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> EditAllocation(int id, leaveAllocationEditModel model)
        {
            try
            {
                //check
                if (ModelState.IsValid)
                {
                    if(await _leaveAllocationRepository.UpdateEmployeeAllocation(model) ==true)
                    {
                        return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
                    }
                }    
            }
            catch
            {
                ModelState.AddModelError(string.Empty, "An Error Has Occurred. Please Try Again Later");
            }
            model.Employee = _mapper.Map<EmployeeListViewModel>( await  _userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = _mapper.Map<LeaveTypeViewModel>(await _leaveTypeRepository.GetAsync(model.LeaveTypeId));
            return View(model);
        }

    }
}
