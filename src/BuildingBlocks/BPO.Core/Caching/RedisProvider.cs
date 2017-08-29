using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BPO.Core
{
    public class RedisProvider : ICacheProvider
    {
        private static string _conn = "127.0.0.1:6379";
 
        public virtual string Get(string key)
        {
            try
            {
                using (var client = ConnectionMultiplexer.Connect(_conn))
                {
                    return client.GetDatabase().StringGet(key);
                }
            }
            catch
            {
                return null;
            }
        }
        public virtual bool Remove(string key)
        {
            using (var client = ConnectionMultiplexer.Connect(_conn))
            {
                return client.GetDatabase().KeyDelete(key);
            }
        }
        public virtual bool RemoveAll(string key)
        {
            using (var client = ConnectionMultiplexer.Connect(_conn))
            {
                foreach (var endPoint in client.GetEndPoints())
                {
                    foreach (var item in client.GetServer(endPoint).Keys(pattern: $"*{key}*"))
                    {
                        client.GetDatabase().KeyDelete(item);
                    }
                }
            }
            return true;
        }
 
        public T Get<T>(string key)
        {
            using (var client = ConnectionMultiplexer.Connect(_conn))
            {
                var strValue = client.GetDatabase().StringGet(key);
                return string.IsNullOrEmpty(strValue) ? default(T) : JsonConvert.DeserializeObject<T>(strValue);
            }
        }

        public bool Insert<T>(string key, T instance)
        {
            var str = JsonConvert.SerializeObject(instance);
            using (var client = ConnectionMultiplexer.Connect(_conn))
            {
                return client.GetDatabase().StringSet(key, str);
            }
        }

        public bool Insert<T>(string key, T instance, double seconds)
        {
            var str = JsonConvert.SerializeObject(instance);
            using (var client = ConnectionMultiplexer.Connect(_conn))
            {
                return client.GetDatabase().StringSet(key, str,TimeSpan.FromSeconds(seconds),When.Always,CommandFlags.None);
            }
        }
 
    }
}