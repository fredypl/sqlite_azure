using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;
using sqlite_azure.iOS;
using SQLite;


using Foundation;
using UIKit;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace sqlite_azure.iOS
{
   public class SQLite_IOS : ISQLite
    {
        public string GetLocalFilePath(string filename)

        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");


            if (!Directory.Exists(libFolder))

            {
                Directory.CreateDirectory(libFolder);
            }


            return Path.Combine(libFolder, filename);

        }
    }
}