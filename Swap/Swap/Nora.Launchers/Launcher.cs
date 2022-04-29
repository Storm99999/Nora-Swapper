using Nora.RPC;
using Swap.Swaps;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Swap.Nora.Launchers
{
    public partial class Launcher : Form
    {
        // well. theres no way to activate it through the api, so you have to remove that part yourself.
        // Not doing it, because it should be the the most original version of nora.
        // Storm - 2022
        [DllImport("user32.DLL")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
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
        // dont care if you take some inspiration or straight up copy this,
        // I don't play fortnite.
        // I probably won't even discover you.
        // Storm - 2022
        public Launcher()
        {
            this.Text = string.Empty;
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }
        // this source code is heavily broken, but it's the only build i could find.
        // Sorry!
        // Storm - 2022
        private void Launcher_Load(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            // show launcher
            new UI().Show();
            // hide this form
            this.Hide();
        }

    
       

        private void Launcher_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 274, 61458, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            API.StartDiscord();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // lol, quite funny, As i'm releasing this anyway lmfao.
            MessageBox.Show("lol u thought");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
