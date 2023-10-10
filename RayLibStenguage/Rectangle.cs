using Stenguage;
using Stenguage.Runtime.Values;

namespace RayLibStenguage
{
    public class Rectangle : ObjectValue
    {
        public NumberValue X { get; set; }
        public NumberValue Y { get; set; }
        public NumberValue Width { get; set; }
        public NumberValue Height { get; set; }

        public Rectangle(string sourceCode, NumberValue x, NumberValue y, NumberValue width, NumberValue height) : base(sourceCode)
        {
            X = x;
            Y = x;
            Width = width;
            Height = height;
        }

    }
}
