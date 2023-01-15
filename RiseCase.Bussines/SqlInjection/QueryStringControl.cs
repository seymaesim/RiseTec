using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RiseCase.Bussines.SqlInjection
{
    public  class QueryStringControl
    {
        public static string QueryClear(string query)
        {

            string[] tehlikeliIfadeler = { "--", ";", "@@", "@", "char", "nchar", "varchar", "nvarchar", "alter", "begin", "cast", "create", "cursor", "declare", "delete", "drop", "end", "exec", "execute", "fetch", "insert", "kill", "open", "select", "sys", "sysobjects", "syscolumns", "table", "update" };

            foreach (string ifade in tehlikeliIfadeler)
            {
                if (query != null)
                {
                    query = Regex.Replace(query, ifade, "x");

                }

            }

            return query;

        }
    }
}
