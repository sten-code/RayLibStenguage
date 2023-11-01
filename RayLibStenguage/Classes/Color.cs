using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
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
            Init();
        }

        public Color(Structs.Color color)
        {
            Struct = color;
            Init();
        }

        public Structs.Color Struct
        {
            get
            {
                return new Structs.Color((byte)R.Value, (byte)G.Value, (byte)B.Value, (byte)A.Value);
            }
            set
            {
                R = new NumberValue(value.r);
                G = new NumberValue(value.g);
                B = new NumberValue(value.b);
                A = new NumberValue(value.a);
            }
        }

    }
}
