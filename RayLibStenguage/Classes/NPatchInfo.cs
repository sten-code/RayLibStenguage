using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class NPatchInfo : ObjectValue
    {
        public Rectangle Source { get; set; }
        public NumberValue Left { get; set; }
        public NumberValue Top { get; set; }
        public NumberValue Right { get; set; }
        public NumberValue Bottom { get; set; }
        public NumberValue Layout { get; set; }

        public NPatchInfo(Rectangle source, NumberValue left, NumberValue top, NumberValue right, NumberValue bottom, NumberValue layout)
        {
            Source = source;
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
            Layout = layout;
            Init();
        }

        public NPatchInfo(Structs.NPatchInfo nPatchInfo)
        {
            Struct = nPatchInfo;
            Init();
        }

        public Structs.NPatchInfo Struct
        {
            get
            {
                return new Structs.NPatchInfo
                {
                    source = Source.Struct,
                    left = (int)Left.Value,
                    top = (int)Top.Value,
                    right = (int)Right.Value,
                    bottom = (int)Bottom.Value,
                    layout = (Structs.NPatchLayout)Layout.Value
                };
            }
            set
            {
                Source = new Rectangle(value.source);
                Left = new NumberValue(value.left);
                Top = new NumberValue(value.top);
                Right = new NumberValue(value.right);
                Bottom = new NumberValue(value.bottom);
                Layout = new NumberValue((int)value.layout);
            }
        }

    }
}
