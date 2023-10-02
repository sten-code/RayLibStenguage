using Raylib_cs;
using Stenguage;
using Stenguage.Runtime.Values;

namespace RayLibStenguage
{
    public class Image : ObjectValue
    {
        public Raylib_cs.Image Source { get; set; }

        public unsafe Image(string sourceCode, Position start, Position end, StringValue filePath) : base(sourceCode, start, end)
        {
            Source = Raylib.LoadImage(Utils.StringToSBytePtr(filePath.Value));
        }

    }
}
