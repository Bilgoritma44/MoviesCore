using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [StringLength(int.MaxValue, ErrorMessage = "Bu Alanda En Az 25 Karakter kullanılmalıdır.", MinimumLength = 25)]
        public string CategoryDescription { get; set; }

        public List<Movie> Movie { get; set; }
    }
}
