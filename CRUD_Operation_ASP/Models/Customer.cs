using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CRUD_Operation_ASP.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required(ErrorMessage ="First Name is Required")]
        [RegularExpression("^([a-zA-Z]{2,}[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}?([a-zA-Z]{1,})?)", ErrorMessage ="Invalid Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Second Name is Required")]
        [RegularExpression("^([a-zA-Z]{2,}[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}?([a-zA-Z]{1,})?)", ErrorMessage = "Invalid Name")]

        public string SecondName { get; set; }
        [Required(ErrorMessage = "Phone Number is Required")]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Invalid Number")]
        

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please Provide Your Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Provide Your Email")]
        [RegularExpression(@"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+", ErrorMessage = "Invalid Number")]


        public string Email { get; set; }

        [Required(ErrorMessage = "Address is Required")]

        public string Address { get; set; }
        [Required(ErrorMessage = "City is Required")]

        public string City { get; set; }
        [Required(ErrorMessage = "State is Required")]

        public string State { get; set; }
        [Required(ErrorMessage = "Country is Required")]

        public string Country { get; set; }
        public bool IsBusiness { get; set; }
        public bool IsDelivery { get; set; }
        public bool IsVisiting { get; set; }
        public bool IsOther { get; set; }



    }
}