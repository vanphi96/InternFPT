using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AccountModel
    {
        [Key]
        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "Bạn phải đăng nhập tài khoản")]
        public string UserName { get; set; }

        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "Bạn phải đăng nhập tài khoản")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public bool Admin { get; set; } = false;
    }
}
