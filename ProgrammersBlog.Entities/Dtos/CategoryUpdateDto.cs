using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [MaxLength(70, ErrorMessage = "{0} alanı maksimum {1} karakter alabilir.")]
        [MinLength(3, ErrorMessage = "{0} alanı minimum {1} karakter olmalıdır.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} alanı maksimum {1} karakter alabilir.")]
        [MinLength(3, ErrorMessage = "{0} alanı minimum {1} karakter olmalıdır.")]
        public string Description { get; set; }
        [DisplayName("Kategori Özel Not Alanı")]
        [MaxLength(500, ErrorMessage = "{0} alanı maksimum {1} karakter alabilir.")]
        [MinLength(3, ErrorMessage = "{0} alanı minimum {1} karakter olmalıdır.")]
        public string Note { get; set; }
        [DisplayName("Kategori Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public bool IsActive { get; set; }
        [DisplayName("Kategori Silindi Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public bool IsDeleted { get; set; }
    }
}
