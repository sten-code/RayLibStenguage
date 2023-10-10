using Raylib_cs;
using Stenguage.Runtime.Values;
using Stenguage.Runtime;
using Stenguage;
using System.Runtime.InteropServices;
using System.Linq;
using System;

namespace RayLibStenguage
{
    public class RCore
    {
        public static RuntimeResult InitWindow(Context ctx, 
            NumberValue width, NumberValue height, StringValue title)
        {
            Raylib.InitWindow(
                (int)width.Value, 
                (int)height.Value, 
                title.Value
            );

            return RuntimeResult.Null();
        }
        public static RuntimeResult WindowShouldClose(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.WindowShouldClose()));
        }
        public static RuntimeResult CloseWindow(Context ctx)
        {
            Raylib.CloseWindow();
            return RuntimeResult.Null();
        }
        public static RuntimeResult IsWindowReady(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowReady()));
        }
        public static RuntimeResult IsWindowFullscreen(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowFullscreen()));
        }
        public static RuntimeResult IsWindowHidden(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowHidden()));
        }
        public static RuntimeResult IsWindowMinimized(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowMinimized()));
        }
        public static RuntimeResult IsWindowMaximized(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowMaximized()));
        }
        public static RuntimeResult IsWindowFocused(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowFocused()));
        }
        public static RuntimeResult IsWindowResized(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowResized()));
        }
        public static RuntimeResult IsWindowState(Context ctx, 
            NumberValue flag)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowState((ConfigFlags)flag.Value)));
        }
        public static RuntimeResult SetWindowState(Context ctx, 
            NumberValue flags)
        {
            Raylib.SetWindowState((ConfigFlags)flags.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult ClearWindowState(Context ctx, 
            NumberValue flags)
        {
            Raylib.ClearWindowState((ConfigFlags)flags.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult ToggleFullscreen(Context ctx)
        {
            Raylib.ToggleFullscreen();
            return RuntimeResult.Null();
        }
        public static RuntimeResult MaximizeWindow(Context ctx)
        {
            Raylib.MaximizeWindow();
            return RuntimeResult.Null();
        }
        public static RuntimeResult MinimizeWindow(Context ctx)
        {
            Raylib.MinimizeWindow();
            return RuntimeResult.Null();
        }
        public static RuntimeResult RestoreWindow(Context ctx)
        {
            Raylib.RestoreWindow();
            return RuntimeResult.Null();
        }
        public static RuntimeResult SetWindowIcon(Context ctx, Image image)
        {
            Raylib.SetWindowIcon(image.Source);
            return RuntimeResult.Null();
        }
        public unsafe static RuntimeResult SetWindowIcons(Context ctx, ListValue images)
        {
            fixed (Raylib_cs.Image* imgs = images.Items.Cast<Image>().Select(img => img.Source).ToArray())
            {
                Raylib.SetWindowIcons(imgs, images.Items.Count);
            }

            return RuntimeResult.Null();
        }
        public static RuntimeResult SetWindowTitle(Context ctx, 
            StringValue title)
        {
            Raylib.SetWindowTitle(title.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult SetWindowPosition(Context ctx, 
            NumberValue x, NumberValue y)
        {
            Raylib.SetWindowPosition(
                (int)x.Value, 
                (int)y.Value
            );
            return RuntimeResult.Null();
        }
        public static RuntimeResult SetWindowMonitor(Context ctx, 
            NumberValue monitor)
        {
            Raylib.SetWindowMonitor((int)monitor.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult SetWindowMinSize(Context ctx,
            NumberValue width, NumberValue height)
        {
            Raylib.SetWindowMinSize(
                (int)width.Value, 
                (int)height.Value
            );
            return RuntimeResult.Null();
        }
        public static RuntimeResult SetWindowSize(Context ctx, 
            NumberValue width, NumberValue height)
        {
            Raylib.SetWindowSize(
                (int)width.Value, 
                (int)height.Value
            );
            return RuntimeResult.Null();
        }
        public static RuntimeResult SetWindowOpacity(Context ctx, 
            NumberValue opacity)
        {
            Raylib.SetWindowOpacity((float)opacity.Value);
            return RuntimeResult.Null();
        }
        public unsafe static RuntimeResult GetWindowHandle(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(((IntPtr)Raylib.GetWindowHandle()).ToInt64()));
        }
        public static RuntimeResult GetScreenWidth(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetScreenWidth()));
        }
        public static RuntimeResult GetScreenHeight(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetScreenHeight()));
        }
        public static RuntimeResult GetRenderWidth(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetRenderWidth()));
        }
        public static RuntimeResult GetRenderHeight(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetRenderHeight()));
        }
        public static RuntimeResult GetMonitorCount(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMonitorCount()));
        }
        public static RuntimeResult GetCurrentMonitor(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetCurrentMonitor()));
        }
        public static RuntimeResult GetMonitorPosition(Context ctx, 
            NumberValue monitor)
        {
            System.Numerics.Vector2 vector = Raylib.GetMonitorPosition((int)monitor.Value);
            return new RuntimeResult().Success(new Vector2(
                new NumberValue(vector.X), 
                new NumberValue(vector.Y) 
            ));
        }
        public static RuntimeResult GetMonitorWidth(Context ctx, 
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMonitorWidth((int)monitor.Value)));
        }
        public static RuntimeResult GetMonitorHeight(Context ctx, 
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMonitorHeight((int)monitor.Value)));
        }
        public static RuntimeResult GetMonitorPhysicalWidth(Context ctx,
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMonitorPhysicalWidth((int)monitor.Value)));
        }
        public static RuntimeResult GetMonitorPhysicalHeight(Context ctx, 
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMonitorPhysicalHeight((int)monitor.Value)));
        }
        public static RuntimeResult GetMonitorRefreshRate(Context ctx, 
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMonitorRefreshRate((int)monitor.Value)));
        }
        public static RuntimeResult GetWindowPosition(Context ctx)
        {
            System.Numerics.Vector2 vector = Raylib.GetWindowPosition();
            return new RuntimeResult().Success(new Vector2(
                new NumberValue(vector.X), 
                new NumberValue(vector.Y)
            ));
        }
        public static RuntimeResult GetWindowScaleDPI(Context ctx)
        {
            System.Numerics.Vector2 vector = Raylib.GetWindowScaleDPI();
            return new RuntimeResult().Success(new Vector2(
                new NumberValue(vector.X), 
                new NumberValue(vector.Y) 
            ));
        }
        public unsafe static RuntimeResult GetMonitorName(Context ctx, 
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetMonitorName((int)monitor.Value)
                )
            ));
        }
        public static RuntimeResult SetClipboardText(Context ctx, 
            StringValue text)
        {
            Raylib.SetClipboardText(text.Value);
            return RuntimeResult.Null();
        }
        public unsafe static RuntimeResult GetClipboardText(Context ctx)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetClipboardText()
                )
            ));
        }
        public static RuntimeResult EnableEventWaiting(Context ctx)
        {
            Raylib.EnableEventWaiting();
            return RuntimeResult.Null();
        }
        public static RuntimeResult DisableEventWaiting(Context ctx)
        {
            Raylib.DisableEventWaiting();
            return RuntimeResult.Null();
        }
        public static RuntimeResult SwapScreenBuffer(Context ctx)
        {
            Raylib.SwapScreenBuffer();
            return RuntimeResult.Null();
        }
        public static RuntimeResult PollInputEvents(Context ctx)
        {
            Raylib.PollInputEvents();
            return RuntimeResult.Null();
        }
        public static RuntimeResult WaitTime(Context ctx, 
            NumberValue seconds)
        {
            Raylib.WaitTime(seconds.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult ShowCursor(Context ctx)
        {
            Raylib.ShowCursor();
            return RuntimeResult.Null();
        }
        public static RuntimeResult HideCursor(Context ctx)
        {
            Raylib.HideCursor();
            return RuntimeResult.Null();
        }
        public static RuntimeResult IsCursorHidden(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsCursorHidden()));
        }
        public static RuntimeResult EnableCursor(Context ctx)
        {
            Raylib.EnableCursor();
            return RuntimeResult.Null();
        }
        public static RuntimeResult DisableCursor(Context ctx)
        {
            Raylib.DisableCursor();
            return RuntimeResult.Null();
        }
        public static RuntimeResult IsCursorOnScreen(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsCursorOnScreen()));
        }
        public static RuntimeResult ClearBackground(Context ctx, 
            Color color)
        {
            Raylib.ClearBackground(
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null();
        }
        public static RuntimeResult BeginDrawing(Context ctx)
        {
            Raylib.BeginDrawing();
            return RuntimeResult.Null();
        }
        public static RuntimeResult EndDrawing(Context ctx)
        {
            Raylib.EndDrawing();
            return RuntimeResult.Null();
        }
        // void BeginMode2D(Camera2D camera);

        public static RuntimeResult EndMode2D(Context ctx)
        {
            Raylib.EndMode2D();
            return RuntimeResult.Null();
        }
        // void BeginMode3D(Camera3D camera);

        public static RuntimeResult EndMode3D(Context ctx)
        {
            Raylib.EndMode3D();
            return RuntimeResult.Null();
        }
        // void BeginTextureMode(RenderTexture2D target);

        public static RuntimeResult EndTextureMode(Context ctx)
        {
            Raylib.EndTextureMode();
            return RuntimeResult.Null();
        }
        // void BeginShaderMode(Shader shader);

        public static RuntimeResult EndShaderMode(Context ctx)
        {
            Raylib.EndShaderMode();
            return RuntimeResult.Null();
        }
        public static RuntimeResult BeginBlendMode(Context ctx, 
            NumberValue mode)
        {
            Raylib.BeginBlendMode((BlendMode)mode.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult EndBlendMode(Context ctx)
        {
            Raylib.EndBlendMode();
            return RuntimeResult.Null();
        }
        public static RuntimeResult BeginScissorMode(Context ctx, 
            NumberValue x, NumberValue y, NumberValue width, NumberValue height)
        {
            Raylib.BeginScissorMode(
                (int)x.Value, 
                (int)y.Value,
                (int)width.Value, 
                (int)height.Value
            );
            return RuntimeResult.Null();
        }
        public static RuntimeResult EndScissorMode(Context ctx)
        {
            Raylib.EndScissorMode();
            return RuntimeResult.Null();
        }
        // void BeginVrStereoMode(VrStereoConfig config);

        public static RuntimeResult EndVrStereoMode(Context ctx)
        {
            Raylib.EndVrStereoMode();
            return RuntimeResult.Null();
        }
        // VrStereoConfig LoadVrStereoConfig(VrDeviceInfo device);

        // void UnloadVrStereoConfig(VrStereoConfig config);

        // Shader LoadShader(string vsFileName, string fsFileName);

        // Shader LoadShaderFromMemory(string vsCode, string fsCode);

        // bool IsShaderReady(Shader shader);

        // int GetShaderLocation(Shader shader, string uniformName);

        // int GetShaderLocationAttrib(Shader shader, string attribName);

        // void SetShaderValue(Shader shader, int locIndex, const void *value, int uniformType);

        // void SetShaderValueV(Shader shader, int locIndex, const void *value, int uniformType, int count);

        // void SetShaderValueMatrix(Shader shader, int locIndex, Matrix mat);

        // void SetShaderValueTexture(Shader shader, int locIndex, Texture2D texture);

        // void UnloadShader(Shader shader);

        // Ray GetMouseRay(Vector2 mousePosition, Camera camera);

        // Matrix GetCameraMatrix(Camera camera);

        // Matrix GetCameraMatrix2D(Camera2D camera);

        // Vector2 GetWorldToScreen(Vector3 position, Camera camera);

        // Vector2 GetScreenToWorld2D(Vector2 position, Camera2D camera);

        // Vector2 GetWorldToScreenEx(Vector3 position, Camera camera, int width, int height);

        // Vector2 GetWorldToScreen2D(Vector2 position, Camera2D camera);

        public static RuntimeResult SetTargetFPS(Context ctx, 
            NumberValue fps)
        {
            Raylib.SetTargetFPS((int)fps.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult GetFPS(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetFPS()));
        }
        public static RuntimeResult GetFrameTime(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetFrameTime()));
        }
        public static RuntimeResult GetTime(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetTime()));
        }
        public static RuntimeResult GetRandomValue(Context ctx, 
            NumberValue min, NumberValue max)
        {
            return new RuntimeResult().Success(new NumberValue(
                Raylib.GetRandomValue(
                    (int)min.Value, 
                    (int)max.Value
                )
            ));
        }
        public static RuntimeResult SetRandomSeed(Context ctx, 
            NumberValue seed)
        {
            Raylib.SetRandomSeed((uint)seed.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult TakeScreenshot(Context ctx,
            StringValue fileName)
        {
            Raylib.TakeScreenshot(fileName.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult SetConfigFlags(Context ctx, 
            NumberValue flags)
        {
            Raylib.SetConfigFlags((ConfigFlags)flags.Value);
            return RuntimeResult.Null();
        }
        public unsafe static RuntimeResult TraceLog(Context ctx, 
            NumberValue logLevel, StringValue text)
        {
            Raylib.TraceLog(
                (TraceLogLevel)logLevel.Value, 
                Utils.StringToSBytePtr(text.Value)
            );
            return RuntimeResult.Null();
        }
        public static RuntimeResult SetTraceLogLevel(Context ctx, 
            NumberValue logLevel)
        {
            Raylib.SetTraceLogLevel((TraceLogLevel)logLevel.Value);
            return RuntimeResult.Null();
        }
        // void *MemAlloc(int size);

        // void *MemRealloc(void *ptr, int size);

        // void MemFree(void *ptr);

        public static RuntimeResult OpenURL(Context ctx, 
            StringValue url)
        {
            Raylib.OpenURL(url.Value);
            return RuntimeResult.Null();
        }
        // void SetTraceLogCallback(TraceLogCallback callback);

        // void SetLoadFileDataCallback(LoadFileDataCallback callback);

        // void SetSaveFileDataCallback(SaveFileDataCallback callback);

        // void SetLoadFileTextCallback(LoadFileTextCallback callback);

        // void SetSaveFileTextCallback(SaveFileTextCallback callback);

        public unsafe static RuntimeResult LoadFileData(Context ctx, 
            StringValue fileName, ListValue bytesRead)
        {
            uint* array = stackalloc uint[bytesRead.Items.Count];
            for (int i = 0; i < bytesRead.Items.Count; i++)
            {
                if (bytesRead.Items[i] is NumberValue)
                {
                    array[i] = (uint)((NumberValue)bytesRead.Items[i]).Value;
                }
            }

            Raylib.LoadFileData(Utils.StringToSBytePtr(fileName.Value), array);
            return RuntimeResult.Null();
        }
        public unsafe static RuntimeResult UnloadFileData(Context ctx, 
            ListValue data)
        {
            byte* bytes = stackalloc byte[data.Items.Count];
            for (int i = 0; i < data.Items.Count; i++)
            {
                if (data.Items[i] is NumberValue)
                {
                    bytes[i] = (byte)((NumberValue)data.Items[i]).Value;
                }
            }

            Raylib.UnloadFileData(bytes);
            return RuntimeResult.Null();
        }

        #region Save File Data
        public unsafe static RuntimeResult SaveFileData(Context ctx, 
            StringValue fileName, ListValue data, NumberValue bytesToWrite)
        {
            byte* bytes = stackalloc byte[data.Items.Count];
            for (int i = 0; i < data.Items.Count; i++)
            {
                if (data.Items[i] is NumberValue)
                {
                    bytes[i] = (byte)((NumberValue)data.Items[i]).Value;
                }
            }

            Raylib.SaveFileData(Utils.StringToSBytePtr(fileName.Value), bytes, (uint)bytesToWrite.Value);
            return RuntimeResult.Null();
        }
        public unsafe static RuntimeResult SaveFileData(Context ctx, 
            StringValue fileName, ListValue data)
        {
            byte* bytes = stackalloc byte[data.Items.Count];
            for (int i = 0; i < data.Items.Count; i++)
            {
                if (data.Items[i] is NumberValue)
                {
                    bytes[i] = (byte)((NumberValue)data.Items[i]).Value;
                }
            }

            Raylib.SaveFileData(Utils.StringToSBytePtr(fileName.Value), bytes, (uint)data.Items.Count);
            return RuntimeResult.Null();
        }
        public unsafe static RuntimeResult SaveFileData(Context ctx, 
            StringValue fileName, StringValue data, NumberValue bytesToWrite)
        {
            byte* bytes = stackalloc byte[data.Value.Length];
            for (int i = 0; i < data.Value.Length; i++)
            {
                bytes[i] = (byte)data.Value[i];
            }

            Raylib.SaveFileData(Utils.StringToSBytePtr(fileName.Value), bytes, (uint)bytesToWrite.Value);
            return RuntimeResult.Null();
        }
        public unsafe static RuntimeResult SaveFileData(Context ctx, 
            StringValue fileName, StringValue data)
        {
            byte* bytes = stackalloc byte[data.Value.Length];
            for (int i = 0; i < data.Value.Length; i++)
            {
                bytes[i] = (byte)data.Value[i];
            }

            Raylib.SaveFileData(Utils.StringToSBytePtr(fileName.Value), bytes, (uint)data.Value.Length);
            return RuntimeResult.Null();
        }
        #endregion

        public unsafe static RuntimeResult ExportDataAsCode(Context ctx,
            ListValue data, NumberValue size, StringValue fileName)
        {
            byte* bytes = stackalloc byte[data.Items.Count];
            for (int i = 0; i < data.Items.Count; i++)
            {
                if (data.Items[i] is NumberValue)
                {
                    bytes[i] = (byte)((NumberValue)data.Items[i]).Value;
                }
            }

            return new RuntimeResult().Success(new BooleanValue(Raylib.ExportDataAsCode(
                bytes, 
                (uint)size.Value, 
                Utils.StringToSBytePtr(fileName.Value)
            )));
        }
        public unsafe static RuntimeResult LoadFileText(Context ctx, 
            StringValue fileName)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi((IntPtr)
                    Raylib.LoadFileText(
                        Utils.StringToSBytePtr(fileName.Value)
                    )
                )
            ));
        }
        public unsafe static RuntimeResult UnloadFileText(Context ctx, 
            StringValue text)
        {
            Raylib.UnloadFileText(Utils.StringToSBytePtr(text.Value));
            return RuntimeResult.Null();
        }
        public unsafe static RuntimeResult SaveFileText(Context ctx, 
            StringValue fileName, StringValue text)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.SaveFileText(
                    Utils.StringToSBytePtr(fileName.Value), 
                    Utils.StringToSBytePtr(text.Value)
                ))
            );
        }
        public unsafe static RuntimeResult FileExists(Context ctx, 
            StringValue fileName)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.FileExists(
                    Utils.StringToSBytePtr(fileName.Value)
                )
            ));
        }
        public unsafe static RuntimeResult DirectoryExists(Context ctx,
            StringValue dirPath)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.DirectoryExists(
                    Utils.StringToSBytePtr(dirPath.Value)
                )
            ));
        }
        public static RuntimeResult IsFileExtension(Context ctx,
            StringValue fileName, StringValue ext)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.IsFileExtension(
                    fileName.Value, 
                    ext.Value
                )
            ));
        }
        public unsafe static RuntimeResult GetFileLength(Context ctx, 
            StringValue fileName)
        {
            return new RuntimeResult().Success(new NumberValue(
                Raylib.GetFileLength(
                    Utils.StringToSBytePtr(fileName.Value)
                )
            ));
        }
        public unsafe static RuntimeResult GetFileExtension(Context ctx,
            StringValue fileName)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetFileExtension(
                        Utils.StringToSBytePtr(fileName.Value)
                    )
                )
            ));
        }
        public unsafe static RuntimeResult GetFileName(Context ctx, 
            StringValue filePath)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetFileName(
                        Utils.StringToSBytePtr(filePath.Value)
                    )
                )
            ));
        }
        public unsafe static RuntimeResult GetFileNameWithoutExt(Context ctx, 
            StringValue filePath)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetFileNameWithoutExt(
                        Utils.StringToSBytePtr(filePath.Value)
                    )
                )
            ));
        }
        public unsafe static RuntimeResult GetDirectoryPath(Context ctx,
            StringValue filePath)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetDirectoryPath(
                        Utils.StringToSBytePtr(filePath.Value)
                    )
                )
            ));
        }
        public unsafe static RuntimeResult GetPrevDirectoryPath(Context ctx,
            StringValue dirPath)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetPrevDirectoryPath(
                        Utils.StringToSBytePtr(dirPath.Value)
                    )
                )
            ));
        }
        public unsafe static RuntimeResult GetWorkingDirectory(Context ctx)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetWorkingDirectory()
                )
            ));
        }
        public unsafe static RuntimeResult GetApplicationDirectory(Context ctx)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetApplicationDirectory()
                )
            ));
        }
        public unsafe static RuntimeResult ChangeDirectory(Context ctx, 
            StringValue dir)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.ChangeDirectory(
                    Utils.StringToSBytePtr(dir.Value)
                )
            ));
        }
        public unsafe static RuntimeResult IsPathFile(Context ctx,
            StringValue path)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.IsPathFile(
                    Utils.StringToSBytePtr(path.Value)
                )
            ));
        }
        // FilePathList LoadDirectoryFiles(string dirPath);

        // FilePathList LoadDirectoryFilesEx(string basePath, string filter, bool scanSubdirs);

        // void UnloadDirectoryFiles(FilePathList files);

        public static RuntimeResult IsFileDropped(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsFileDropped()));
        }
        // FilePathList LoadDroppedFiles(void);

        // void UnloadDroppedFiles(FilePathList files);

        public static RuntimeResult GetFileModTime(Context ctx,
            StringValue fileName)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetFileModTime(fileName.Value)));
        }
        // string CompressData(string data, int dataSize, int *compDataSize);

        // string DecompressData(string compData, int compDataSize, int *dataSize);

        // string EncodeDataBase64(string data, int dataSize, int *outputSize);

        // string DecodeDataBase64(string data, int *outputSize);

        public static RuntimeResult IsKeyPressed(Context ctx, 
            NumberValue key)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsKeyPressed((KeyboardKey)key.Value)));
        }
        public static RuntimeResult IsKeyDown(Context ctx,
            NumberValue key)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsKeyDown((KeyboardKey)key.Value)));
        }
        public static RuntimeResult IsKeyReleased(Context ctx, 
            NumberValue key)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsKeyReleased((KeyboardKey)key.Value)));
        }
        public static RuntimeResult IsKeyUp(Context ctx,
            NumberValue key)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsKeyUp((KeyboardKey)key.Value)));
        }
        public static RuntimeResult SetExitKey(Context ctx, 
            NumberValue key)
        {
            Raylib.SetExitKey((KeyboardKey)key.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult GetKeyPressed(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetKeyPressed()));
        }
        public static RuntimeResult GetCharPressed(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetCharPressed()));
        }
        public static RuntimeResult IsGamepadAvailable(Context ctx, 
            NumberValue gamepad)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsGamepadAvailable((int)gamepad.Value)));
        }
        public unsafe static RuntimeResult GetGamepadName(Context ctx,
            NumberValue gamepad)
        {
            return new RuntimeResult().Success(new StringValue(Marshal.PtrToStringAnsi((IntPtr)Raylib.GetGamepadName((int)gamepad.Value))));
        }
        public static RuntimeResult IsGamepadButtonPressed(Context ctx, 
            NumberValue gamepad, NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.IsGamepadButtonPressed(
                    (int)gamepad.Value, 
                    (GamepadButton)button.Value
                )
            ));
        }
        public static RuntimeResult IsGamepadButtonDown(Context ctx,
            NumberValue gamepad, NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.IsGamepadButtonDown(
                    (int)gamepad.Value, 
                    (GamepadButton)button.Value
                )
            ));
        }
        public static RuntimeResult IsGamepadButtonReleased(Context ctx,
            NumberValue gamepad, NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.IsGamepadButtonReleased(
                    (int)gamepad.Value, 
                    (GamepadButton)button.Value
                )
            ));
        }
        public static RuntimeResult IsGamepadButtonUp(Context ctx, 
            NumberValue gamepad, NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.IsGamepadButtonUp(
                    (int)gamepad.Value, 
                    (GamepadButton)button.Value
                )
            ));
        }
        public static RuntimeResult GetGamepadButtonPressed(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetGamepadButtonPressed()));
        }
        public static RuntimeResult GetGamepadAxisCount(Context ctx, 
            NumberValue gamepad)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetGamepadAxisCount((int)gamepad.Value)));
        }
        public static RuntimeResult GetGamepadAxisMovement(Context ctx, 
            NumberValue gamepad, NumberValue axis)
        {
            return new RuntimeResult().Success(new NumberValue(
                Raylib.GetGamepadAxisMovement(
                    (int)gamepad.Value, 
                    (GamepadAxis)axis.Value
                )
            ));
        }
        public static RuntimeResult SetGamepadMappings(Context ctx, 
            StringValue mappings)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.SetGamepadMappings(mappings.Value)));
        }
        public static RuntimeResult IsMouseButtonPressed(Context ctx, 
            NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsMouseButtonPressed((MouseButton)button.Value)));
        }
        public static RuntimeResult IsMouseButtonDown(Context ctx, 
            NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsMouseButtonDown((MouseButton)button.Value)));
        }
        public static RuntimeResult IsMouseButtonReleased(Context ctx,
            NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsMouseButtonReleased((MouseButton)button.Value)));
        }
        public static RuntimeResult IsMouseButtonUp(Context ctx, 
            NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsMouseButtonUp((MouseButton)button.Value)));
        }
        public static RuntimeResult GetMouseX(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMouseX()));
        }
        public static RuntimeResult GetMouseY(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMouseY()));
        }
        public static RuntimeResult GetMousePosition(Context ctx)
        {
            System.Numerics.Vector2 vector = Raylib.GetMousePosition();
            return new RuntimeResult().Success(new Vector2(
                new NumberValue(vector.X),
                new NumberValue(vector.Y) 
            ));
        }
        public static RuntimeResult GetMouseDelta(Context ctx)
        {
            System.Numerics.Vector2 vector = Raylib.GetMouseDelta();
            return new RuntimeResult().Success(new Vector2(
                new NumberValue(vector.X), 
                new NumberValue(vector.Y) 
            ));
        }
        public static RuntimeResult SetMousePosition(Context ctx, 
            NumberValue x, NumberValue y)
        {
            Raylib.SetMousePosition((int)x.Value, (int)y.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult SetMouseOffset(Context ctx, 
            NumberValue offsetX, NumberValue offsetY)
        {
            Raylib.SetMouseOffset((int)offsetX.Value, (int)offsetY.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult SetMouseScale(Context ctx,
            NumberValue scaleX, NumberValue scaleY)
        {
            Raylib.SetMouseScale((float)scaleX.Value, (float)scaleY.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult GetMouseWheelMove(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMouseWheelMove()));
        }
        public static RuntimeResult GetMouseWheelMoveV(Context ctx)
        {
            System.Numerics.Vector2 vector = Raylib.GetMouseWheelMoveV();
            return new RuntimeResult().Success(new Vector2(
                new NumberValue(vector.X), 
                new NumberValue(vector.Y) 
            ));
        }
        public static RuntimeResult SetMouseCursor(Context ctx,
            NumberValue cursor)
        {
            Raylib.SetMouseCursor((MouseCursor)cursor.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult GetTouchX(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetTouchX()));
        }
        public static RuntimeResult GetTouchY(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetTouchY()));
        }
        public static RuntimeResult GetTouchPosition(Context ctx, 
            NumberValue index)
        {
            System.Numerics.Vector2 vector = Raylib.GetTouchPosition((int)index.Value);
            return new RuntimeResult().Success(new Vector2(
                new NumberValue(vector.X), 
                new NumberValue(vector.Y) 
            ));
        }
        public static RuntimeResult GetTouchPointId(Context ctx,
            NumberValue index)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetTouchPointId((int)index.Value)));
        }
        public static RuntimeResult GetTouchPointCount(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetTouchPointCount()));
        }
        public static RuntimeResult SetGesturesEnabled(Context ctx,
            NumberValue flags)
        {
            Raylib.SetGesturesEnabled((Gesture)flags.Value);
            return RuntimeResult.Null();
        }
        public static RuntimeResult IsGestureDetected(Context ctx,
            NumberValue gesture)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsGestureDetected((Gesture)gesture.Value)));
        }
        public static RuntimeResult GetGestureDetected(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue((double)Raylib.GetGestureDetected()));
        }
        public static RuntimeResult GetGestureHoldDuration(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetGestureHoldDuration()));
        }
        public static RuntimeResult GetGestureDragVector(Context ctx)
        {
            System.Numerics.Vector2 vector = Raylib.GetGestureDragVector();
            return new RuntimeResult().Success(new Vector2(
                new NumberValue(vector.X),
                new NumberValue(vector.Y) 
            ));
        }
        public static RuntimeResult GetGestureDragAngle(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetGestureDragAngle()));
        }
        public static RuntimeResult GetGesturePinchVector(Context ctx)
        {
            System.Numerics.Vector2 vector = Raylib.GetGesturePinchVector();
            return new RuntimeResult().Success(new Vector2(
                new NumberValue(vector.X), 
                new NumberValue(vector.Y) 
            ));
        }
        public static RuntimeResult GetGesturePinchAngle(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetGesturePinchAngle()));
        }
        // void UpdateCamera(Camera *camera, int mode);

        // void UpdateCameraPro(Camera *camera, Vector3 movement, Vector3 rotation, float zoom);

    }
}
