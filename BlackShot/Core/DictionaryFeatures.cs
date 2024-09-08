using Core.enums;

namespace Core
{
    public class DictionaryFeatures
    {
        public static void AddPacket(Dictionary<ushort, List<object>> dictionary, object packetId, object packetObj)
        {
            var idCorrected = (ushort)(AuthCoreReceiveEnum)packetId;
            if (!dictionary.ContainsKey(idCorrected))
            {
                dictionary[idCorrected] = [];
            }
            dictionary[idCorrected].Add(packetObj);
        }
    }
}
