using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class Image : ObjectValue
    {
        public Structs.Image Source { get; set; }

        public Image(Structs.Image source)
        {
            Source = source;
            Init();
        }
    }
}
