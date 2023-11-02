using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class GlyphInfo : ObjectValue
    {
        public NumberValue Value { get; set; }
        public NumberValue OffsetX { get; set; }
        public NumberValue OffsetY { get; set; }
        public NumberValue AdvanceX { get; set; }
        public Image Image { get; set; }

        public GlyphInfo(NumberValue value, NumberValue offsetX, NumberValue offsetY, NumberValue advanceX, ListValue recs, Image image) : base()
        {
            Value = value;
            OffsetX = offsetX;
            OffsetY = offsetY;
            AdvanceX = advanceX;
            Image = image;
            Init();
        }

        public GlyphInfo(Structs.GlyphInfo font)
        {
            Struct = font;
            Init();
        }

        public Structs.GlyphInfo Struct
        {
            get
            {
                return new Structs.GlyphInfo
                {
                    value = (int)Value.Value,
                    offsetX = (int)OffsetX.Value,
                    offsetY = (int)OffsetY.Value,
                    advanceX = (int)AdvanceX.Value,
                    image = Image.Source
                };
            }
            set
            {
                Value = new NumberValue(value.value);
                OffsetX = new NumberValue(value.offsetX);
                OffsetY = new NumberValue(value.offsetY);
                AdvanceX = new NumberValue(value.advanceX);
                Image = new Image(value.image);
            }
        }

    }
}
