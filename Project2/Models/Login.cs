using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class Login
    {
        [Key]
        public int employee_id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage ="Please Provide email")]
        [Display(Name ="Employee Email")]
        [DataType(DataType.EmailAddress)]
        public string employee_email { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Please Enter Correct Password")]
        [Display(Name ="Enter Password")]
        [DataType(DataType.Password)]
        public string employee_password { get; set; }

        [Display(Name = "Enter User Role")]
        [Required]
        public string employee_role { get; set; }

    }
}
