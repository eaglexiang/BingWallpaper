using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace 必应壁纸
{
    class MyFiles
    {
        public static string HTML
        {
            get
            {
                return html;
            }
            set
            {
                if (html != value)
                {
                    html = value;
                }
            }
        }
        static string html = "";
        static public bool Inited = false;
        static string datpath
        {
            get
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                path += @"\Eagle\Wallpaper\";
                return path;
            }
        }
        static string datapath
        {
            get
            {
                return datpath + @"\config.dat";
            }
        }
        static public string BingURL = @"http://cn.bing.com/";
        static int MaxNum = 1000;//最大数量
        static public string Path_Save = "No Path";//资源下载后的存储路径
        //static public bool Downloaded = false;//图片是否已经下载
        static public string UrlOfImage = null;//图片的URL
        public static Bitmap Picture;//下载的壁纸图片
        private static string Log_String = "";
        public static string Information;//图片相关信息，如图片名、拍摄地
        public static int Progress = 0;//进度条指示器
        public static uint Getted = 0;//尝试抓取次数
        public static string Log(string logs)
        {
            Log_String = logs + Log_String;
            return Log_String;
        }
        public static string Log()
        {
            return Log_String;
        }

        /// <summary>
        /// 根据壁纸的URL下载图片到内存
        /// </summary>
        /// <returns></returns>
        static public Bitmap Download()
        {
            if (Picture == null)
            {
                Log("开始下载\n");
                Picture = GetBMP();
            }
            return Picture;
        }

        private void Request()
        {
            try
            {
                WebRequest wrq = WebRequest.Create("http://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1&mkt=zh-CN");
                WebResponse wrp = wrq.GetResponse();
                Stream stream = wrp.GetResponseStream();
                StreamReader sr = new StreamReader(stream, Encoding.GetEncoding("utf-8"));
                string String_JSON = sr.ReadToEnd();
                JObject Obj_JSON = JObject.Parse(String_JSON);
                string String_Images = Obj_JSON["images"][0].ToString();
                String_Images = String_Images.Remove(String_Images.Length - 16, 14);//删除末端无法识别的hs
                Dictionary<string, string> Dic_Images = JsonConvert.DeserializeObject<Dictionary<string, string>>(String_Images);
                UrlOfImage = @"http://cn.bing.com/" + Dic_Images["url"];
                Information = Dic_Images["copyright"];
            }
            catch (Exception ex)
            {
                Log(ex.Message + '\n');
            }
        }

        /// <summary>
        /// 获取图片的URL
        /// </summary>
        public  /*static*/ void GetURLofImage()
        {
            try
            {
                while (true)
                {
                    string HTML_c;
                    if (Getted % 3 == 0)//HTTP请求
                    {
                        Progress = 2;
                        Getted += 1;
                        Log("发起请求\n");
                        Request();
                    }
                    else
                    {
                        if (Getted % 3 == 1)//下载静态网页
                        {
                            Progress = 3;
                            Getted += 1;
                            Log("静态抓取\n");
                            try
                            {
                                HTML_c = new WebClient().DownloadString(@"http://cn.bing.com/");
                            }
                            catch (Exception ex)
                            {
                                Log(ex.Message + "\n");
                                HTML_c = "";
                            }
                        }
                        else//读取动态网页
                        {
                            Getted += 1;
                            Progress = 4;
                            Log("动态抓取\n");
                            HTML_c = HTML;
                        }
                        if (HTML_c != null && HTML_c != "" && (UrlOfImage == null || UrlOfImage == ""))//处理HTML代码
                        {
                            string[] Result = GetNewURL(HTML_c);
                            foreach (string Url_Tmp in Result)
                            {
                                if (Url_Tmp == null)
                                {
                                    break;
                                }
                                else
                                {
                                    Uri uri = new Uri(Url_Tmp);
                                    if (System.IO.Path.GetExtension(uri.AbsolutePath) == ".jpg" ||
                                        System.IO.Path.GetExtension(uri.AbsolutePath) == ".JPG")
                                    {
                                        UrlOfImage = Url_Tmp;
                                    }
                                }
                            }
                        }
                    }
                    if (UrlOfImage != null && Picture == null)
                    {
                        Progress = 5;
                        Log("成功解析到壁纸\n");
                        Download();
                        if (Picture != null)
                        {
                            Progress = 6;
                            Log("下载成功\n");
                            break;
                        }
                        else
                        {
                            Log("下载失败\n");
                        }
                    }
                    Thread.Sleep(500);
                }
            }
            catch
            {
                ;
            }
        }

        static private Bitmap GetBMP()
        {
            try
            {
                if (UrlOfImage != null)
                {
                    WebClient mywebclient = new WebClient();
                    Bitmap tmp = new Bitmap(mywebclient.OpenRead(UrlOfImage));
                    return tmp;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                Log("图片下载失败\n");
                return null;
            }
        }

        static string[] HandingURL(string html)
        {
            string[] urlre = GetNewURL(html);
            return urlre;
        }

        static string[] GetNewURL(string line)
        {
            string[] urlre = new string[MaxNum];
            int key = 0;
            string regex = @"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";  //url的正则表达式
            try
            {
                string tmp;
                while (line != null)
                {
                    if ((tmp = Regex.Match(line, regex).ToString()).Length != 0 && key < MaxNum)
                    {
                        urlre[key++] = tmp;
                        int ind = line.IndexOf(tmp);
                        line = line.Substring((ind + tmp.Length - 1));
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message + "\n");
            }
            return urlre;
        }

        static public void Init()
        {
            try
            {
                if (!Directory.Exists(datpath))
                {
                    Directory.CreateDirectory(datpath);
                }
                string datapath = datpath + @"\config.dat";
                if (File.Exists(datapath))
                {
                    FileStream fs = new FileStream(datapath, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    Path_Save = sr.ReadLine();
                    sr.Close();
                    fs.Close();
                }
                else
                {
                    //StreamWriter sw = File.CreateText(datapath);
                    //Path_Save = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\BingWallpapers\";
                    //sw.WriteLine(Path_Save);
                    //sw.Close();
                    if (!Set_Path_Save())
                        Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message + "\n");
            }
        }

        static public bool Set_Path_Save()
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "请选择壁纸的收藏目录";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    Path_Save = fbd.SelectedPath;

                    FileStream fs = new FileStream(datapath, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Flush();
                    sw.WriteLine(Path_Save);
                    sw.Close();
                    fs.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message + "\n");
                return false;
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern int SystemParametersInfo(
         int uAction,
         int uParam,
         string lpvParam,
         int fuWinIni
         );

        public static void SetWallpaper()
        {
            Thread tmp = new Thread(SetWallpaper_Thread);
            tmp.IsBackground = true;
            tmp.Start();
        }

        private static void SetWallpaper_Thread()
        {
            string filepath = System.IO.Path.GetTempPath() + @"\tmp.tmp";
            try
            {
                MyFiles.Picture.Save(filepath, System.Drawing.Imaging.ImageFormat.Bmp);
                //SystemParametersInfo(20, 0, filepath, 0x2);
                SystemParametersInfo(20,
            0,
            filepath,
            0x01 | 0x02);
            }
            catch (Exception ex)
            {
                Log(ex.Message + "\n");
            }
        }

        /// <summary>
        /// 将图片保存到文件
        /// </summary>
        /// <returns>是否保存成功</returns>
        public static bool Save()
        {
            Uri url = new Uri(MyFiles.UrlOfImage);
            string filepath = Path_Save + "\\" + Path.GetFileName(url.AbsolutePath);
            if (Exsit())
            {
                Log("壁纸已存在\n");
                return true;
            }
            else
            {
                if (Picture != null)
                {
                    Log("壁纸已保存\n");
                    Picture.Save(filepath);
                    return true;
                }
                else
                {
                    Log("没有可保存的壁纸\n");
                    return false;
                }
            }
        }

        /// <summary>
        /// 判断图片文件在收藏目录是否存在
        /// </summary>
        /// <returns>是否存在</returns>
        public static bool Exsit()
        {
            try
            {
                Uri url = new Uri(MyFiles.UrlOfImage);
                string filepath = Path_Save + "\\" + Path.GetFileName(url.AbsolutePath);
                return File.Exists(filepath);
            }
            catch
            {
                return false;
            }
        }
    }
}
