namespace LobbyCore.Enums
{
    public enum LoginResultEnum : byte
    {
        Success = 0,
        Dismissal = 240,
        KDNotMatch = 241,
        LocationNotAllowed = 242,
        ClanOnly = 247,
        RankTooHigh = 248,
        SystemError = 249,
        UnableToRetrieveCharacter = 250,
        WaitingForResponse = 251,
        AlreadyLogged = 252,
        InvalidClientVersion = 253,
        ChannelMaxCapacity = 254,
        WrongCredentials = 255 // Back when they used the ID and Password interface
    }
}
