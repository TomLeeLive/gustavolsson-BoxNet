using System;
using BoxNet.GamerServices;

namespace BoxNet
{
    public class InviteAcceptedEventArgs : EventArgs
    {
        public InviteAcceptedEventArgs(SignedInGamer gamer, bool isCurrentSession)
        {
            this.Gamer = gamer;
            this.IsCurrentSession = isCurrentSession;
        }

        public SignedInGamer Gamer { get; private set; }
        public bool IsCurrentSession { get; private set; }
    }
}
