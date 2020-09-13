namespace BoxNet
{
    public enum NetworkSessionEndReason : byte
    {
        ClientSignedOut,
        HostEndedSession,
        RemovedByHost,
        Disconnected,
    }
}
