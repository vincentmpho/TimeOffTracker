using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TimeOffTracker.Web.Models
{
    public class LeaveRequestsCreateViewModel : IValidatableObject
    {
        [Required]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        [Required]
        public int LeaveTypeId { get; set; }
        public SelectList? leaveTypes { get; set; }

        [Display(Name ="Request Comments")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate> EndDate)
            {
                yield return new ValidationResult("The  start Date Must Be Before End Date",
                    new[] {nameof(StartDate), nameof(EndDate)});
            }
            if (RequestComments?.Length>250)
            {
                yield return new ValidationResult("Comments are to long", new[] { nameof(RequestComments) });               
            }
        }
    }
}
