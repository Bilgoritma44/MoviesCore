using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Gallery
    {
        [Key]
        public int PhotoId { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string PhotoName { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string PhotoUrl { get; set; }
    }
}
