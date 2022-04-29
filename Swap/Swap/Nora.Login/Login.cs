using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Nora.RPC;
using Swap.data;
using Swap.Swaps;


namespace Swap.Nora.Login
{


    public partial class Login : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Login()
        {
            this.FormBorderStyle = FormBorderStyle.None; // do shit
            InitializeComponent();
        }

        private void siticoneRoundedGradientButton1_Click(object sender, EventArgs e)
        {
            // Paid Accounts Note: 
            // this will change in Updates so you don't crack it +  It doesn't have a logn rn
            //string username = "NoraPremiumDevVERSION320x_dkOWEKxapaeE";
            //string accountText = "Nora Premium: you we're active in Chat And got Nora Premium. Thanks for your Support! now you get the unreleased Versions of Nora early + you have *FULL* acess to any Cosmetic that is paid/VIPs (*only*) Enjoy!";
            // string password = "NoraPremium";
            //if (siticoneRoundedTextBox1.Text == username && siticoneRoundedTextBox2.Text == password)
            //{
            // download the api to the path (.json file as i like to read it from a json file, you can use a other method but yeah.)
            //string path = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Nora-Swapper";
            //string premiumUserAccountName = "Premium/Paid User";
            // MessageBox.Show($"Logged In As : {premiumUserAccountName} \n\n\n\n\n\n\n\n {accountText}", "Nora Swapper", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // new Nora.Launchers.Launcher().Show();
            //this.Hide();
            //}
            // else
            // {
            //string GetAccountLoginERROR = "Invalid Username Or Password. Please Try again, If that does the same -thing Contact a Mod or admin in our Discord.";
            // string title = "Nora Login";
            //    MessageBox.Show(GetAccountLoginERROR, title);
        }
        //}




        private void siticoneRoundedGradientButton2_Click(object sender, EventArgs e)
        {
            // checks in the api if free login is avaible.
            API.GetLogin();
            this.Hide();
        }

        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Login_Load(object sender, EventArgs e)
            
        {
            
            var client = new WebClient();
            if (client.DownloadString("https://api.zhitslikeflexzh.repl.co/api/Items/downtime2.txt").Contains("true"))
            {
                WebClient wc = new WebClient();
                JObject api = JObject.Parse(wc.DownloadString("https://api.zhitslikeflexzh.repl.co/api/v1/api.json"));
                string text = api["downtime"]["text"].ToString();
                string ending = api["downtime"]["ending"].ToString();
                string creator = api["swapper"]["creator"].ToString();
                string developer = api["swapper"]["developer"].ToString();
                MessageBox.Show($"Sorry, however {text}. \nDowntime will end at {ending}.\nDeveloped by {creator} and {developer}", "Nora Swapper", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Commands.commands.Command("HideControl");
            }
            else
            {

            }
        }
        
        public void backup(object sender, EventArgs e)
        {
            try
            {

                new Options().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOG: ERROR going to options.");

            }
        }

        private void siticoneCustomGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Drag Form for cool ui
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void siticoneRoundedGradientButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void siticoneRoundedGradientButton1_Click_1(object sender, EventArgs e)
        {

        }

        public void siticoneButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry but we had to disable Nitro Boosters paid login as we experienced some issues.\nHopefully we bring it back in future updates.");
            //if (siticoneRoundedTextBox1.Text == "")
            //{
            // MessageBox.Show("Sorry but u cant login with blank information. Try again.");
            //}
            //else
            //{
            // var client = new WebClient();
            //if (client.DownloadString("https://jimssusstormauthalllogs.iwxjim.repl.co/Api/var.txt").Contains(siticoneRoundedTextBox1.Text) && client.DownloadString("https://jimssusstormauthalllogs.iwxjim.repl.co/Api/var2.txt").Contains(siticoneRoundedTextBox2.Text))
            // {
            // user.paid = true;
            //MessageBox.Show("Thanks for nitro boosting Nora \nHere are your premium items skins-pickaxes-emotes", "Nitro Booster");
            //Hide();
            //   MessageBox.Show("Please make sure to open settings in the menu select your fortnite paks path and click 'Create Backups' button . If u dont do it none of the swaps will work.");
            // new UI().Show();
            //  new Options().Show();


            //}
            // else
            //  {
            // MessageBox.Show("Hey, sorry! but you entered the wrong details. Try again.");

            // }
            // }
        }


        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            user.paid = true;
            Hide();
            MessageBox.Show("NOTE : After Clicking 'Ok' A Menu will appear which u will have to select your fortnite paks then press the Create Backups Button In order for every swap to work(When Swapper Is responsible again that means backups were created).\nIf you ever wish to revert all items click The button revert all (When the swapper is responsible again that means everything reverted).");
            new UI().Show();
            new Options().Show();
        }

        private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void siticoneButton4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/DFPVtTPzuE");
        }

        private void siticoneButton4_Click_1(object sender, EventArgs e)
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
    }
}
