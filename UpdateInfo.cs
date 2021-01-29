using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewContext_Windows_Forms
{
    public partial class Updates : Form
    {
        public Updates()
        {
            InitializeComponent();
            Shown += Updates_Shown;
        }
        private void Updates_Shown(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            VersionLabel.Text = String.Format("Current Version: {0}  | Most recent version: {1}",new object[] {fvi.FileVersion, Globals.Serverversion });
        }
        private void CloseButton_Click(object sender, EventArgs e) => Close();

        private void Button1_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("https://github.com/ElectronDevDude/NewMenu/releases");
        private void copyright_Click(object sender, EventArgs e) => Process.Start("https://github.com/ElectronDevDude/NewMenu/blob/main/LICENSE");
    }
}
