using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BoxNet
{
    public sealed class AvailableNetworkSessionCollection : ReadOnlyCollection<AvailableNetworkSession>, IDisposable
    {
        public AvailableNetworkSessionCollection(IList<AvailableNetworkSession> list) : base(list)
        {}

        public void Dispose()
        {}
    }
}