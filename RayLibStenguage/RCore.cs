using Stenguage.Runtime.Values;
using Stenguage.Runtime;
using RayLibStenguage.Classes;
using System.Runtime.InteropServices;
using System;

namespace RayLibStenguage
{
    public class RCore
    {
        //  Window-related functions 

        // void InitWindow(int width, int height, string title);  // Initialize window and OpenGL context 
        public static RuntimeResult InitWindow(Context ctx,
            NumberValue width, NumberValue height, StringValue title)
        {
            Imports.InitWindow((int)width.Value, (int)height.Value, title.Value);
            return RuntimeResult.Null();
        }

        // bool WindowShouldClose(void);                               // Check if KEY_ESCAPE pressed or Close icon pressed 
        public static RuntimeResult WindowShouldClose(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.WindowShouldClose()));
        }

        // void CloseWindow(void);                                     // Close window and unload OpenGL context 
        public static RuntimeResult CloseWindow(Context ctx)
        {
            Imports.CloseWindow();
            return RuntimeResult.Null();
        }

        // bool IsWindowReady(void);                                   // Check if window has been initialized successfully 
        public static RuntimeResult IsWindowReady(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsWindowReady()));
        }

        // bool IsWindowFullscreen(void);                              // Check if window is currently fullscreen 
        public static RuntimeResult IsWindowFullscreen(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsWindowFullscreen()));
        }

        // bool IsWindowHidden(void);                                  // Check if window is currently hidden (only PLATFORM_DESKTOP) 
        public static RuntimeResult IsWindowHidden(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsWindowHidden()));
        }

        // bool IsWindowMinimized(void);                               // Check if window is currently minimized (only PLATFORM_DESKTOP) 
        public static RuntimeResult IsWindowMinimized(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsWindowMinimized()));
        }

        // bool IsWindowMaximized(void);                               // Check if window is currently maximized (only PLATFORM_DESKTOP) 
        public static RuntimeResult IsWindowMaximized(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsWindowMaximized()));
        }

        // bool IsWindowFocused(void);                                 // Check if window is currently focused (only PLATFORM_DESKTOP) 
        public static RuntimeResult IsWindowFocused(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsWindowFocused()));
        }

        // bool IsWindowResized(void);                                 // Check if window has been resized last frame 
        public static RuntimeResult IsWindowResized(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsWindowResized()));
        }

        // bool IsWindowState(uint flag);                      // Check if one specific window flag is enabled 
        public static RuntimeResult IsWindowState(Context ctx,
            uint flag)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsWindowState(flag)));
        }

        // void SetWindowState(uint flags);                    // Set window configuration state using flags (only PLATFORM_DESKTOP) 
        public static RuntimeResult SetWindowState(Context ctx,
            uint flags)
        {
            Imports.SetWindowState(flags);
            return RuntimeResult.Null();
        }

        // void ClearWindowState(uint flags);                  // Clear window configuration state flags 
        public static RuntimeResult ClearWindowState(Context ctx,
            uint flags)
        {
            Imports.ClearWindowState(flags);
            return RuntimeResult.Null();
        }

        // void ToggleFullscreen(void);                                // Toggle window state: fullscreen/windowed (only PLATFORM_DESKTOP) 
        public static RuntimeResult ToggleFullscreen(Context ctx)
        {
            Imports.ToggleFullscreen();
            return RuntimeResult.Null();
        }

        // void MaximizeWindow(void);                                  // Set window state: maximized, if resizable (only PLATFORM_DESKTOP) 
        public static RuntimeResult MaximizeWindow(Context ctx)
        {
            Imports.MaximizeWindow();
            return RuntimeResult.Null();
        }

        // void MinimizeWindow(void);                                  // Set window state: minimized, if resizable (only PLATFORM_DESKTOP) 
        public static RuntimeResult MinimizeWindow(Context ctx)
        {
            Imports.MinimizeWindow();
            return RuntimeResult.Null();
        }

        // void RestoreWindow(void);                                   // Set window state: not minimized/maximized (only PLATFORM_DESKTOP) 
        public static RuntimeResult RestoreWindow(Context ctx)
        {
            Imports.RestoreWindow();
            return RuntimeResult.Null();
        }

        // void SetWindowIcon(Image image);                            // Set icon for window (single image, RGBA 32bit, only PLATFORM_DESKTOP) 
        public static RuntimeResult SetWindowIcon(Context ctx,
            Image image)
        {
            Imports.SetWindowIcon(image.Source);
            return RuntimeResult.Null();
        }

        // void SetWindowIcons(Image[] images, int count);              // Set icon for window (multiple images, RGBA 32bit, only PLATFORM_DESKTOP) 
        public static RuntimeResult SetWindowIcons(Context ctx,
            ListValue images, NumberValue count)
        {
            Imports.SetWindowIcons(
                images.Items
                    .Where(x => x.GetType() == typeof(Image))
                    .Select(x => ((Image)x).Source)
                    .ToArray(), 
                (int)count.Value
            );
            return RuntimeResult.Null();
        }

        // void SetWindowTitle(string title);                     // Set title for window (only PLATFORM_DESKTOP) 
        public static RuntimeResult SetWindowTitle(Context ctx,
            StringValue title)
        {
            Imports.SetWindowTitle(title.Value);
            return RuntimeResult.Null();
        }

        // void SetWindowPosition(int x, int y);                       // Set window position on screen (only PLATFORM_DESKTOP) 
        public static RuntimeResult SetWindowPosition(Context ctx,
            NumberValue x, NumberValue y)
        {
            Imports.SetWindowPosition((int)x.Value, (int)y.Value);
            return RuntimeResult.Null();
        }

        // void SetWindowMonitor(int monitor);                         // Set monitor for the current window (fullscreen mode) 
        public static RuntimeResult SetWindowMonitor(Context ctx,
            NumberValue monitor)
        {
            Imports.SetWindowMonitor((int)monitor.Value);
            return RuntimeResult.Null();
        }

        // void SetWindowMinSize(int width, int height);               // Set window minimum dimensions (for FLAG_WINDOW_RESIZABLE) 
        public static RuntimeResult SetWindowMinSize(Context ctx,
            NumberValue width, NumberValue height)
        {
            Imports.SetWindowMinSize((int)width.Value, (int)height.Value);
            return RuntimeResult.Null();
        }

        // void SetWindowSize(int width, int height);                  // Set window dimensions 
        public static RuntimeResult SetWindowSize(Context ctx,
            NumberValue width, NumberValue height)
        {
            Imports.SetWindowSize((int)width.Value, (int)height.Value);
            return RuntimeResult.Null();
        }

        // void SetWindowOpacity(float opacity);                       // Set window opacity [0.0f..1.0f] (only PLATFORM_DESKTOP) 
        public static RuntimeResult SetWindowOpacity(Context ctx,
            NumberValue opacity)
        {
            Imports.SetWindowOpacity((float)opacity.Value);
            return RuntimeResult.Null();
        }

        // void *GetWindowHandle(void);                                // Get native window handle 
        public static RuntimeResult GetWindowHandle(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue((double)Imports.GetWindowHandle()));
        }

        // int GetScreenWidth(void);                                   // Get current screen width 
        public static RuntimeResult GetScreenWidth(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetScreenWidth()));
        }

        // int GetScreenHeight(void);                                  // Get current screen height 
        public static RuntimeResult GetScreenHeight(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetScreenHeight()));
        }

        // int GetRenderWidth(void);                                   // Get current render width (it considers HiDPI) 
        public static RuntimeResult GetRenderWidth(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetRenderWidth()));
        }

        // int GetRenderHeight(void);                                  // Get current render height (it considers HiDPI) 
        public static RuntimeResult GetRenderHeight(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetRenderHeight()));
        }

        // int GetMonitorCount(void);                                  // Get number of connected monitors 
        public static RuntimeResult GetMonitorCount(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetMonitorCount()));
        }

        // int GetCurrentMonitor(void);                                // Get current connected monitor 
        public static RuntimeResult GetCurrentMonitor(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetCurrentMonitor()));
        }

        // Vector2 GetMonitorPosition(int monitor);                    // Get specified monitor position 
        public static RuntimeResult GetMonitorPosition(Context ctx,
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetMonitorPosition((int)monitor.Value)));
        }

        // int GetMonitorWidth(int monitor);                           // Get specified monitor width (current video mode used by monitor) 
        public static RuntimeResult GetMonitorWidth(Context ctx,
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetMonitorWidth((int)monitor.Value)));
        }

        // int GetMonitorHeight(int monitor);                          // Get specified monitor height (current video mode used by monitor) 
        public static RuntimeResult GetMonitorHeight(Context ctx,
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetMonitorHeight((int)monitor.Value)));
        }

        // int GetMonitorPhysicalWidth(int monitor);                   // Get specified monitor physical width in millimetres 
        public static RuntimeResult GetMonitorPhysicalWidth(Context ctx,
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetMonitorPhysicalWidth((int)monitor.Value)));
        }

        // int GetMonitorPhysicalHeight(int monitor);                  // Get specified monitor physical height in millimetres 
        public static RuntimeResult GetMonitorPhysicalHeight(Context ctx,
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetMonitorPhysicalHeight((int)monitor.Value)));
        }

        // int GetMonitorRefreshRate(int monitor);                     // Get specified monitor refresh rate 
        public static RuntimeResult GetMonitorRefreshRate(Context ctx,
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetMonitorRefreshRate((int)monitor.Value)));
        }

        // Vector2 GetWindowPosition(void);                            // Get window position XY on monitor 
        public static RuntimeResult GetWindowPosition(Context ctx)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetWindowPosition()));
        }

        // Vector2 GetWindowScaleDPI(void);                            // Get window scale DPI factor 
        public static RuntimeResult GetWindowScaleDPI(Context ctx)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetWindowScaleDPI()));
        }

        // string GetMonitorName(int monitor);                    // Get the human-readable, UTF-8 encoded name of the specified monitor 
        public static RuntimeResult GetMonitorName(Context ctx,
            NumberValue monitor)
        {
            return new RuntimeResult().Success(new StringValue(Imports.GetMonitorName((int)monitor.Value)));
        }

        // void SetClipboardText(string text);                    // Set clipboard text content 
        public static RuntimeResult SetClipboardText(Context ctx,
            StringValue text)
        {
            Imports.SetClipboardText(text.Value);
            return RuntimeResult.Null();
        }

        // string GetClipboardText(void);                         // Get clipboard text content 
        public static RuntimeResult GetClipboardText(Context ctx)
        {
            return new RuntimeResult().Success(new StringValue(Imports.GetClipboardText()));
        }

        // void EnableEventWaiting(void);                              // Enable waiting for events on EndDrawing(), no automatic event polling 
        public static RuntimeResult EnableEventWaiting(Context ctx)
        {
            Imports.EnableEventWaiting();
            return RuntimeResult.Null();
        }

        // void DisableEventWaiting(void);                             // Disable waiting for events on EndDrawing(), automatic events polling 
        public static RuntimeResult DisableEventWaiting(Context ctx)
        {
            Imports.DisableEventWaiting();
            return RuntimeResult.Null();
        }

        //  Custom frame control functions 

        //  NOTE: Those functions are intended for advance users that want full control over the frame processing 

        //  By default EndDrawing() does this job: draws everything + SwapScreenBuffer() + manage frame timing + PollInputEvents() 

        //  To avoid that behaviour and control frame processes manually, enable in config.h: SUPPORT_CUSTOM_FRAME_CONTROL 

        // void SwapScreenBuffer(void);                                // Swap back buffer with front buffer (screen drawing) 
        public static RuntimeResult SwapScreenBuffer(Context ctx)
        {
            Imports.SwapScreenBuffer();
            return RuntimeResult.Null();
        }

        // void PollInputEvents(void);                                 // Register all input events 
        public static RuntimeResult PollInputEvents(Context ctx)
        {
            Imports.PollInputEvents();
            return RuntimeResult.Null();
        }

        // void WaitTime(double seconds);                              // Wait for some time (halt program execution) 
        public static RuntimeResult WaitTime(Context ctx,
            NumberValue seconds)
        {
            Imports.WaitTime(seconds.Value);
            return RuntimeResult.Null();
        }

        //  Cursor-related functions 

        // void ShowCursor(void);                                      // Shows cursor 
        public static RuntimeResult ShowCursor(Context ctx)
        {
            Imports.ShowCursor();
            return RuntimeResult.Null();
        }

        // void HideCursor(void);                                      // Hides cursor 
        public static RuntimeResult HideCursor(Context ctx)
        {
            Imports.HideCursor();
            return RuntimeResult.Null();
        }

        // bool IsCursorHidden(void);                                  // Check if cursor is not visible 
        public static RuntimeResult IsCursorHidden(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsCursorHidden()));
        }

        // void EnableCursor(void);                                    // Enables cursor (unlock cursor) 
        public static RuntimeResult EnableCursor(Context ctx)
        {
            Imports.EnableCursor();
            return RuntimeResult.Null();
        }

        // void DisableCursor(void);                                   // Disables cursor (lock cursor) 
        public static RuntimeResult DisableCursor(Context ctx)
        {
            Imports.DisableCursor();
            return RuntimeResult.Null();
        }

        // bool IsCursorOnScreen(void);                                // Check if cursor is on the screen 
        public static RuntimeResult IsCursorOnScreen(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsCursorOnScreen()));
        }

        //  Drawing-related functions 

        // void ClearBackground(Color color);                          // Set background color (framebuffer clear color) 
        public static RuntimeResult ClearBackground(Context ctx,
            Color color)
        {
            Imports.ClearBackground(color.Struct);
            return RuntimeResult.Null();
        }

        // void BeginDrawing(void);                                    // Setup canvas (framebuffer) to start drawing 
        public static RuntimeResult BeginDrawing(Context ctx)
        {
            Imports.BeginDrawing();
            return RuntimeResult.Null();
        }

        // void EndDrawing(void);                                      // End canvas drawing and swap buffers (double buffering) 
        public static RuntimeResult EndDrawing(Context ctx)
        {
            Imports.EndDrawing();
            return RuntimeResult.Null();
        }

        // void BeginMode2D(Camera2D camera);                          // Begin 2D mode with custom camera (2D) 
        public static RuntimeResult BeginMode2D(Context ctx,
            Camera2D camera)
        {
            Imports.BeginMode2D(camera.Struct);
            return RuntimeResult.Null();
        }

        // void EndMode2D(void);                                       // Ends 2D mode with custom camera 
        public static RuntimeResult EndMode2D(Context ctx)
        {
            Imports.EndMode2D();
            return RuntimeResult.Null();
        }

        // void BeginMode3D(Camera3D camera);                          // Begin 3D mode with custom camera (3D) 
        public static RuntimeResult BeginMode3D(Context ctx,
            Camera3D camera)
        {
            Imports.BeginMode3D(camera.Struct);
            return RuntimeResult.Null();
        }

        // void EndMode3D(void);                                       // Ends 3D mode and returns to default 2D orthographic mode 
        public static RuntimeResult EndMode3D(Context ctx)
        {
            Imports.EndMode3D();
            return RuntimeResult.Null();
        }

        // void BeginTextureMode(RenderTexture2D target);              // Begin drawing to render texture 
        public static RuntimeResult BeginTextureMode(Context ctx,
            RenderTexture2D target)
        {
            Imports.BeginTextureMode(target.Struct);
            return RuntimeResult.Null();
        }

        // void EndTextureMode(void);                                  // Ends drawing to render texture 
        public static RuntimeResult EndTextureMode(Context ctx)
        {
            Imports.EndTextureMode();
            return RuntimeResult.Null();
        }

        // void BeginShaderMode(Shader shader);                        // Begin custom shader drawing 
        public static RuntimeResult BeginShaderMode(Context ctx,
            Shader shader)
        {
            Imports.BeginShaderMode(shader.Struct);
            return RuntimeResult.Null();
        }

        // void EndShaderMode(void);                                   // End custom shader drawing (use default shader) 
        public static RuntimeResult EndShaderMode(Context ctx)
        {
            Imports.EndShaderMode();
            return RuntimeResult.Null();
        }

        // void BeginBlendMode(int mode);                              // Begin blending mode (alpha, additive, multiplied, subtract, custom) 
        public static RuntimeResult BeginBlendMode(Context ctx,
            NumberValue mode)
        {
            Imports.BeginBlendMode((int)mode.Value);
            return RuntimeResult.Null();
        }

        // void EndBlendMode(void);                                    // End blending mode (reset to default: alpha blending) 
        public static RuntimeResult EndBlendMode(Context ctx)
        {
            Imports.EndBlendMode();
            return RuntimeResult.Null();
        }

        // void BeginScissorMode(int x, int y, int width, int height); // Begin scissor mode (define screen area for following drawing) 
        public static RuntimeResult BeginScissorMode(Context ctx,
            NumberValue x, NumberValue y, NumberValue width, NumberValue height)
        {
            Imports.BeginScissorMode((int)x.Value, (int)y.Value, (int)width.Value, (int)height.Value);
            return RuntimeResult.Null();
        }

        // void EndScissorMode(void);                                  // End scissor mode 
        public static RuntimeResult EndScissorMode(Context ctx)
        {
            Imports.EndScissorMode();
            return RuntimeResult.Null();
        }

        // void BeginVrStereoMode(VrStereoConfig config);              // Begin stereo rendering (requires VR simulator) 
        public static RuntimeResult BeginVrStereoMode(Context ctx,
            VrStereoConfig config)
        {
            Imports.BeginVrStereoMode(config.Struct);
            return RuntimeResult.Null();
        }

        // void EndVrStereoMode(void);                                 // End stereo rendering (requires VR simulator) 
        public static RuntimeResult EndVrStereoMode(Context ctx)
        {
            Imports.EndVrStereoMode();
            return RuntimeResult.Null();
        }

        //  VR stereo config functions for VR simulator 

        // VrStereoConfig LoadVrStereoConfig(VrDeviceInfo device);     // Load VR stereo config for VR simulator device parameters 
        public static RuntimeResult LoadVrStereoConfig(Context ctx,
            VrDeviceInfo device)
        {
            return new RuntimeResult().Success(new VrStereoConfig(Imports.LoadVrStereoConfig(device.Struct)));
        }

        // void UnloadVrStereoConfig(VrStereoConfig config);           // Unload VR stereo config 
        public static RuntimeResult UnloadVrStereoConfig(Context ctx,
            VrStereoConfig config)
        {
            Imports.UnloadVrStereoConfig(config.Struct);
            return RuntimeResult.Null();
        }

        //  Shader management functions 

        //  NOTE: Shader functionality is not available on OpenGL 1.1 

        // Shader LoadShader(string vsFileName, string fsFileName);   // Load shader from files and bind default locations 
        public static RuntimeResult LoadShader(Context ctx,
            StringValue vsFileName, StringValue fsFileName)
        {
            return new RuntimeResult().Success(new Shader(Imports.LoadShader(vsFileName.Value, fsFileName.Value)));
        }

        // Shader LoadShaderFromMemory(string vsCode, string fsCode); // Load shader from code strings and bind default locations 
        public static RuntimeResult LoadShaderFromMemory(Context ctx,
            StringValue vsCode, StringValue fsCode)
        {
            return new RuntimeResult().Success(new Shader(Imports.LoadShaderFromMemory(vsCode.Value, fsCode.Value)));
        }

        // bool IsShaderReady(Shader shader);                                   // Check if a shader is ready 
        public static RuntimeResult IsShaderReady(Context ctx,
            Shader shader)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsShaderReady(shader.Struct)));
        }

        // int GetShaderLocation(Shader shader, string uniformName);       // Get shader uniform location 
        public static RuntimeResult GetShaderLocation(Context ctx,
            Shader shader, StringValue uniformName)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetShaderLocation(shader.Struct, uniformName.Value)));
        }

        // int GetShaderLocationAttrib(Shader shader, string attribName);  // Get shader attribute location 
        public static RuntimeResult GetShaderLocationAttrib(Context ctx,
            Shader shader, StringValue attribName)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetShaderLocationAttrib(shader.Struct, attribName.Value)));
        }

        // void SetShaderValue(Shader shader, int locIndex, void* value, int uniformType);               // Set shader uniform value 
        public static unsafe RuntimeResult SetShaderValue(Context ctx,
            Shader shader, NumberValue locIndex, RuntimeValue value, NumberValue uniformType)
        {
            object val = new object();
            if (value.Type == RuntimeValueType.Number)
                val = ((NumberValue)value).Value;
            else if (value.Type == RuntimeValueType.Boolean)
                val = ((BooleanValue)value).Value;
            else if (value.GetType() == typeof(Vector2))
                val = ((Vector2)value).Struct;
            else if (value.GetType() == typeof(Vector3))
                val = ((Vector3)value).Struct;
            GCHandle handle = GCHandle.Alloc(val, GCHandleType.Pinned);
            try
            {
                Imports.SetShaderValue(shader.Struct, (int)locIndex.Value, handle.AddrOfPinnedObject().ToPointer(), (int)uniformType.Value);
            } 
            finally
            {
                handle.Free();
            }
            return RuntimeResult.Null();
        }

        // void SetShaderValueV(Shader shader, int locIndex, void* value, int uniformType, int count);   // Set shader uniform value vector 
        public static unsafe RuntimeResult SetShaderValueV(Context ctx,
            Shader shader, NumberValue locIndex, ListValue value, NumberValue uniformType, NumberValue count)
        {
            object[] val = new object[0];
            if (value.Type == RuntimeValueType.Number)
                val = value.Items.Select(x => ((NumberValue)x).Value).Cast<object>().ToArray();
            else if (value.Type == RuntimeValueType.Boolean)
                val = value.Items.Select(x => ((BooleanValue)x).Value ? 1 : 0).Cast<object>().ToArray();
            else if (value.GetType() == typeof(Vector2))
                val = value.Items.Select(x => ((Vector2)x).Struct).Cast<object>().ToArray();
            else if (value.GetType() == typeof(Vector3))
                val = value.Items.Select(x => ((Vector3)x).Struct).Cast<object>().ToArray();
            GCHandle handle = GCHandle.Alloc(val, GCHandleType.Pinned);
            try
            {
                Imports.SetShaderValueV(shader.Struct, (int)locIndex.Value, handle.AddrOfPinnedObject().ToPointer(), (int)uniformType.Value, (int)count.Value);
            }
            finally
            {
                handle.Free();
            }
            return RuntimeResult.Null();
        }

        // void SetShaderValueMatrix(Shader shader, int locIndex, Matrix mat);         // Set shader uniform value (matrix 4x4) 
        public static RuntimeResult SetShaderValueMatrix(Context ctx,
            Shader shader, NumberValue locIndex, Matrix mat)
        {
            Imports.SetShaderValueMatrix(shader.Struct, (int)locIndex.Value, mat.Struct);
            return RuntimeResult.Null();
        }

        // void SetShaderValueTexture(Shader shader, int locIndex, Texture2D texture); // Set shader uniform value for texture (sampler2d) 
        public static RuntimeResult SetShaderValueTexture(Context ctx,
            Shader shader, NumberValue locIndex, Texture2D texture)
        {
            Imports.SetShaderValueTexture(shader.Struct, (int)locIndex.Value, texture.Struct);
            return RuntimeResult.Null();
        }

        // void UnloadShader(Shader shader);                                    // Unload shader from GPU memory (VRAM) 
        public static RuntimeResult UnloadShader(Context ctx,
            Shader shader)
        {
            Imports.UnloadShader(shader.Struct);
            return RuntimeResult.Null();
        }

        //  Screen-space-related functions 

        // Ray GetMouseRay(Vector2 mousePosition, Camera3D camera);      // Get a ray trace from mouse position 
        public static RuntimeResult GetMouseRay(Context ctx,
            Vector2 mousePosition, Camera3D camera)
        {
            return new RuntimeResult().Success(new Ray(Imports.GetMouseRay(mousePosition.Struct, camera.Struct)));
        }

        // Matrix GetCameraMatrix(Camera3D camera);                      // Get camera transform matrix (view matrix) 
        public static RuntimeResult GetCameraMatrix(Context ctx,
            Camera3D camera)
        {
            return new RuntimeResult().Success(new Matrix(Imports.GetCameraMatrix(camera.Struct)));
        }

        // Matrix GetCameraMatrix2D(Camera2D camera);                  // Get camera 2d transform matrix 
        public static RuntimeResult GetCameraMatrix2D(Context ctx,
            Camera2D camera)
        {
            return new RuntimeResult().Success(new Matrix(Imports.GetCameraMatrix2D(camera.Struct)));
        }

        // Vector2 GetWorldToScreen(Vector3 position, Camera3D camera);  // Get the screen space position for a 3d world space position 
        public static RuntimeResult GetWorldToScreen(Context ctx,
            Vector3 position, Camera3D camera)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetWorldToScreen(position.Struct, camera.Struct)));
        }

        // Vector2 GetScreenToWorld2D(Vector2 position, Camera2D camera); // Get the world space position for a 2d camera screen space position 
        public static RuntimeResult GetScreenToWorld2D(Context ctx,
            Vector2 position, Camera2D camera)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetScreenToWorld2D(position.Struct, camera.Struct)));
        }

        // Vector2 GetWorldToScreenEx(Vector3 position, Camera3D camera, int width, int height); // Get size position for a 3d world space position 
        public static RuntimeResult GetWorldToScreenEx(Context ctx,
            Vector3 position, Camera3D camera, NumberValue width, NumberValue height)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetWorldToScreenEx(position.Struct, camera.Struct, (int)width.Value, (int)height.Value)));
        }

        // Vector2 GetWorldToScreen2D(Vector2 position, Camera2D camera); // Get the screen space position for a 2d camera world space position 
        public static RuntimeResult GetWorldToScreen2D(Context ctx,
            Vector2 position, Camera2D camera)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetWorldToScreen2D(position.Struct, camera.Struct)));
        }

        //  Timing-related functions 

        // void SetTargetFPS(int fps);                                 // Set target FPS (maximum) 
        public static RuntimeResult SetTargetFPS(Context ctx,
            NumberValue fps)
        {
            Imports.SetTargetFPS((int)fps.Value);
            return RuntimeResult.Null();
        }

        // int GetFPS(void);                                           // Get current FPS 
        public static RuntimeResult GetFPS(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetFPS()));
        }

        // float GetFrameTime(void);                                   // Get time in seconds for last frame drawn (delta time) 
        public static RuntimeResult GetFrameTime(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetFrameTime()));
        }

        // double GetTime(void);                                       // Get elapsed time in seconds since InitWindow() 
        public static RuntimeResult GetTime(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetTime()));
        }

        //  Misc. functions 

        // int GetRandomValue(int min, int max);                       // Get a random value between min and max (both included) 
        public static RuntimeResult GetRandomValue(Context ctx,
            NumberValue min, NumberValue max)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetRandomValue((int)min.Value, (int)max.Value)));
        }

        // void SetRandomSeed(uint seed);                      // Set the seed for the random number generator 
        public static RuntimeResult SetRandomSeed(Context ctx,
            uint seed)
        {
            Imports.SetRandomSeed(seed);
            return RuntimeResult.Null();
        }

        // void TakeScreenshot(string fileName);                  // Takes a screenshot of current screen (filename extension defines format) 
        public static RuntimeResult TakeScreenshot(Context ctx,
            StringValue fileName)
        {
            Imports.TakeScreenshot(fileName.Value);
            return RuntimeResult.Null();
        }

        // void SetConfigFlags(uint flags);                    // Setup init configuration flags (view FLAGS) 
        public static RuntimeResult SetConfigFlags(Context ctx,
            uint flags)
        {
            Imports.SetConfigFlags(flags);
            return RuntimeResult.Null();
        }

        //// void TraceLog(int logLevel, string text, __arglist);         // Show trace log messages (LOG_DEBUG, LOG_INFO, LOG_WARNING, LOG_ERROR__arglist) 
        //public static RuntimeResult TraceLog(Context ctx,
        //    NumberValue logLevel, StringValue text,  /* -------------------- DO THIS MANUALLY -------------------- */)
        //{
        //    Imports.TraceLog((int)logLevel.Value, text.Value, /* -------------------- DO THIS MANUALLY -------------------- */);
        //    return RuntimeResult.Null();
        //}

        //// void SetTraceLogLevel(int logLevel);                        // Set the current threshold (minimum) log level 
        //public static RuntimeResult SetTraceLogLevel(Context ctx,
        //    NumberValue logLevel)
        //{
        //    Imports.SetTraceLogLevel((int)logLevel.Value);
        //    return RuntimeResult.Null();
        //}

        //// void *MemAlloc(uint size);                          // Internal memory allocator 
        //public static RuntimeResult* MemAlloc(Context ctx,
        //    uint size)
        //{
        //    Imports.MemAlloc(size);
        //    return RuntimeResult.Null();
        //}

        //// void *MemRealloc(void *ptr, uint size);             // Internal memory reallocator 
        //public static RuntimeResult* MemRealloc(Context ctx)
        //{
        //    Imports.* MemRealloc();
        //    return RuntimeResult.Null();
        //}

        //// void MemFree(void *ptr);                                    // Internal memory free 
        //public static RuntimeResult MemFree(Context ctx)
        //{
        //    Imports.MemFree();
        //    return RuntimeResult.Null();
        //}

        // void OpenURL(string url);                              // Open URL with default system browser (if available) 
        public static RuntimeResult OpenURL(Context ctx,
            StringValue url)
        {
            Imports.OpenURL(url.Value);
            return RuntimeResult.Null();
        }

        //  Set custom callbacks 

        //  WARNING: Callbacks setup is intended for advance users 

        //// void SetTraceLogCallback(TraceLogCallback callback);         // Set custom trace log 
        //public static RuntimeResult SetTraceLogCallback(Context ctx,
        //    TraceLogCallback callback)
        //{
        //    Imports.SetTraceLogCallback(callback);
        //    return RuntimeResult.Null();
        //}

        //// void SetLoadFileDataCallback(LoadFileDataCallback callback); // Set custom file binary data loader 
        //public static RuntimeResult SetLoadFileDataCallback(Context ctx,
        //    LoadFileDataCallback callback)
        //{
        //    Imports.SetLoadFileDataCallback(callback);
        //    return RuntimeResult.Null();
        //}

        //// void SetSaveFileDataCallback(SaveFileDataCallback callback); // Set custom file binary data saver 
        //public static RuntimeResult SetSaveFileDataCallback(Context ctx,
        //    SaveFileDataCallback callback)
        //{
        //    Imports.SetSaveFileDataCallback(callback);
        //    return RuntimeResult.Null();
        //}

        //// void SetLoadFileTextCallback(LoadFileTextCallback callback); // Set custom file text data loader 
        //public static RuntimeResult SetLoadFileTextCallback(Context ctx,
        //    LoadFileTextCallback callback)
        //{
        //    Imports.SetLoadFileTextCallback(callback);
        //    return RuntimeResult.Null();
        //}

        //// void SetSaveFileTextCallback(SaveFileTextCallback callback); // Set custom file text data saver 
        //public static RuntimeResult SetSaveFileTextCallback(Context ctx,
        //    SaveFileTextCallback callback)
        //{
        //    Imports.SetSaveFileTextCallback(callback);
        //    return RuntimeResult.Null();
        //}

        //  Files management functions 

        // string LoadFileData(string fileName, IntPtr bytesRead);       // Load file data as byte array (read) 
        //public static RuntimeResult LoadFileData(Context ctx,
        //    StringValue fileName, IntPtr bytesRead)
        //{
        //    return new RuntimeResult().Success(new StringValue(Imports.LoadFileData(fileName.Value, bytesRead)));
        //}

        //// void UnloadFileData(string data);                   // Unload file data allocated by LoadFileData() 
        //public static RuntimeResult UnloadFileData(Context ctx,
        //    StringValue data)
        //{
        //    Imports.UnloadFileData(data.Value);
        //    return RuntimeResult.Null();
        //}

        //// bool SaveFileData(string fileName, void *data, uint bytesToWrite);   // Save data to file from byte array (write), returns true on success 
        //public static RuntimeResult SaveFileData(Context ctx,
        //    StringValue fileName, void* data, uint bytesToWrite)
        //{
        //    return new RuntimeResult().Success(new BooleanValue(Imports.SaveFileData(fileName.Value, *data, bytesToWrite)));
        //}

        //// bool ExportDataAsCode(string data, uint size, string fileName); // Export data to code (.h), returns true on success 
        //public static RuntimeResult ExportDataAsCode(Context ctx,
        //    StringValue data, uint size, StringValue fileName)
        //{
        //    return new RuntimeResult().Success(new BooleanValue(Imports.ExportDataAsCode(data.Value, size, fileName.Value)));
        //}

        // string LoadFileText(string fileName);                   // Load text data from file (read), returns a '\0' terminated string 
        public static RuntimeResult LoadFileText(Context ctx,
            StringValue fileName)
        {
            return new RuntimeResult().Success(new StringValue(Imports.LoadFileText(fileName.Value)));
        }

        // void UnloadFileText(string text);                            // Unload file text data allocated by LoadFileText() 
        public static RuntimeResult UnloadFileText(Context ctx,
            StringValue text)
        {
            Imports.UnloadFileText(text.Value);
            return RuntimeResult.Null();
        }

        // bool SaveFileText(string fileName, string text);        // Save text data to file (write), string must be '\0' terminated, returns true on success 
        public static RuntimeResult SaveFileText(Context ctx,
            StringValue fileName, StringValue text)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.SaveFileText(fileName.Value, text.Value)));
        }

        // bool FileExists(string fileName);                      // Check if file exists 
        public static RuntimeResult FileExists(Context ctx,
            StringValue fileName)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.FileExists(fileName.Value)));
        }

        // bool DirectoryExists(string dirPath);                  // Check if a directory path exists 
        public static RuntimeResult DirectoryExists(Context ctx,
            StringValue dirPath)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.DirectoryExists(dirPath.Value)));
        }

        // bool IsFileExtension(string fileName, string ext); // Check file extension (including point: .png, .wav) 
        public static RuntimeResult IsFileExtension(Context ctx,
            StringValue fileName, StringValue ext)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsFileExtension(fileName.Value, ext.Value)));
        }

        // int GetFileLength(string fileName);                    // Get file length in bytes (NOTE: GetFileSize() conflicts with windows.h) 
        public static RuntimeResult GetFileLength(Context ctx,
            StringValue fileName)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetFileLength(fileName.Value)));
        }

        // string GetFileExtension(string fileName);         // Get pointer to extension for a filename string (includes dot: '.png') 
        public static RuntimeResult GetFileExtension(Context ctx,
            StringValue fileName)
        {
            return new RuntimeResult().Success(new StringValue(Imports.GetFileExtension(fileName.Value)));
        }

        // string GetFileName(string filePath);              // Get pointer to filename for a path string 
        public static RuntimeResult GetFileName(Context ctx,
            StringValue filePath)
        {
            return new RuntimeResult().Success(new StringValue(Imports.GetFileName(filePath.Value)));
        }

        // string GetFileNameWithoutExt(string filePath);    // Get filename string without extension (uses static string) 
        public static RuntimeResult GetFileNameWithoutExt(Context ctx,
            StringValue filePath)
        {
            return new RuntimeResult().Success(new StringValue(Imports.GetFileNameWithoutExt(filePath.Value)));
        }

        // string GetDirectoryPath(string filePath);         // Get full path for a given fileName with path (uses static string) 
        public static RuntimeResult GetDirectoryPath(Context ctx,
            StringValue filePath)
        {
            return new RuntimeResult().Success(new StringValue(Imports.GetDirectoryPath(filePath.Value)));
        }

        // string GetPrevDirectoryPath(string dirPath);      // Get previous directory path for a given path (uses static string) 
        public static RuntimeResult GetPrevDirectoryPath(Context ctx,
            StringValue dirPath)
        {
            return new RuntimeResult().Success(new StringValue(Imports.GetPrevDirectoryPath(dirPath.Value)));
        }

        // string GetWorkingDirectory(void);                      // Get current working directory (uses static string) 
        public static RuntimeResult GetWorkingDirectory(Context ctx)
        {
            return new RuntimeResult().Success(new StringValue(Imports.GetWorkingDirectory()));
        }

        // string GetApplicationDirectory(void);                  // Get the directory if the running application (uses static string) 
        public static RuntimeResult GetApplicationDirectory(Context ctx)
        {
            return new RuntimeResult().Success(new StringValue(Imports.GetApplicationDirectory()));
        }

        // bool ChangeDirectory(string dir);                      // Change working directory, return true on success 
        public static RuntimeResult ChangeDirectory(Context ctx,
            StringValue dir)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.ChangeDirectory(dir.Value)));
        }

        // bool IsPathFile(string path);                          // Check if a given path is a file or a directory 
        public static RuntimeResult IsPathFile(Context ctx,
            StringValue path)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsPathFile(path.Value)));
        }

        // FilePathList LoadDirectoryFiles(string dirPath);       // Load directory filepaths 
        public static RuntimeResult LoadDirectoryFiles(Context ctx,
            StringValue dirPath)
        {
            return new RuntimeResult().Success(new FilePathList(Imports.LoadDirectoryFiles(dirPath.Value)));
        }

        // FilePathList LoadDirectoryFilesEx(string basePath, string filter, bool scanSubdirs); // Load directory filepaths with extension filtering and recursive directory scan 
        public static RuntimeResult LoadDirectoryFilesEx(Context ctx,
            StringValue basePath, StringValue filter, BooleanValue scanSubdirs)
        {
            return new RuntimeResult().Success(new FilePathList(Imports.LoadDirectoryFilesEx(basePath.Value, filter.Value, scanSubdirs.Value)));
        }

        // void UnloadDirectoryFiles(FilePathList files);              // Unload filepaths 
        public static RuntimeResult UnloadDirectoryFiles(Context ctx,
            Structs.FilePathList files)
        {
            Imports.UnloadDirectoryFiles(files);
            return RuntimeResult.Null();
        }

        // bool IsFileDropped(void);                                   // Check if a file has been dropped into window 
        public static RuntimeResult IsFileDropped(Context ctx)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsFileDropped()));
        }



        // TODO: make file dropping working


        // FilePathList LoadDroppedFiles(void);                        // Load dropped filepaths 
        public static RuntimeResult LoadDroppedFiles(Context ctx)
        {
            List<StringValue> paths = new List<StringValue>();
            Structs.FilePathList list = Imports.LoadDroppedFiles();
            unsafe
            {
                for (int i = 0; i < list.count; i++)
                {
                    paths.Add(new StringValue(Marshal.PtrToStringUTF8((IntPtr)list.paths[i])));
                }
            }
            
            return new RuntimeResult().Success(new ListValue(paths.Cast<RuntimeValue>().ToList()));
        }

        // void UnloadDroppedFiles(FilePathList files);                // Unload dropped filepaths 
        public static RuntimeResult UnloadDroppedFiles(Context ctx,
            FilePathList files)
        {
            Imports.UnloadDroppedFiles(files.Struct);
            return RuntimeResult.Null();
        }

        // long GetFileModTime(string fileName);                  // Get file modification time (last write time) 
        public static RuntimeResult GetFileModTime(Context ctx,
            StringValue fileName)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetFileModTime(fileName.Value)));
        }

        //  Compression/Encoding functionality 

        // string CompressData(string data, int dataSize, IntPtr compDataSize);        // Compress data (DEFLATE algorithm), memory must be MemFree() 
        public static RuntimeResult CompressData(Context ctx,
            StringValue data, NumberValue dataSize, IntPtr compDataSize)
        {
            return new RuntimeResult().Success(new StringValue(Imports.CompressData(data.Value, (int)dataSize.Value, compDataSize)));
        }

        // string DecompressData(string compData, int compDataSize, IntPtr dataSize);  // Decompress data (DEFLATE algorithm), memory must be MemFree() 
        public static RuntimeResult DecompressData(Context ctx,
            StringValue compData, NumberValue compDataSize, IntPtr dataSize)
        {
            return new RuntimeResult().Success(new StringValue(Imports.DecompressData(compData.Value, (int)compDataSize.Value, dataSize)));
        }

        // string EncodeDataBase64(string data, int dataSize, IntPtr outputSize);               // Encode data to Base64 string, memory must be MemFree() 
        public static RuntimeResult EncodeDataBase64(Context ctx,
            StringValue data, NumberValue dataSize, IntPtr outputSize)
        {
            return new RuntimeResult().Success(new StringValue(Imports.EncodeDataBase64(data.Value, (int)dataSize.Value, outputSize)));
        }

        // string DecodeDataBase64(string data, IntPtr outputSize);                    // Decode Base64 string data, memory must be MemFree() 
        public static RuntimeResult DecodeDataBase64(Context ctx,
            StringValue data, IntPtr outputSize)
        {
            return new RuntimeResult().Success(new StringValue(Imports.DecodeDataBase64(data.Value, outputSize)));
        }

        // ------------------------------------------------------------------------------------
        //  Input Handling Functions (Module: core)
        // ------------------------------------------------------------------------------------ 

        //  Input-related functions: keyboard 

        // bool IsKeyPressed(int key);                             // Check if a key has been pressed once 
        public static RuntimeResult IsKeyPressed(Context ctx,
            NumberValue key)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsKeyPressed((int)key.Value)));
        }

        // bool IsKeyDown(int key);                                // Check if a key is being pressed 
        public static RuntimeResult IsKeyDown(Context ctx,
            NumberValue key)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsKeyDown((int)key.Value)));
        }

        // bool IsKeyReleased(int key);                            // Check if a key has been released once 
        public static RuntimeResult IsKeyReleased(Context ctx,
            NumberValue key)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsKeyReleased((int)key.Value)));
        }

        // bool IsKeyUp(int key);                                  // Check if a key is NOT being pressed 
        public static RuntimeResult IsKeyUp(Context ctx,
            NumberValue key)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsKeyUp((int)key.Value)));
        }

        // void SetExitKey(int key);                               // Set a custom key to exit program (default is ESC) 
        public static RuntimeResult SetExitKey(Context ctx,
            NumberValue key)
        {
            Imports.SetExitKey((int)key.Value);
            return RuntimeResult.Null();
        }

        // int GetKeyPressed(void);                                // Get key pressed (keycode), call it multiple times for keys queued, returns 0 when the queue is empty 
        public static RuntimeResult GetKeyPressed(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetKeyPressed()));
        }

        // int GetCharPressed(void);                               // Get char pressed (unicode), call it multiple times for chars queued, returns 0 when the queue is empty 
        public static RuntimeResult GetCharPressed(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetCharPressed()));
        }

        //  Input-related functions: gamepads 

        // bool IsGamepadAvailable(int gamepad);                   // Check if a gamepad is available 
        public static RuntimeResult IsGamepadAvailable(Context ctx,
            NumberValue gamepad)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsGamepadAvailable((int)gamepad.Value)));
        }

        // string GetGamepadName(int gamepad);                // Get gamepad internal name id 
        public static RuntimeResult GetGamepadName(Context ctx,
            NumberValue gamepad)
        {
            return new RuntimeResult().Success(new StringValue(Imports.GetGamepadName((int)gamepad.Value)));
        }

        // bool IsGamepadButtonPressed(int gamepad, int button);   // Check if a gamepad button has been pressed once 
        public static RuntimeResult IsGamepadButtonPressed(Context ctx,
            NumberValue gamepad, NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsGamepadButtonPressed((int)gamepad.Value, (int)button.Value)));
        }

        // bool IsGamepadButtonDown(int gamepad, int button);      // Check if a gamepad button is being pressed 
        public static RuntimeResult IsGamepadButtonDown(Context ctx,
            NumberValue gamepad, NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsGamepadButtonDown((int)gamepad.Value, (int)button.Value)));
        }

        // bool IsGamepadButtonReleased(int gamepad, int button);  // Check if a gamepad button has been released once 
        public static RuntimeResult IsGamepadButtonReleased(Context ctx,
            NumberValue gamepad, NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsGamepadButtonReleased((int)gamepad.Value, (int)button.Value)));
        }

        // bool IsGamepadButtonUp(int gamepad, int button);        // Check if a gamepad button is NOT being pressed 
        public static RuntimeResult IsGamepadButtonUp(Context ctx,
            NumberValue gamepad, NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsGamepadButtonUp((int)gamepad.Value, (int)button.Value)));
        }

        // int GetGamepadButtonPressed(void);                      // Get the last gamepad button pressed 
        public static RuntimeResult GetGamepadButtonPressed(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetGamepadButtonPressed()));
        }

        // int GetGamepadAxisCount(int gamepad);                   // Get gamepad axis count for a gamepad 
        public static RuntimeResult GetGamepadAxisCount(Context ctx,
            NumberValue gamepad)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetGamepadAxisCount((int)gamepad.Value)));
        }

        // float GetGamepadAxisMovement(int gamepad, int axis);    // Get axis movement value for a gamepad axis 
        public static RuntimeResult GetGamepadAxisMovement(Context ctx,
            NumberValue gamepad, NumberValue axis)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetGamepadAxisMovement((int)gamepad.Value, (int)axis.Value)));
        }

        // int SetGamepadMappings(string mappings);           // Set internal gamepad mappings (SDL_GameControllerDB) 
        public static RuntimeResult SetGamepadMappings(Context ctx,
            StringValue mappings)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.SetGamepadMappings(mappings.Value)));
        }

        //  Input-related functions: mouse 

        // bool IsMouseButtonPressed(int button);                  // Check if a mouse button has been pressed once 
        public static RuntimeResult IsMouseButtonPressed(Context ctx,
            NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsMouseButtonPressed((int)button.Value)));
        }

        // bool IsMouseButtonDown(int button);                     // Check if a mouse button is being pressed 
        public static RuntimeResult IsMouseButtonDown(Context ctx,
            NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsMouseButtonDown((int)button.Value)));
        }

        // bool IsMouseButtonReleased(int button);                 // Check if a mouse button has been released once 
        public static RuntimeResult IsMouseButtonReleased(Context ctx,
            NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsMouseButtonReleased((int)button.Value)));
        }

        // bool IsMouseButtonUp(int button);                       // Check if a mouse button is NOT being pressed 
        public static RuntimeResult IsMouseButtonUp(Context ctx,
            NumberValue button)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsMouseButtonUp((int)button.Value)));
        }

        // int GetMouseX(void);                                    // Get mouse position X 
        public static RuntimeResult GetMouseX(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetMouseX()));
        }

        // int GetMouseY(void);                                    // Get mouse position Y 
        public static RuntimeResult GetMouseY(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetMouseY()));
        }

        // Vector2 GetMousePosition(void);                         // Get mouse position XY 
        public static RuntimeResult GetMousePosition(Context ctx)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetMousePosition()));
        }

        // Vector2 GetMouseDelta(void);                            // Get mouse delta between frames 
        public static RuntimeResult GetMouseDelta(Context ctx)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetMouseDelta()));
        }

        // void SetMousePosition(int x, int y);                    // Set mouse position XY 
        public static RuntimeResult SetMousePosition(Context ctx,
            NumberValue x, NumberValue y)
        {
            Imports.SetMousePosition((int)x.Value, (int)y.Value);
            return RuntimeResult.Null();
        }

        // void SetMouseOffset(int offsetX, int offsetY);          // Set mouse offset 
        public static RuntimeResult SetMouseOffset(Context ctx,
            NumberValue offsetX, NumberValue offsetY)
        {
            Imports.SetMouseOffset((int)offsetX.Value, (int)offsetY.Value);
            return RuntimeResult.Null();
        }

        // void SetMouseScale(float scaleX, float scaleY);         // Set mouse scaling 
        public static RuntimeResult SetMouseScale(Context ctx,
            NumberValue scaleX, NumberValue scaleY)
        {
            Imports.SetMouseScale((float)scaleX.Value, (float)scaleY.Value);
            return RuntimeResult.Null();
        }

        // float GetMouseWheelMove(void);                          // Get mouse wheel movement for X or Y, whichever is larger 
        public static RuntimeResult GetMouseWheelMove(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetMouseWheelMove()));
        }

        // Vector2 GetMouseWheelMoveV(void);                       // Get mouse wheel movement for both X and Y 
        public static RuntimeResult GetMouseWheelMoveV(Context ctx)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetMouseWheelMoveV()));
        }

        // void SetMouseCursor(int cursor);                        // Set mouse cursor 
        public static RuntimeResult SetMouseCursor(Context ctx,
            NumberValue cursor)
        {
            Imports.SetMouseCursor((int)cursor.Value);
            return RuntimeResult.Null();
        }

        //  Input-related functions: touch 

        // int GetTouchX(void);                                    // Get touch position X for touch point 0 (relative to screen size) 
        public static RuntimeResult GetTouchX(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetTouchX()));
        }

        // int GetTouchY(void);                                    // Get touch position Y for touch point 0 (relative to screen size) 
        public static RuntimeResult GetTouchY(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetTouchY()));
        }

        // Vector2 GetTouchPosition(int index);                    // Get touch position XY for a touch point index (relative to screen size) 
        public static RuntimeResult GetTouchPosition(Context ctx,
            NumberValue index)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetTouchPosition((int)index.Value)));
        }

        // int GetTouchPointId(int index);                         // Get touch point identifier for given index 
        public static RuntimeResult GetTouchPointId(Context ctx,
            NumberValue index)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetTouchPointId((int)index.Value)));
        }

        // int GetTouchPointCount(void);                           // Get number of touch points 
        public static RuntimeResult GetTouchPointCount(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetTouchPointCount()));
        }

        // ------------------------------------------------------------------------------------ 
        //  Gestures and Touch Handling Functions (Module: rgestures) 
        // ------------------------------------------------------------------------------------ 

        // void SetGesturesEnabled(uint flags);      // Enable a set of gestures using flags 
        public static RuntimeResult SetGesturesEnabled(Context ctx,
            uint flags)
        {
            Imports.SetGesturesEnabled(flags);
            return RuntimeResult.Null();
        }

        // bool IsGestureDetected(int gesture);              // Check if a gesture have been detected 
        public static RuntimeResult IsGestureDetected(Context ctx,
            NumberValue gesture)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsGestureDetected((int)gesture.Value)));
        }

        // int GetGestureDetected(void);                     // Get latest detected gesture 
        public static RuntimeResult GetGestureDetected(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetGestureDetected()));
        }

        // float GetGestureHoldDuration(void);               // Get gesture hold time in milliseconds 
        public static RuntimeResult GetGestureHoldDuration(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetGestureHoldDuration()));
        }

        // Vector2 GetGestureDragVector(void);               // Get gesture drag vector 
        public static RuntimeResult GetGestureDragVector(Context ctx)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetGestureDragVector()));
        }

        // float GetGestureDragAngle(void);                  // Get gesture drag angle 
        public static RuntimeResult GetGestureDragAngle(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetGestureDragAngle()));
        }

        // Vector2 GetGesturePinchVector(void);              // Get gesture pinch delta 
        public static RuntimeResult GetGesturePinchVector(Context ctx)
        {
            return new RuntimeResult().Success(new Vector2(Imports.GetGesturePinchVector()));
        }

        // float GetGesturePinchAngle(void);                 // Get gesture pinch angle 
        public static RuntimeResult GetGesturePinchAngle(Context ctx)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetGesturePinchAngle()));
        }

        // ----------------------------------------------------------------------------------- 
        //  Camera3D System Functions (Module: rcamera 
        // ----------------------------------------------------------------------------------- 

        // void UpdateCamera(Camera3D *camera, int mode);      // Update camera position for selected mod 
        public static RuntimeResult UpdateCamera(Context ctx,
            Camera3D camera, NumberValue mode)
        {
            unsafe
            {
                Structs.Camera3D cam = camera.Struct;
                Imports.UpdateCamera(&cam, (int)mode.Value);
            }
            return RuntimeResult.Null();
        }

        // void UpdateCameraPro(Camera3D *camera, Vector3 movement, Vector3 rotation, float zoom); // Update camera movement/rotatio 
        public static RuntimeResult UpdateCameraPro(Context ctx,
            Camera3D camera, Vector3 movement, Vector3 rotation, NumberValue zoom)
        {
            unsafe
            {
                Structs.Camera3D cam = camera.Struct;
                Imports.UpdateCameraPro(&cam, movement.Struct, rotation.Struct, (float)zoom.Value);
            }
            return RuntimeResult.Null();
        }

        //  


    }
}
