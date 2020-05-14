using RestSharp;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DiscordRaid
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public String lines;
        public Boolean stop;
        public String[] tokens;
        public String channelID;
        public String message;
        public Form1()
        {
            InitializeComponent();
            //Load all tokens from a text file named "tokens.txt"
            tokens = File.ReadAllLines(Directory.GetCurrentDirectory() + "/tokens.txt");
            foreach (String token in tokens)
            {
                lines += token + Environment.NewLine;
            }
            textBox2.Text = lines;
            spamButton.Click += new EventHandler(startButton);
            stopButton.Click += new EventHandler(stopBut);
            void spamThread()
            {
                while (!stop)
                {
                    foreach (String tok in tokens)
                    {
                        var client = new RestClient("https://discordapp.com/api/v7/channels/" + channelID + "/messages");
                        var request = new RestRequest(Method.POST);
                        request.AddHeader("authorization", tok);
                        request.AddHeader("Content-Type", "application/json");
                        request.AddParameter("application/json", "{\r\n  \"content\": \"" + message + "\"\r\n}", ParameterType.RequestBody);
                        IRestResponse response = client.Execute(request);
                    }
                }
            }
            void startButton(object sender, EventArgs e)
            {
                stop = false;
                channelID = channelIDBox.Text;
                message = messageBox.Text;
                String invite = inviteBox.Text;
                if (channelID.Any(char.IsDigit) && message.Any(char.IsLetter) && invite.Any(char.IsLetter))
                {
                    foreach (String tok in tokens)
                    {
                        var client3 = new RestClient("https://discordapp.com/api/v7/invite/" + invite);
                        var request3 = new RestRequest(Method.POST);
                        request3.AddHeader("authorization", tok);
                        IRestResponse response3 = client3.Execute(request3);
                    }
                    Thread t = new Thread(new ThreadStart(spamThread));
                    t.Start();
                }
                else
                {
                    MessageBox.Show("You Left Something Blank!");
                }
            }
            void stopBut(object sender, EventArgs e)
            {
                stop = true;
            }
        }

    }
}
