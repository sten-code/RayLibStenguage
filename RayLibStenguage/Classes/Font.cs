using Raylib_cs;
using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class Font : ObjectValue
    {
        public NumberValue BaseSize { get; set; }
        public NumberValue GlyphCount { get; set; }
        public NumberValue GlyphPadding { get; set; }
        public Texture2D Texture { get; set; }
        public ListValue Recs { get; set; }
        public ListValue Glyphs { get; set; }

        public Font(NumberValue baseSize, NumberValue glyphCount, NumberValue glyphPadding, Texture2D texture, ListValue recs, ListValue glyphs) : base()
        {
            BaseSize = baseSize;
            GlyphCount = glyphCount;
            GlyphPadding = glyphPadding;
            Texture = texture;
            Recs = recs;
            Glyphs = glyphs;
            Init();
        }

        public Font(Structs.Font font)
        {
            Struct = font;
            Init();
        }

        public Structs.Font Struct
        {
            get
            {
                return new Structs.Font
                {
                    baseSize = (int)BaseSize.Value,
                    glyphCount = (int)GlyphCount.Value,
                    glyphPadding = (int)GlyphPadding.Value,
                    texture = Texture.Struct,
                    recs = Recs.Items.Where(x => x.GetType() == typeof(Rectangle)).Select(x => ((Rectangle)x).Struct).ToArray(),
                    glyphs = Glyphs.Items.Where(x => x.GetType() == typeof(GlyphInfo)).Select(x => ((GlyphInfo)x).Struct).ToArray(),
                };
            }
            set
            {
                BaseSize = new NumberValue(value.baseSize);
                GlyphCount = new NumberValue(value.glyphCount);
                GlyphPadding = new NumberValue(value.glyphPadding);
                Texture = new Texture2D(value.texture);
                Recs = new ListValue(value.recs.Select(x => new Rectangle(x)).Cast<RuntimeValue>().ToList());
                Glyphs = new ListValue(value.glyphs.Select(x => new GlyphInfo(x)).Cast<RuntimeValue>().ToList());
            }
        }

    }
}
