using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class Texture2D : ObjectValue
    {
        public NumberValue Id { get; set; }
        public NumberValue Width { get; set; }
        public NumberValue Height { get; set; }
        public NumberValue MipMaps { get; set; }
        public NumberValue Format { get; set; }
        public Structs.Texture2D Source;

        public Texture2D(NumberValue id, NumberValue width, NumberValue height, NumberValue mipmaps, NumberValue format)
        {
            Id = id;
            Width = width;
            Height = height;
            MipMaps = mipmaps;
            Format = format;
            Source = Struct;
            Init();
        }

        public Texture2D(Structs.Texture2D texture2D)
        {
            Struct = texture2D;
            Source = texture2D;
            Init();
        }

        public Structs.Texture2D Struct
        {
            get
            {
                return new Structs.Texture2D
                { 
                    id = (uint)Id.Value,
                    width = (int)Width.Value,
                    height = (int)Height.Value,
                    mipmaps = (int)MipMaps.Value,
                    format = (Structs.PixelFormat)Format.Value
                };
            }
            set
            {
                Id = new NumberValue(value.id);
                Width = new NumberValue(value.width);
                Height = new NumberValue(value.height);
                MipMaps = new NumberValue(value.mipmaps);
                Format = new NumberValue((double)value.format);
            }
        }

    }
}
