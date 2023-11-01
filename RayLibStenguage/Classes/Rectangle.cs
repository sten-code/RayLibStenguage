using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class Rectangle : ObjectValue
    {
        public NumberValue X { get; set; }
        public NumberValue Y { get; set; }
        public NumberValue Width { get; set; }
        public NumberValue Height { get; set; }

        public Rectangle(NumberValue x, NumberValue y, NumberValue width, NumberValue height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Init();
        }

        public Rectangle(Structs.Rectangle rectangle)
        {
            Struct = rectangle;
            Init();
        }

        public Structs.Rectangle Struct
        {
            get
            {
                return new Structs.Rectangle((float)X.Value, (float)Y.Value, (float)Width.Value, (float)Height.Value);
            }
            set
            {
                X = new NumberValue(value.x);
                Y = new NumberValue(value.y);
                Width = new NumberValue(value.width);
                Height = new NumberValue(value.height);
            }
        }

    }
}
