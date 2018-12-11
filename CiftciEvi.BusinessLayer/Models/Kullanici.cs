using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    public class Kullanici
    {
        public int Id { get; set; }

        //[Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage ="İsim Giriniz."),DataType(DataType.Text)]
        [Display(Name ="İsim")]
        public string Adi { get; set; }

        [Required(ErrorMessage ="Soyisim Giriniz."), DataType(DataType.Text)]
        public string Soyadi { get; set; }

        [Required(ErrorMessage ="Eposta gereklikdir."), DataType(DataType.EmailAddress,ErrorMessage ="Geçerli bir E-Posta hesabı giriniz.")]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Sifre { get; set; }

        [Required, DataType(DataType.Password)]
        [Compare("Sifre",ErrorMessage ="Şifreler Uyuşmuyor.")]
        [Display(Name ="Şifre Doğrulama")]
        public string SifreConfirm { get; set; }


        [Required(ErrorMessage ="Cep Telefonu Giriniz.")]
        [Display(Name ="Cep Telefonu")]
        [Phone(ErrorMessage ="Uygun bir cep telefonu giriniz.")]
        public string Cep { get; set; }

        public bool Adminmi { get; set; }
    }
}
