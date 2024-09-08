using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 百度文字识别.Entity;

namespace 百度文字识别.Utils
{
    public static class JsonTool
    {
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
    }
}