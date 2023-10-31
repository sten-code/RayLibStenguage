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

        public Color(NumberValue r, NumberValue g, NumberValue b, NumberValue a = null) : base()
        {
            R = r;
            G = g;
            B = b;
            A = a == null ? new NumberValue(255) : a;
        }

    }
}
