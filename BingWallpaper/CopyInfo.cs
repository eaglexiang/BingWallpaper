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
    public partial class CopyInfo : Form
    {
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern int ReleaseCapture();
        public const int WM_SysCommand = 0x0112;
        public const int SC_MOVE = 0xF012;

        public CopyInfo(string info)
        {
            InitializeComponent();
            label_Info.Text = info;
            Width = label_Info.Width + 20;
            Height = label_Info.Height + 60;
            label_Copy.Location = new Point((Width - label_Copy.Width * 2) / 3, Height - 40);
            label_Cancel.Location = new Point(label_Copy.Location.X * 2 + label_Copy.Width, label_Copy.Location.Y);
            label_Info.Location = new Point((Width - label_Info.Width) / 2, (label_Copy.Location.Y - label_Info.Height) / 2);
            label_Info.Parent = label_BG;
            label_BG.Size = new Size(Width - 6, Height - 6);
            label_BG.Location = new Point(3, 3);
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

        private void label_Copy_Click(object sender, EventArgs e)
        {
            string info = label_Info.Text;
            info = info.Replace('\n', ' ');
            Clipboard.SetText(info);
            Close();
        }

        private void label_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static void Show(string info)
        {
            CopyInfo box = new CopyInfo(info);
            box.ShowDialog();
        }

        private void label_Info_MouseDown(object sender, MouseEventArgs e)
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
