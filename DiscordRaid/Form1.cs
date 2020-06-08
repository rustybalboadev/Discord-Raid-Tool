using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DiscordRaid
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Boolean invited = false;
        public String lines;
        public Boolean stop;
        List<string> list = new List<string>();
        public String channelID;
        public String message;
        public String guildID;
        public String timeoutAmount;
        public String invite;
        List<string> bad_tokens = new List<string>();
        public Form1()
        {
            InitializeComponent();
            string[] all_lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "/tokens.txt");
            foreach (string line in all_lines)
            {
                list.Add(line);
            }
            foreach (String token in list)
            {
                lines += token + Environment.NewLine;
            }
            textBox2.Text = lines;
            spamButton.Click += new EventHandler(startButton);
            stopButton.Click += new EventHandler(stopBut);
            quitButton.Click += new EventHandler(quit);
            leaveServer.Click += new EventHandler(leave);
            inviteAllButton.Click += new EventHandler(inviteAll);
            addReactionButton.Click += new EventHandler(addReactionFunc);

            void timeoutTime(string amount)
            {
                Thread.Sleep(Int32.Parse(amount));
            }

            void spamThread()
            {
                while (!stop)
                {
                    foreach (String tok in list)
                    {
                        var client = new RestClient("https://discordapp.com/api/v7/channels/" + channelID + "/messages");
                        var request = new RestRequest(Method.POST);
                        request.AddHeader("authorization", tok);
                        request.AddHeader("Content-Type", "application/json");
                        request.AddParameter("application/json", "{\r\n  \"content\": \"" + message + "\"\r\n}", ParameterType.RequestBody);
                        IRestResponse response = client.Execute(request);
                        timeoutTime(timeoutAmount);
                    }
                }
            }

            void inviteAll(object sender, EventArgs e)
            {
                channelID = channelIDBox.Text;
                message = messageBox.Text;
                timeoutAmount = timeout.Text;
                invite = inviteBox.Text;
                if (channelID.Any(char.IsDigit) && message.Any(char.IsLetter) && invite.Any(char.IsLetter))
                {
                    invited = true;
                    foreach (String tok in list)
                    {
                        var client3 = new RestClient("https://discordapp.com/api/v7/invite/" + invite);
                        var request3 = new RestRequest(Method.POST);
                        request3.AddHeader("authorization", tok);
                        IRestResponse response3 = client3.Execute(request3);
                        if (!response3.IsSuccessful)
                        {
                            bad_tokens.Add(tok);
                        }
                        else
                        {
                            Console.WriteLine(tok);
                        }
                        dynamic stuff = JsonConvert.DeserializeObject(response3.Content);
                        try
                        {
                            guildID = stuff.guild.id;
                        }
                        catch
                        {

                        }
                    }
                    foreach (String btok in bad_tokens)
                    {
                        list.Remove(btok);
                        continue;
                    }
                } 
                else
                {
                    MessageBox.Show("You Left Something Blank!");
                }
            }

            void startButton(object sender, EventArgs e)
            {
                stop = false;
                if (channelID.Any(char.IsDigit) && message.Any(char.IsLetter) && invite.Any(char.IsLetter))
                {

                    Thread t = new Thread(new ThreadStart(spamThread));
                    t.Start();
                }
                else
                {
                    MessageBox.Show("You Left Something Blank!");
                }
            }

            void addReactionFunc(object sender, EventArgs e)
            {
                String reactionChannel = reactionChannelID.Text;
                String msg = reactionMessageID.Text;
                String emoji = emojiTextBox.Text;
                String encodedEmoji = System.Web.HttpUtility.UrlEncode(emoji);
                if (invited)
                {
                    foreach (String tok in list)
                    {
                        var client5 = new RestClient("https://discordapp.com/api/v6/channels/" + reactionChannel + "/messages/" + msg + "/reactions/" + encodedEmoji + "/@me");
                        var request5 = new RestRequest(Method.PUT);
                        request5.AddHeader("authorization", tok);
                        IRestResponse response5 = client5.Execute(request5);
                    }
                }
                else
                {
                    MessageBox.Show("You Haven't Invited the users!");
                }
            }

            void quit(object sender, EventArgs e)
            {
                Application.Exit();
            }

            void stopBut(object sender, EventArgs e)
            {
                stop = true;
            }
            void leave(object sender, EventArgs e)
            {
                foreach (string tok in list)
                {
                    var client4 = new RestClient("https://discordapp.com/api/v7/users/@me/guilds/" + guildID);
                    var request4 = new RestRequest(Method.DELETE);
                    request4.AddHeader("authorization", tok);
                    IRestResponse response4 = client4.Execute(request4);
                }
            }
        }

    }
}
