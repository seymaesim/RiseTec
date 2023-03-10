using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.Entity.Concrete
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        public string? Ad { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        public string? SoyAd { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        public string? Firma { get; set; } 
    }
}
