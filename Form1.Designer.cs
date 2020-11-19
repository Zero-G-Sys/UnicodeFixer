namespace UnicodeFixer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fixedTextBox = new System.Windows.Forms.RichTextBox();
            this.brokenTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderRenameOutput = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.selectedFolderTextbox = new System.Windows.Forms.TextBox();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.betterFolderBrowser1 = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.unicodeOrigin = new System.Windows.Forms.ComboBox();
            this.toolTipHelpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fixedTextBox);
            this.groupBox1.Controls.Add(this.brokenTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instant Convert";
            this.toolTipHelpInfo.SetToolTip(this.groupBox1, "Input text into the left textbox to restore it.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fixed Text: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broken text:";
            // 
            // fixedTextBox
            // 
            this.fixedTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fixedTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fixedTextBox.Location = new System.Drawing.Point(346, 37);
            this.fixedTextBox.Name = "fixedTextBox";
            this.fixedTextBox.ReadOnly = true;
            this.fixedTextBox.Size = new System.Drawing.Size(329, 180);
            this.fixedTextBox.TabIndex = 1;
            this.fixedTextBox.Text = "";
            // 
            // brokenTextBox
            // 
            this.brokenTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brokenTextBox.Location = new System.Drawing.Point(11, 37);
            this.brokenTextBox.Name = "brokenTextBox";
            this.brokenTextBox.Size = new System.Drawing.Size(329, 180);
            this.brokenTextBox.TabIndex = 0;
            this.brokenTextBox.Text = "";
            this.brokenTextBox.TextChanged += new System.EventHandler(this.brokenTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.folderRenameOutput);
            this.groupBox2.Controls.Add(this.startButton);
            this.groupBox2.Controls.Add(this.selectedFolderTextbox);
            this.groupBox2.Controls.Add(this.selectFolderButton);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.Location = new System.Drawing.Point(13, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folder Convert";
            this.toolTipHelpInfo.SetToolTip(this.groupBox2, "Restore filenames. Rename all files in selected folder and subfolders.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Output:";
            // 
            // folderRenameOutput
            // 
            this.folderRenameOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.folderRenameOutput.Location = new System.Drawing.Point(10, 107);
            this.folderRenameOutput.Name = "folderRenameOutput";
            this.folderRenameOutput.ReadOnly = true;
            this.folderRenameOutput.Size = new System.Drawing.Size(664, 190);
            this.folderRenameOutput.TabIndex = 3;
            this.folderRenameOutput.Text = "";
            this.folderRenameOutput.TextChanged += new System.EventHandler(this.folderRenameOutput_TextChanged);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(6, 50);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(668, 32);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // selectedFolderTextbox
            // 
            this.selectedFolderTextbox.Location = new System.Drawing.Point(96, 23);
            this.selectedFolderTextbox.Name = "selectedFolderTextbox";
            this.selectedFolderTextbox.Size = new System.Drawing.Size(578, 23);
            this.selectedFolderTextbox.TabIndex = 1;
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(6, 21);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(83, 23);
            this.selectFolderButton.TabIndex = 0;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // betterFolderBrowser1
            // 
            this.betterFolderBrowser1.Multiselect = false;
            this.betterFolderBrowser1.RootFolder = "C:";
            this.betterFolderBrowser1.Title = "Please select a folder...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select origin encoding:";
            this.toolTipHelpInfo.SetToolTip(this.label1, "Select in what language the gliberish text was originaly from.");
            // 
            // unicodeOrigin
            // 
            this.unicodeOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unicodeOrigin.FormattingEnabled = true;
            this.unicodeOrigin.Items.AddRange(new object[] {
            "Japanese",
            "Chinese"});
            this.unicodeOrigin.Location = new System.Drawing.Point(146, 12);
            this.unicodeOrigin.Name = "unicodeOrigin";
            this.unicodeOrigin.Size = new System.Drawing.Size(121, 21);
            this.unicodeOrigin.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 585);
            this.Controls.Add(this.unicodeOrigin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Unicode Fixer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox selectedFolderTextbox;
        private System.Windows.Forms.Button selectFolderButton;
        private WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser betterFolderBrowser1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox fixedTextBox;
        private System.Windows.Forms.RichTextBox brokenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox unicodeOrigin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox folderRenameOutput;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ToolTip toolTipHelpInfo;
    }
}

