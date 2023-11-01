using Stenguage.Errors;
using Stenguage.Runtime;
using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class Vector4 : ObjectValue
    {
        public NumberValue X { get; set; }
        public NumberValue Y { get; set; }
        public NumberValue Z { get; set; }
        public NumberValue W { get; set; }

        public Vector4(NumberValue x, NumberValue y, NumberValue z, NumberValue w) : base()
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
            Init();
        }

        public Vector4(System.Numerics.Vector4 vector)
        {
            Struct = vector;
            Init();
        }

        public System.Numerics.Vector4 Struct
        {
            get
            {
                return new System.Numerics.Vector4 { X = (float)X.Value, Y = (float)Y.Value, Z = (float)Z.Value, W = (float)W.Value };
            }
            set
            {
                X = new NumberValue(value.X);
                Y = new NumberValue(value.Y);
                Z = new NumberValue(value.Z);
                W = new NumberValue(value.W);
            }
        }

        public override RuntimeResult Add(RuntimeValue right, Context ctx)
        {
            if (right.GetType() != typeof(Vector4))
                return new RuntimeResult().Failure(new OperationError("+", Type, right.Type, ctx.Env.SourceCode, ctx.Start, ctx.End));

            Vector4 vec = (Vector4)right;
            return new RuntimeResult().Success(
                new Vector4(
                    new NumberValue(X.Value + vec.X.Value),
                    new NumberValue(Y.Value + vec.Y.Value),
                    new NumberValue(Z.Value + vec.Z.Value),
                    new NumberValue(W.Value + vec.W.Value)
                )
            );
        }

        public override RuntimeResult Sub(RuntimeValue right, Context ctx)
        {
            if (right.GetType() != typeof(Vector4))
                return new RuntimeResult().Failure(new OperationError("-", Type, right.Type, ctx.Env.SourceCode, ctx.Start, ctx.End));

            Vector4 vec = (Vector4)right;
            return new RuntimeResult().Success(
                new Vector4(
                    new NumberValue(X.Value - vec.X.Value),
                    new NumberValue(Y.Value - vec.Y.Value),
                    new NumberValue(Z.Value - vec.Z.Value),
                    new NumberValue(W.Value - vec.W.Value)
                )
            );
        }

        public override RuntimeResult Mul(RuntimeValue right, Context ctx)
        {
            if (right.GetType() != typeof(NumberValue))
                return new RuntimeResult().Failure(new OperationError("*", Type, right.Type, ctx.Env.SourceCode, ctx.Start, ctx.End));

            NumberValue num = (NumberValue)right;
            return new RuntimeResult().Success(
                new Vector4(
                    new NumberValue(X.Value * num.Value),
                    new NumberValue(Y.Value * num.Value),
                    new NumberValue(Z.Value * num.Value),
                    new NumberValue(Z.Value * num.Value)
                )
            );
        }

        public override RuntimeResult Div(RuntimeValue right, Context ctx)
        {
            if (right.GetType() != typeof(NumberValue))
                return new RuntimeResult().Failure(new OperationError("/", Type, right.Type, ctx.Env.SourceCode, ctx.Start, ctx.End));

            NumberValue num = (NumberValue)right;
            return new RuntimeResult().Success(
                new Vector4(
                    new NumberValue(X.Value / num.Value),
                    new NumberValue(Y.Value / num.Value),
                    new NumberValue(Z.Value / num.Value),
                    new NumberValue(Z.Value / num.Value)
                )
            );
        }

        public RuntimeResult Normalized(Context ctx)
        {
            double length = Math.Sqrt(X.Value * X.Value + Y.Value * Y.Value + Z.Value * Z.Value);
            return new RuntimeResult().Success(
                new Vector4(
                    new NumberValue(X.Value / length),
                    new NumberValue(Y.Value / length),
                    new NumberValue(Z.Value / length),
                    new NumberValue(Z.Value / length)
                )
            );
        }

        public RuntimeResult Magnitude(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Math.Sqrt(X.Value * X.Value + Y.Value * Y.Value + Z.Value * Z.Value + W.Value * W.Value)));
        }

        public RuntimeResult ClampMagnitude(NumberValue maxLength, Context ctx)
        {
            RuntimeResult res = new RuntimeResult();

            double sqrMagnitude = X.Value * X.Value + Y.Value * Y.Value + Z.Value * Z.Value + W.Value * W.Value;
            if (sqrMagnitude > maxLength.Value * maxLength.Value)
            {
                Vector4 normalized = (Vector4)res.Register(Normalized(ctx));
                if (res.ShouldReturn()) return res;

                return res.Success(
                    new Vector4(
                        new NumberValue(normalized.X.Value * maxLength.Value),
                        new NumberValue(normalized.Y.Value * maxLength.Value),
                        new NumberValue(normalized.Z.Value * maxLength.Value),
                        new NumberValue(normalized.Z.Value * maxLength.Value)
                    )
                );
            }

            return res.Success(this);
        }

    }
}
