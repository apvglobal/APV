﻿using System;

namespace Apv.IO.Caching
{
    internal abstract class LRUCache<TKey, TValue> : Cache<TKey, TValue>
    {
        public LRUCache(int max_capacity)
            : base(max_capacity)
        {
        }

        protected override void OnAccess(CacheItem item)
        {
            item.Time = DateTime.Now;
        }
    }
}
