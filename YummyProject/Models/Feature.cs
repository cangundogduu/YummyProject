using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YummyProject.Models
{
    public class Feature
    {
        public int FeatureId { get; set; }

        [Required(ErrorMessage ="Resim Url Boş Bırakılamaz!")]
        public string ImageUrl { get; set; }


        [Required(ErrorMessage = "Başlık Boş Bırakılamaz!")]
        [MinLength(5,ErrorMessage ="Başlık, En az 5 karakter içermelidir.")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Açıklama Boş Bırakılamaz!")]
        [MaxLength(100,ErrorMessage ="Açıklama, Maksimum 100 karakter olmalıdır.")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Video Url Boş Bırakılamaz!")]
        public string VideoUrl { get; set; }
    }
}