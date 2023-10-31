using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class VrStereoConfig : ObjectValue
    {
        public Matrix Projection1 { get; set; }
        public Matrix Projection2 { get; set; }
        public Matrix ViewOffset1 { get; set; }
        public Matrix ViewOffset2 { get; set; }
        public Vector2 LeftLensCenter { get; set; }
        public Vector2 RightLensCenter { get; set; }
        public Vector2 LeftScreenCenter { get; set; }
        public Vector2 RightScreenCenter { get; set; }
        public Vector2 Scale { get; set; }
        public Vector2 ScaleIn { get; set; }

        public VrStereoConfig(
            Matrix projection1, Matrix projection2, 
            Matrix viewOffset1, Matrix viewOffset2,
            Vector2 leftLensCenter, Vector2 rightLensCenter,
            Vector2 leftScreenCenter, Vector2 rightScreenCenter,
            Vector2 scale, Vector2 scaleIn) : base()
        {
            Projection1 = projection1;
            Projection2 = projection2;
            ViewOffset1 = viewOffset1;
            ViewOffset2 = viewOffset2;
            LeftLensCenter = leftLensCenter;
            RightLensCenter = rightLensCenter;
            Scale = scale;
            ScaleIn = scaleIn;
            Init();
        }

        public VrStereoConfig(Structs.VrStereoConfig vrStereoConfig)
        {
            Struct = vrStereoConfig;
            Init();
        }

        public Structs.VrStereoConfig Struct
        {
            get
            {
                return new Structs.VrStereoConfig
                {
                    projection1 = Projection1.Struct, 
                    projection2 = Projection2.Struct,
                    viewOffset1 = ViewOffset1.Struct,
                    viewOffset2 = ViewOffset2.Struct,
                    leftLensCenter = LeftLensCenter.Struct,
                    rightLensCenter = RightLensCenter.Struct,
                    leftScreenCenter = LeftScreenCenter.Struct,
                    rightScreenCenter = RightScreenCenter.Struct,
                    scale = Scale.Struct,
                    scaleIn = ScaleIn.Struct
                };
            }
            set
            {
                Projection1 = new Matrix(value.projection1);
                Projection2 = new Matrix(value.projection2);
                ViewOffset1 = new Matrix(value.viewOffset1);
                ViewOffset2 = new Matrix(value.viewOffset2);
                LeftLensCenter = new Vector2(value.leftLensCenter);
                RightLensCenter = new Vector2(value.rightLensCenter);
                LeftScreenCenter = new Vector2(value.leftScreenCenter);
                RightScreenCenter = new Vector2(value.rightScreenCenter);
                Scale = new Vector2(value.scale);
                ScaleIn = new Vector2(value.scaleIn);
            }
        }

    }
}
