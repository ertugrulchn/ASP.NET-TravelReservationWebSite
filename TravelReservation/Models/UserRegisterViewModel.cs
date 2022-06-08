using System.ComponentModel.DataAnnotations;

namespace TravelReservation.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Yazınız.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Yazınız.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Yazınız.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresini Yazınız.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Yazınız.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Yazınız.")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
