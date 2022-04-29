using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    class Config
    {
        // bunch of path's and Links.
        public static WebClient wc = new WebClient();
        public static JObject api = JObject.Parse(wc.DownloadString("https://api.zhitslikeflexzh.repl.co/api/v1/api.json"));
        public static string ld = api["Swapper"]["link"].ToString();
        public static string ld1 = api["Swapper"]["linkDLL1"].ToString();
        public static string ld2 = api["Swapper"]["linkDLL2"].ToString();
        public static string ld3 = api["Swapper"]["linkDLL3"].ToString();
        public static string ld4 = api["Swapper"]["linkDLL4"].ToString();
        public static string ld5 = api["Swapper"]["linkDLL5"].ToString();
        public static string ld6 = api["Swapper"]["linkDLL6"].ToString();
        public static string path = Environment.CurrentDirectory;
        public static string latestDownload = ld;
        public static string latestDownloadDll1 = ld1;
        public static string latestDownloadDll2 = ld2;
        public static string latestDownloadDll3 = ld3;
        public static string latestDownloadDll4 = ld4;
        public static string latestDownloadDll5 = ld5;
        public static string latestDownloadDll6 = ld6;

        public static void CheckDlls()
        {
            if (File.Exists(Environment.CurrentDirectory + "/Bunifu_UI_v1.52.dll"))
            {

            }
            else
            {
                MessageBox.Show("Please put all dlls In 1 Single Folder With The Swapper!", "Error");
                Application.Exit();
            }
        }
    }
}
