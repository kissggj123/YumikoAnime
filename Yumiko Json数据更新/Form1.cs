using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Xml;
using WinSCP;
using CCWin;

namespace Yumiko_Json数据更新
{

    public partial class Form1 : CCSkinMain
    {
        private const int INTERNET_CONNECTION_MODEM = 1;
        private const int INTERNET_CONNECTION_LAN = 2;
        private const int INTERNET_CONNECTION_PROXY = 4;
        private const int INTERNET_CONNECTION_MODEM_BUSY = 8;
        private Thread _thread = null;
        private static String amine1url = "https://****/anime1.php";//amine.php路径
        private static String Calibururl = "https://****/calibur.php";//calibur.php路径
        private static String ageurl = "https://****/agefans.php";//agefans.php路径
        private static String newbgmsurl = "https://api.tls.moe/?app=bangumi&key=calendar";
        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(
        ref int dwFlag,
        int dwReserved
         );
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string data = Path + "data";
            string filename = Path + "data" + @"\" + "true.yumiko";
            //
            System.Int32 dwFlag = new int();
            if (!InternetGetConnectedState(ref dwFlag, 0))
            {
                MessageBox.Show("无法启动更新程序", "未连接网络", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                //
                if (!System.IO.Directory.Exists(Path + @"\" + "data"))
                {
                    // 目录不存在，建立目录
                    System.IO.Directory.CreateDirectory(Path + @"\" + "data");
                    MessageBox.Show("检测到无数据文件！\n\r已为你生成数据文件，请重启程序后继续操作", "创建数据完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    //不操作
                    FileStream fs = File.Create(filename);  //创建文件
                    fs.Close();
                    StreamWriter sw = new StreamWriter(filename);  //创建写入流
                    sw.Write("你想写入的东西" + "{" + "版本号日期什么的" + "}");
                    sw.Flush();
                    sw.Close();
                    upload1.Enabled = false;
                    ready1.Text = "准备更新";
                    ready2.Text = "准备更新";
                    ready3.Text = "准备更新";
                    ready4.Text = "准备更新";
                }
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_thread != null && _thread.IsAlive)
            {
                try
                {
                    _thread.Abort();
                }
                catch { }
            }
        }


        private void anime1()
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string data = Path + "data";
            string animepath = Path + "data" + @"\" + "anime1.json";
            try
            {

                this.ready1.Text = "正在更新...";
                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                Byte[] pageData = MyWebClient.DownloadData(amine1url); //从指定网站下载数据
                string pagejson = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                //MessageBox.Show(animepath + "的数据更新成功", "已完工", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (StreamWriter sw = new StreamWriter(animepath))//将获取的内容写入文本
                {
                    sw.Write(pagejson);
                }
                _thread = null;
                ready1.Text = "更新完成";

            }
            catch (WebException webEx)
            {
                MessageBox.Show(webEx.Message, "无法更新数据", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ready1.Text = "无法更新";
            }
            finally
            {
                _thread = null;
                Control.CheckForIllegalCrossThreadCalls = false;
                Thread t2 = new Thread(new ThreadStart(Calibur1));
                t2.Start();
                t2.Join();
            }
        }

        //t2线程
        private void Calibur1()
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string data = Path + "data";
            string jsonpath = Path + "data" + @"\" + "calibur.json";
            try
            {

                this.ready2.Text = "正在更新...";
                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                Byte[] pageData = MyWebClient.DownloadData(Calibururl); //从指定网站下载数据
                string pagejson = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                //MessageBox.Show(animepath + "的数据更新成功", "已完工", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (StreamWriter sw = new StreamWriter(jsonpath))//将获取的内容写入文本
                {
                    sw.Write(pagejson);
                }
                _thread = null;
                ready2.Text = "更新完成";

            }
            catch (WebException webEx)
            {
                MessageBox.Show(webEx.Message, "无法更新数据", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ready2.Text = "无法更新";
            }
            finally
            {
                _thread = null;
                Control.CheckForIllegalCrossThreadCalls = false;
                Thread t3 = new Thread(new ThreadStart(AGE1));
                t3.Start();
                t3.Join();
            }
        }

        //t3线程
        private void AGE1()
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string data = Path + "data";
            string jsonpath = Path + "data" + @"\" + "agefans.json";
            try
            {

                this.ready3.Text = "正在更新...";
                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                Byte[] pageData = MyWebClient.DownloadData(ageurl); //从指定网站下载json数据
                string pagejson = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                //MessageBox.Show(animepath + "的数据更新成功", "已完工", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (StreamWriter sw = new StreamWriter(jsonpath))//将获取的内容写入文本
                {
                    sw.Write(pagejson);
                }
                _thread = null;
                ready3.Text = "更新完成";

            }
            catch (WebException webEx)
            {
                MessageBox.Show(webEx.Message, "无法更新数据", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ready3.Text = "无法更新";
            }
            finally
            {
                _thread = null;
                Control.CheckForIllegalCrossThreadCalls = false;
                Thread t4 = new Thread(new ThreadStart(newbgms1));
                t4.Start();
                t4.Join();
            }
        }

        //t4线程
        private void newbgms1()
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string data = Path + "data";
            string jsonpath = Path + "data" + @"\" + "newbgms.json";
            try
            {

                this.ready4.Text = "正在更新...";
                WebClient MyWebClient = new WebClient();
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                Byte[] pageData = MyWebClient.DownloadData(newbgmsurl); //从指定网站下载数据
                string pagejson = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                //MessageBox.Show(animepath + "的数据更新成功", "已完工", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (StreamWriter sw = new StreamWriter(jsonpath))//将获取的内容写入文本
                {
                    sw.Write(pagejson);
                }
                _thread = null;
                ready4.Text = "更新完成";
                //MessageBox.Show("数据全部更新成功", "更新完成", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (WebException webEx)
            {
                MessageBox.Show(webEx.Message, "无法更新数据", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ready4.Text = "无法更新";
            }
            finally
            {
                _thread = null;
                updatejson1.Enabled = true;
                upload1.Enabled = true;
                updatejson1.Text = "已同步完成";
                //MessageBox.Show("数据全部更新成功", "更新完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }








        private void updatejson1_Click(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory;
            string animepath = Path + "data" + @"\" + "anime1.json";
            string caliburpath = Path + "data" + @"\" + "calibur.json";
            string agepath = Path + "data" + @"\" + "agefans.json";
            string newbgmspath = Path + "data" + @"\" + "newbgms.json";
            FileStream fs = File.Create(animepath);  //创建文件
            fs.Close();
            FileStream fs2 = File.Create(caliburpath);  //创建文件
            fs2.Close();
            FileStream fs3 = File.Create(agepath);  //创建文件
            fs3.Close();
            FileStream fs4 = File.Create(newbgmspath);  //创建文件
            fs4.Close();
            Control.CheckForIllegalCrossThreadCalls = false;
            _thread = new Thread(new ThreadStart(anime1));
            updatejson1.Enabled = false;
            updatejson1.Text = "正在更新";
            _thread.Start();
        }

        private void upload1_Click(object sender, EventArgs e)
        {
            string DATAPath = AppDomain.CurrentDomain.BaseDirectory;
            string data = DATAPath + "data";
            upload1.Enabled = false;
            updatejson1.Enabled = false;
            upload1.Text = "开始上传";
            IEnumerable<string> yumikodata = Directory.EnumerateFiles(DATAPath + "data");
            ready1.Text = "开始上传";
            ready2.Text = "开始上传";
            ready3.Text = "开始上传";
            ready4.Text = "开始上传";
            using (WebClient client = new WebClient())
            {
                client.Proxy = null;
                client.Credentials = new NetworkCredential("ftp用户名", "密码");

                foreach (string file in yumikodata)
                {
                    client.UploadFile(
                        "ftp://你的ip/" + Path.GetFileName(file), file);
                    ready1.Text = "完成上传";
                    ready2.Text = "完成上传";
                    ready3.Text = "完成上传";
                    ready4.Text = "完成上传";
                    upload1.Enabled = true;
                    updatejson1.Enabled = true;
                    upload1.Text = "已上传完成";
                    //MessageBox.Show("数据全部上传成功", "上传完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //结尾
                }
            }
        }
    }
}

