using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string ProducerPhoto { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string ProducerName { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [StringLength(int.MaxValue, ErrorMessage = "Bu Alanda En Az 25 Karakter kullanılmalıdır.", MinimumLength = 25)]
        public string ProducerBio { get; set; }

        public List<Movie> Movie { get; set; }
    }
}
