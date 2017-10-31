using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using sqlite_azure;

namespace sqlite_azure
{
   public  interface ISQLite
    {
        string GetLocalFilePath(string filename);
    }
}
