using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace 百度文字识别.Entity
{
    /// <summary>
    /// Json元素的内容类
    /// </summary>
    public class JsonItem
    {
        /// <summary>
        /// 是否找到元素
        /// </summary>
        public bool IsFind { get; set; }

        /// <summary>
        /// 父元素
        /// </summary>
        public JObject ParentItem { get; set; }

        /// <summary>
        /// 元素信息
        /// </summary>
        public KeyValuePair<string, JToken?> Item { get; set; }

        /// <summary>
        /// Key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public JToken? Value { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public string ValueStr => (Value ?? "").ToString() ;
    }
}