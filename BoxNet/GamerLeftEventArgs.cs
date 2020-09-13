using System;

namespace BoxNet
{
    public class GamerLeftEventArgs : EventArgs
    {
        public GamerLeftEventArgs(NetworkGamer gamer)
        {
            this.Gamer = gamer;
        }

        public NetworkGamer Gamer { get; private set; }
    }
}
