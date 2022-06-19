using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //Model validation için eklememiz gerekiyor

namespace AspNetMVCEgitimi.NETFramework.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz!"), StringLength(50)]   //Required attribute ü property nin üzerine eklenir ve o property i zorunlu hale getirir. 
        public string Ad { get; set; }
        [Required, StringLength(50)] 
        public string Soyad { get; set; }
        [Required]
        [EmailAddress]  //aşağıdaki alanın email tipinde olmasını sağlar. 
        public string Email { get; set; }
        [Phone]
        public string Telefon { get; set; }
        [Required]
        [Display(Name = "TC Kimlik Numarası")]  //Display ile property adını ekranda farklı isimle gösterebiliriz
        [MinLength(11, ErrorMessage = "TC Kimlik Numarası en az 11 karakter olmalıdır")]  //Bu alana girilebilecek minimum karakter sayısı 
        [MaxLength(11, ErrorMessage = "TC Kimlik Numarası en fazla 11 karakter olmalıdır")]  //Bu da 11 karakterden fazla olmaması için yazdık. 
        public string TcKimlikNo { get; set; }
        [Display(Name = "Doğum Tarihi"), DisplayFormat(DataFormatString = "{0:dd.MM.yyy}"), DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Şifre"), DataType(DataType.Password)]
        [StringLength(10, ErrorMessage = "{0} {2} karakterden uzun olmalı", MinimumLength = 5)]
        public string Sifre { get; set; }
        [Display(Name = "Şifrenizi Tekrar Giriniz"), DataType(DataType.Password)]
        [Compare("Sifre")]  //SifreTekrar alanını Sifre alanı ile karşılaştır
        public string SifreTekrar { get; set; }

    }
}