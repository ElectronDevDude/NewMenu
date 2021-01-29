using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using Microsoft.Win32;
namespace NewContext_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        InitializeComponent();
        Shown += Form1_Shown;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            var delaytime = Task.Delay(10000);
            UpdateIcon.Visible = true;
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            try
            {
                int compareresult;
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://geinc.xyz/NME");
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                int code = (int)response.StatusCode;
                if (code == 200)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                    var clientversion = new Version(fvi.FileVersion);
                    Globals.Serverversion = readStream.ReadToEnd();
                    compareresult = clientversion.CompareTo(new Version(Globals.Serverversion));
                    if (compareresult==0) {
                        UpdateIcon.Visible = false;
                        return;
                    }
                    else
                    {
                        UpdateIcon.ShowBalloonTip(10);
                    }

                }
                else
                {
                    UpdateIcon.Visible = false;
                    ServerConnectionError.Visible = true;
                    Globals.Serverversion = "N/A";
                    ServerConnectionError.ShowBalloonTip(10);
                }
            }
            catch (WebException) {
                UpdateIcon.Visible = false;
                ServerConnectionError.Visible = true;
                Globals.Serverversion = "N/A";
                ServerConnectionError.ShowBalloonTip(10);
            }

        }
            private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            TemplateFile.ShowDialog();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help HelpMenu = new Help();
            HelpMenu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SelectFormatText.Hide();
                FileFormatInput.Hide();
                SelectFileText.Show();
                FileSelectButton.Show();
                SelectionAddInfo.Show();
                SelectionRemoveInfo.Hide();
                if (Globals.Newfileloaded) {
                    LoadedDisplay.Hide();
                }
                else
                {
                    LoadedDisplay.Show();
                }
            }
            else
            {
                SelectFormatText.Show();
                FileFormatInput.Show();
                SelectFileText.Hide();
                FileSelectButton.Hide();
                SelectionAddInfo.Hide();
                SelectionRemoveInfo.Show();
                LoadedDisplay.Hide();
            }
        }

        private void TemplateFile_FileOk(object sender, CancelEventArgs e)
        {
            if (TemplateFile.SafeFileName.Count(f=>(f.ToString()=="."))>1) {
                MessageBox.Show("Invalid file name");
                return;
            }
            if (TemplateFile.CheckFileExists)
            {

                MessageBox.Show("File: '" + TemplateFile.SafeFileName + "' loaded!");
                Globals.Newfileloaded = true;
                LoadedDisplay.Hide();
            }
            else {
                return;
                    }
        }
        private void UpdateIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            Updates UpdateMenu = new Updates();
            UpdateMenu.Show();
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            if (!Globals.Newfileloaded)
            {
                MessageBox.Show("Please select a file to be your template!");
                return;
            }
            if (!TemplateFile.CheckFileExists) {
                MessageBox.Show("File invalid");
                return;
            }
            string newfilename = "Template" + TemplateFile.SafeFileName.Substring(TemplateFile.SafeFileName.IndexOf("."));
            string shellnewdir = @"C:\Windows\ShellNew\"+ newfilename;
            System.IO.File.Copy(TemplateFile.FileName,shellnewdir,true);
            RegistryKey shellnewkey = Registry.ClassesRoot.CreateSubKey(TemplateFile.SafeFileName.Substring(TemplateFile.SafeFileName.IndexOf("."))+@"\ShellNew\",true);
            shellnewkey.SetValue("FileName", shellnewdir);
            shellnewkey.Close();
            MessageBox.Show("Menu updated!");

        }

        private void ServerConnectionError_BalloonTipClosed(object sender, EventArgs e)
        {
            ServerConnectionError.Visible = false;
            UpdateIcon.Visible = false;
        }
        private void copyright_Click(object sender, EventArgs e) => Process.Start("https://github.com/ElectronDevDude/NewMenu/blob/main/LICENSE");
    }
    public static class Globals
    {
        public static bool Newfileloaded = false;
        public static string Serverversion;
    }
}
