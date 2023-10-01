# RayLib Stenguage

RayLib Stenguage is a wrapper for Raylib in Stenguage. It uses `Raylib-cs` to wrap the function to Stenguage.

## Setup

- Download this repository
- Download the [Stenguage](https://github.com/sten-code/Stenguage) repository
- Compile the Stenguage Interpreter with Visual Studio
- Open the `.sln` file in the RaylibStenguage folder and add a COM Reference to the `Stenguage.dll` file that you got from compiling the Stenguage Interpreter.
    - This dll file can be found inside `RayLibStenguage/bin/{Debug|Release}/net6.0`
- Now you can compile RayLib Stenguage
- `Raylib-cs` requires the official `raylib.dll` file to run. Download the `raylib-4.5.0_win64_msvc16.zip` file from the [4.5.0 raylib release](https://github.com/raysan5/raylib/releases/tag/4.5.0)
- Open the zip file, go to `raylib-4.5.0_win64_msvc16/lib` and copy the `raylib.dll` file into the output path of RayLib Stenguage.
- Go to your Stenguage install and these files into the folder that contains the `Stenguage.exe` file:
    - `raylib.dll`
    - `Raylib-cs.dll`
- Now create a folder named `lib`, inside there move the `RayLibStenguage.dll` into it.

The final file structure *should* look like this:
```
net6.0
├─libs
│ └─RayLibStenguage.dll
├─raylib.dll
├─Raylib-cs.dll
├─Stenguage.dll
├─Stenguage.exe
└─Stenguage.runtimeconfig.json
```

After all of those steps you will be able to use Raylib inside of Stenguage by using it like this

```py
from raylibstenguage import *

InitWindow(800, 480, "Hello World")

while (!WindowShouldClose())
{
    BeginDrawing()
    ClearBackground([255, 255, 255, 255])

    DrawText("Hello, world!", 12, 12, 20, [0, 0, 0, 255])

    EndDrawing()
}

CloseWindow()
```