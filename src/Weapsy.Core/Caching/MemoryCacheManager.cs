﻿using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Weapsy.Core.Caching
{
    public class MemoryCacheManager : ICacheManager
	{
        IMemoryCache _memoryCache;

        public MemoryCacheManager(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

	    public T Get<T>(string key)
		{
            return (T)_memoryCache.Get(key);
		}

		public void Set(string key, object data, int cacheTime)
		{
			if (data == null)
				return;

            var memoryCacheEntryOptions = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromSeconds(cacheTime));

            _memoryCache.Set(key, data, memoryCacheEntryOptions);
		}

        public bool IsSet(string key)
        {
            //return Cache.Contains(key);

            throw new NotImplementedException();
        }

        public void Remove(string key)
		{
            _memoryCache.Remove(key);
		}

		public void RemoveByPattern(string pattern)
		{
            //var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            //var keysToRemove = new List<string>();

            //foreach (var item in Cache)
            //{
            //	if (regex.IsMatch(item.Key))
            //	{
            //		keysToRemove.Add(item.Key);
            //	}
            //}

            //foreach (string key in keysToRemove)
            //{
            //	Remove(key);
            //}

            throw new NotImplementedException();
        }

		public void Clear()
		{
            //foreach (var item in Cache)
            //{
            //	Remove(item.Key);
            //}

            throw new NotImplementedException();
        }
    }
}