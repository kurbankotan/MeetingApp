using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad alanı zorunludur. Lütfen Ad alanını doldurunuz.")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Telefon alanı zorunludur. Lütfen Telefon alanını doldurunuz.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="Eposta alanı zorunludur. Lütfen Eposta alanını doldurunuz.")]
        [EmailAddress(ErrorMessage ="Eposta formatı hatalı. Lütfen Eposta alanını kontrol ediniz.")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Katılım Durumu alanı zorunludur. Lütfen katılma durumunuzu belirtiniz.")]
        public bool? WillAttend { get; set; }
    }
}