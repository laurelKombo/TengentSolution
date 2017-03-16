using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_Assesment.Models
{
    public class UserClienSite
    {
        [Required(ErrorMessage = "Username required.", AllowEmptyStrings = false)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password required.", AllowEmptyStrings = false)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}