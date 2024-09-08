using BlubLib;
using System.Text;

namespace Core.Serializer
{
    public static class Extensions
    {
        public static void WriteString(this BinaryWriter w, string value, int length)
        {
            if (value == null)
            {
                w.Write(new byte[length]);
                return;
            }
            byte[] a = new byte[length];
            a.ToBinaryWriter().Write(Encoding.ASCII.GetBytes(value));
            w.Write(a);
        }

        public static string ReadString(this BinaryReader r, int length)
        {
            return Encoding.ASCII.GetString(r.ReadBytes(length));
        }
    }
}
