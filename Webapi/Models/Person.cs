
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Webapi
{
    public class Person
    {
        [Display(Name = "First name")]
        [Required(ErrorMessage ="First name mustn't empty")]
        public string FirstName {get; set;}
        [Display(Name = "Last name")]
        [Required(ErrorMessage ="First name mustn't empty")]
        public string LastName {get; set;}
        public string Gender {get; set;}
        
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth {get; set;}
        [Display(Name = "Phone number")]
        public string PhoneNumber {get; set;}
        [Display(Name = "Birth place")]
        public string BirthPlace {get; set;}
        [Display(Name = "Graduated")]
        public bool isGraduated {get; set;}
        // [Display(Name = "Start date")]
        // [DataType(DataType.Date)]
        // public DateTime _StarDate {get; set;}
        // [Display(Name = "End date")]
        // [DataType(DataType.Date)]
        // public Nullable<DateTime> _EndDate {get; set;}
        
    }
    
}