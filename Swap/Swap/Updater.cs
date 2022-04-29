using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    public partial class Updater : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Updater()
        {
            InitializeComponent();
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            /* tbh i dont like that code, If i ever make this open source, you can make a fork or pull request. */
            // ^^ this was from 2020 or so, Regards, Storm - 2022
            siticoneCircleProgressBar1.Value = 23;

            var wc = new WebClient();
            wc.DownloadFile(Config.latestDownload, Config.path + "/Nora.exe");
            siticoneCircleProgressBar1.Value = 45;
            wc.DownloadFile(Config.latestDownloadDll1, Config.path);
            wc.DownloadFile(Config.latestDownloadDll2, Config.path);
            wc.DownloadFile(Config.latestDownloadDll3, Config.path);
            wc.DownloadFile(Config.latestDownloadDll4,Config.path);
            siticoneCircleProgressBar1.Value = 90;
            wc.DownloadFile(Config.latestDownloadDll5, Config.path);
            wc.DownloadFile(Config.latestDownloadDll6, Config.path);
            siticoneCircleProgressBar1.Value = 100;
            pdnctu.Text = "Launching...";
            Thread.Sleep(2000);
            Process.Start("Nora.exe");
            Application.Exit();
        }
    }
}
