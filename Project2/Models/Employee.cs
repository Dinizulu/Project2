using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    [Table("emplyee_details")]
    public class Employee
    {
        [Key]
        public int EmployeeNumber { get; set; }
        public string Department { get; set; }
        public string EducationField { get; set; }
        public double HourlyRate { get; set; }
        public double MonthlyIncome { get; set; }
        public double MonthlyRate { get; set; }
    }
}
