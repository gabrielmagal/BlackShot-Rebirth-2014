using Core.enums;

namespace Core.Enums
{
    public class AuthCoreReceiveEnumHelper
    {
        public static string? GetName(int value)
        {
            if (Enum.IsDefined(typeof(AuthCoreReceiveEnum), value))
            {
                return Enum.GetName(typeof(AuthCoreReceiveEnum), value);
            }
            return null;
        }
    }
}
