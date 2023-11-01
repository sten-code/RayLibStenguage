using Stenguage.Runtime.Values;
using System.Runtime.InteropServices;

namespace RayLibStenguage.Classes
{
    public class FilePathList : ObjectValue
    {
        public ListValue Paths { get; set; }
        public Structs.FilePathList List { get; set; }

        public FilePathList(Structs.FilePathList list)
        {
            Struct = list;
            Init();
        }

        public unsafe Structs.FilePathList Struct
        {
            get
            {
                return List;
            }
            set
            {
                List = value;
                Paths.Items.Clear();
                // Iterate through the array of byte pointers and convert them to strings
                int i = 0;
                while (true)
                {
                    byte* bytePtr = List.paths[i];
                    if (bytePtr == null)
                        break;

                    string str = Marshal.PtrToStringUTF8((IntPtr)bytePtr);
                    Paths.Items.Add(new StringValue(str));
                    i++;
                }
            }
        }

    }
}
