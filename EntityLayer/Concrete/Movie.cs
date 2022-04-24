using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [StringLength(int.MaxValue,ErrorMessage ="Bu Alanda En Az 25 karakter kullanmalısın..",MinimumLength =25)]
        public string MovieDescription { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string MovieName { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string MovieImageUrl { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public DateTime MovieCreateDate { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string MovieStatus { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        //Actor Foeing Key
        public int ActorId { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public Actor Actor { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        //Producer Foreing Key
        public int ProducerId { get; set; }

        public Producer Producer { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        //Category Foreing Key
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        //Cinema ForeignKey
        public int CinemaId { get; set; }

        public Cinema Cinema { get; set; }
    }
}
