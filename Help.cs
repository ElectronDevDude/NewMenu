using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace NewContext_Windows_Forms
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            Shown += Help_Shown;
        }
        private void Help_Shown(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            VersionDisplay.Text = "Version: "+ fvi.FileVersion + "  |  More features coming soon!";
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e) => new Updates().Show();

        private void copyright_Click(object sender, EventArgs e)=>Process.Start("https://github.com/ElectronDevDude/NewMenu/blob/main/LICENSE");
    }
}
