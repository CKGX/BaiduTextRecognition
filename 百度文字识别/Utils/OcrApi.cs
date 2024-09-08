using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace 百度文字识别.Utils
{
    public class OcrApi
    {
        /// <summary>
        /// 百度通用文字识别
        /// </summary>
        /// <param name="imgBytes"></param>
        /// <returns>
        /// <para>返回Json字符串</para>
        /// <para>成功包含关键字（内容是数组）：words_result</para>
        /// <para>失败包含关键字：error</para>
        /// </returns>
        public static string OcrToCurrent(byte[] imgBytes)
        {
            var jsonToken = BaiduApi.GetAccessToken();
            var resultCkJsonItem = JsonTool.FindFistKeyItem(JObject.Parse(jsonToken), "access_token");
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
    }
}
