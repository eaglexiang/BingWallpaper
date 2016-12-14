using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.IO;
using IWshRuntimeLibrary;
using System.Diagnostics;
using System.Net;

namespace 必应壁纸
{

    public partial class Form_Main : Form
    {
        Size EST;//全屏时暂存窗体尺寸
        bool IsFullScreen = false;//窗体是否处于全屏
        string Information;//图片相关信息，如图片名、拍摄地
        Thread FindURL;//分析HTML代码的线程
        Thread FindLatest;//检查新版本的线程
        string myVersion = "1.11.7";//关于菜单显示的版本号
        string BetaVersion = "";//检查到的最新测试版本号
        string ReleaseVersion = "";//检查到的最新稳定版本号
        int tried = 0;//已尝试刷新次数
        int hided = 0;//主窗体的隐藏层数
        //Thread loading;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Thread_Load()
        {
            try
            {
                //抓取图片信息
                HtmlDocument html = webBrowser1.Document;
                if (html != null)
                {
                    //HtmlElement bgDiv = html.GetElementById("bgDiv");
                    HtmlElement hplaT = html.GetElementById("hplaT");

                    ////获取图片URL
                    //if (bgDiv != null)
                    //{
                    //    string style = bgDiv.Style;//包含壁纸地址的div
                    //    if (style != null)
                    //    {
                    //        MyFiles.HTML = style;
                    //    }
                    //}
                    MyFiles.HTML = webBrowser1.DocumentText;

                    //抓取信息
                    HtmlElement sh_cp = html.GetElementById("sh_cp");
                    if (sh_cp != null)
                    {
                        if (图片信息ToolStripMenuItem.Enabled == false)
                        {
                            string info = sh_cp.GetAttribute("title");
                            if (info != null)
                            {
                                Information = info;
                                图片信息ToolStripMenuItem.Enabled = true;//使查看图片信息按钮可用
                                MyFiles.Log += "抓取到图片信息\n" + Information + '\n';
                            }
                        }
                    }
                    //抓取信息2
                    if (hplaT != null)
                    {
                        if (图片信息ToolStripMenuItem.Enabled == false)
                        {
                            HtmlElement hplaTtl = hplaT.FirstChild;
                            if (hplaTtl != null)
                            {
                                HtmlElement tmp = hplaTtl.NextSibling;
                                if (tmp != null)
                                {
                                    HtmlElement first = tmp.FirstChild;
                                    if (first != null)
                                    {
                                        HtmlElement next = first.NextSibling;
                                        if (next != null)
                                        {
                                            string title = hplaTtl.InnerText;//标题
                                            string location = next.InnerText;//拍摄地
                                            if (title != null && location != null)
                                            {
                                                if (!图片信息ToolStripMenuItem.Enabled)
                                                {
                                                    Information = title + '\n' + location;
                                                    图片信息ToolStripMenuItem.Enabled = true;//使查看图片信息按钮可用
                                                    MyFiles.Log += "抓取到图片信息\n" + Information + '\n';
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                //显示图片
                if (MyFiles.Picture != null)
                {
                    if (pictureBox1.Image == null)
                    {
                        MyFiles.Log += "抓取到图片\n";
                        pictureBox1.Image = MyFiles.Picture;
                        EnableLabels();
                        OneKeyWork();
                    }
                }

                //停止timer_refresh
                if (pictureBox1.Image != null && Information != null && Information != "")
                {
                    if (timer_Refresh.Enabled)
                    {
                        timer_Refresh.Stop();
                        MyFiles.Log += "停止抓取\n";
                    }
                }

                //检查新版本
                if (BetaVersion != "" && ReleaseVersion != "")
                {
                    MyFiles.Log = MyFiles.Log +
                        "LocalVersion: " + myVersion + "\n";

                    if (myVersion != BetaVersion && myVersion != ReleaseVersion)
                    {
                        string Version;
                        if (BetaVersion != "error")
                        {
                            Version = BetaVersion;
                        }
                        else
                        {
                            Version = ReleaseVersion;
                        }

                        string info = Version;
                        Form_Hide();
                        检查更新ToolStripMenuItem.Text = "检查更新";
                        检查更新ToolStripMenuItem.Enabled = true;
                        if (Version == "error")
                        {
                            About.Show("更新检查貌似出了点问题\n" + info, @"explore", @"http://bybz.tech/html/jump/fromupdate.html", "手动检查");
                        }
                        else
                        {
                            About.Show("已检查到更新版本\n" + info, @"explore", @"http://bybz.tech/html/jump/fromupdate.html", "立即更新");
                        }
                        Form_Show();
                        检查更新ToolStripMenuItem.Text = "检查更新";
                        检查更新ToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        MyFiles.Log += "不存在更新版本\n";
                        检查更新ToolStripMenuItem.Text = "暂无更新";
                    }
                    BetaVersion = "";
                    ReleaseVersion = "";
                }
            }
            catch (Exception ex)
            {
                MyFiles.Log += ex.Message + '\n';
            }
        }

        //public delegate string getStr();
        //int times_Load = 0;
        //private string getHTML()
        //{
        //    if (times_Load == 5)
        //    {
        //        webBrowser1.Refresh();
        //        times_Load = 0;
        //    }
        //    else
        //    {
        //        ++times_Load;
        //    }
        //    return webBrowser1.DocumentText;
        //}

        //public delegate void Func();
        private void EnableLabels()
        {
            label_Download.Enabled = true;
            IfSaved();
            label_Wallpaper.Enabled = true;
            label_Path.Enabled = true;
            this.Text = "Bing 壁纸";
            //MyFiles.Inited = true;
        }
        private void label_Download_Click(object sender, EventArgs e)
        {
            Download();
        }//开始下载

        private void Download()
        {
            try
            {
                if (MyFiles.Picture != null)
                {
                    MyFiles.Save();
                    if (!IfSaved())
                    {
                        if (MyFiles.Download() != null)
                        {
                            MyFiles.Save();
                            IfSaved();
                        }
                        else
                        {
                            MyFiles.Log += "收藏失败\n";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467259)
                {
                    MyFiles.Log += "该收藏目录需要管理员权限\n";
                }
                else
                {
                    MyFiles.Log += ex.Message + '\n';
                }
            }
        }

        private void SetWallpaper()
        {
            try
            {
                Download();
                MyFiles.SetWallpaper();
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467259)
                {
                    MyFiles.Log += "当前的收藏目录需要更高权限，建议您更改收藏目录。如果一定要在此目录，请将本程序以管理员方式启动。\n";
                }
                else
                {
                    MyFiles.Log += ex.Message + '\n';
                }
            }
        }
        private void label_Wallpaper_Click(object sender, EventArgs e)
        {
            SetWallpaper();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int SystemParametersInfo(
         int uAction,
         int uParam,
         string lpvParam,
         int fuWinIni
         );
        private void OneKeyWork()
        {
            if (Program.OneKey)
            {
                string filepath = System.IO.Path.GetTempPath() + @"\tmp.tmp";
                try
                {
                    MyFiles.Picture.Save(filepath, System.Drawing.Imaging.ImageFormat.Bmp);
                    SystemParametersInfo(20, 0, filepath, 0x2);
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MyFiles.Log += ex.Message + '\n';
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MyFiles.Log = "欢迎使用\n";
                this.KeyPreview = true;
                //MyFiles.Init();
                label_Path.Text = MyFiles.Path_Save;
                FindURL = new Thread(MyFiles.GetURLofImage);
                FindURL.IsBackground = true;
                MyFiles.Log += "开始搜索图片\n";
                FindURL.Start();
                MyFiles.Log += "开始状态检查\n";
                timer_Load.Start();
            }
            catch (Exception ex)
            {
                MyFiles.Log += ex.Message + '\n';
            }
        }

        /// <summary>
        /// 检查今日壁纸是否已经收藏过
        /// </summary>
        bool IfSaved()
        {
            if (MyFiles.Exsit())
            {
                label_Download.Enabled = false;
                label_Download.Text = "已经收藏";
                label_Exit.Text = "完成";
                return true;
            }
            else
            {
                label_Exit.Text = "取消";
                return false;
            }
        }

        private void label_ChooseFolder_Click(object sender, EventArgs e)
        {
            MyFiles.Set_Path_Save();
            if (label_Path.Text != MyFiles.Path_Save)
            {
                MessageBoxButtons mbb = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("请问您是否需要将已收藏壁纸全部复制到新的目录？", "对了", mbb);
                if (dr == DialogResult.OK)
                {
                    Process process = new Process();//创建进程对象  
                    string command = "copy /y " + label_Path.Text + "\\*.jpg " + MyFiles.Path_Save + "\\";
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "cmd.exe";//设定需要执行的命令  
                    startInfo.Arguments = "/C " + command;//“/C”表示执行完命令后马上退出  
                    startInfo.UseShellExecute = false;//不使用系统外壳程序启动  
                    startInfo.RedirectStandardInput = false;//不重定向输入  
                    startInfo.RedirectStandardOutput = true; //重定向输出  
                    startInfo.CreateNoWindow = true;//不创建窗口  
                    process.StartInfo = startInfo;
                    try
                    {
                        if (process.Start())//开始进程  
                        {
                            process.WaitForExit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MyFiles.Log += ex.Message + '\n';
                    }
                    finally
                    {
                        if (process != null)
                            process.Close();
                    }
                }
            }
            label_Path.Text = MyFiles.Path_Save;
            IfSaved();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Left)
            {
                FullScreen();
            }
        }

        private void FullScreen()
        {
            IsFullScreen = !IsFullScreen;

            Form_Hide();

            if (IsFullScreen)
            {
                EST = this.MaximumSize;
                this.MaximumSize = new System.Drawing.Size(0, 0);
                this.MinimumSize = new System.Drawing.Size(0, 0);

                label_ChooseFolder.Visible = false;
                label_Wallpaper.Visible = false;
                label_Download.Visible = false;
                label_Exit.Visible = false;
                label_Path.Visible = false;
                richTextBox_Logs.Visible = false;

                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.MaximumSize = EST;
                this.MinimumSize = EST;

                label_ChooseFolder.Visible = true;
                label_Wallpaper.Visible = true;
                label_Download.Visible = true;
                label_Exit.Visible = true;
                label_Path.Visible = true;
                richTextBox_Logs.Visible = true;

                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }

            Form_Show();
        }

        private void Form_Hide()
        {
            ++hided;
            while (this.Opacity > 0)
            {
                Thread.Sleep(10);
                this.Opacity -= 0.1;
            }
        }

        private void Form_Show()
        {
            --hided;
            if (hided <= 0)
            {
                this.Refresh();
                while (this.Opacity < 1)
                {
                    Thread.Sleep(10);
                    this.Opacity += 0.1;
                }
            }
        }

        private void label_Path_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(MyFiles.Path_Save))
                {
                    System.Diagnostics.Process.Start("explorer.exe", MyFiles.Path_Save);
                }
                else
                {
                    Directory.CreateDirectory(MyFiles.Path_Save);
                    System.Diagnostics.Process.Start("explorer.exe", MyFiles.Path_Save);
                }
            }
            catch (Exception ex)
            {
                MyFiles.Log += ex.Message + '\n';
            }
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = SystemColors.ControlDark;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = SystemColors.Control;
        }

        private void label_Path_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                label_MouseLeave(sender, e);
                label_Path.Text = MyFiles.Path_Save;
            }
            catch
            {
                System.Environment.Exit(0);
            }
        }

        private void label_Path_MouseEnter(object sender, EventArgs e)
        {
            label_MouseEnter(sender, e);
            label_Path.Text = "设置目录";
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).BackColor = SystemColors.GrayText;
        }

        private void label_MouseUp(object sender, MouseEventArgs e)
        {
            ((Label)sender).BackColor = SystemColors.Control;
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Form_Hide();
            Close();
        }

        private void 懒人助手ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
            "是否添加一键收藏更换壁纸功能？",
            "懒人助手",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "您想将快捷更新助手保存到哪里？";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    WshShell shell = new WshShell();
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(
                      fbd.SelectedPath +
                      "\\" + "更新今日壁纸.lnk"
                    );
                    shortcut.TargetPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
                    shortcut.Arguments = @"/onekey";
                    shortcut.WindowStyle = 1;
                    shortcut.Save();
                }
                else
                {
                    ;
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FullScreen();
        }

        private void 关于作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Hide();
            About.Show("必应壁纸。\n" +
                "版本 " + myVersion + "。\n" +
                "© 2016 Eagle。\n" +
                "保留所有权利。");
            Form_Show();
        }

        private void timer_Load_Tick(object sender, EventArgs e)
        {
            Thread_Load();
            //更新Log
            if (richTextBox_Logs.Text != MyFiles.Log)
            {
                richTextBox_Logs.Text = MyFiles.Log;
            }
        }

        private void 图片信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Hide();
            CopyInfo.Show(Information);
            Form_Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        public void FindUpdate()
        {
            try
            {
                WebClient wc = new WebClient();

                string NewVersion = wc.DownloadString("http://bybz.tech/html/version/beta");
                if (NewVersion != null)
                    BetaVersion = NewVersion;
                else
                    BetaVersion = "error";
                MyFiles.Log = MyFiles.Log +
                        "BetaVersion: " + BetaVersion + "\n";

                NewVersion = wc.DownloadString("http://bybz.tech/html/version/release");
                if (NewVersion != null)
                    ReleaseVersion = NewVersion;
                else
                    ReleaseVersion = "error";
                MyFiles.Log = MyFiles.Log +
                        "ReleaseVersion: " + ReleaseVersion + "\n";
            }
            catch
            {
                BetaVersion = "error";
                ReleaseVersion = "error";
                MyFiles.Log = MyFiles.Log += "检查更新时出现异常";
            }
        }

        private void 检查更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((ToolStripItem)sender).Enabled = false;
                ((ToolStripItem)sender).Text = "正在检查";
                FindLatest = new Thread(FindUpdate);
                FindLatest.IsBackground = true;
                FindLatest.Start();
                MyFiles.Log += "开始检查更新\n";
            }
            catch (Exception ex)
            {
                MyFiles.Log += ex.Message + '\n';
            }
        }

        private void 必应中国ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", @"http://cn.bing.com/");
            }
            catch (Exception ex)
            {
                MyFiles.Log += ex.Message + '\n';
            }
        }

        private void timer_Refresh_Tick(object sender, EventArgs e)
        {
            if (tried == 0)
            {
                ++tried;
                Form_Hide();
                About.Show("您与必应之间的连接可能出了点问题", @"iexplore.exe", @"http://cn.bing.com/", "测试一下");
                Form_Show();
            }
            webBrowser1.Refresh();
            MyFiles.Log += "抓取失败，重新抓取\n";
        }

        bool RichIsFront = true;
        private void myKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Keys keycode = e.KeyCode;
            if (keycode == Keys.F8)
            {
                if (RichIsFront)
                {
                    RichIsFront = false;
                    Controls.SetChildIndex(richTextBox_Logs, 0);
                }
                else
                {
                    RichIsFront = true;
                    Controls.SetChildIndex(richTextBox_Logs, 100);
                }
            }
        }
    }
}
