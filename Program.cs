using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 必应壁纸
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                bool flag = false;
                System.Threading.Mutex mutex = new System.Threading.Mutex(true, "bingwallpaper", out flag);
                if (flag)
                {
                    MyFiles.Init();
                    Form_Main fm = new Form_Main();
                    if (args.Length > 0)
                    {
                        if (args[0] == @"/onekey")
                        {
                            OneKey = true;
                            fm.Opacity = 0;
                            fm.ShowInTaskbar = false;
                            fm.Enabled = false;
                            fm.ShowDialog();
                        }
                        else
                        {
                            OneKey = false;
                            fm.ShowDialog();
                        }
                    }
                    else
                    {
                        fm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static bool OneKey;
    }
}
