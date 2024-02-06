﻿using System.ComponentModel.DataAnnotations;

namespace TimeOffTracker.Web.Models
{
    public class LeaveTypeViewModel
    {
       public int Id  { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name   { get; set; }
        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1,25,ErrorMessage ="Please Enter A valid Number")]
        public int DefaultDays   { get; set; }
    }
}
