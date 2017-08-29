using System;
using System.Collections.Generic;
using System.Text;


namespace BPO.Core
{
    /// <summary>
    /// 缓存提供者
    /// </summary>
    public interface ICacheProvider
    {
        /// <summary>
        /// 根据Key获取缓存实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T Get<T>(string key);

        /// <summary>
        /// 向缓存中按Key添加数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="instance"></param>
        bool Insert<T>(string key, T instance);

        /// <summary>
        /// 向缓存中按Key添加数据,并设置缓存时间
        /// </summary>
        /// <param name="key"></param>
        /// <param name="instance"></param>
        /// <param name="seconds"></param>
        bool Insert<T>(string key, T instance, double seconds);

        /// <summary>
        /// 从缓存中按Key移除缓存数据项
        /// </summary>
        /// <param name="key"></param>
        bool Remove(string key);
        bool RemoveAll(string key);
    }
}
