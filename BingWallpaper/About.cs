using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 必应壁纸
{
    public partial class About : Form
    {
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern int ReleaseCapture();
        public const int WM_SysCommand = 0x0112;
        public const int SC_MOVE = 0xF012;
        string Shell;
        string Param;

        public About(string info)
        {
            InitializeComponent();
            label_About.Text = info;
            Width = label_About.Width + 20;
            Height = label_About.Height + 90;
            label_About.Location = new Point((Width - label_About.Width) / 2, 10);
            linkLabel_Contact.Location = new Point((Width - linkLabel_Contact.Width) / 2, label_About.Location.Y + label_About.Height + 10);
            label_Cancel.Location = new Point((Width - label_Cancel.Width) / 2, linkLabel_Contact.Location.Y + linkLabel_Contact.Height + 10);
            label_About.Parent = label_BG;
            linkLabel_Contact.Parent = label_BG;
            label_BG.Size = new Size(Width - 6, Height - 6);
            label_BG.Location = new Point(3, 3);
            Shell = @"explorer.exe";
            Param = @"http://bybz.tech/html/jump/fromabout.html";
        }

        public About(string info, string shell, string parm, string label)
        {
            InitializeComponent();
            label_About.Text = info;
            Width = label_About.Width + 20;
            Height = label_About.Height + 90;
            label_About.Location = new Point((Width - label_About.Width) / 2, 10);
            linkLabel_Contact.Location = new Point((Width - linkLabel_Contact.Width) / 2, label_About.Location.Y + label_About.Height + 10);
            label_Cancel.Location = new Point((Width - label_Cancel.Width) / 2, linkLabel_Contact.Location.Y + linkLabel_Contact.Height + 10);
            label_About.Parent = label_BG;
            linkLabel_Contact.Parent = label_BG;
            label_BG.Size = new Size(Width - 6, Height - 6);
            label_BG.Location = new Point(3, 3);
            linkLabel_Contact.Text = label;
            Shell = shell;
            Param = parm;
        }

        public static void Show(string info)
        {
            About box = new About(info);
            box.ShowDialog();
        }
        public static void Show(string info, string shell, string parm, string label)
        {
            About box = new About(info, shell, parm, label);
            box.ShowDialog();
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).BackColor = SystemColors.GrayText;
        }

        private void label_MouseUp(object sender, MouseEventArgs e)
        {
            ((Label)sender).BackColor = SystemColors.Control;
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = SystemColors.ControlDark;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = SystemColors.Control;
        }

        private void label_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel_Contact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Shell,Param);
        }

        private void label_About_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle.ToInt32(), WM_SysCommand, SC_MOVE, 0);
        }

        private void label_BG_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle.ToInt32(), WM_SysCommand, SC_MOVE, 0);
        }
    }
}
