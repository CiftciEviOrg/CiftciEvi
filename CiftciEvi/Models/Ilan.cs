using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.Models
{
    public class Ilan
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Eposta gereklikdir."),DataType(DataType.Text)]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "Açıklama Alanı Boş Bırakılamaz"), DataType(DataType.Text)]
        [Display(Name = "Ilan hakkında bilgi veriniz...")]
        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Fiyat gereklidir."), DataType(DataType.Currency)]
        public decimal Fiyat { get; set; }


        public string Kimden { get; set; }

        public Resim Resim { get; set; }

        public DateTime Tarih { get; set; }

        public Durum Durum { get; set; }

        public Adres Adres { get; set; }

        public Onay Onay { get; set; }

    }
}
