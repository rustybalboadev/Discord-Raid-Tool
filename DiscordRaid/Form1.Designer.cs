namespace DiscordRaid
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startSpam = new MetroFramework.Controls.MetroButton();
            this.stopSpam = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tokenLoaded = new MetroFramework.Controls.MetroLabel();
            this.tokenTextBox = new MetroFramework.Controls.MetroTextBox();
            this.messageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.channelTextBox = new MetroFramework.Controls.MetroTextBox();
            this.inviteTextBox = new MetroFramework.Controls.MetroTextBox();
            this.quitButton = new MetroFramework.Controls.MetroButton();
            this.leaveServer = new MetroFramework.Controls.MetroButton();
            this.timeoutTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inviteButton = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reactionButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.emojiTextBox = new MetroFramework.Controls.MetroTextBox();
            this.reactionMessageID = new MetroFramework.Controls.MetroTextBox();
            this.reactionChannelID = new MetroFramework.Controls.MetroTextBox();
            this.failedTokensTextBox = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startSpam
            // 
            this.startSpam.Location = new System.Drawing.Point(19, 252);
            this.startSpam.Name = "startSpam";
            this.startSpam.Size = new System.Drawing.Size(111, 23);
            this.startSpam.TabIndex = 12;
            this.startSpam.Text = "Start Spam";
            this.startSpam.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startSpam.Click += new System.EventHandler(this.startSpam_Click);
            // 
            // stopSpam
            // 
            this.stopSpam.Location = new System.Drawing.Point(134, 252);
            this.stopSpam.Name = "stopSpam";
            this.stopSpam.Size = new System.Drawing.Size(101, 23);
            this.stopSpam.TabIndex = 13;
            this.stopSpam.Text = "Stop Spam";
            this.stopSpam.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stopSpam.Click += new System.EventHandler(this.stopSpam_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(18, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(151, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Enter Server Invite Code";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Enter Channel ID";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(148, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Enter Message to Spam";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tokenLoaded
            // 
            this.tokenLoaded.AutoSize = true;
            this.tokenLoaded.ForeColor = System.Drawing.Color.White;
            this.tokenLoaded.Location = new System.Drawing.Point(751, 22);
            this.tokenLoaded.Name = "tokenLoaded";
            this.tokenLoaded.Size = new System.Drawing.Size(95, 19);
            this.tokenLoaded.TabIndex = 19;
            this.tokenLoaded.Text = "Tokens Loaded";
            this.tokenLoaded.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tokenTextBox
            // 
            this.tokenTextBox.ForeColor = System.Drawing.Color.White;
            this.tokenTextBox.Location = new System.Drawing.Point(563, 63);
            this.tokenTextBox.Multiline = true;
            this.tokenTextBox.Name = "tokenTextBox";
            this.tokenTextBox.ReadOnly = true;
            this.tokenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tokenTextBox.Size = new System.Drawing.Size(481, 383);
            this.tokenTextBox.TabIndex = 23;
            this.tokenTextBox.TabStop = false;
            this.tokenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tokenTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(19, 147);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.PromptText = "u r loser lol";
            this.messageTextBox.Size = new System.Drawing.Size(216, 20);
            this.messageTextBox.TabIndex = 21;
            this.messageTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // channelTextBox
            // 
            this.channelTextBox.Location = new System.Drawing.Point(18, 102);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.PromptText = "769013685929902110";
            this.channelTextBox.Size = new System.Drawing.Size(217, 20);
            this.channelTextBox.TabIndex = 22;
            this.channelTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inviteTextBox
            // 
            this.inviteTextBox.Location = new System.Drawing.Point(18, 57);
            this.inviteTextBox.Name = "inviteTextBox";
            this.inviteTextBox.PromptText = "K3zW8psRTp";
            this.inviteTextBox.Size = new System.Drawing.Size(217, 20);
            this.inviteTextBox.TabIndex = 20;
            this.inviteTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(955, 13);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(89, 28);
            this.quitButton.TabIndex = 24;
            this.quitButton.Text = "Quit";
            this.quitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // leaveServer
            // 
            this.leaveServer.Location = new System.Drawing.Point(18, 281);
            this.leaveServer.Name = "leaveServer";
            this.leaveServer.Size = new System.Drawing.Size(217, 23);
            this.leaveServer.TabIndex = 25;
            this.leaveServer.Text = "Leave Server";
            this.leaveServer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.leaveServer.Click += new System.EventHandler(this.leaveServer_Click);
            // 
            // timeoutTextBox
            // 
            this.timeoutTextBox.Location = new System.Drawing.Point(18, 193);
            this.timeoutTextBox.Name = "timeoutTextBox";
            this.timeoutTextBox.PromptText = "300";
            this.timeoutTextBox.Size = new System.Drawing.Size(217, 20);
            this.timeoutTextBox.TabIndex = 26;
            this.timeoutTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 168);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 19);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "Timeout in ms";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inviteButton);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.timeoutTextBox);
            this.groupBox1.Controls.Add(this.leaveServer);
            this.groupBox1.Controls.Add(this.inviteTextBox);
            this.groupBox1.Controls.Add(this.channelTextBox);
            this.groupBox1.Controls.Add(this.messageTextBox);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.stopSpam);
            this.groupBox1.Controls.Add(this.startSpam);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 333);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invite/Spam";
            // 
            // inviteButton
            // 
            this.inviteButton.Location = new System.Drawing.Point(18, 219);
            this.inviteButton.Name = "inviteButton";
            this.inviteButton.Size = new System.Drawing.Size(216, 27);
            this.inviteButton.TabIndex = 28;
            this.inviteButton.Text = "Invite";
            this.inviteButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.inviteButton.Click += new System.EventHandler(this.inviteButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reactionButton);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.emojiTextBox);
            this.groupBox2.Controls.Add(this.reactionMessageID);
            this.groupBox2.Controls.Add(this.reactionChannelID);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(266, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 333);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Reaction";
            // 
            // reactionButton
            // 
            this.reactionButton.Location = new System.Drawing.Point(17, 193);
            this.reactionButton.Name = "reactionButton";
            this.reactionButton.Size = new System.Drawing.Size(216, 27);
            this.reactionButton.TabIndex = 6;
            this.reactionButton.Text = "Add Reaction";
            this.reactionButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.reactionButton.Click += new System.EventHandler(this.reactionButton_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 125);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(42, 19);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Emoji";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 80);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(154, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Message ID with reaction";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(16, 27);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Channel ID";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // emojiTextBox
            // 
            this.emojiTextBox.Location = new System.Drawing.Point(16, 147);
            this.emojiTextBox.Name = "emojiTextBox";
            this.emojiTextBox.Size = new System.Drawing.Size(217, 20);
            this.emojiTextBox.TabIndex = 2;
            this.emojiTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // reactionMessageID
            // 
            this.reactionMessageID.Location = new System.Drawing.Point(16, 102);
            this.reactionMessageID.Name = "reactionMessageID";
            this.reactionMessageID.PromptText = "807033702932545588";
            this.reactionMessageID.Size = new System.Drawing.Size(217, 20);
            this.reactionMessageID.TabIndex = 1;
            this.reactionMessageID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // reactionChannelID
            // 
            this.reactionChannelID.Location = new System.Drawing.Point(16, 57);
            this.reactionChannelID.Name = "reactionChannelID";
            this.reactionChannelID.PromptText = "769013685929902110";
            this.reactionChannelID.Size = new System.Drawing.Size(217, 20);
            this.reactionChannelID.TabIndex = 0;
            this.reactionChannelID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // failedTokensTextBox
            // 
            this.failedTokensTextBox.AutoSize = true;
            this.failedTokensTextBox.Location = new System.Drawing.Point(5, 82);
            this.failedTokensTextBox.Name = "failedTokensTextBox";
            this.failedTokensTextBox.Size = new System.Drawing.Size(92, 19);
            this.failedTokensTextBox.TabIndex = 30;
            this.failedTokensTextBox.Text = "Failed Tokens: ";
            this.failedTokensTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 476);
            this.ControlBox = false;
            this.Controls.Add(this.failedTokensTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.tokenTextBox);
            this.Controls.Add(this.tokenLoaded);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Discord Raid Tool";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton startSpam;
        private MetroFramework.Controls.MetroButton stopSpam;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel tokenLoaded;
        private MetroFramework.Controls.MetroTextBox tokenTextBox;
        private MetroFramework.Controls.MetroTextBox messageTextBox;
        private MetroFramework.Controls.MetroTextBox channelTextBox;
        private MetroFramework.Controls.MetroTextBox inviteTextBox;
        private MetroFramework.Controls.MetroButton quitButton;
        private MetroFramework.Controls.MetroButton leaveServer;
        private MetroFramework.Controls.MetroTextBox timeoutTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton reactionButton;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox emojiTextBox;
        private MetroFramework.Controls.MetroTextBox reactionMessageID;
        private MetroFramework.Controls.MetroTextBox reactionChannelID;
        private MetroFramework.Controls.MetroButton inviteButton;
        private MetroFramework.Controls.MetroLabel failedTokensTextBox;
    }
}

