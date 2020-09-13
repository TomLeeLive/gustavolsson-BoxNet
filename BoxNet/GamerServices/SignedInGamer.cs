using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxNet.GamerServices
{
    public sealed class SignedInGamer : Gamer
    {
        public int PlayerIndex { get; set; }

        public SignedInGamer(string displayName, string gamertag, int playerIndex)
        {
            DisplayName = displayName;
            Gamertag = gamertag;
            PlayerIndex = playerIndex;
        }

        public static Action<object, SignedOutEventArgs> SignedOut { get; internal set; }
    }
}
