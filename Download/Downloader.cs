using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Download
{
    class Downloader
    {
        public static void Download(string url)
        {
            try
            {
                Uri uri = new Uri(url);
                string fileName = File.SetName(uri);
                WebClient webClient = new WebClient();

                try
                {
                    File.TryOverWrite(ref fileName, uri);
                    Download(uri, fileName, webClient);
                }

                catch (WebException)
                {
                    OutputHandling.Error("EMPTY INNER PATH NAME NOT LEGAL");
                    OutputHandling.Error($"UNABLE TO DOWNLOAD {fileName}, PLEASE MAKE SURE THAT THE FILE PATH IS CORRECT");
                }
            }

            catch (UriFormatException)
            {
                OutputHandling.Error("INVALID URI");
                OutputHandling.Error("INVALID URL FORMAT SPECIFIED");
            }
        }
    }
}

