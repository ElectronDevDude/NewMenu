
namespace NewContext_Windows_Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.TemplateFile = new System.Windows.Forms.OpenFileDialog();
            this.SelectFileText = new System.Windows.Forms.Label();
            this.HelpButtonA = new System.Windows.Forms.Button();
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FileFormatInput = new System.Windows.Forms.TextBox();
            this.SelectFormatText = new System.Windows.Forms.Label();
            this.SelectionAddInfo = new System.Windows.Forms.Label();
            this.SelectionRemoveInfo = new System.Windows.Forms.Label();
            this.LoadedDisplay = new System.Windows.Forms.Label();
            this.UpdateIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ServerConnectionError = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::NewContext_Windows_Forms.Properties.Resources.NewContextTriring;
            this.pictureBox1.Location = new System.Drawing.Point(655, 630);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(64, 64);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(64, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.Font = new System.Drawing.Font("Space Invaders", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "©ElectronDev 2021\r\n";
            this.label1.Click += new System.EventHandler(this.copyright_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Location = new System.Drawing.Point(12, 648);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(129, 49);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.AutoSize = true;
            this.RemoveButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.Location = new System.Drawing.Point(385, 524);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(106, 19);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove File";
            this.RemoveButton.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(497, 524);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Add File";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CompleteButton
            // 
            this.CompleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompleteButton.Location = new System.Drawing.Point(585, 512);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(135, 42);
            this.CompleteButton.TabIndex = 1;
            this.CompleteButton.Text = "Change!";
            this.CompleteButton.UseVisualStyleBackColor = false;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // TemplateFile
            // 
            this.TemplateFile.InitialDirectory = "c:\\";
            this.TemplateFile.Title = "Template File Selector";
            this.TemplateFile.FileOk += new System.ComponentModel.CancelEventHandler(this.TemplateFile_FileOk);
            this.TemplateFile.HelpRequest += new System.EventHandler(this.HelpButton_Click);
            // 
            // SelectFileText
            // 
            this.SelectFileText.AutoSize = true;
            this.SelectFileText.BackColor = System.Drawing.Color.Transparent;
            this.SelectFileText.Font = new System.Drawing.Font("Space Invaders", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFileText.Location = new System.Drawing.Point(7, 152);
            this.SelectFileText.Name = "SelectFileText";
            this.SelectFileText.Size = new System.Drawing.Size(275, 26);
            this.SelectFileText.TabIndex = 5;
            this.SelectFileText.Text = "Select Template File:";
            // 
            // HelpButtonA
            // 
            this.HelpButtonA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpButtonA.BackColor = System.Drawing.Color.Transparent;
            this.HelpButtonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HelpButtonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButtonA.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.HelpButtonA.Location = new System.Drawing.Point(591, 12);
            this.HelpButtonA.Name = "HelpButtonA";
            this.HelpButtonA.Size = new System.Drawing.Size(129, 49);
            this.HelpButtonA.TabIndex = 6;
            this.HelpButtonA.Text = "Help";
            this.HelpButtonA.UseVisualStyleBackColor = false;
            this.HelpButtonA.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileSelectButton.Location = new System.Drawing.Point(325, 145);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(123, 44);
            this.FileSelectButton.TabIndex = 7;
            this.FileSelectButton.Text = "Select File";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 62);
            this.label3.TabIndex = 8;
            this.label3.Text = "ElectronDev\'s\r\nNew Menu modifier\r\n";
            // 
            // FileFormatInput
            // 
            this.FileFormatInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FileFormatInput.Location = new System.Drawing.Point(325, 231);
            this.FileFormatInput.Name = "FileFormatInput";
            this.FileFormatInput.Size = new System.Drawing.Size(136, 23);
            this.FileFormatInput.TabIndex = 9;
            this.FileFormatInput.Text = "e.g. \".PDF\"";
            this.FileFormatInput.Visible = false;
            // 
            // SelectFormatText
            // 
            this.SelectFormatText.AutoSize = true;
            this.SelectFormatText.BackColor = System.Drawing.Color.Transparent;
            this.SelectFormatText.Font = new System.Drawing.Font("Space Invaders", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFormatText.Location = new System.Drawing.Point(7, 231);
            this.SelectFormatText.Name = "SelectFormatText";
            this.SelectFormatText.Size = new System.Drawing.Size(252, 26);
            this.SelectFormatText.TabIndex = 10;
            this.SelectFormatText.Text = "Enter a file format:";
            this.SelectFormatText.Visible = false;
            // 
            // SelectionAddInfo
            // 
            this.SelectionAddInfo.AutoSize = true;
            this.SelectionAddInfo.BackColor = System.Drawing.Color.Transparent;
            this.SelectionAddInfo.Font = new System.Drawing.Font("Space Invaders", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionAddInfo.Location = new System.Drawing.Point(12, 353);
            this.SelectionAddInfo.Name = "SelectionAddInfo";
            this.SelectionAddInfo.Size = new System.Drawing.Size(662, 44);
            this.SelectionAddInfo.TabIndex = 11;
            this.SelectionAddInfo.Text = "Please select the file that you wish to use as a template in the\r\nnew menu.";
            // 
            // SelectionRemoveInfo
            // 
            this.SelectionRemoveInfo.AutoSize = true;
            this.SelectionRemoveInfo.BackColor = System.Drawing.Color.Transparent;
            this.SelectionRemoveInfo.Font = new System.Drawing.Font("Space Invaders", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionRemoveInfo.Location = new System.Drawing.Point(8, 397);
            this.SelectionRemoveInfo.Name = "SelectionRemoveInfo";
            this.SelectionRemoveInfo.Size = new System.Drawing.Size(602, 44);
            this.SelectionRemoveInfo.TabIndex = 12;
            this.SelectionRemoveInfo.Text = "Please enter the file extension of the file type you want\r\nto remove!";
            this.SelectionRemoveInfo.Visible = false;
            // 
            // LoadedDisplay
            // 
            this.LoadedDisplay.AutoSize = true;
            this.LoadedDisplay.BackColor = System.Drawing.Color.Transparent;
            this.LoadedDisplay.Location = new System.Drawing.Point(454, 160);
            this.LoadedDisplay.Name = "LoadedDisplay";
            this.LoadedDisplay.Size = new System.Drawing.Size(110, 15);
            this.LoadedDisplay.TabIndex = 13;
            this.LoadedDisplay.Text = "No File Loaded.";
            // 
            // UpdateIcon
            // 
            this.UpdateIcon.BalloonTipText = "An update is available for the New Menu Modifier! Click this notification for mor" +
    "e details!\r\n";
            this.UpdateIcon.BalloonTipTitle = "Update Available";
            this.UpdateIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("UpdateIcon.Icon")));
            this.UpdateIcon.Text = "Checking for updates...";
            this.UpdateIcon.BalloonTipClicked += new System.EventHandler(this.UpdateIcon_BalloonTipClicked);
            this.UpdateIcon.BalloonTipClosed += new System.EventHandler(this.ServerConnectionError_BalloonTipClosed);
            this.UpdateIcon.Click += new System.EventHandler(this.UpdateIcon_BalloonTipClicked);
            // 
            // ServerConnectionError
            // 
            this.ServerConnectionError.BalloonTipText = "Connection to version checker failed.";
            this.ServerConnectionError.BalloonTipTitle = "Unable to check for updates.";
            this.ServerConnectionError.Icon = ((System.Drawing.Icon)(resources.GetObject("ServerConnectionError.Icon")));
            this.ServerConnectionError.Text = "Network connection failed";
            this.ServerConnectionError.BalloonTipClicked += new System.EventHandler(this.UpdateIcon_BalloonTipClicked);
            this.ServerConnectionError.BalloonTipClosed += new System.EventHandler(this.ServerConnectionError_BalloonTipClosed);
            this.ServerConnectionError.Click += new System.EventHandler(this.UpdateIcon_BalloonTipClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::NewContext_Windows_Forms.Properties.Resources.NewContext_Backgroundsmaller;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(732, 709);
            this.ControlBox = false;
            this.Controls.Add(this.LoadedDisplay);
            this.Controls.Add(this.SelectionRemoveInfo);
            this.Controls.Add(this.SelectionAddInfo);
            this.Controls.Add(this.SelectFormatText);
            this.Controls.Add(this.FileFormatInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileSelectButton);
            this.Controls.Add(this.HelpButtonA);
            this.Controls.Add(this.SelectFileText);
            this.Controls.Add(this.CompleteButton);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Space Invaders", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(748, 748);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.Text = "New Menu Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RadioButton RemoveButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.OpenFileDialog TemplateFile;
        private System.Windows.Forms.Label SelectFileText;
        private System.Windows.Forms.Button HelpButtonA;
        private System.Windows.Forms.Button FileSelectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FileFormatInput;
        private System.Windows.Forms.Label SelectFormatText;
        private System.Windows.Forms.Label SelectionAddInfo;
        private System.Windows.Forms.Label SelectionRemoveInfo;
        private System.Windows.Forms.Label LoadedDisplay;
        private System.Windows.Forms.NotifyIcon UpdateIcon;
        private System.Windows.Forms.NotifyIcon ServerConnectionError;
    }
}

