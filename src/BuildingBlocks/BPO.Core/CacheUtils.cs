using System;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;

namespace BPO.Core
{
    public class CacheUtils
    {
        private CacheUtils() { }

        private static readonly MemoryCache Cache;

        /// <summary>
        /// Static initializer should ensure we only have to look up the current cache
        /// instance once.
        /// </summary>
        static CacheUtils()
        {
            Cache = new MemoryCache(new MemoryCacheOptions());
        }

        //public static void ClearAll()
        //{
          
        //    var cacheEnum = Cache.GetEnumerator();
        //    var keys = new List<string>();
        //    while (cacheEnum.MoveNext())
        //    {
        //        keys.Add(cacheEnum.Key.ToString());
        //    }

        //    foreach (var key in keys)
        //    {
        //        Cache.Remove(key);
        //    }
        //}

        //public static void RemoveByStartString(string startString)
        //{
        //    if (!string.IsNullOrEmpty(startString))
        //    {
        //        RemoveByPattern(startString + "([w+]*)");
        //    }
        //}

        //public static void RemoveByPattern(string pattern)
        //{
        //    var cacheEnum = Cache.GetEnumerator();
        //    var regex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);
        //    while (cacheEnum.MoveNext())
        //    {
        //        if (regex.IsMatch(cacheEnum.Key.ToString()))
        //        {
        //            Cache.Remove(cacheEnum.Key.ToString());
        //        }
        //    }
        //}

        /// <summary>
        /// Removes the specified key from the cache
        /// </summary>
        /// <param name="key"></param>
        public static void Remove(string key)
        {
            Cache.Remove(key);
        }

        public static void Insert(string key, object obj)
        {
            Cache.Set(key, obj);
        }

        public static void InsertMinutes(string key, object obj, int minutes)
        {
            Cache.Set(key, obj, TimeSpan.FromMinutes(minutes));
        }

        public static void InsertHours(string key, object obj, int hours)
        {
            Cache.Set(key, obj, TimeSpan.FromHours(hours));
        }

       
        public static bool IsCache(string key)
        {
            return Cache.Get(key) != null;
        }

        public static object Get(string key)
        {
            return Cache.Get(key);
        }

        public static int GetInt(string key, int notFound)
        {
            var retval = Get(key);
            if (retval == null)
            {
                return notFound;
            }
            return (int)retval;
        }

        public static DateTime GetDateTime(string key, DateTime notFound)
        {
            var retval = Get(key);
            if (retval == null)
            {
                return notFound;
            }
            return (DateTime)retval;
        }

        public static T Get<T>(string key) where T : class
        {
            return Cache.Get(key) as T;
        }

 
        public static int Count => Cache.Count;

 
        public static void UpdateTemporaryCacheFile(string cacheFileName)
        {
            var cacheFilePath = GetCacheFilePath(cacheFileName);
            FileUtils.WriteText(cacheFilePath, ECharset.utf_8, "cache chaged:" + DateUtils.GetDateAndTimeString(DateTime.Now));
        }

        public static void DeleteTemporaryCacheFile(string cacheFileName)
        {
            var cacheFilePath = GetCacheFilePath(cacheFileName);
            FileUtils.DeleteFileIfExists(cacheFilePath);
        }

        public static string GetCacheFilePath(string cacheFileName)
        {
            return PathUtils.Combine(WebConfigUtils.ContentRootPath, DirectoryUtils.SiteFiles.DirectoryName, DirectoryUtils.SiteFiles.TemporaryFiles, cacheFileName);
        }
    }
}
