using System.ComponentModel.DataAnnotations;

namespace TravelReservation.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı Alanı Zorunludur.")]
        public string username { get; set; }
        [Required(ErrorMessage = "Şifre Alanı Zorunludur.")]
        public string password { get; set; }
    }
}
