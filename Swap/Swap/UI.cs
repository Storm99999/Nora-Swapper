using Nora.RPC;
using Nora.Searchers.Tool.Researcher;
using Swap.data;
using Swap.Nora.Commands;
using Swap.Swaps;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Swap
{
    public partial class UI : Form
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

        public static void SwapStrings(string pak, long offset, string Codes)
        {
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(Codes);
            binaryWriter.Close();
        }
        public static void RevertStrings(string pak, long offset, string Codes)
        {
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(Codes);
            binaryWriter.Close();
        }


        private long offset = 245365;
        private long offset1 = 2324;
        string CODE_BODY = "20x0238X0593lxX293019rxX";
        string CODE_HEAD = "12x9310X92310X439";
        
        public UI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.skins1.Hide();
            this.emotes1.Hide();
            this.backblings1.Hide();
        }
        string filePath = Options.GetPaksFolder + "/pakchunk10_s2-WindowsClient.pak";

        private void button1_Click(object sender, EventArgs e)
        {
            SwapStrings(filePath, offset, CODE_BODY);
            SwapStrings(filePath, offset1, CODE_HEAD);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo FVI = FileVersionInfo.GetVersionInfo(assembly.Location);
            if (FVI.FileVersion == "1.0.0.0")
            {
                MessageBox.Show("A new update has been detected!", "Nora Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Updater().Show();
                Hide();
            }
            else
            {
                
            }
            API.CheckIfCanUseSwapper();
            RPC.InitalizeRPC(); // wh
            pickAxes1.Hide();

            if (user.paid == true)
            {
                paidLabel.Text = "Paid: True";
            }
            else
            {
                paidLabel.Text = "Paid: False";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Stream stream = File.OpenRead(filePath);
            try
            {
                foreach (long offset in Researcher.FindPosition(stream, 0, offset, CODE_BODY))
                {
                    stream.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(filePath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.Write(CODE_HEAD);
                    binaryWriter.Close();
                    MessageBox.Show("Done");
                }
            }
            finally
            {
            }
        }

        private void siticoneCirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {
            pickAxes1.Hide();
            skins1.Show();
            this.emotes1.Hide();
            this.backblings1.Hide();
            news1.Hide();
            RPC.client.UpdateDetails("Browsing Skins");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.skins1.Hide();
            pickAxes1.Hide();
            this.backblings1.Hide();
            this.emotes1.Hide();
            news1.Hide();
        }

        private void siticoneCirclePictureBox2_Click(object sender, EventArgs e)
        {
            RPC.client.UpdateDetails("Browsing BackBlings");
            backblings1.Show();
            this.skins1.Hide();
            pickAxes1.Hide();
            this.emotes1.Hide();
            news1.Hide();
        }

        private void siticoneCirclePictureBox3_Click(object sender, EventArgs e)
        {
            RPC.client.UpdateDetails("Browsing Emotes");
            pickAxes1.Hide();
            this.backblings1.Hide();
            this.emotes1.Show();
            this.skins1.Hide();
            news1.Hide();
        }

        private void siticoneCirclePictureBox4_Click_1(object sender, EventArgs e)
        {
            RPC.client.UpdateDetails("Selecting Options");
            new Options().Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void skins1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneCirclePictureBox5_Click(object sender, EventArgs e)
        {
            commands.Command("HideControl");
        }

        private void siticoneCirclePictureBox6_Click(object sender, EventArgs e)
        {
            /* ok, fuck pickaxes. */
            RPC.client.UpdateDetails("Browsing Pickaxes");
            pickAxes1.Show();
            this.backblings1.Hide();
            news1.Hide();
            this.emotes1.Hide();
        }

        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void pickAxes1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneCirclePictureBox5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Credits to itzpaul#4361 for plenty of new working codes" +
                ", to ɪwx jɪm유#6969 for fixing nearly every bug on nora and updating codes " +
                ", To all of our developers  , to xoid plays MANY CODES and ofcourse to Storm.#1020 the owner and the main developer of our swapper");

            DialogResult dialogResult = MessageBox.Show("Xoid Plays Discord Server (many codes)", "Xoid Plays", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("https://discord.gg/3rmrVVPqkH");
            }
            else if (dialogResult == DialogResult.No)
            {

            }

            DialogResult dialogResult1 = MessageBox.Show("ITZPAUL SWAPPER Discord Server (some codes)", "itzpaul#4361", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("https://discord.gg/qBhKDW48xd");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void siticoneCirclePictureBox7_Click(object sender, EventArgs e)
        {
            

        }

        private void emotes2_Load(object sender, EventArgs e)
        {
            
        }

        private void paidLabel_Click(object sender, EventArgs e)
        {

        }

        private void emotes1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneCirclePictureBox7_Click_1(object sender, EventArgs e)
        {
            news1.Show();
            /* Custom news go brrr. */
            RPC.client.UpdateDetails("Browsing Custom News");
            this.backblings1.Hide();
            this.emotes1.Hide();
        }
    }
    }

