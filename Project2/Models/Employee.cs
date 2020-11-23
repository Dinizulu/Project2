using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    [Table("emplyee_details")]
    public partial class Employee
    {
        [Key]
        public int EmployeeNumber { get; set; }
        public int Age { get; set; }
        public string Attrition { get; set; }
        public string BusinessTravel { get; set; }
        public int DistanceFromHome { get; set; }
        public int Education { get; set; }
        public int EnvironmentSatisfaction { get; set; }
        public int EmployeeCount { get; set; }
        public string Gender { get; set; }
        public string JobRole { get; set; }
        public int JobLevel { get; set; }
        public int JobInvolvement { get; set; }
        public int JobSatisfaction { get; set; }
        public int RelationshipSatisfaction { get; set; }
        public int PerformanceRating { get; set; }
        public string MaritalStatus { get; set; }
        
        public int NumCompaniesWorked { get; set; }
        public string Department { get; set; }
        public string EducationField { get; set; }
        public double DailyRate { get; set; }
        public double HourlyRate { get; set; }
        public double MonthlyIncome { get; set; }
        public double MonthlyRate { get; set; }
        public int PercentSalaryHike { get; set; }
        public string Over18 { get; set; }
        public int StandardHours { get; set; }
        public string OverTime { get; set; }
        public int StockOptionLevel { get; set; }
        public int TotalWorkingYears { get; set; }
        public int TrainingTimesLastYear { get; set; }
        public int WorkLifeBalance { get; set; }
        public int YearsAtCompany { get; set; }
        public int YearsInCurrentRole { get; set; }
        public int YearsSinceLastPromotion { get; set; }
        public int YearsWithCurrManager { get; set; }

        public string emplyee_password { get; set; }
    }
}
