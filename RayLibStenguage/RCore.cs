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
        public static RuntimeResult InitWindow(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue width, NumberValue height, StringValue title)
        {
            Raylib.InitWindow(
                (int)width.Value, 
                (int)height.Value, 
                title.Value
            );

            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult WindowShouldClose(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.WindowShouldClose(), scope.SourceCode, start, end));
        }
        public static RuntimeResult CloseWindow(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.CloseWindow();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult IsWindowReady(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowReady(), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsWindowFullscreen(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowFullscreen(), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsWindowHidden(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowHidden(), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsWindowMinimized(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowMinimized(), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsWindowMaximized(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowMaximized(), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsWindowFocused(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowFocused(), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsWindowResized(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowResized(), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsWindowState(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue flag)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsWindowState((ConfigFlags)flag.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult SetWindowState(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue flags)
        {
            Raylib.SetWindowState((ConfigFlags)flags.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult ClearWindowState(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue flags)
        {
            Raylib.ClearWindowState((ConfigFlags)flags.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult ToggleFullscreen(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.ToggleFullscreen();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult MaximizeWindow(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.MaximizeWindow();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult MinimizeWindow(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.MinimizeWindow();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult RestoreWindow(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.RestoreWindow();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult SetWindowIcon(Stenguage.Runtime.Environment scope, Position start, Position end, Image image)
        {
            Raylib.SetWindowIcon(image.Source);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public unsafe static RuntimeResult SetWindowIcons(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue images)
        {
            fixed (Raylib_cs.Image* imgs = images.Items.Cast<Image>().Select(img => img.Source).ToArray())
            {
                Raylib.SetWindowIcons(imgs, images.Items.Count);
            }

            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult SetWindowTitle(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue title)
        {
            Raylib.SetWindowTitle(title.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult SetWindowPosition(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue x, NumberValue y)
        {
            Raylib.SetWindowPosition(
                (int)x.Value, 
                (int)y.Value
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult SetWindowMonitor(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue monitor)
        {
            Raylib.SetWindowMonitor((int)monitor.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult SetWindowMinSize(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height)
        {
            Raylib.SetWindowMinSize(
                (int)width.Value, 
                (int)height.Value
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult SetWindowSize(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue width, NumberValue height)
        {
            Raylib.SetWindowSize(
                (int)width.Value, 
                (int)height.Value
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult SetWindowOpacity(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue opacity)
        {
            Raylib.SetWindowOpacity((float)opacity.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public unsafe static RuntimeResult GetWindowHandle(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(((IntPtr)Raylib.GetWindowHandle()).ToInt64(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetScreenWidth(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetScreenWidth(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetScreenHeight(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetScreenHeight(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetRenderWidth(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetRenderWidth(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetRenderHeight(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetRenderHeight(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetMonitorCount(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMonitorCount(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetCurrentMonitor(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetCurrentMonitor(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetMonitorPosition(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue monitor)
        {
            System.Numerics.Vector2 vector = Raylib.GetMonitorPosition((int)monitor.Value);
            return new RuntimeResult().Success(new Vector2(scope.SourceCode, start, end,
                new NumberValue(vector.X, scope.SourceCode, start, end), 
                new NumberValue(vector.Y, scope.SourceCode, start, end) 
            ));
        }
        public static RuntimeResult GetMonitorWidth(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMonitorWidth((int)monitor.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetMonitorHeight(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMonitorHeight((int)monitor.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetMonitorPhysicalWidth(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMonitorPhysicalWidth((int)monitor.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetMonitorPhysicalHeight(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMonitorPhysicalHeight((int)monitor.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetMonitorRefreshRate(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMonitorRefreshRate((int)monitor.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetWindowPosition(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            System.Numerics.Vector2 vector = Raylib.GetWindowPosition();
            return new RuntimeResult().Success(new Vector2(scope.SourceCode, start, end,
                new NumberValue(vector.X, scope.SourceCode, start, end), 
                new NumberValue(vector.Y, scope.SourceCode, start, end)
            ));
        }
        public static RuntimeResult GetWindowScaleDPI(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            System.Numerics.Vector2 vector = Raylib.GetWindowScaleDPI();
            return new RuntimeResult().Success(new Vector2(scope.SourceCode, start, end,
                new NumberValue(vector.X, scope.SourceCode, start, end), 
                new NumberValue(vector.Y, scope.SourceCode, start, end) 
            ));
        }
        public unsafe static RuntimeResult GetMonitorName(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetMonitorName((int)monitor.Value)
                ),
            scope.SourceCode, start, end));
        }
        public static RuntimeResult SetClipboardText(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue text)
        {
            Raylib.SetClipboardText(text.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public unsafe static RuntimeResult GetClipboardText(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetClipboardText()
                ), 
            scope.SourceCode, start, end));
        }
        public static RuntimeResult EnableEventWaiting(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.EnableEventWaiting();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DisableEventWaiting(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.DisableEventWaiting();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult SwapScreenBuffer(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.SwapScreenBuffer();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult PollInputEvents(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.PollInputEvents();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult WaitTime(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue seconds)
        {
            Raylib.WaitTime(seconds.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult ShowCursor(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.ShowCursor();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult HideCursor(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.HideCursor();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult IsCursorHidden(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsCursorHidden(), scope.SourceCode, start, end));
        }
        public static RuntimeResult EnableCursor(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.EnableCursor();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DisableCursor(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.DisableCursor();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult IsCursorOnScreen(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsCursorOnScreen(), scope.SourceCode, start, end));
        }
        public static RuntimeResult ClearBackground(Stenguage.Runtime.Environment scope, Position start, Position end, 
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
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult BeginDrawing(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.BeginDrawing();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult EndDrawing(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.EndDrawing();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        // void BeginMode2D(Camera2D camera);

        public static RuntimeResult EndMode2D(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.EndMode2D();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        // void BeginMode3D(Camera3D camera);

        public static RuntimeResult EndMode3D(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.EndMode3D();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        // void BeginTextureMode(RenderTexture2D target);

        public static RuntimeResult EndTextureMode(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.EndTextureMode();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        // void BeginShaderMode(Shader shader);

        public static RuntimeResult EndShaderMode(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.EndShaderMode();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult BeginBlendMode(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue mode)
        {
            Raylib.BeginBlendMode((BlendMode)mode.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult EndBlendMode(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.EndBlendMode();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult BeginScissorMode(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue x, NumberValue y, NumberValue width, NumberValue height)
        {
            Raylib.BeginScissorMode(
                (int)x.Value, 
                (int)y.Value,
                (int)width.Value, 
                (int)height.Value
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult EndScissorMode(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.EndScissorMode();
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        // void BeginVrStereoMode(VrStereoConfig config);

        public static RuntimeResult EndVrStereoMode(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib.EndVrStereoMode();
            return RuntimeResult.Null(scope.SourceCode, start, end);
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

        public static RuntimeResult SetTargetFPS(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue fps)
        {
            Raylib.SetTargetFPS((int)fps.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult GetFPS(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetFPS(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetFrameTime(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetFrameTime(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetTime(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetTime(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetRandomValue(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue min, NumberValue max)
        {
            return new RuntimeResult().Success(new NumberValue(
                Raylib.GetRandomValue(
                    (int)min.Value, 
                    (int)max.Value
                ), 
            scope.SourceCode, start, end));
        }
        public static RuntimeResult SetRandomSeed(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue seed)
        {
            Raylib.SetRandomSeed((uint)seed.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult TakeScreenshot(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue fileName)
        {
            Raylib.TakeScreenshot(fileName.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult SetConfigFlags(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue flags)
        {
            Raylib.SetConfigFlags((ConfigFlags)flags.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public unsafe static RuntimeResult TraceLog(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue logLevel, StringValue text)
        {
            Raylib.TraceLog(
                (TraceLogLevel)logLevel.Value, 
                Utils.StringToSBytePtr(text.Value)
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult SetTraceLogLevel(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue logLevel)
        {
            Raylib.SetTraceLogLevel((TraceLogLevel)logLevel.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        // void *MemAlloc(int size);

        // void *MemRealloc(void *ptr, int size);

        // void MemFree(void *ptr);

        public static RuntimeResult OpenURL(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue url)
        {
            Raylib.OpenURL(url.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        // void SetTraceLogCallback(TraceLogCallback callback);

        // void SetLoadFileDataCallback(LoadFileDataCallback callback);

        // void SetSaveFileDataCallback(SaveFileDataCallback callback);

        // void SetLoadFileTextCallback(LoadFileTextCallback callback);

        // void SetSaveFileTextCallback(SaveFileTextCallback callback);

        public unsafe static RuntimeResult LoadFileData(Stenguage.Runtime.Environment scope, Position start, Position end, 
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
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public unsafe static RuntimeResult UnloadFileData(Stenguage.Runtime.Environment scope, Position start, Position end, 
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
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }

        #region Save File Data
        public unsafe static RuntimeResult SaveFileData(Stenguage.Runtime.Environment scope, Position start, Position end, 
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
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public unsafe static RuntimeResult SaveFileData(Stenguage.Runtime.Environment scope, Position start, Position end, 
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
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public unsafe static RuntimeResult SaveFileData(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue fileName, StringValue data, NumberValue bytesToWrite)
        {
            byte* bytes = stackalloc byte[data.Value.Length];
            for (int i = 0; i < data.Value.Length; i++)
            {
                bytes[i] = (byte)data.Value[i];
            }

            Raylib.SaveFileData(Utils.StringToSBytePtr(fileName.Value), bytes, (uint)bytesToWrite.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public unsafe static RuntimeResult SaveFileData(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue fileName, StringValue data)
        {
            byte* bytes = stackalloc byte[data.Value.Length];
            for (int i = 0; i < data.Value.Length; i++)
            {
                bytes[i] = (byte)data.Value[i];
            }

            Raylib.SaveFileData(Utils.StringToSBytePtr(fileName.Value), bytes, (uint)data.Value.Length);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        #endregion

        public unsafe static RuntimeResult ExportDataAsCode(Stenguage.Runtime.Environment scope, Position start, Position end,
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
            ), scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult LoadFileText(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue fileName)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi((IntPtr)
                    Raylib.LoadFileText(
                        Utils.StringToSBytePtr(fileName.Value)
                    )
                ),
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult UnloadFileText(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue text)
        {
            Raylib.UnloadFileText(Utils.StringToSBytePtr(text.Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public unsafe static RuntimeResult SaveFileText(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue fileName, StringValue text)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.SaveFileText(
                    Utils.StringToSBytePtr(fileName.Value), 
                    Utils.StringToSBytePtr(text.Value)
                ), scope.SourceCode, start, end)
            );
        }
        public unsafe static RuntimeResult FileExists(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue fileName)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.FileExists(
                    Utils.StringToSBytePtr(fileName.Value)
                ), 
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult DirectoryExists(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue dirPath)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.DirectoryExists(
                    Utils.StringToSBytePtr(dirPath.Value)
                ),
            scope.SourceCode, start, end));
        }
        public static RuntimeResult IsFileExtension(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue fileName, StringValue ext)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.IsFileExtension(
                    fileName.Value, 
                    ext.Value
                ), 
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult GetFileLength(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue fileName)
        {
            return new RuntimeResult().Success(new NumberValue(
                Raylib.GetFileLength(
                    Utils.StringToSBytePtr(fileName.Value)
                ), 
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult GetFileExtension(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue fileName)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetFileExtension(
                        Utils.StringToSBytePtr(fileName.Value)
                    )
                ), 
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult GetFileName(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue filePath)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetFileName(
                        Utils.StringToSBytePtr(filePath.Value)
                    )
                ),
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult GetFileNameWithoutExt(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue filePath)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetFileNameWithoutExt(
                        Utils.StringToSBytePtr(filePath.Value)
                    )
                ),
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult GetDirectoryPath(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue filePath)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetDirectoryPath(
                        Utils.StringToSBytePtr(filePath.Value)
                    )
                ),
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult GetPrevDirectoryPath(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue dirPath)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetPrevDirectoryPath(
                        Utils.StringToSBytePtr(dirPath.Value)
                    )
                ),
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult GetWorkingDirectory(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetWorkingDirectory()
                ),
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult GetApplicationDirectory(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.GetApplicationDirectory()
                ),
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult ChangeDirectory(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue dir)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.ChangeDirectory(
                    Utils.StringToSBytePtr(dir.Value)
                ),
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult IsPathFile(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue path)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.IsPathFile(
                    Utils.StringToSBytePtr(path.Value)
                ),
            scope.SourceCode, start, end));
        }
        // FilePathList LoadDirectoryFiles(string dirPath);

        // FilePathList LoadDirectoryFilesEx(string basePath, string filter, bool scanSubdirs);

        // void UnloadDirectoryFiles(FilePathList files);

        public static RuntimeResult IsFileDropped(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsFileDropped(), scope.SourceCode, start, end));
        }
        // FilePathList LoadDroppedFiles(void);

        // void UnloadDroppedFiles(FilePathList files);

        public static RuntimeResult GetFileModTime(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue fileName)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetFileModTime(fileName.Value), scope.SourceCode, start, end));
        }
        // string CompressData(string data, int dataSize, int *compDataSize);

        // string DecompressData(string compData, int compDataSize, int *dataSize);

        // string EncodeDataBase64(string data, int dataSize, int *outputSize);

        // string DecodeDataBase64(string data, int *outputSize);

        public static RuntimeResult IsKeyPressed(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue key)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsKeyPressed((KeyboardKey)key.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsKeyDown(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue key)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsKeyDown((KeyboardKey)key.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsKeyReleased(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue key)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsKeyReleased((KeyboardKey)key.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsKeyUp(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue key)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsKeyUp((KeyboardKey)key.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult SetExitKey(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue key)
        {
            Raylib.SetExitKey((KeyboardKey)key.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult GetKeyPressed(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetKeyPressed(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetCharPressed(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetCharPressed(), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsGamepadAvailable(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue gamepad)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsGamepadAvailable((int)gamepad.Value), scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult GetGamepadName(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue gamepad)
        {
            return new RuntimeResult().Success(new StringValue(Marshal.PtrToStringAnsi((IntPtr)Raylib.GetGamepadName((int)gamepad.Value)), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsGamepadButtonPressed(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue gamepad, NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.IsGamepadButtonPressed(
                    (int)gamepad.Value, 
                    (GamepadButton)button.Value
                ),
            scope.SourceCode, start, end));
        }
        public static RuntimeResult IsGamepadButtonDown(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue gamepad, NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.IsGamepadButtonDown(
                    (int)gamepad.Value, 
                    (GamepadButton)button.Value
                ), 
            scope.SourceCode, start, end));
        }
        public static RuntimeResult IsGamepadButtonReleased(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue gamepad, NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.IsGamepadButtonReleased(
                    (int)gamepad.Value, 
                    (GamepadButton)button.Value
                ),
            scope.SourceCode, start, end));
        }
        public static RuntimeResult IsGamepadButtonUp(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue gamepad, NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.IsGamepadButtonUp(
                    (int)gamepad.Value, 
                    (GamepadButton)button.Value
                ),
            scope.SourceCode, start, end));
        }
        public static RuntimeResult GetGamepadButtonPressed(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetGamepadButtonPressed(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetGamepadAxisCount(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue gamepad)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetGamepadAxisCount((int)gamepad.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetGamepadAxisMovement(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue gamepad, NumberValue axis)
        {
            return new RuntimeResult().Success(new NumberValue(
                Raylib.GetGamepadAxisMovement(
                    (int)gamepad.Value, 
                    (GamepadAxis)axis.Value
                ),
            scope.SourceCode, start, end));
        }
        public static RuntimeResult SetGamepadMappings(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue mappings)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.SetGamepadMappings(mappings.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsMouseButtonPressed(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsMouseButtonPressed((MouseButton)button.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsMouseButtonDown(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsMouseButtonDown((MouseButton)button.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsMouseButtonReleased(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsMouseButtonReleased((MouseButton)button.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult IsMouseButtonUp(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsMouseButtonUp((MouseButton)button.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetMouseX(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMouseX(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetMouseY(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMouseY(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetMousePosition(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            System.Numerics.Vector2 vector = Raylib.GetMousePosition();
            return new RuntimeResult().Success(new Vector2(scope.SourceCode, start, end,
                new NumberValue(vector.X, scope.SourceCode, start, end),
                new NumberValue(vector.Y, scope.SourceCode, start, end) 
            ));
        }
        public static RuntimeResult GetMouseDelta(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            System.Numerics.Vector2 vector = Raylib.GetMouseDelta();
            return new RuntimeResult().Success(new Vector2(scope.SourceCode, start, end,
                new NumberValue(vector.X, scope.SourceCode, start, end), 
                new NumberValue(vector.Y, scope.SourceCode, start, end) 
            ));
        }
        public static RuntimeResult SetMousePosition(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue x, NumberValue y)
        {
            Raylib.SetMousePosition((int)x.Value, (int)y.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult SetMouseOffset(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue offsetX, NumberValue offsetY)
        {
            Raylib.SetMouseOffset((int)offsetX.Value, (int)offsetY.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult SetMouseScale(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue scaleX, NumberValue scaleY)
        {
            Raylib.SetMouseScale((float)scaleX.Value, (float)scaleY.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult GetMouseWheelMove(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetMouseWheelMove(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetMouseWheelMoveV(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            System.Numerics.Vector2 vector = Raylib.GetMouseWheelMoveV();
            return new RuntimeResult().Success(new Vector2(scope.SourceCode, start, end,
                new NumberValue(vector.X, scope.SourceCode, start, end), 
                new NumberValue(vector.Y, scope.SourceCode, start, end) 
            ));
        }
        public static RuntimeResult SetMouseCursor(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue cursor)
        {
            Raylib.SetMouseCursor((MouseCursor)cursor.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult GetTouchX(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetTouchX(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetTouchY(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetTouchY(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetTouchPosition(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue index)
        {
            System.Numerics.Vector2 vector = Raylib.GetTouchPosition((int)index.Value);
            return new RuntimeResult().Success(new Vector2(scope.SourceCode, start, end,
                new NumberValue(vector.X, scope.SourceCode, start, end), 
                new NumberValue(vector.Y, scope.SourceCode, start, end) 
            ));
        }
        public static RuntimeResult GetTouchPointId(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue index)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetTouchPointId((int)index.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetTouchPointCount(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetTouchPointCount(), scope.SourceCode, start, end));
        }
        public static RuntimeResult SetGesturesEnabled(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue flags)
        {
            Raylib.SetGesturesEnabled((Gesture)flags.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult IsGestureDetected(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue gesture)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsGestureDetected((Gesture)gesture.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetGestureDetected(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue((double)Raylib.GetGestureDetected(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetGestureHoldDuration(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetGestureHoldDuration(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetGestureDragVector(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            System.Numerics.Vector2 vector = Raylib.GetGestureDragVector();
            return new RuntimeResult().Success(new Vector2(scope.SourceCode, start, end,
                new NumberValue(vector.X, scope.SourceCode, start, end),
                new NumberValue(vector.Y, scope.SourceCode, start, end) 
            ));
        }
        public static RuntimeResult GetGestureDragAngle(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetGestureDragAngle(), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetGesturePinchVector(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            System.Numerics.Vector2 vector = Raylib.GetGesturePinchVector();
            return new RuntimeResult().Success(new Vector2(scope.SourceCode, start, end,
                new NumberValue(vector.X, scope.SourceCode, start, end), 
                new NumberValue(vector.Y, scope.SourceCode, start, end) 
            ));
        }
        public static RuntimeResult GetGesturePinchAngle(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetGesturePinchAngle(), scope.SourceCode, start, end));
        }
        // void UpdateCamera(Camera *camera, int mode);

        // void UpdateCameraPro(Camera *camera, Vector3 movement, Vector3 rotation, float zoom);

    }
}
