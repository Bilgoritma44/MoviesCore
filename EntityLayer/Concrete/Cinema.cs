using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string CinemaLogo { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string CinemaName { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [StringLength(int.MaxValue,ErrorMessage ="{0} Bu Alanda En Az 25 Karakter kullanılmalıdır.",MinimumLength =25)]
        public string CinemaDescription { get; set; }

        public List<Movie> Movie { get; set; }
    }
}
