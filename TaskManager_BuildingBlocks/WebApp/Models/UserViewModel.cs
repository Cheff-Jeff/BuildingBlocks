using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class UserViewModel
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string RePassword { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        public string Salt { get; set; }


        public string HiddenPassword = "******";


        public List<UserViewModel> listusers = new List<UserViewModel>();

        public UserViewModel()
        {

        }

        public UserViewModel(int id, string email, bool isadmin)
        {
            this.UserId = id;
            this.Email = email;
            this.IsAdmin = isadmin;
        }
    }
}
