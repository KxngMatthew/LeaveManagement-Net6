using System.ComponentModel.DataAnnotations;

namespace LeaveManagementApp.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string? Name { get; set; }

        [Display(Name = "Default Number of Days")]
        [Required]
        public int DefaultDays { get; set; }
    }
}
