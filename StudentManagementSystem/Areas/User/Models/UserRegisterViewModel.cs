using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Areas.User.Models
{

    //bu view modelin içerisine olmasını istediğimiz alanları yazacağız
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını girin")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifre girin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen mail girin")]
        public string Mail { get; set; }
    }
}
