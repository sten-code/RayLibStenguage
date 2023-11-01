using Stenguage.Errors;
using Stenguage.Runtime;
using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class Matrix : ObjectValue
    {
        public NumberValue M00 { get; set; }
        public NumberValue M01 { get; set; }
        public NumberValue M02 { get; set; }
        public NumberValue M03 { get; set; }
        public NumberValue M10 { get; set; }
        public NumberValue M11 { get; set; }
        public NumberValue M12 { get; set; }
        public NumberValue M13 { get; set; }
        public NumberValue M20 { get; set; }
        public NumberValue M21 { get; set; }
        public NumberValue M22 { get; set; }
        public NumberValue M23 { get; set; }
        public NumberValue M30 { get; set; }
        public NumberValue M31 { get; set; }
        public NumberValue M32 { get; set; }
        public NumberValue M33 { get; set; }

        public Matrix(NumberValue m00, NumberValue m01, NumberValue m02, NumberValue m03,
                      NumberValue m10, NumberValue m11, NumberValue m12, NumberValue m13,
                      NumberValue m20, NumberValue m21, NumberValue m22, NumberValue m23,
                      NumberValue m30, NumberValue m31, NumberValue m32, NumberValue m33
                      ) : base()
        {
            M00 = m00; M01 = m01; M02 = m02; M03 = m03;
            M10 = m10; M11 = m11; M12 = m12; M13 = m13;
            M20 = m20; M21 = m21; M22 = m22; M23 = m23;
            M30 = m30; M31 = m31; M32 = m32; M33 = m33;
            Init();
        }

        public Matrix(System.Numerics.Matrix4x4 matrix)
        {
            Struct = matrix;
            Init();
        }

        public System.Numerics.Matrix4x4 Struct
        {
            get
            {
                return new System.Numerics.Matrix4x4(
                    (float)M00.Value, (float)M01.Value, (float)M02.Value, (float)M03.Value,
                    (float)M10.Value, (float)M11.Value, (float)M12.Value, (float)M13.Value,
                    (float)M20.Value, (float)M21.Value, (float)M22.Value, (float)M23.Value,
                    (float)M30.Value, (float)M31.Value, (float)M32.Value, (float)M33.Value
                );
            }
            set
            {
                M00 = new NumberValue(value.M11);
                M01 = new NumberValue(value.M12);
                M02 = new NumberValue(value.M13);
                M03 = new NumberValue(value.M14);

                M10 = new NumberValue(value.M21);
                M11 = new NumberValue(value.M22);
                M12 = new NumberValue(value.M23);
                M13 = new NumberValue(value.M24);

                M20 = new NumberValue(value.M31);
                M21 = new NumberValue(value.M32);
                M22 = new NumberValue(value.M33);
                M23 = new NumberValue(value.M34);

                M30 = new NumberValue(value.M41);
                M31 = new NumberValue(value.M42);
                M32 = new NumberValue(value.M43);
                M33 = new NumberValue(value.M44);
            }
        }

    }
}
