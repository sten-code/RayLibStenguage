using Stenguage.Runtime.Values;

namespace RayLibStenguage
{
    internal class Utils
    {
        public static object GetValue(RuntimeValue value)
        {
            if (value.Type == RuntimeValueType.Number)
                return ((NumberValue)value).Value;
            else if (value.Type == RuntimeValueType.String)
                return ((StringValue)value).Value;
            else if (value.Type == RuntimeValueType.Boolean)
                return ((BooleanValue)value).Value;
            else if (value.Type == RuntimeValueType.List)
                return ((ListValue)value).Items.Select(x => GetValue(x)).ToArray();
            else
                return null;
        }

    }
}
