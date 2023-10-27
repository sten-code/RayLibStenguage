using Stenguage.Runtime.Values;

namespace RayLibStenguage
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
        }

    }
}
