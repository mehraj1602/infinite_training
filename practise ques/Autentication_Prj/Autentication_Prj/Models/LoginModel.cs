using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Autentication_Prj.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="please enter user name")]
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}