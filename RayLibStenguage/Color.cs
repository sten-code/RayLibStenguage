using Stenguage;
using Stenguage.Runtime.Values;

namespace RayLibStenguage
{
    public class Color : ObjectValue
    {
        public NumberValue R { get; set; }
        public NumberValue G { get; set; }
        public NumberValue B { get; set; }
        public NumberValue A { get; set; }

        public Color(string sourceCode, Position start, Position end, NumberValue r, NumberValue g, NumberValue b, NumberValue a = null) : base(sourceCode, start, end)
        {
            R = r;
            G = g;
            B = b;
            A = a == null ? new NumberValue(255, SourceCode, Start, End) : a;
        }

    }
}
