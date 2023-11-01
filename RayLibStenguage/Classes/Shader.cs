using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class Shader : ObjectValue
    {
        public NumberValue Id { get; set; }
        public ListValue Locs { get; set; }

        public Shader(NumberValue id, ListValue locs) : base()
        {
            Id = id;
            Locs = locs;
            Init();
        }

        public Shader(Structs.Shader shader)
        {
            Struct = shader;
            Init();
        }

        public Structs.Shader Struct
        {
            get
            {
                return new Structs.Shader
                {
                    id = (uint)Id.Value,
                    locs = Locs.Items.Where(x => x.Type == RuntimeValueType.Number).Select(x => (int)((NumberValue)x).Value).ToArray()
                };
            }
            set
            {
                Id = new NumberValue(value.id);
                Locs = new ListValue(value.locs.Select(x => new NumberValue(x)).Cast<RuntimeValue>().ToList());
            }
        }

    }
}
