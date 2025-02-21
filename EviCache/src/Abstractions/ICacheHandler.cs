﻿using System.Collections.Immutable;

namespace EviCache.Abstractions;

public interface ICacheHandler<TKey, TValue> where TKey : notnull
{
    ImmutableList<TKey> InternalCollection { get; }
    void RegisterAccess(TKey key);
    void RegisterInsertion(TKey key);
    void RegisterUpdate(TKey key);
    void RegisterRemoval(TKey key);
    void Clear();
    bool TrySelectEvictionCandidate(out TKey candidate);
}