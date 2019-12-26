using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Layer
{
    public static class Helper
    {
        public static string Connection(string connection)
        {
            return ConfigurationManager.ConnectionStrings[connection].ConnectionString;
        }
    }
}
