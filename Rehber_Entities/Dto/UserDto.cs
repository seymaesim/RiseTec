using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rehber_Entities.Dto
{
    public class UserDto
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
    }
}
