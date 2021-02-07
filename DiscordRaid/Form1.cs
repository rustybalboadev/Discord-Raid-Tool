using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DiscordRaid
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        bool invited, stop;
        List<string> tokenList = new List<string>();
        List<string> badTokens = new List<string>();
        string invite, channelID, message, timeout, guildID;
        int failedTokens = 0;


        public Form1()
        {
            InitializeComponent();

            foreach (string token in File.ReadAllLines(Directory.GetCurrentDirectory() + "/tokens.txt")) {
                if (token != "" || token != Environment.NewLine)
                {
                    tokenList.Add(token);
                    tokenTextBox.Text += token + Environment.NewLine;
                }
            }
            
            //Fix Prompt Text Bug
            inviteTextBox.Text = " ";
            inviteTextBox.Text = "";

            channelTextBox.Text = " ";
            channelTextBox.Text = "";

            messageTextBox.Text = " ";
            messageTextBox.Text = "";

            timeoutTextBox.Text = " ";
            timeoutTextBox.Text = "";

            reactionChannelID.Text = " ";
            reactionChannelID.Text = "";

            reactionMessageID.Text = " ";
            reactionMessageID.Text = "";

        }

        void spamThread()
        {
            while (!stop)
            {
                foreach (string token in tokenList)
                {
                    var client = new RestClient("https://discordapp.com/api/v6/channels/" + channelID + "/messages");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("authorization", token);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("application/json", "{\r\n \"content\": \"" + message + "\"\r\n}", ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);
                    Thread.Sleep(Int32.Parse(timeout));
                }
            }
        }

        private void inviteButton_Click(object sender, EventArgs e)
        {
            channelID = channelTextBox.Text;
            message = messageTextBox.Text;
            timeout = timeoutTextBox.Text;
            invite = inviteTextBox.Text;

            if (channelID != "" || message != "" || invite != "")
            {
                invited = true;
                foreach (string token in tokenList)
                {
                    var client = new RestClient("https://discordapp.com/api/v6/invite/" + invite);
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("authorization", token);
                    IRestResponse response = client.Execute(request);
                    if (!response.IsSuccessful)
                    {
                        //tokenList.Remove(token);
                        badTokens.Add(token);
                        failedTokens += 1;
                        failedTokensTextBox.Text = "Failed Tokens: " + failedTokens.ToString();
                    } else
                    {
                        dynamic data = JsonConvert.DeserializeObject(response.Content);
                        guildID = data.guild.id;
                    }
                }
                foreach (string token in badTokens)
                {
                    tokenList.Remove(token);
                }
            }
            else
            {
                MessageBox.Show("You left something blank!");
            }
        }

        private void startSpam_Click(object sender, EventArgs e)
        {
            stop = false;
            if (channelID != "" || message != "" || invite != "")
            {
                Thread t = new Thread(new ThreadStart(spamThread));
                t.Start();
            } else
            {
                MessageBox.Show("You left something blank!");
            }
        }

        private void stopSpam_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void leaveServer_Click(object sender, EventArgs e)
        {
            foreach (string token in tokenList)
            {
                var client = new RestClient("https://discordapp.com/api/v6/users/@me/guilds/" + guildID);
                var request = new RestRequest(Method.DELETE);
                request.AddHeader("authorization", token);
                IRestResponse response = client.Execute(request);
            }
        }

        private void reactionButton_Click(object sender, EventArgs e)
        {
            string reactionChannel = reactionChannelID.Text;
            string reactionMessage = reactionMessageID.Text;
            string encodedEmoji = HttpUtility.UrlEncode(emojiTextBox.Text);
            if (invited)
            {
                foreach (string token in tokenList)
                {
                    var client = new RestClient("https://discordapp.com/api/v6/channels/" + reactionChannel + "/messages/" + reactionMessage + "/reactions/" + encodedEmoji + "/@me");
                    var request = new RestRequest(Method.PUT);
                    request.AddHeader("authorization", token);
                    IRestResponse response = client.Execute(request);
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
