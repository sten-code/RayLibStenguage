using System.Text;

namespace RayLibStenguage
{
    internal class Utils
    {
        public unsafe static sbyte* StringToSBytePtr(string str)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(str);

            unsafe
            {
                fixed (byte* p = bytes)
                {
                    sbyte* sp = (sbyte*)p;
                    return sp;
                }
            }
        }
    }
}
