using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class EditUser
    {
        [Key]
        public int EmployeeNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Hourley Rate")]
        [Display(Name = "Enter Hourly Rate")]
        public double HourlyRate { get; set; }

 
        [Display(Name = "Enter Daily Rate")]
        public double DailyRate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Montley Rate")]
        [Display(Name = "Enter Monthley Rate")]
        public double MonthlyRate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Montley Income")]
        [Display(Name = "Enter Montley Income")]
        public double MonthlyIncome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Percentage Of Salary Hike")]
        [Display(Name = "Enter Percentage of Salary hike")]
        public int PercentSalaryHike { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Standard Working Hours")]
        [Display(Name = "Enter Standard Working Hours")]
        public int StandardHours { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Select if Overtime")]
        [Display(Name = "Select if Overtime")]
        public string OverTime { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Job Involvement")]
        [Display(Name = "Enter Job Involvement")]
        public int JobInvolvement { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Job Satistfaction")]
        [Display(Name = "Enter Job Satistfaction")]
        public int JobSatisfaction { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Job Perfomance Rating")]
        [Display(Name = "Enter Perfomance Rating")]
        public int PerformanceRating { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Relationship Satisfaction")]
        [Display(Name = "Enter Relationship Satisfaction")]
        public int RelationshipSatisfaction { get; set; }

    }
}
