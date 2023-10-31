using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class Camera2D : ObjectValue
    {
        public Vector2 Offset { get; set; }
        public Vector2 Target { get; set; }
        public NumberValue Rotation { get; set; }
        public NumberValue Zoom { get; set; }

        public Camera2D(Vector2 offset, Vector2 target, NumberValue rotation, NumberValue zoom) : base()
        {
            Offset = offset;
            Target = target;
            Rotation = rotation;
            Zoom = zoom;
            Init();
        }

        public Camera2D(Structs.Camera2D camera)
        {
            Struct = camera;
            Init();
        }

        public Structs.Camera2D Struct
        {
            get
            {
                return new Structs.Camera2D(Offset.Struct, Target.Struct, (float)Rotation.Value, (float)Zoom.Value);
            }
            set
            {
                Offset = new Vector2(value.offset);
                Target = new Vector2(value.target);
                Rotation = new NumberValue(value.rotation);
                Zoom = new NumberValue(value.zoom);
            }
        }

    }
}
