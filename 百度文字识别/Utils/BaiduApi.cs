using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 百度文字识别.Properties;

namespace 百度文字识别.Utils
{
    public class BaiduApi
    {
        /// <summary>
        /// 获取百度的Token
        /// </summary>
        /// <returns>
        /// <para>返回Json字符串</para>
        /// <para>成功包含关键字：access_token</para>
        /// <para>失败包含关键字：error</para>
        /// </returns>
        public static String GetAccessToken()
        {
            String authHost = "https://aip.baidubce.com/oauth/2.0/token";
            HttpClient client = new HttpClient();
            List<KeyValuePair<String, String>> paraList = new List<KeyValuePair<string, string>>();
            paraList.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            paraList.Add(new KeyValuePair<string, string>("client_id", Settings.Default.ApiKey));
            paraList.Add(new KeyValuePair<string, string>("client_secret", Settings.Default.SecretKey));

            HttpResponseMessage response = client.PostAsync(authHost, new FormUrlEncodedContent(paraList)).Result;
            String result = response.Content.ReadAsStringAsync().Result;
            return result;
        }
    }
}
