using RiseCase.Bussines.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseCase.Bussines.Abstract
{
    public interface IReportsService : IGenericService<ReportsDAL>
    {
        IEnumerable<UserDetailReport> UserDetailList();
        IEnumerable<UserDetailLocationCountReport> UserLogationCountList();

        IEnumerable<UserDetailLocationCountReport> UserLocationCountParameterList(string konum);
        IEnumerable<UserDetailLocationNumberCountReport> UserLocationNumberCountParameterList(string konum);
    }
}
