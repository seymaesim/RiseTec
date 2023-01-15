using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.Bussines.DAL
{
    public class ReportsDAL
    {

    }
    public class UserDetailReport
    {
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string Firma { get; set; } = string.Empty;
        public string IletisimTipi { get; set; } = string.Empty;
        public string IletisimBilgisi { get; set; } = string.Empty;
    }
    public class UserDetailLocationCountReport
    {
        public string Konum { get; set; } = string.Empty;
        public int KisiSayisi { get; set; }
    }
    public class UserDetailLocationNumberCountReport
    {
        public string Konum { get; set; } = string.Empty;
        public int KisiTelefonSayisi { get; set; }
    }
}
