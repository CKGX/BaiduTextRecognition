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
            SetSettings();
        }

        private void PictureBoxScroll()
        {
            pictureBoxShow.Height = splitContainer1.Panel1.Height;
            pictureBoxShow.Width = splitContainer1.Panel1.Width;
        }

        /// <summary>
        /// 获取指定Key的获取Json的元素的内容
        /// </summary>
        /// <param name="jObject">JObject（JObject.Parse(jsonStr)获取）</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        public static JsonItem FindFistKeyItem(JObject jObject, string key)
        {
            JsonItem jsonItem = new JsonItem();
            //检查当前对象中是否存在Key
            foreach (KeyValuePair<string, JToken> keyValuePair in jObject)
            {
                string otherKey = keyValuePair.Key;

                if (key.Equals(otherKey))
                {
                    jsonItem.ParentItem = jObject;
                    jsonItem.IsFind = true;
                    jsonItem.Item = keyValuePair;
                    jsonItem.Key = keyValuePair.Key;
                    jsonItem.Value = keyValuePair.Value;
                    break;
                }
                else
                {
                    JToken otherJToken = jObject[otherKey];
                    if (otherJToken != null && otherJToken.Any())
                    {
                        var otherJTokenType = otherJToken.Type;
                        JObject newJObject;
                        if (otherJTokenType == JTokenType.Array)
                        {
                            newJObject = (JObject)otherJToken[0];
                        }
                        else
                        {
                            newJObject = (JObject)otherJToken;
                        }
                        jsonItem = FindFistKeyItem(newJObject, key);
                        if (jsonItem.IsFind)
                        {
                            break;
                        }
                    }
                }
            }

            return jsonItem;
        }

        /// <summary>
        /// 百度通用文字识别
        /// </summary>
        /// <param name="imgBytes"></param>
        /// <returns>
        /// <para>返回Json字符串</para>
        /// <para>成功包含关键字（内容是数组）：words_result</para>
        /// <para>失败包含关键字：error</para>
        /// </returns>
        public string OcrToCurrent(byte[] imgBytes)
        {
            var jsonToken = BaiduApi.GetAccessToken();
            var resultCkJsonItem = FindFistKeyItem(JObject.Parse(jsonToken), "access_token");
            string result = "";
            if (resultCkJsonItem.IsFind)
            {
                string token = resultCkJsonItem.ValueStr;
                string host = "https://aip.baidubce.com/rest/2.0/ocr/v1/general_basic?access_token=" + token;
                Encoding encoding = Encoding.Default;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
                request.Method = "post";
                request.KeepAlive = true;
                String str = "image=" + HttpUtility.UrlEncode(Convert.ToBase64String(imgBytes));
                byte[] buffer = encoding.GetBytes(str);
                request.ContentLength = buffer.Length;
                request.GetRequestStream().Write(buffer, 0, buffer.Length);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException(), Encoding.Default);
                result = reader.ReadToEnd();
            }
            else
            {
                result = jsonToken;
            }

            return result;
        }

        

        private void buttonGetImgText_Click(object sender, EventArgs e)
        {
            SetSettings();
            buttonCopyWords.Enabled = false;
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                pictureBoxShow.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                var imgStream = memoryStream.ToArray();
                var obj = OcrToCurrent(imgStream);
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
                var item = FindFistKeyItem(obj, "words_result").Value ?? JsonConvert.SerializeObject(obj);

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
        public void SetSettings()
        {
            if (string.IsNullOrWhiteSpace(Settings.Default.ApiKey))
            {
                Settings.Default.AppId = "";
                Settings.Default.ApiKey = "";
                Settings.Default.SecretKey = "";
                MessageBox.Show("请输入百度相关文字识别相关key");
                ShowSettingForm();
            }
            if (string.IsNullOrWhiteSpace(Settings.Default.AppId) || string.IsNullOrWhiteSpace(Settings.Default.ApiKey) || string.IsNullOrWhiteSpace(Settings.Default.SecretKey))
            {
                SetSettings();
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