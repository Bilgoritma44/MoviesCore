using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ApplicationUser
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        public string Password { get; set; }
        
        public string UserRole { get; set; }
    }
}
