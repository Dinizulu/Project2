using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project2.Models
{
    [Table("employees")]
    public partial class User
    {
        [Key]
        public int employee_id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string employee_Fname { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string employee_Lname { get; set; }

        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string employee_email { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Minimum 8 Characters required")]
        public string employee_password { get; set; }

        [Display(Name = "Re-enter Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("employee_password",ErrorMessage ="Password Entered does not match!")]
        public string password { get; set; }

        [Display(Name ="Enter Select Role")]
        [Required]
        public string employee_role { get; set; }
    }
}

