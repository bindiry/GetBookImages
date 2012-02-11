using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace GetBookPicture
{
    public partial class Form1 : Form
    {
		Thread threadToPlay;
		private int intBufferSize = 51200;
	
        public Form1()
        {
            InitializeComponent();
            Form1.CheckForIllegalCrossThreadCalls = false;
            
            this.btnStop.Enabled = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            this.txtSavePath.Text = this.folderBrowserDialog1.SelectedPath;
		}

		#region 单击按钮
		//GO
        private void btnGO_Click(object sender, EventArgs e)
        {
			if (this.txtURL.Text.Trim() == "")
			{
				MessageBox.Show("URL不能为空", "提示");
				return;
			}

			if (this.txtStartID.Text.Trim() == "")
			{
				MessageBox.Show("起始ID不能为空", "提示");
				return;
			}

			if (this.txtEndID.Text.Trim() == "")
			{
				MessageBox.Show("结束ID不能为空", "提示");
				return;
			}

			if (this.nudWildLong.Value <= 0)
			{
				MessageBox.Show("通配符要大于0", "提示");
				return;
			}

			if (this.txtPrefix.Text.Trim() == "")
			{
				MessageBox.Show("文件名前缀不能为空", "提示");
				return;
			}

			if (this.txtUrlPrefix1.Text.Trim() == "")
			{
				MessageBox.Show("截取URL前缀1不能为空", "提示");
				return;
			}



			if (this.txtRegex1.Text.Trim() == "")
			{
				MessageBox.Show("截取开始1不能为空", "提示");
				return;
			}

			
			if (this.txtSavePath.Text.Trim() == "")
			{
				MessageBox.Show("请选择保存文件夹","提示");
				return;
			}
			
			
			ThreadStart ts = new ThreadStart(GO_Download);
            threadToPlay = new Thread(ts);
            threadToPlay.Start();
            
            this.btnStop.Enabled = true;
		}
		#endregion

		private void GO_Download()
		{
			//获取通配符位数
			string strDileCount = "";
			int intDileCount = Convert.ToInt32(this.nudWildLong.Value);
			for (int j=1; j <= intDileCount; j++)
			{
				strDileCount += "0";
			}
			
			
			this.btnGO.Text = "下载中";
			this.btnGO.Enabled = false;
			int intStartID = Convert.ToInt32(this.txtStartID.Text);
			int intEndID = Convert.ToInt32(this.txtEndID.Text);
			string strUrl = this.txtURL.Text;
			int intResidual = Convert.ToInt32(txtEndID.Text) - Convert.ToInt32(txtStartID.Text);
			this.labResidual.Text = intResidual.ToString();
			
			bool bolIsDone = true;

			string strFileUrl1 = this.txtUrlPrefix1.Text;
			string strFileUrl2 = this.txtUrlPrefix2.Text;		
			string strReg1 = this.txtRegex1.Text;
			string strReg2 = this.txtRegex2.Text;

			string strGetFileUrl = "";
			for (int i = intStartID; i <= intEndID; i++)
			{
				string Url = strUrl.Replace("(*)", String.Format("{0:"+ strDileCount +"}",i));
				HttpWebRequest httpRequest = WebRequest.Create(Url) as HttpWebRequest;
				httpRequest.Method = "GET";
				httpRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9b4) Gecko/2008030714 Firefox/3.0b4";
				httpRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
				httpRequest.Timeout = 10 * 1000;

				try
				{
					using (HttpWebResponse httpResponse = httpRequest.GetResponse() as HttpWebResponse)
					{
						using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.GetEncoding("gb2312")))
						{

							this.labCurrentID.Text = i.ToString();
							string strSource = reader.ReadToEnd();
							Match m = null;
							
							if (Regex.IsMatch(strSource, strReg1))
							{
								m = Regex.Match(strSource, strReg1);
								string strFileName = m.Groups[0].Value;
								strGetFileUrl = strFileUrl1 + strFileName;
							}
							else
							{
								m = Regex.Match(strSource, strReg2);
								string strFileName = m.Groups[0].Value;
								strGetFileUrl = strFileUrl2 + strFileName;
							}
							
		
							string strSave = this.txtSavePath.Text + "\\" + this.txtPrefix.Text + i.ToString() + ".jpg";
							DownloadFile(strGetFileUrl, strSave);
							this.labSaved.Text = (Convert.ToInt32(this.labSaved.Text) + 1).ToString();
							if (Convert.ToInt32(this.labResidual.Text) > 0)
							{
								this.labResidual.Text = (Convert.ToInt32(this.labResidual.Text) - 1).ToString();
							}
							this.txtLog.Text = "ID: " + i + "  下载完毕" + "\r\n\r\n" + this.txtLog.Text;
							//MessageBox.Show(strFile);
						}
					}
				}
				catch(Exception ex)
				{
					//MessageBox.Show(ex.Message);
					this.txtLog.Text = "ID: " + i + "  " + ex.Message + "\r\n\r\n" + strGetFileUrl + "\r\n\r\n" + this.txtLog.Text;
					this.labLost.Text = (Convert.ToInt32(this.labLost.Text) + 1).ToString();
				}
			}
			
			if (bolIsDone)
			{
				MessageBox.Show("下载完成啦~~~~");
			}
			
			this.btnGO.Text = "开始";
			this.btnGO.Enabled = true;
		}
		
		private void DownloadFile(string sFileUrl, string sFileSavePath)
		{
			string strDirForSave = Path.GetDirectoryName(sFileSavePath);
			if (!Directory.Exists(strDirForSave))
			{
				Directory.CreateDirectory(strDirForSave);
			}
			HttpWebRequest _request = (HttpWebRequest)WebRequest.Create(sFileUrl);
			HttpWebResponse _response = (HttpWebResponse)_request.GetResponse();
			Stream _stream = _response.GetResponseStream();
			FileStream fs = File.Create(sFileSavePath);
			byte[] _buffer = new byte[intBufferSize];
			int intReadCount = 0;
			while ((intReadCount = _stream.Read(_buffer, 0, intBufferSize)) > 0)
				fs.Write(_buffer, 0, intReadCount);
			fs.Close();
			_stream.Close();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			threadToPlay.Abort();
			this.btnGO.Text = "开始";
			this.btnGO.Enabled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("献给一个努力的小老师  \n------------------------------\n\nBindiry\n\nhttp://junnan.org\n\nBindiry@gmail.com", "关于");
		}

		private void txtUrlPrefix1_Enter(object sender, EventArgs e)
		{
			int intLastPos = this.txtURL.Text.LastIndexOf("/");
			this.txtUrlPrefix1.Text = this.txtURL.Text.Substring(0, intLastPos+1);
		}

        private void label10_Click(object sender, EventArgs e)
        {

        }


    }
}
