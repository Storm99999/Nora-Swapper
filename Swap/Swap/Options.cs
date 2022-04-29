using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Swap.Properties;
using Swap.Swaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        string args = "com.epicgames.launcher://apps/Fortnite?action=";

        private void Options_Load(object sender, EventArgs e)
        {
        
            TextBox_PAKS.Text = Options.GetPaksFolder;
        }

        public void button1_Click(object sender, EventArgs e)
        {
         
                // dupe ucas cuz i have no researcher :(
                try
                {
                    string paks = Options.GetPaksFolder;
                File.Copy(paks + "\\pakchunk10_s3-WindowsClient.pak", paks + "\\pakchunk100_s3-WindowsClient.pak");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s3-WindowsClient.sig", paks + "\\pakchunk100_s3-WindowsClient.sig");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s3-WindowsClient.utoc", paks + "\\pakchunk100_s3-WindowsClient.utoc");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s3-WindowsClient.ucas", paks + "\\pakchunk100_s3-WindowsClient.ucas");
                Thread.Sleep(4000);
                File.Copy(paks + "\\pakchunk10_s4-WindowsClient.pak", paks + "\\pakchunk100_s4-WindowsClient.pak");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s4-WindowsClient.sig", paks + "\\pakchunk100_s4-WindowsClient.sig");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s4-WindowsClient.utoc", paks + "\\pakchunk100_s4-WindowsClient.utoc");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s4-WindowsClient.ucas", paks + "\\pakchunk100_s4-WindowsClient.ucas");
                Thread.Sleep(4000);
                File.Copy(paks + "\\pakchunk10_s5-WindowsClient.pak", paks + "\\pakchunk100_s5-WindowsClient.pak");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s5-WindowsClient.sig", paks + "\\pakchunk100_s5-WindowsClient.sig");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s5-WindowsClient.utoc", paks + "\\pakchunk100_s5-WindowsClient.utoc");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s5-WindowsClient.ucas", paks + "\\pakchunk100_s5-WindowsClient.ucas");
                Thread.Sleep(6000);
                File.Copy(paks + "\\pakchunk10_s22-WindowsClient.pak", paks + "\\pakchunk100_s22-WindowsClient.pak");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s22-WindowsClient.sig", paks + "\\pakchunk100_s22-WindowsClient.sig");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s22-WindowsClient.utoc", paks + "\\pakchunk100_s22-WindowsClient.utoc");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s22-WindowsClient.ucas", paks + "\\pakchunk100_s22-WindowsClient.ucas");
                Thread.Sleep(6000);
                File.Copy(paks + "\\pakchunk10_s21-WindowsClient.pak", paks + "\\pakchunk100_s21-WindowsClient.pak");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s21-WindowsClient.sig", paks + "\\pakchunk100_s21-WindowsClient.sig");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s21-WindowsClient.utoc", paks + "\\pakchunk100_s21-WindowsClient.utoc");
                Thread.Sleep(2000);
                File.Copy(paks + "\\pakchunk10_s21-WindowsClient.ucas", paks + "\\pakchunk100_s21-WindowsClient.ucas");
                Thread.Sleep(6000);
                MessageBox.Show("LOG: Succesfully created Backups.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LOG: Your Paks Folder Couldnt Be found please select the pak folder right Or Your backups already exist.");
                }
        }

        private void SELECT_Click(object sender, EventArgs e)
        {
            
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Settings.Default.paksPath = dialog.FileName;
                Settings.Default.Save();
                TextBox_PAKS.Text = Settings.Default.paksPath;
            }
        }

        public static string GetPaksFolder
        {
            get { return Settings.Default.paksPath; }
        }



        public static string GetStrechedFolder
        {
            get { return Settings.Default.strechedFolder; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string paks = GetPaksFolder + "\\pakchunk100_s4-WindowsClient.ucas";
                string paks1 = GetPaksFolder + "\\pakchunk100_s5-WindowsClient.ucas";
                string paks2 = GetPaksFolder + "\\pakchunk100_s22-WindowsClient.ucas";
                string paks3 = GetPaksFolder + "\\pakchunk100_s3-WindowsClient.ucas";
                string paks4 = GetPaksFolder + "\\pakchunk100_s3-WindowsClient.pak";
                string paks5 = GetPaksFolder + "\\pakchunk100_s3-WindowsClient.sig";
                string paks6 = GetPaksFolder + "\\pakchunk100_s3-WindowsClient.utoc";
                string paks7 = GetPaksFolder + "\\pakchunk100_s4-WindowsClient.pak";
                string paks8 = GetPaksFolder + "\\pakchunk100_s4-WindowsClient.sig";
                string paks9 = GetPaksFolder + "\\pakchunk100_s5-WindowsClient.utoc";
                string paks10 = GetPaksFolder + "\\pakchunk100_s5-WindowsClient.sig";
                string paks11 = GetPaksFolder + "\\pakchunk100_s5-WindowsClient.pak";
                string paks12 = GetPaksFolder + "\\pakchunk100_s22-WindowsClient.utoc";
                string paks13 = GetPaksFolder + "\\pakchunk100_s22-WindowsClient.sig";
                string paks14 = GetPaksFolder + "\\pakchunk100_s22-WindowsClient.pak";
                string paks15 = GetPaksFolder + "\\pakchunk100_s4-WindowsClient.utoc";
                string paks16 = GetPaksFolder + "\\pakchunk100_s21-WindowsClient.utoc";
                string paks17 = GetPaksFolder + "\\pakchunk100_s21-WindowsClient.ucas";
                string paks18 = GetPaksFolder + "\\pakchunk100_s21-WindowsClient.sig";
                string paks19 = GetPaksFolder + "\\pakchunk100_s21-WindowsClient.pak";


                if (File.Exists(paks))
                {
                    Del(paks);
                }
                else
                {
                    SCBE2();
                }
                if (File.Exists(paks1))
                {
                    Del(paks1);
                }
                else
                {
                  
                }
                if (File.Exists(paks2))
                {
                    Del(paks2);
                }
                else
                {
                    
                }
                if (File.Exists(paks3))
                {
                    Del(paks3);
                }
                else
                {
                  
                }
                if (File.Exists(paks4))
                {
                    Del(paks4);
                }
                else
                {
                  
                }
                if (File.Exists(paks5))
                {
                    Del(paks5);
                }
                else
                {
                   
                }
                if (File.Exists(paks6))
                {
                    Del(paks6);
                }
                else
                {
                    
                }
                if (File.Exists(paks7))
                {
                    Del(paks7);
                }
                else
                {
                    
                }
                if (File.Exists(paks8))
                {
                    Del(paks8);
                }
                else
                {
                    
                }
                if (File.Exists(paks9))
                {
                    Del(paks9);
                }
                else
                {
                    
                }
                if (File.Exists(paks10))
                {
                    Del(paks10);
                }
                else
                {
                    
                }
                if (File.Exists(paks11))
                {
                    Del(paks11);
                }
                else
                {
                    
                }
                if (File.Exists(paks12))
                {
                    Del(paks12);
                }
                else
                {
                    
                }
                if (File.Exists(paks13))
                {
                    Del(paks13);
                }
                else
                {
                    
                }
                if (File.Exists(paks14))
                {
                    Del(paks14);
                }
                else
                {
                    
                }
                if (File.Exists(paks15))
                {
                    Del(paks15);
                }
                else
                {
                    
                }
                if (File.Exists(paks16))
                {
                    Del(paks16);
                }
                else
                {
                    
                }
                if (File.Exists(paks17))
                {
                    Del(paks17);
                }
                else
                {
                    
                }
                if (File.Exists(paks18))
                {
                    Del(paks18);
                }
                else
                {
                    
                }
                if (File.Exists(paks19))
                {
                    Del(paks19);
                }
                else
                {
                    
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // no storm nora is ready for release
            Process.Start(args + "launch");
            Thread.Sleep(4500);
            Application.Exit();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                string paks = GetPaksFolder + "\\pakchunk100_s4-WindowsClient.ucas";
                string paks1 = GetPaksFolder + "\\pakchunk100_s5-WindowsClient.ucas";
                string paks2 = GetPaksFolder + "\\pakchunk100_s22-WindowsClient.ucas";
                string paks3 = GetPaksFolder + "\\pakchunk100_s3-WindowsClient.ucas";
                string paks4 = GetPaksFolder + "\\pakchunk100_s3-WindowsClient.pak";
                string paks5 = GetPaksFolder + "\\pakchunk100_s3-WindowsClient.sig";
                string paks6 = GetPaksFolder + "\\pakchunk100_s3-WindowsClient.utoc";
                string paks7 = GetPaksFolder + "\\pakchunk100_s4-WindowsClient.pak";
                string paks8 = GetPaksFolder + "\\pakchunk100_s4-WindowsClient.sig";
                string paks9 = GetPaksFolder + "\\pakchunk100_s5-WindowsClient.utoc";
                string paks10 = GetPaksFolder + "\\pakchunk100_s5-WindowsClient.sig";
                string paks11 = GetPaksFolder + "\\pakchunk100_s5-WindowsClient.pak";
                string paks12 = GetPaksFolder + "\\pakchunk100_s22-WindowsClient.utoc";
                string paks13 = GetPaksFolder + "\\pakchunk100_s22-WindowsClient.sig";
                string paks14 = GetPaksFolder + "\\pakchunk100_s22-WindowsClient.pak";
                string paks15 = GetPaksFolder + "\\pakchunk100_s4-WindowsClient.utoc";
                string paks16 = GetPaksFolder + "\\pakchunk100_s21-WindowsClient.utoc";
                string paks17 = GetPaksFolder + "\\pakchunk100_s21-WindowsClient.ucas";
                string paks18 = GetPaksFolder + "\\pakchunk100_s21-WindowsClient.sig";
                string paks19 = GetPaksFolder + "\\pakchunk100_s21-WindowsClient.pak";


                if (File.Exists(paks))
                {
                    Del(paks);
                }
                else
                {
                    SCBE();
                }
                if (File.Exists(paks1))
                {
                    Del(paks1);
                }
                else
                {
                    
                }
                if (File.Exists(paks2))
                {
                    Del(paks2);
                }
                else
                {
                    
                }
                if (File.Exists(paks3))
                {
                    Del(paks3);
                }
                else
                {
                    
                }
                if (File.Exists(paks4))
                {
                    Del(paks4);
                }
                else
                {
                    
                }
                if (File.Exists(paks5))
                {
                    Del(paks5);
                }
                else
                {
                    
                }
                if (File.Exists(paks6))
                {
                    Del(paks6);
                }
                else
                {
                    
                }
                if (File.Exists(paks7))
                {
                    Del(paks7);
                }
                else
                {
                    
                }
                if (File.Exists(paks8))
                {
                    Del(paks8);
                }
                else
                {
                    
                }
                if (File.Exists(paks9))
                {
                    Del(paks9);
                }
                else
                {
                    
                }
                if (File.Exists(paks10))
                {
                    Del(paks10);
                }
                else
                {
                   
                }
                if (File.Exists(paks11))
                {
                    Del(paks11);
                }
                else
                {
                  
                }
                if (File.Exists(paks12))
                {
                    Del(paks12);
                }
                else
                {
                   
                }
                if (File.Exists(paks13))
                {
                    Del(paks13);
                }
                else
                {
                    
                }
                if (File.Exists(paks14))
                {
                    Del(paks14);
                }
                else
                {
                   
                }
                if (File.Exists(paks15))
                {
                    Del(paks15);
                }
                else
                {
                    
                }
                if (File.Exists(paks16))
                {
                    Del(paks16);
                }
                else
                {
                    
                }
                if (File.Exists(paks17))
                {
                    Del(paks17);
                }
                else
                {
                    
                }
                if (File.Exists(paks18))
                {
                    Del(paks18);
                }
                else
                {
                    
                }
                if (File.Exists(paks19))
                {
                    Del(paks19);
                }
                else
                {
                    
                }
            }
            Thread.Sleep(4000);
            {
                try
                {
                    string paks = Options.GetPaksFolder;
                    File.Copy(paks + "\\pakchunk10_s3-WindowsClient.pak", paks + "\\pakchunk100_s3-WindowsClient.pak");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s3-WindowsClient.sig", paks + "\\pakchunk100_s3-WindowsClient.sig");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s3-WindowsClient.utoc", paks + "\\pakchunk100_s3-WindowsClient.utoc");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s3-WindowsClient.ucas", paks + "\\pakchunk100_s3-WindowsClient.ucas");
                    Thread.Sleep(4000);
                    File.Copy(paks + "\\pakchunk10_s4-WindowsClient.pak", paks + "\\pakchunk100_s4-WindowsClient.pak");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s4-WindowsClient.sig", paks + "\\pakchunk100_s4-WindowsClient.sig");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s4-WindowsClient.utoc", paks + "\\pakchunk100_s4-WindowsClient.utoc");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s4-WindowsClient.ucas", paks + "\\pakchunk100_s4-WindowsClient.ucas");
                    Thread.Sleep(4000);
                    File.Copy(paks + "\\pakchunk10_s5-WindowsClient.pak", paks + "\\pakchunk100_s5-WindowsClient.pak");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s5-WindowsClient.sig", paks + "\\pakchunk100_s5-WindowsClient.sig");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s5-WindowsClient.utoc", paks + "\\pakchunk100_s5-WindowsClient.utoc");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s5-WindowsClient.ucas", paks + "\\pakchunk100_s5-WindowsClient.ucas");
                    Thread.Sleep(6000);
                    File.Copy(paks + "\\pakchunk10_s22-WindowsClient.pak", paks + "\\pakchunk100_s22-WindowsClient.pak");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s22-WindowsClient.sig", paks + "\\pakchunk100_s22-WindowsClient.sig");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s22-WindowsClient.utoc", paks + "\\pakchunk100_s22-WindowsClient.utoc");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s22-WindowsClient.ucas", paks + "\\pakchunk100_s22-WindowsClient.ucas");
                    Thread.Sleep(6000);
                    File.Copy(paks + "\\pakchunk10_s21-WindowsClient.pak", paks + "\\pakchunk100_s21-WindowsClient.pak");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s21-WindowsClient.sig", paks + "\\pakchunk100_s21-WindowsClient.sig");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s21-WindowsClient.utoc", paks + "\\pakchunk100_s21-WindowsClient.utoc");
                    Thread.Sleep(2000);
                    File.Copy(paks + "\\pakchunk10_s21-WindowsClient.ucas", paks + "\\pakchunk100_s21-WindowsClient.ucas");
                    Thread.Sleep(6000);
                    MessageBox.Show("LOG: Succesfully reverted Backups.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("LOG: Your Paks Folder Couldnt Be found please select the pak folder right Or Your backups already exist.");
                    
                }
            }
        }

        public static void SCBE()
        {
            MessageBox.Show("Couldnt Not Find Your Paks Folder Please select it By Clicking on the select button.");
        }


        public static void SCBE2()
        {
            MessageBox.Show("Backups are already deleted OR Your paks folder is wrong please select the right one.");
        }

        public static void backups()
        {
            
        }


        public static void RevertAll()
        {
            string paks = GetPaksFolder + "\\pakchunk100_s4-WindowsClient.ucas";
            string paks1 = GetPaksFolder + "\\pakchunk100_s5-WindowsClient.ucas";
            string paks2 = GetPaksFolder + "\\pakchunk100_s22-WindowsClient.ucas";
            string paks3 = GetPaksFolder + "\\pakchunk100_s3-WindowsClient.ucas";
            string paks4 = GetPaksFolder + "\\pakchunk100_s3-WindowsClient.pak";
            string paks5 = GetPaksFolder + "\\pakchunk100_s3-WindowsClient.sig";
            string paks6 = GetPaksFolder + "\\pakchunk100_s3-WindowsClient.utoc";
            string paks7 = GetPaksFolder + "\\pakchunk100_s4-WindowsClient.pak";
            string paks8 = GetPaksFolder + "\\pakchunk100_s4-WindowsClient.sig";
            string paks9 = GetPaksFolder + "\\pakchunk100_s5-WindowsClient.utoc";
            string paks10 = GetPaksFolder + "\\pakchunk100_s5-WindowsClient.sig";
            string paks11 = GetPaksFolder + "\\pakchunk100_s5-WindowsClient.pak";
            string paks12 = GetPaksFolder + "\\pakchunk100_s22-WindowsClient.utoc";
            string paks13 = GetPaksFolder + "\\pakchunk100_s22-WindowsClient.sig";
            string paks14 = GetPaksFolder + "\\pakchunk100_s22-WindowsClient.pak";
            string paks15 = GetPaksFolder + "\\pakchunk100_s4-WindowsClient.utoc";

            if (File.Exists(paks))
            {
                Del(paks);
            }
            else
            {
                SCBE();
            }
             if (File.Exists(paks1))
            {
                Del(paks1);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks2))
            {
                Del(paks2);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks3))
            {
                Del(paks3);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks4))
            {
                Del(paks4);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks5))
            {
                Del(paks5);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks6))
            {
                Del(paks6);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks7))
            {
                Del(paks7);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks8))
            {
                Del(paks8);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks9))
            {
                Del(paks9);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks10))
            {
                Del(paks10);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks11))
            {
                Del(paks11);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks12))
            {
                Del(paks12);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks13))
            {
                Del(paks13);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks14))
            {
                Del(paks14);
            }
            else
            {
                SCBE();
            }
            if (File.Exists(paks15))
            {
                Del(paks15);
            }
            else
            {
                SCBE();
            }
        }

        public static void Del(string file)
        {
            File.Delete(file);
        }

        private void TextBox_PAKS_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
    }
    

