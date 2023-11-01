using Stenguage.Runtime.Values;

namespace RayLibStenguage.Classes
{
    public class VrDeviceInfo : ObjectValue
    {
        public NumberValue HResolution { get; set; }
        public NumberValue VResolution { get; set; }
        public NumberValue HScreenSize { get; set; }
        public NumberValue VScreenSize { get; set; }
        public NumberValue VScreenCenter { get; set; }
        public NumberValue EyeToScreenDistance { get; set; }
        public NumberValue LensSeparationDistance { get; set; }
        public NumberValue InterpupillaryDistance { get; set; }
        public ListValue LensDistortionValues { get; set; }
        public ListValue ChromaAbCorrection { get; set; }


        public VrDeviceInfo(
            NumberValue hResolution, NumberValue vResolution,
            NumberValue hScreenSize, NumberValue vScreenSize,
            NumberValue vScreenCenter, NumberValue eyeToScreenDistance,
            NumberValue lensSeparationDistance, NumberValue interpupillaryDistance,
            ListValue lensDistortionValues, ListValue chromaAbCorrection) : base()
        {
            HResolution = hResolution;
            VResolution = vResolution;
            HScreenSize = hScreenSize;
            VScreenSize = vScreenSize;
            VScreenCenter = vScreenCenter;
            EyeToScreenDistance = eyeToScreenDistance;
            LensSeparationDistance = lensSeparationDistance;
            InterpupillaryDistance = interpupillaryDistance;
            LensDistortionValues = lensDistortionValues;
            ChromaAbCorrection = chromaAbCorrection;
            Init();
        }

        public VrDeviceInfo(Structs.VrDeviceInfo vrStereoConfig)
        {
            Struct = vrStereoConfig;
            Init();
        }

        public Structs.VrDeviceInfo Struct
        {
            get
            {
                Structs.VrDeviceInfo vrDeviceInfo = new Structs.VrDeviceInfo
                {
                    hResolution = (int)HResolution.Value,
                    vResolution = (int)VResolution.Value,
                    hScreenSize = (float)HScreenSize.Value,
                    vScreenSize = (float)VScreenSize.Value,
                    vScreenCenter = (float)VScreenCenter.Value,
                    eyeToScreenDistance = (float)EyeToScreenDistance.Value,
                    lensSeparationDistance = (float)LensSeparationDistance.Value,
                    interpupillaryDistance = (float)InterpupillaryDistance.Value
                };

                unsafe
                {
                    for (int i = 0; i < 4; i++)
                        vrDeviceInfo.lensDistortionValues[i] =
                            LensDistortionValues.Items[i].Type == RuntimeValueType.Number ?
                                (float)((NumberValue)LensDistortionValues.Items[i]).Value
                                : 0.0f;
                }
                return vrDeviceInfo;
            }
            set
            {
                HResolution = new NumberValue(value.hResolution);
                VResolution = new NumberValue(value.vResolution);
                HScreenSize = new NumberValue(value.hScreenSize);
                VScreenSize = new NumberValue(value.vScreenSize);
                VScreenCenter = new NumberValue(value.vScreenCenter);
                EyeToScreenDistance = new NumberValue(value.eyeToScreenDistance);
                LensSeparationDistance = new NumberValue(value.lensSeparationDistance);
                InterpupillaryDistance = new NumberValue(value.interpupillaryDistance);
                unsafe
                {
                    float[] lensDistortionValues = new float[4];
                    for (int i = 0; i < 4; i++)
                    {
                        lensDistortionValues[i] = value.lensDistortionValues[i];
                    }
                    LensDistortionValues = new ListValue(lensDistortionValues.Select(x => new NumberValue(x)).Cast<RuntimeValue>().ToList());

                    float[] chromaAbCorrection = new float[4];
                    for (int i = 0; i < 4; i++)
                    {
                        chromaAbCorrection[i] = value.chromaAbCorrection[i];
                    }
                    ChromaAbCorrection = new ListValue(chromaAbCorrection.Select(x => new NumberValue(x)).Cast<RuntimeValue>().ToList());
                }
            }
        }

    }
}
