using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Required(ErrorMessage ="Bu Alan Boş Geçilemez")]
        public string ActorPhoto { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string ActorName { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [StringLength(int.MaxValue,ErrorMessage ="Bu Alanda En Az 25 Karakter Kullanılmalıdr.",MinimumLength =25)]
        public string ActorBio { get; set; }

        public List<Movie> Movie { get; set; }
    }
}
