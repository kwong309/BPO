using System;
using System.Collections.Generic;
using System.Text;

namespace BPO.Core
{
    /// <summary>
    /// 缓存访问Helper
    /// </summary>
    public static class CacheHelper
    {
        private static ICacheProvider CacheProvider
        {
            get
            {
                return new RedisProvider();
            }
        }
        /// <summary>
        /// 从获取中获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Get<T>(string key)
        {
            if (!string.IsNullOrEmpty(key))
            {
                var value = CacheProvider.Get<T>(key);
                return value;
            }
            return default(T);
        }

        /// <summary>
        /// 从缓存中获取对象，如果对象不存，则用func创建对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static T Get<T>(string key, Func<T> func)
        {
            var obj = Get<T>(key); ;
            if (obj == null)
            {
                obj = func();
                if (obj == null) throw new NullReferenceException("缓存的对象为空");
                CacheProvider.Insert<T>(key, obj);
            }
            return obj;
        }

        /// <summary>
        /// 从缓存中获取对象，如果对象不存，则用func创建对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="func"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static T Get<T>(string key, Func<T> func, double seconds)
        {
            var obj = Get<T>(key); ;
            if (obj == null)
            {
                obj = func();
                if (obj == null) throw new NullReferenceException("缓存的对象为空");

                CacheProvider.Insert<T>(key, obj, seconds);
            }
            return obj;
        }

        /// <summary>
        /// 向缓存中添对象
        /// </summary>
        /// <param name="key"></param>
        /// <param name="instance"></param>
        public static void Insert<T>(string key, T instance)
        {
            CacheProvider.Insert<T>(key, instance);
        }

        /// <summary>
        /// 向缓存中添加对象
        /// </summary>
        /// <param name="key"></param>
        /// <param name="instance"></param>
        /// <param name="seconds"></param>
        public static void Insert<T>(string key, T instance, double seconds)
        {
            CacheProvider.Insert<T>(key, instance, seconds);
        }

        /// <summary>
        /// 从缓存中移取对象
        /// </summary>
        /// <param name="key"></param>
        public static void Remove(string key)
        {
            CacheProvider.Remove(key);
        }
        /// <summary>
        /// 从缓存中移取对象
        /// </summary>
        /// <param name="key"></param>
        public static void RemoveAll(string key)
        {
            CacheProvider.RemoveAll(key);
        }
    }
}