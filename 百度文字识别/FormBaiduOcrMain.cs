using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.Web;
using 百度文字识别.Entity;
using 百度文字识别.Properties;
using 百度文字识别.Utils;

namespace 百度文字识别
{
    public partial class FormBaiduOcrMain : Form
    {
        public FormBaiduOcrMain()
        {
            InitializeComponent();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Image = Clipboard.GetImage();
            buttonGetImgText.Focus();
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            PictureBoxScroll();
        }

        private void FormBaiduOcrMain_Load(object sender, EventArgs e)
        {
            CheckSettings();
        }

        private void PictureBoxScroll()
        {
            pictureBoxShow.Height = splitContainer1.Panel1.Height;
            pictureBoxShow.Width = splitContainer1.Panel1.Width;
        }


        private void buttonGetImgText_Click(object sender, EventArgs e)
        {
            CheckSettings();
            buttonCopyWords.Enabled = false;
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                pictureBoxShow.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                var imgStream = memoryStream.ToArray();
                var obj = OcrApi.OcrToCurrent(imgStream);
                richTextBoxImgText.Text = obj.ToString();
                SetClipboard();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                labelWord.Text = "出现异常，详情是：" + System.Environment.NewLine + exception.Message + System.Environment.NewLine + DateTime.Now;
                buttonCopyWords.Enabled = true;
            }
        }

        private void buttonCopyWords_Click(object sender, EventArgs e)
        {
            SetClipboard();
        }

        /// <summary>
        /// 设置提取的内容到剪切板
        /// </summary>
        private void SetClipboard()
        {
            if (!string.IsNullOrWhiteSpace(richTextBoxImgText.Text))
            {
                JObject obj = JObject.Parse(richTextBoxImgText.Text);
                var item = JsonTool.FindFistKeyItem(obj, "words_result").Value ?? JsonConvert.SerializeObject(obj);

                string text = item.ToString();
                Clipboard.SetText(text);
                labelWord.Text = "提签的内容已经复制到剪切板" + System.Environment.NewLine + DateTime.Now;
                buttonCopyWords.Enabled = true;
            }
        }

        private void 设置百度ApiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSettingForm();
        }

        /// <summary>
        /// 设置
        /// </summary>
        public void CheckSettings()
        {
            if (string.IsNullOrWhiteSpace(Settings.Default.AppId) || string.IsNullOrWhiteSpace(Settings.Default.ApiKey) || string.IsNullOrWhiteSpace(Settings.Default.SecretKey))
            {
                Settings.Default.AppId = "";
                Settings.Default.ApiKey = "";
                Settings.Default.SecretKey = "";
                MessageBox.Show("请输入百度相关文字识别相关key");
                ShowSettingForm();
            }
        }

        /// <summary>
        /// 显示设置窗体
        /// </summary>
        public void ShowSettingForm()
        {
            var form = new FormSettingsToPropertyGrid(Settings.Default);
            form.ShowDialog();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxImgText.Text = "";
            labelWord.Text = "";
        }
    }
}