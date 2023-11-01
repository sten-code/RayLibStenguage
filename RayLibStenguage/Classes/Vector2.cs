using Stenguage.Errors;
using Stenguage.Runtime;
using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class Vector2 : ObjectValue
    {
        public NumberValue X { get; set; }
        public NumberValue Y { get; set; }

        public Vector2(NumberValue x, NumberValue y) : base()
        {
            X = x;
            Y = y;
            Init();
        }

        public Vector2(System.Numerics.Vector2 vector)
        {
            Struct = vector;
            Init();
        }

        public System.Numerics.Vector2 Struct
        {
            get
            {
                return new System.Numerics.Vector2 { X = (float)X.Value, Y = (float)Y.Value };
            }
            set
            {
                X = new NumberValue(value.X);
                Y = new NumberValue(value.Y);
            }
        }

        public override RuntimeResult Add(RuntimeValue right, Context ctx)
        {
            if (right.GetType() != typeof(Vector2))
                return new RuntimeResult().Failure(new OperationError("+", Type, right.Type, ctx.Env.SourceCode, ctx.Start, ctx.End));

            Vector2 vec = (Vector2)right;
            return new RuntimeResult().Success(
                new Vector2(
                    new NumberValue(X.Value + vec.X.Value),
                    new NumberValue(Y.Value + vec.Y.Value)
                )
            );
        }

        public override RuntimeResult Sub(RuntimeValue right, Context ctx)
        {
            if (right.GetType() != typeof(Vector2))
                return new RuntimeResult().Failure(new OperationError("-", Type, right.Type, ctx.Env.SourceCode, ctx.Start, ctx.End));

            Vector2 vec = (Vector2)right;
            return new RuntimeResult().Success(
                new Vector2(
                    new NumberValue(X.Value - vec.X.Value),
                    new NumberValue(Y.Value - vec.Y.Value)
                )
            );
        }

        public override RuntimeResult Mul(RuntimeValue right, Context ctx)
        {
            if (right.GetType() != typeof(NumberValue))
                return new RuntimeResult().Failure(new OperationError("*", Type, right.Type, ctx.Env.SourceCode, ctx.Start, ctx.End));

            NumberValue num = (NumberValue)right;
            return new RuntimeResult().Success(
                new Vector2(
                    new NumberValue(X.Value * num.Value),
                    new NumberValue(Y.Value * num.Value)
                )
            );
        }

        public override RuntimeResult Div(RuntimeValue right, Context ctx)
        {
            if (right.GetType() != typeof(NumberValue))
                return new RuntimeResult().Failure(new OperationError("/", Type, right.Type, ctx.Env.SourceCode, ctx.Start, ctx.End));

            NumberValue num = (NumberValue)right;
            return new RuntimeResult().Success(
                new Vector2(
                    new NumberValue(X.Value / num.Value),
                    new NumberValue(Y.Value / num.Value)
                )
            );
        }

        public RuntimeResult Normalized(Context ctx)
        {
            double length = Math.Sqrt(X.Value * X.Value + Y.Value * Y.Value);
            return new RuntimeResult().Success(
                new Vector2(
                    new NumberValue(X.Value / length),
                    new NumberValue(Y.Value / length)
                )
            );
        }

        public RuntimeResult Magnitude(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Math.Sqrt(X.Value * X.Value + Y.Value * Y.Value)));
        }

        public RuntimeResult ClampMagnitude(NumberValue maxLength, Context ctx)
        {
            RuntimeResult res = new RuntimeResult();

            double sqrMagnitude = X.Value * X.Value + Y.Value * Y.Value;
            if (sqrMagnitude > maxLength.Value * maxLength.Value)
            {
                Vector2 normalized = (Vector2)res.Register(Normalized(ctx));
                if (res.ShouldReturn()) return res;

                return res.Success(
                    new Vector2(
                        new NumberValue(normalized.X.Value * maxLength.Value),
                        new NumberValue(normalized.Y.Value * maxLength.Value)
                    )
                );
            }

            return res.Success(this);
        }

    }
}
