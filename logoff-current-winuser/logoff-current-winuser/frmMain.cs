using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace logoff_current_winuser
{
    public partial class frmMain : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0, 0);
        }
    }
}
