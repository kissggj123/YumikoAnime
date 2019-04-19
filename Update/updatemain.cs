using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace Update
{
    public partial class updatemain : CCSkinMain
    {
        private static String URL = "https://github.com/kissggj123/YumikoAnime/raw/master/YumikoAnime.exe";
        public updatemain()
        {
            InitializeComponent();
        }

        private void updatemain_Load(object sender, EventArgs e)
        {
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "update";
            if (File.Exists(Path2 + @"\" + "YumikoAnime.exe"))
            {
                updateyumiko.Enabled = true;
                updateyumiko.Text = "开始安装";
                noupdate.Enabled = true;
                prog.Value = 0;
            }
            else
            {
                updateyumiko.Enabled = true;
                noupdate.Enabled = false;
                prog.Value = 0;
            }
            FileVersionInfo myFileVersion = FileVersionInfo.GetVersionInfo(System.Windows.Forms.Application.ExecutablePath);
            ready1.Text = myFileVersion.FileVersion;
            ready1.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

        }

        public static bool CheckValidationResult(object sender, X509Certificate2 certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }


        private void updateyumiko_Click(object sender, EventArgs e)
        {
            string Path2 = AppDomain.CurrentDomain.BaseDirectory + "update";
            string filename = Path2 + @"\" + "YumikoAnime.exe";
            //为了防止线程的卡死做了内存回收和url连接数量的的优化
            try
            {
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                System.Net.ServicePointManager.DefaultConnectionLimit = 210;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                ServicePointManager.ServerCertificateValidationCallback += (s, cert, chain, sslPolicyErrors) => true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                if (prog != null)
                {
                    prog.Maximum = (int)totalBytes;
                }
                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    System.Windows.Forms.Application.DoEvents();
                    so.Write(by, 0, osize);
                    System.GC.Collect();
                    if (prog != null)
                    {
                        System.GC.Collect();
                        prog.Value = (int)totalDownloadedByte;
                    }
                    osize = st.Read(by, 0, (int)by.Length);
                    updateyumiko.Text = "正在下载";
                    updateyumiko.Enabled = false;
                    System.Windows.Forms.Application.DoEvents(); //必须加注这句代码，否则label1将因为循环执行太快而来不及显示信息
                }
                so.Close();
                st.Close();
                updateyumiko.Enabled = true;
                updateyumiko.Text = "开始安装";
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
        }
   
