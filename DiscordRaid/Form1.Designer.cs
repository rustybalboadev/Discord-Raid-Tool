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
            this.SuspendLayout();
            // 
            // spamButton
            // 
            this.spamButton.Location = new System.Drawing.Point(23, 277);
            this.spamButton.Name = "spamButton";
            this.spamButton.Size = new System.Drawing.Size(111, 23);
            this.spamButton.TabIndex = 12;
            this.spamButton.Text = "Spam";
            this.spamButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(141, 277);
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
            this.metroLabel1.Location = new System.Drawing.Point(24, 139);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(151, 19);
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
            this.messageBox.Location = new System.Drawing.Point(23, 251);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(219, 20);
            this.messageBox.TabIndex = 21;
            this.messageBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // channelIDBox
            // 
            this.channelIDBox.Location = new System.Drawing.Point(23, 206);
            this.channelIDBox.Name = "channelIDBox";
            this.channelIDBox.Size = new System.Drawing.Size(219, 20);
            this.channelIDBox.TabIndex = 22;
            this.channelIDBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inviteBox
            // 
            this.inviteBox.Location = new System.Drawing.Point(23, 161);
            this.inviteBox.Name = "inviteBox";
            this.inviteBox.Size = new System.Drawing.Size(219, 20);
            this.inviteBox.TabIndex = 23;
            this.inviteBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

