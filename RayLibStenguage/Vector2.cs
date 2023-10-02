using Stenguage;
using Stenguage.Runtime.Values;

namespace RayLibStenguage
{
    public class Vector2 : ObjectValue
    {
        public NumberValue X { get; set; }
        public NumberValue Y { get; set; }

        public Vector2(string sourceCode, Position start, Position end, NumberValue x, NumberValue y) : base(sourceCode, start, end)
        {
            X = x;
            Y = x;
        }

    }
}
