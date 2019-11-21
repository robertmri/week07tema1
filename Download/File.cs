using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Download
{
    class File
    {
        public static void Rename(ref string fileName, Uri uri)
        {
            StringBuilder fileNameSB = new StringBuilder();
            fileNameSB.Append(DateTime.Now.ToString("MMddyyyyhhmmss"));
            fileNameSB.Append(" - ");
            fileNameSB.Append(Path.GetFileName(uri.LocalPath));
            fileName = fileNameSB.ToString();
        }
        public static string SetName(Uri uri)
        {
            StringBuilder fileName = new StringBuilder();
            fileName.Append(Path.GetFileName(uri.LocalPath));
            return fileName.ToString();
        }
    }
}
