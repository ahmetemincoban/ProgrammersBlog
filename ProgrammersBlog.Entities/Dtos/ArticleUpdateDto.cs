using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Entities.Dtos
{
    public class ArticleUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} Alanı Maksimum {1} Karakter Alabilir.")]
        [MinLength(5, ErrorMessage = "{0} Alanı Minimum {1} Karakter Alabilir.")]
        public string Title { get; set; }
        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MinLength(20, ErrorMessage = "{0} Alanı Minimum {1} Karakter Alabilir.")]
        public string Content { get; set; }
        [DisplayName("Thumbnail")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(250, ErrorMessage = "{0} Alanı Maksimum {1} Karakter Alabilir.")]
        [MinLength(5, ErrorMessage = "{0} Alanı Minimum {1} Karakter Alabilir.")]
        public string Thumbnail { get; set; }
        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [DisplayName("Yazar Adı")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} Alanı Maksimum {1} Karakter Alabilir.")]
        [MinLength(1, ErrorMessage = "{0} Alanı Minimum {1} Karakter Alabilir.")]
        public string SeoAuthor { get; set; }
        [DisplayName("Seo Açıklama")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(150, ErrorMessage = "{0} Alanı Maksimum {1} Karakter Alabilir.")]
        [MinLength(1, ErrorMessage = "{0} Alanı Minimum {1} Karakter Alabilir.")]
        public string SeoDescription { get; set; }
        [DisplayName("Seo Etiketler")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} Alanı Maksimum {1} Karakter Alabilir.")]
        [MinLength(0, ErrorMessage = "{0} Alanı Minimum {1} Karakter Alabilir.")]
        public string SeoTags { get; set; }
        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [DisplayName("Yayınlansın Mı?")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        public bool isActive { get; set; }
        [DisplayName("Silinsin Mi?")]
        [Required(ErrorMessage = "{0} Alanı Boş Geçilmemelidir.")]
        public bool isDeleted { get; set; }
        
    }
}
