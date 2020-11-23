using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class UserInfo
    {
        [Key]
        [Display(Name ="Enter Employee Number or leave blank")]
        public int EmployeeNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your correct age")]
        [Display(Name = "Enter age")]
        public int Age { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Require")]
        [Display(Name = "Select Attrition")]
        public string Attrition { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Required")]
        [Display(Name = "Select Business Travel")]
        public string BusinessTravel { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Distance from home")]
        [Display(Name = "Distance from home")]
        public int DistanceFromHome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Education number")]
        [Display(Name = "Enter Education")]
        public int Education { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Education Field")]
        [Display(Name = "Enter Education Field")]
        public string EducationField { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Department")]
        [Display(Name = "Enter Department")]
        public string Department { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Environment Satisfaction")]
        [Display(Name = "Enter Environmental Satisfaction")]
        public int EnvironmentSatisfaction { get; set; }

        public int EmployeeCount { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter job role")]
        [Display(Name = "Job Role")]
        public string JobRole { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter job level")]
        [Display(Name = "Job Level")]
        public int JobLevel { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select Marital Status")]
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter number of years worked")]
        [Display(Name = "Number Of Companies Worked")]
        public int NumCompaniesWorked { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select appropriate")]
        [Display(Name = "Over 18")]
        public string Over18 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Overtime")]
        [Display(Name = "Overtime")]
        public string OverTime { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter stock option level")]
        [Display(Name = "Stock Option Level")]
        public int StockOptionLevel { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter of total years worked")]
        [Display(Name = "Total years Worked")]
        public int TotalWorkingYears { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter last year training time")]
        [Display(Name = "Training Time Last Year")]
        public int TrainingTimesLastYear { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Life work balance")]
        [Display(Name = "Life Work Balance")]
        public int WorkLifeBalance { get; set; }

        [Required]
        [Display(Name = "Years at Company")]
        public int YearsAtCompany { get; set; }

        [Required]
        [Display(Name = "Years At Current Role")]
        public int YearsInCurrentRole { get; set; }

        [Required]
        [Display(Name = "Years Since Last Promotion")]
        public int YearsSinceLastPromotion { get; set; }

        [Required]
        [Display(Name = "Years With Current Manager")]
        public int YearsWithCurrManager { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Correct Password")]
        [DataType(DataType.Password)]
        public string emplyee_password { get; set; }
    }
}
