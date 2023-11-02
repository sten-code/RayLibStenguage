using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class Camera3D : ObjectValue
    {
        public Vector3 Position { get; set; }
        public Vector3 Target { get; set; }
        public Vector3 Up { get; set; }
        public NumberValue FOVY { get; set; }
        public NumberValue Projection { get; set; }

        public Camera3D(Vector3 position, Vector3 target, Vector3 up, NumberValue fovy, NumberValue projection) : base()
        {
            Position = position;
            Target = target;
            Up = up;
            FOVY = fovy;
            Projection = projection;
            Init();
        }

        public Camera3D(Structs.Camera3D camera)
        {
            Struct = camera;
            Init();
        }

        public Structs.Camera3D Struct
        {
            get
            {
                return new Structs.Camera3D(Position.Struct, Target.Struct, Up.Struct, (float)FOVY.Value, (Structs.CameraProjection)Projection.Value);
            }
            set
            {
                Position = new Vector3(value.position);
                Target = new Vector3(value.target);
                Up = new Vector3(value.up);
                FOVY = new NumberValue(value.fovy);
                Projection = new NumberValue((double)value.projection);
            }
        }

    }
}
