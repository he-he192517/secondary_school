using System.Text.Json;
using Microsoft.Extensions.Caching.Distributed;

namespace FurSystemTest.Application.Util
{
    /// <summary>
    /// 缓存帮助类-redis
    /// </summary>
    public class Cachelper
    {
        //内存缓存
        private readonly IDistributedCache _distributedCache;
        public Cachelper(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }
        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expiry"></param>
        /// <returns></returns>
        public bool StringSet<T>(string key, T value, TimeSpan? expiry=null)
        {
            var options = new DistributedCacheEntryOptions();
            if (expiry != null)
            {
                options.SetAbsoluteExpiration((TimeSpan)expiry);
            }

            var jsonData = JsonSerializer.Serialize(value);
            _distributedCache.SetString(key, jsonData, options);
            return true;
        }
        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T StringGet<T>(string key)
        {
            var jsonData = _distributedCache.GetString(key);
            return jsonData == null ? default : JsonSerializer.Deserialize<T>(jsonData);
        }
        public void DeleteKey(string key)
        {
            _distributedCache.Remove(key);
        }
    }
}