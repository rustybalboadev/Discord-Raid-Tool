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
            this.SuspendLayout();
            // 
            // spamButton
            // 
            this.spamButton.Location = new System.Drawing.Point(23, 323);
            this.spamButton.Name = "spamButton";
            this.spamButton.Size = new System.Drawing.Size(111, 23);
            this.spamButton.TabIndex = 12;
            this.spamButton.Text = "Spam";
            this.spamButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(139, 323);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(101, 23);
            this.stopButton.TabIndex = 13;
            this.stopButton.Text = "Stop";
            this.stopButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(23, 131);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(194, 25);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Enter Server Invite Code";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 184);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Enter Channel ID";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 229);
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
            this.tokenLoaded.Location = new System.Drawing.Point(482, 22);
            this.tokenLoaded.Name = "tokenLoaded";
            this.tokenLoaded.Size = new System.Drawing.Size(95, 19);
            this.tokenLoaded.TabIndex = 19;
            this.tokenLoaded.Text = "Tokens Loaded";
            this.tokenLoaded.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(296, 44);
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
            this.messageBox.Location = new System.Drawing.Point(24, 251);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(216, 20);
            this.messageBox.TabIndex = 21;
            this.messageBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // channelIDBox
            // 
            this.channelIDBox.Location = new System.Drawing.Point(23, 206);
            this.channelIDBox.Name = "channelIDBox";
            this.channelIDBox.Size = new System.Drawing.Size(217, 20);
            this.channelIDBox.TabIndex = 22;
            this.channelIDBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inviteBox
            // 
            this.inviteBox.Location = new System.Drawing.Point(23, 161);
            this.inviteBox.Name = "inviteBox";
            this.inviteBox.Size = new System.Drawing.Size(217, 20);
            this.inviteBox.TabIndex = 23;
            this.inviteBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(688, 10);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(89, 28);
            this.quitButton.TabIndex = 24;
            this.quitButton.Text = "Quit";
            this.quitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // leaveServer
            // 
            this.leaveServer.Location = new System.Drawing.Point(23, 352);
            this.leaveServer.Name = "leaveServer";
            this.leaveServer.Size = new System.Drawing.Size(217, 23);
            this.leaveServer.TabIndex = 25;
            this.leaveServer.Text = "Leave Server";
            this.leaveServer.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timeout
            // 
            this.timeout.Location = new System.Drawing.Point(23, 297);
            this.timeout.Name = "timeout";
            this.timeout.Size = new System.Drawing.Size(217, 20);
            this.timeout.TabIndex = 26;
            this.timeout.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 272);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 19);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "Timeout in ms";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.timeout);
            this.Controls.Add(this.leaveServer);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.inviteBox);
            this.Controls.Add(this.channelIDBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tokenLoaded);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.spamButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Discord Raid Tool";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
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
    }
}

