using System;

namespace BoxNet
{
    public class NetworkSessionEndedEventArgs : EventArgs
    {
        public NetworkSessionEndedEventArgs(NetworkSessionEndReason endReason)
        {
            this.EndReason = endReason;
        }

        public NetworkSessionEndReason EndReason { get; private set; }
    }
}
