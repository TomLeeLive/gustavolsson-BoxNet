using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxNet.GamerServices
{
    public abstract class Gamer : IDisposable
    {
        public static SignedInGamerCollection SignedInGamers { get; }

        public string DisplayName { get; set; }
        public string Gamertag { get; set; }
        public object Tag { get; set; }
        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            IsDisposed = true;
        }
    }
}
