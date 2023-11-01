using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class RenderTexture2D : ObjectValue
    {
        public NumberValue Id { get; set; }
        public Texture2D Texture { get; set; }
        public Texture2D Depth { get; set; }

        public RenderTexture2D(NumberValue id, Texture2D texture, Texture2D depth)
        {
            Id = id;
            Texture = texture;
            Depth = depth;
            Init();
        }

        public RenderTexture2D(Structs.RenderTexture2D renderTexture2D)
        {
            Struct = renderTexture2D;
            Init();
        }

        public Structs.RenderTexture2D Struct
        {
            get
            {
                return new Structs.RenderTexture2D
                {
                    id = (uint)Id.Value,
                    texture = Texture.Struct,
                    depth = Depth.Struct,
                };
            }
            set
            {
                Id = new NumberValue(value.id);
                Texture = new Texture2D(value.texture);
                Depth = new Texture2D(value.depth);
            }
        }

    }
}
