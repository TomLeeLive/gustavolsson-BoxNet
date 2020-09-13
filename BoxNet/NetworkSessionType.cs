using System;

namespace BoxNet
{
    public enum NetworkSessionType : byte
    {
        Local = 0,
        SystemLink = 1,
        PlayerMatch = 2,
        Ranked = 3,
    }
}
