using Stenguage.Runtime.Values;

namespace RayLibStenguage
{
    public class Vector2 : ObjectValue
    {
        public NumberValue X { get; set; }
        public NumberValue Y { get; set; }

        public Vector2(string sourceCode, NumberValue x, NumberValue y) : base(sourceCode)
        {
            X = x;
            Y = x;
        }

    }
}
