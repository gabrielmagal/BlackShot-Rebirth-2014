namespace Core.Auth.Enums
{
    public enum CharacterCreationErrorEnum : ushort
    {
        Success = 0,
        ERR_CHARINFO = 65403,
        NameAlreadyExists = 65404,
        NotEnoughSlots = 65405
    }
}
