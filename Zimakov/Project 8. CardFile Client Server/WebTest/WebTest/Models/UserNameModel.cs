using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTest.Models
{
    public class UserNameModel
    {
        [Required(ErrorMessage = "Представьтесь, пожалуйста")]
        public string UserName { get; set; }
        public string UserAge { get; set; }
    }
}