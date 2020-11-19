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

        private string RestoreUnicode(string text)
        {
            char[] str;

            Encoding latin = Encoding.GetEncoding(1252);
            Encoding unicode = Encoding.GetEncoding(GetUnicodeCode());

            str = unicode.GetChars(latin.GetBytes(text.ToCharArray()));

            return new string(str);
        }

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

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            if (betterFolderBrowser1.ShowDialog(this) == DialogResult.OK)
            {
                selectedFolderTextbox.Text = betterFolderBrowser1.SelectedFolder;
                startButton.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                string originalFileName = "";
                string restoredFileName = "";
                string originalFileFullName = "";

                DirectoryInfo d = new DirectoryInfo(selectedFolderTextbox.Text);
                FileInfo[] infos = d.GetFiles("*", SearchOption.AllDirectories);

                foreach (FileInfo f in infos)
                {
                    originalFileName = f.Name;
                    restoredFileName = RestoreUnicode(f.Name);
                    originalFileFullName = f.FullName;

                    if (!originalFileName.Equals(restoredFileName) && !restoredFileName.Contains("?"))
                    {
                        File.Move(f.FullName, f.FullName.Replace(originalFileName, restoredFileName));

                        folderRenameOutput.AppendText("-\"" + f.FullName + "\" changed to \"" +
                            f.FullName.Replace(originalFileName, restoredFileName) + "\"" + Environment.NewLine);

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
    }
}
