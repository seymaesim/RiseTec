using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.Entity.Concrete
{
    public class Kind
    {
        [Key]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        public string? TurAdi { get; set; }
    }
}
