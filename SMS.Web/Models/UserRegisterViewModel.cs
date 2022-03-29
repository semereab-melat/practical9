using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using SMS.Data.Models;

namespace SMS.Web.Models
{
    // need separate registerview model for register remote validation which is not needed in login
    public class UserRegisterViewModel
    {       
        [Required]
        public string Name{ get; set;  }
        [Required]
        [EmailAddress]
        public string Email{ get; set;  }
        [Required]
        public string Password{ get; set;  }

       [Compare("Password", ErrorMessage ="Password do not match!")]
        public string PasswordConfirm{ get; set;  }
        [Required]
        public Role Role{ get; set;  }

    }
}