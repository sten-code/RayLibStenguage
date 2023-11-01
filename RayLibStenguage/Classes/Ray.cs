using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class Ray : ObjectValue
    {
        public Vector3 Position { get; set; }
        public Vector3 Direction { get; set; }

        public Ray(Vector3 position, Vector3 direction) : base()
        {
            Position = position;
            Direction = direction;
            Init();
        }

        public Ray(Structs.Ray ray)
        {
            Struct = ray;
            Init();
        }

        public Structs.Ray Struct
        {
            get
            {
                return new Structs.Ray(Position.Struct, Direction.Struct);
            }
            set
            {
                Position = new Vector3(value.position);
                Direction = new Vector3(value.direction);
            }
        }

    }
}
