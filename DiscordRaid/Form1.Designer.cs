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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.spamButton = new MetroFramework.Controls.MetroButton();
            this.stopButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tokenLoaded = new MetroFramework.Controls.MetroLabel();
            this.textBox2 = new MetroFramework.Controls.MetroTextBox();
            this.messageBox = new MetroFramework.Controls.MetroTextBox();
            this.channelIDBox = new MetroFramework.Controls.MetroTextBox();
            this.inviteBox = new MetroFramework.Controls.MetroTextBox();
            this.quitButton = new MetroFramework.Controls.MetroButton();
            this.leaveServer = new MetroFramework.Controls.MetroButton();
            this.timeout = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reactionChannelID = new MetroFramework.Controls.MetroTextBox();
            this.reactionMessageID = new MetroFramework.Controls.MetroTextBox();
            this.emojiTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.addReactionButton = new MetroFramework.Controls.MetroButton();
            this.inviteAllButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // spamButton
            // 
            this.spamButton.Location = new System.Drawing.Point(18, 254);
            this.spamButton.Name = "spamButton";
            this.spamButton.Size = new System.Drawing.Size(111, 23);
            this.spamButton.TabIndex = 12;
            this.spamButton.Text = "Start Spam";
            this.spamButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(134, 254);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(101, 23);
            this.stopButton.TabIndex = 13;
            this.stopButton.Text = "Stop Spam";
            this.stopButton.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(563, 63);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(481, 383);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(19, 147);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(216, 20);
            this.messageBox.TabIndex = 21;
            this.messageBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // channelIDBox
            // 
            this.channelIDBox.Location = new System.Drawing.Point(18, 102);
            this.channelIDBox.Name = "channelIDBox";
            this.channelIDBox.Size = new System.Drawing.Size(217, 20);
            this.channelIDBox.TabIndex = 22;
            this.channelIDBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inviteBox
            // 
            this.inviteBox.Location = new System.Drawing.Point(18, 57);
            this.inviteBox.Name = "inviteBox";
            this.inviteBox.Size = new System.Drawing.Size(217, 20);
            this.inviteBox.TabIndex = 23;
            this.inviteBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(955, 13);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(89, 28);
            this.quitButton.TabIndex = 24;
            this.quitButton.Text = "Quit";
            this.quitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // leaveServer
            // 
            this.leaveServer.Location = new System.Drawing.Point(18, 283);
            this.leaveServer.Name = "leaveServer";
            this.leaveServer.Size = new System.Drawing.Size(217, 23);
            this.leaveServer.TabIndex = 25;
            this.leaveServer.Text = "Leave Server";
            this.leaveServer.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timeout
            // 
            this.timeout.Location = new System.Drawing.Point(18, 193);
            this.timeout.Name = "timeout";
            this.timeout.Size = new System.Drawing.Size(217, 20);
            this.timeout.TabIndex = 26;
            this.timeout.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.groupBox1.Controls.Add(this.inviteAllButton);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.timeout);
            this.groupBox1.Controls.Add(this.leaveServer);
            this.groupBox1.Controls.Add(this.inviteBox);
            this.groupBox1.Controls.Add(this.channelIDBox);
            this.groupBox1.Controls.Add(this.messageBox);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.spamButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 333);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invite/Spam";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addReactionButton);
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
            // reactionChannelID
            // 
            this.reactionChannelID.Location = new System.Drawing.Point(16, 57);
            this.reactionChannelID.Name = "reactionChannelID";
            this.reactionChannelID.Size = new System.Drawing.Size(217, 20);
            this.reactionChannelID.TabIndex = 0;
            this.reactionChannelID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // reactionMessageID
            // 
            this.reactionMessageID.Location = new System.Drawing.Point(16, 102);
            this.reactionMessageID.Name = "reactionMessageID";
            this.reactionMessageID.Size = new System.Drawing.Size(217, 20);
            this.reactionMessageID.TabIndex = 1;
            this.reactionMessageID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // emojiTextBox
            // 
            this.emojiTextBox.Location = new System.Drawing.Point(16, 147);
            this.emojiTextBox.Name = "emojiTextBox";
            this.emojiTextBox.Size = new System.Drawing.Size(217, 20);
            this.emojiTextBox.TabIndex = 2;
            this.emojiTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // addReactionButton
            // 
            this.addReactionButton.Location = new System.Drawing.Point(17, 193);
            this.addReactionButton.Name = "addReactionButton";
            this.addReactionButton.Size = new System.Drawing.Size(216, 27);
            this.addReactionButton.TabIndex = 6;
            this.addReactionButton.Text = "Add Reaction";
            this.addReactionButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inviteAllButton
            // 
            this.inviteAllButton.Location = new System.Drawing.Point(18, 219);
            this.inviteAllButton.Name = "inviteAllButton";
            this.inviteAllButton.Size = new System.Drawing.Size(216, 27);
            this.inviteAllButton.TabIndex = 28;
            this.inviteAllButton.Text = "Invite";
            this.inviteAllButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 476);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.textBox2);
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

        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroButton spamButton;
        private MetroFramework.Controls.MetroButton stopButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel tokenLoaded;
        private MetroFramework.Controls.MetroTextBox textBox2;
        private MetroFramework.Controls.MetroTextBox messageBox;
        private MetroFramework.Controls.MetroTextBox channelIDBox;
        private MetroFramework.Controls.MetroTextBox inviteBox;
        private MetroFramework.Controls.MetroButton quitButton;
        private MetroFramework.Controls.MetroButton leaveServer;
        private MetroFramework.Controls.MetroTextBox timeout;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton addReactionButton;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox emojiTextBox;
        private MetroFramework.Controls.MetroTextBox reactionMessageID;
        private MetroFramework.Controls.MetroTextBox reactionChannelID;
        private MetroFramework.Controls.MetroButton inviteAllButton;
        ﻿namespace DiscordRaid
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.spamButton = new MetroFramework.Controls.MetroButton();
            this.stopButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tokenLoaded = new MetroFramework.Controls.MetroLabel();
            this.textBox2 = new MetroFramework.Controls.MetroTextBox();
            this.messageBox = new MetroFramework.Controls.MetroTextBox();
            this.channelIDBox = new MetroFramework.Controls.MetroTextBox();
            this.inviteBox = new MetroFramework.Controls.MetroTextBox();
            this.quitButton = new MetroFramework.Controls.MetroButton();
            this.leaveServer = new MetroFramework.Controls.MetroButton();
            this.timeout = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reactionChannelID = new MetroFramework.Controls.MetroTextBox();
            this.reactionMessageID = new MetroFramework.Controls.MetroTextBox();
            this.emojiTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.addReactionButton = new MetroFramework.Controls.MetroButton();
            this.inviteAllButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // spamButton
            // 
            this.spamButton.Location = new System.Drawing.Point(18, 254);
            this.spamButton.Name = "spamButton";
            this.spamButton.Size = new System.Drawing.Size(111, 23);
            this.spamButton.TabIndex = 12;
            this.spamButton.Text = "Start Spam";
            this.spamButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(134, 254);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(101, 23);
            this.stopButton.TabIndex = 13;
            this.stopButton.Text = "Stop Spam";
            this.stopButton.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(563, 63);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(481, 383);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(19, 147);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(216, 20);
            this.messageBox.TabIndex = 21;
            this.messageBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // channelIDBox
            // 
            this.channelIDBox.Location = new System.Drawing.Point(18, 102);
            this.channelIDBox.Name = "channelIDBox";
            this.channelIDBox.Size = new System.Drawing.Size(217, 20);
            this.channelIDBox.TabIndex = 22;
            this.channelIDBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inviteBox
            // 
            this.inviteBox.Location = new System.Drawing.Point(18, 57);
            this.inviteBox.Name = "inviteBox";
            this.inviteBox.Size = new System.Drawing.Size(217, 20);
            this.inviteBox.TabIndex = 23;
            this.inviteBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(955, 13);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(89, 28);
            this.quitButton.TabIndex = 24;
            this.quitButton.Text = "Quit";
            this.quitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // leaveServer
            // 
            this.leaveServer.Location = new System.Drawing.Point(18, 283);
            this.leaveServer.Name = "leaveServer";
            this.leaveServer.Size = new System.Drawing.Size(217, 23);
            this.leaveServer.TabIndex = 25;
            this.leaveServer.Text = "Leave Server";
            this.leaveServer.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timeout
            // 
            this.timeout.Location = new System.Drawing.Point(18, 193);
            this.timeout.Name = "timeout";
            this.timeout.Size = new System.Drawing.Size(217, 20);
            this.timeout.TabIndex = 26;
            this.timeout.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.groupBox1.Controls.Add(this.inviteAllButton);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.timeout);
            this.groupBox1.Controls.Add(this.leaveServer);
            this.groupBox1.Controls.Add(this.inviteBox);
            this.groupBox1.Controls.Add(this.channelIDBox);
            this.groupBox1.Controls.Add(this.messageBox);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.spamButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 333);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invite/Spam";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addReactionButton);
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
            // reactionChannelID
            // 
            this.reactionChannelID.Location = new System.Drawing.Point(16, 57);
            this.reactionChannelID.Name = "reactionChannelID";
            this.reactionChannelID.Size = new System.Drawing.Size(217, 20);
            this.reactionChannelID.TabIndex = 0;
            this.reactionChannelID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // reactionMessageID
            // 
            this.reactionMessageID.Location = new System.Drawing.Point(16, 102);
            this.reactionMessageID.Name = "reactionMessageID";
            this.reactionMessageID.Size = new System.Drawing.Size(217, 20);
            this.reactionMessageID.TabIndex = 1;
            this.reactionMessageID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // emojiTextBox
            // 
            this.emojiTextBox.Location = new System.Drawing.Point(16, 147);
            this.emojiTextBox.Name = "emojiTextBox";
            this.emojiTextBox.Size = new System.Drawing.Size(217, 20);
            this.emojiTextBox.TabIndex = 2;
            this.emojiTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // addReactionButton
            // 
            this.addReactionButton.Location = new System.Drawing.Point(17, 193);
            this.addReactionButton.Name = "addReactionButton";
            this.addReactionButton.Size = new System.Drawing.Size(216, 27);
            this.addReactionButton.TabIndex = 6;
            this.addReactionButton.Text = "Add Reaction";
            this.addReactionButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inviteAllButton
            // 
            this.inviteAllButton.Location = new System.Drawing.Point(18, 219);
            this.inviteAllButton.Name = "inviteAllButton";
            this.inviteAllButton.Size = new System.Drawing.Size(216, 27);
            this.inviteAllButton.TabIndex = 28;
            this.inviteAllButton.Text = "Invite";
            this.inviteAllButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 476);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.textBox2);
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

        private System.Windows.Forms.ToolTip toolTip1;
        private MetroFramework.Controls.MetroButton spamButton;
        private MetroFramework.Controls.MetroButton stopButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel tokenLoaded;
        private MetroFramework.Controls.MetroTextBox textBox2;
        private MetroFramework.Controls.MetroTextBox messageBox;
        private MetroFramework.Controls.MetroTextBox channelIDBox;
        private MetroFramework.Controls.MetroTextBox inviteBox;
        private MetroFramework.Controls.MetroButton quitButton;
        private MetroFramework.Controls.MetroButton leaveServer;
        private MetroFramework.Controls.MetroTextBox timeout;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton addReactionButton;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox emojiTextBox;
        private MetroFramework.Controls.MetroTextBox reactionMessageID;
        private MetroFramework.Controls.MetroTextBox reactionChannelID;
        private MetroFramework.Controls.MetroButton inviteAllButton;
    }
}


    }
}

