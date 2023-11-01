using Stenguage.Runtime.Values;

namespace RayLibStenguage
{
	internal class Utils
	{
		public static object GetValue(RuntimeValue value)
		{
			if (value.Type == RuntimeValueType.Number)
			{
				return ((NumberValue)value).Value;
			}
			if (value.Type == RuntimeValueType.String)
			{
				return ((StringValue)value).Value;
			}
			if (value.Type == RuntimeValueType.Boolean)
			{
				return ((BooleanValue)value).Value;
			}
			if (value.Type == RuntimeValueType.List)
			{
				return (from x in ((ListValue)value).Items
				select Utils.GetValue(x)).ToArray<object>();
			}
			return null;
		}
	}
}
