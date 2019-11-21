using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Download
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = InputHandling.ReadString("Url to download from: ");
            Downloader.Download(url);
        }
    }
}
