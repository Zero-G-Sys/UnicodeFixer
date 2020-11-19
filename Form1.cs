using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace UnicodeFixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            unicodeOrigin.SelectedIndex = 0; // Set defualt combobox as japanese
        }

        // Returns Encoding code for language selected in combobox
        private int GetUnicodeCode()
        {
            int code = 932;

            switch (unicodeOrigin.SelectedIndex)
            {
                case 0:
                    code = 932; // Japanese
                    break;
                case 1:
                    code = 936; // Chinese
                    break;
                default:
                    throw new Exception("Error in selected origin unicode, select again. " +
                        "If the error persists contact developer");
                    break;
            }

            return code;
        }

        // Recieves broken text and restores it by chaging it to latin encode then to
        // proper unicode
        private string RestoreUnicode(string text)
        {
            char[] str;

            Encoding latin = Encoding.GetEncoding(1252);
            Encoding unicode = Encoding.GetEncoding(GetUnicodeCode());

            str = unicode.GetChars(latin.GetBytes(text.ToCharArray()));

            return new string(str);
        }

        // Calls RestoreUnicode method each time left richtextbox text is changed
        // Prints result in right richtextbox
        private void brokenTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fixedTextBox.Text = RestoreUnicode(brokenTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button to call BetterFolderBrowser dialog
        // Prints result in textbox and activates strat button
        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            if (betterFolderBrowser1.ShowDialog(this) == DialogResult.OK)
            {
                selectedFolderTextbox.Text = betterFolderBrowser1.SelectedFolder;
                startButton.Enabled = true;
            }
        }

        // Get all files from selected folder and changes the name of files
        // with bad unicode
        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                string originalFileName = "";
                string restoredFileName = "";

                DirectoryInfo d = new DirectoryInfo(selectedFolderTextbox.Text);
                DirectoryInfo[] subdirectories = d.GetDirectories("*", SearchOption.AllDirectories);
                FileInfo[] infos = d.GetFiles("*", SearchOption.AllDirectories); // AllDirectories for subfolders

                foreach (FileInfo f in infos)
                {
                    originalFileName = f.Name;
                    restoredFileName = RestoreUnicode(f.Name);

                    // If name changed (name had bad unicode) or
                    // name doesn't have ? (trying to restore good unicode)
                    if (!originalFileName.Equals(restoredFileName) && !restoredFileName.Contains("?"))
                    {
                        File.Move(f.FullName, f.FullName.Replace(originalFileName, restoredFileName));

                        // Output text
                        folderRenameOutput.AppendText("-\"" + f.FullName + "\" file changed to \"" +
                            f.FullName.Replace(originalFileName, restoredFileName) + "\"" + Environment.NewLine);

                        // Fix output text font change when displying unicode
                        folderRenameOutput.Font = new Font(folderRenameOutput.Font.FontFamily,
                            folderRenameOutput.Font.Size, folderRenameOutput.Font.Style);
                    }
                }

                foreach (DirectoryInfo subdir in subdirectories)
                {
                    originalFileName = subdir.Name;
                    restoredFileName = RestoreUnicode(subdir.Name);

                    if (!originalFileName.Equals(restoredFileName) && !restoredFileName.Contains("?"))
                    {
                        Directory.Move(subdir.FullName, subdir.FullName.Replace(originalFileName, restoredFileName));

                        folderRenameOutput.AppendText("-\"" + subdir.FullName + "\" directory changed to \"" +
                            subdir.FullName.Replace(originalFileName, restoredFileName) + "\"" +
                            Environment.NewLine);

                        folderRenameOutput.Font = new Font(folderRenameOutput.Font.FontFamily,
                            folderRenameOutput.Font.Size, folderRenameOutput.Font.Style);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Scroll to bottom of folderOutputTextbox
        private void folderRenameOutput_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            folderRenameOutput.SelectionStart = folderRenameOutput.Text.Length;
            // scroll it automatically
            folderRenameOutput.ScrollToCaret();
        }
    }
}
