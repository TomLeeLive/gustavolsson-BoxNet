using System;

namespace BoxNet
{
    public class HostChangedEventArgs : EventArgs
    {
        public HostChangedEventArgs(NetworkGamer oldHost, NetworkGamer newHost)
        {
            this.OldHost = oldHost;
            this.NewHost = newHost;
        }

        public NetworkGamer OldHost { get; private set; }
        public NetworkGamer NewHost { get; private set; }
    }
}
