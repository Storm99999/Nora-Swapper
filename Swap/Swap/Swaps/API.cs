using Swap.Nora.Commands;
using Swap.Nora.Items.Skins;
using Swap.Nora.Launchers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Swap.Swaps
{
    // yea i have 2 api's 1 is for skins and the 2. Is for general stuff like offsets, pretty weird for some people but I like it.
    class API
    {
        // random shit
        private static void ui()
        {

        }
        public static void StartDiscord(string discord = "https://discord.gg/bFPGZs35m8") // just to make this shit alot easier.
        {
            string discord1 = "https://discord.gg/W6hV3Tgu";
            Process.Start(discord);
            Process.Start(discord1);
        }
        // Check If Free Login is currently avaible
        public static void GetLogin(string profileName="FREE USER", string profileText="Get Premium by being Active In Chat. You'll get your premium account in a day. If there is no Account info in the next 5 days, Please Contact a support/Admin/Mod to give you the login infomation.")
        {
           
                // download the api to the path (.json file as i like to read it from a json file, you can use a other method but yeah.)
                WebClient web = new WebClient();

                string path = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Nora-Swapper\\api.json";
                web.DownloadFile("https://cdn.discordapp.com/attachments/825770516266221581/843186854266536016/api.json", path);
                string api = $"Logged In As : {profileName}! \n\n\n{profileText}";
                MessageBox.Show(api);
                new Launcher().Show();
        }

        public static void AntiDotPeek()
        {
            string loc = @"C:\Users\" + Environment.UserName + @"\AppData\Local\JetBrains\Installations\dotPeek203.exe";
            if (File.Exists(loc))
            {
                foreach (var dotpeek in Process.GetProcessesByName("dotPeek64"))
                {
                    dotpeek.Kill();
                    MessageBox.Show("DotPeek was detected. ANTI SKID HAS DETECTED ILLEGAL PROCESS: " + loc + " stop it.");
                }
            }
        }
        public static void AntiDNSpy()
        {
                foreach (var dnSpy in Process.GetProcessesByName("dnSpy"))
                {
                    dnSpy.Kill();
                    MessageBox.Show("DNSpy was detected. ANTI SKID HAS DETECTED ILLEGAL PROCESS: dnSpy.exe" + " stop it.");
                }
        }

        // Swap Check
        public static void CheckForSwap(string str)
        {
            WebClient wc = new WebClient();

            switch (str)
            {
                case "RenegadeRaider":
                    if (wc.DownloadString("https://pastebin.com/raw/FqGvsz3M").Contains("RenegadeToRenegadeRaider=true,"))
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("This Skin is unavaible. Please Check Later, If you are sure this is a bug Report it on our discord.", "Nora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        commands.Command("HideControl");
                    }
                    break;
                case "DiaDivaToOGSkull":
                    if (wc.DownloadString("https://pastebin.com/raw/FqGvsz3M").Contains("DiaDivaToOGSkull=true,"))
                    {

                    }
                    else
                    {
                        MessageBox.Show("This Skin is unavaible. Please Check Later, If you are sure this is a bug Report it on our discord.", "Nora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        commands.Command("HideControl");
                    }
                    break;



                case "RenegadeNoHead":
                    if (wc.DownloadString("https://pastebin.com/raw/FqGvsz3M").Contains("AssaultToRenegade=true,"))
                    {

                    }
                    else
                    {
                        MessageBox.Show("This Skin is unavaible. Please Check Later, If you are sure this is a bug Report it on our discord.", "Nora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        commands.Command("HideControl");
                    }
                    break;
                case "FrozenRaidersRevenge":
                    if (wc.DownloadString("https://pastebin.com/FqGvsz3M").Contains("FrozenAxeToFrozenRaidersRevenge=true,"))
                    {

                    }
                    else
                    {
                        MessageBox.Show("This Skin is unavaible. Please Check Later, If you are sure this is a bug Report it on our discord.", "Nora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        commands.Command("HideControl");
                    }
                    break;
                case "GalaxyAxe":
                    if (wc.DownloadString("https://pastebin.com/FqGvsz3M").Contains("FrozenAxeToGalaxyAxe=false"))
                    {

                    }
                    else
                    {
                        MessageBox.Show("This Skin is unavaible. Please Check Later, If you are sure this is a bug Report it on our discord.", "Nora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        commands.Command("HideControl");
                    }
                    break;
            }

        }
       
        // kill fortnite if opened
        public static void KillFortnite()
        {
            foreach (var fn in Process.GetProcessesByName("FortniteClient-Win64-Shipping"))
            {
                fn.Kill();
                string warningMSG = "Fortnite has been detected in your Processes, and has been instantly Terminated. Opened Fortnite Clients could lead to a bugged swapping experience or a Ban.";
                MessageBox.Show(warningMSG);
            }      
        }

        
        // Kill epic if opened
        public static void KillEpicGames()
        {
            foreach (var epic in Process.GetProcessesByName("EpicGamesLauncher"))
            {
                epic.Kill();
                string warningMSG = "EpicGamesLauncher has been detected in your Processes, and has been instantly Terminated. Opened Fortnite Clients could lead to a bugged swapping experience or a Ban.";
                MessageBox.Show(warningMSG);
            }
        }

        
        // swapper status
        public static void CheckIfCanUseSwapper()
        {
            WebClient CheckIfCanSwap = new WebClient();
            bool f = CheckIfCanSwap.DownloadString("https://pastebin.com/raw/UTbYpHn1").Contains("true");
            if (f)
            {
                
            }
            else
            {
                MessageBox.Show("The Swapper Is Not Working Or Offline. Please Stay Patient...");
                commands.Command("HideControl");
            }
        }

    }
}
