using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCoreTest.Shared
{
    public class Employee
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EmployeeId { get; set; }

        [Required]
        //[StringLength(50, ErrorMessage = "Name must be 1-50 characters long", MinimumLength = 1)]
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [Required]
        //[StringLength(50, ErrorMessage = "Name must be 1-50 characters long", MinimumLength = 1)]
        [DisplayName("Last name")]
        public string LastName { get; set; }
        [DisplayName("Date of birth")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }

        
        public Employee()
        {
            FirstName = "undefined";
            LastName = "undefined";
        }

    }



}