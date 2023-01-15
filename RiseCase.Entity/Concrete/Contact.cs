using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.Entity.Concrete
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = true)]
        public int KindID { get; set; }

        [Required(AllowEmptyStrings = true)]
        public int UserID { get; set; }

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        public string? ContactValue { get; set; } = null;
    }
}
