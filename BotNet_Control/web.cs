using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BotNet_Control
{
    static class web
    {
        public static string GetHTML(string URI)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Proxy = null;

                return wc.DownloadString(URI);
            }
        }

        public static string SendPOST(string URI, string PostData)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Proxy = null;

                return wc.UploadString(URI, "POST", PostData);
            }
        }
    }
}
