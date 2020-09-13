using System.Collections.Generic;

namespace BoxNet.GamerServices
{
    public class SignedInGamerCollection : GamerCollection<SignedInGamer>
    {
        public SignedInGamerCollection(IList<SignedInGamer> list) : base(list)
        { }
    }
}