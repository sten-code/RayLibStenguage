using System.Numerics;
using System.Runtime.InteropServices;
using RayLibStenguage.Classes;
using static RayLibStenguage.Structs;

namespace RayLibStenguage
{
    public class Imports
    {
        #region RCore

        //  Window-related functions 

        // void InitWindow(int width, int height, string title);  // Initialize window and OpenGL context 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void InitWindow(int width, int height, [MarshalAs(UnmanagedType.LPStr)] string title);

        // bool WindowShouldClose(void);                               // Check if KEY_ESCAPE pressed or Close icon pressed 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool WindowShouldClose();

        // void CloseWindow(void);                                     // Close window and unload OpenGL context 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void CloseWindow();

        // bool IsWindowReady(void);                                   // Check if window has been initialized successfully 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsWindowReady();

        // bool IsWindowFullscreen(void);                              // Check if window is currently fullscreen 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsWindowFullscreen();

        // bool IsWindowHidden(void);                                  // Check if window is currently hidden (only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsWindowHidden();

        // bool IsWindowMinimized(void);                               // Check if window is currently minimized (only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsWindowMinimized();

        // bool IsWindowMaximized(void);                               // Check if window is currently maximized (only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsWindowMaximized();

        // bool IsWindowFocused(void);                                 // Check if window is currently focused (only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsWindowFocused();

        // bool IsWindowResized(void);                                 // Check if window has been resized last frame 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsWindowResized();

        // bool IsWindowState(uint flag);                      // Check if one specific window flag is enabled 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsWindowState(uint flag);

        // void SetWindowState(uint flags);                    // Set window configuration state using flags (only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetWindowState(uint flags);

        // void ClearWindowState(uint flags);                  // Clear window configuration state flags 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ClearWindowState(uint flags);

        // void ToggleFullscreen(void);                                // Toggle window state: fullscreen/windowed (only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ToggleFullscreen();

        // void MaximizeWindow(void);                                  // Set window state: maximized, if resizable (only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void MaximizeWindow();

        // void MinimizeWindow(void);                                  // Set window state: minimized, if resizable (only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void MinimizeWindow();

        // void RestoreWindow(void);                                   // Set window state: not minimized/maximized (only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void RestoreWindow();

        // void SetWindowIcon(Structs.Image image);                            // Set icon for window (single image, RGBA 32bit, only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetWindowIcon(Structs.Image image);

        // void SetWindowIcons(Structs.Image[] images, int count);              // Set icon for window (multiple images, RGBA 32bit, only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetWindowIcons(Structs.Image[] images, int count);

        // void SetWindowTitle(string title);                     // Set title for window (only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetWindowTitle([MarshalAs(UnmanagedType.LPStr)] string title);

        // void SetWindowPosition(int x, int y);                       // Set window position on screen (only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetWindowPosition(int x, int y);

        // void SetWindowMonitor(int monitor);                         // Set monitor for the current window (fullscreen mode) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetWindowMonitor(int monitor);

        // void SetWindowMinSize(int width, int height);               // Set window minimum dimensions (for FLAG_WINDOW_RESIZABLE) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetWindowMinSize(int width, int height);

        // void SetWindowSize(int width, int height);                  // Set window dimensions 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetWindowSize(int width, int height);

        // void SetWindowOpacity(float opacity);                       // Set window opacity [0.0f..1.0f] (only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetWindowOpacity(float opacity);

        // void *GetWindowHandle(void);                                // Get native window handle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr GetWindowHandle();

        // int GetScreenWidth(void);                                   // Get current screen width 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetScreenWidth();

        // int GetScreenHeight(void);                                  // Get current screen height 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetScreenHeight();

        // int GetRenderWidth(void);                                   // Get current render width (it considers HiDPI) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetRenderWidth();

        // int GetRenderHeight(void);                                  // Get current render height (it considers HiDPI) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetRenderHeight();

        // int GetMonitorCount(void);                                  // Get number of connected monitors 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetMonitorCount();

        // int GetCurrentMonitor(void);                                // Get current connected monitor 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetCurrentMonitor();

        // Vector2 GetMonitorPosition(int monitor);                    // Get specified monitor position 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetMonitorPosition(int monitor);

        // int GetMonitorWidth(int monitor);                           // Get specified monitor width (current video mode used by monitor) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetMonitorWidth(int monitor);

        // int GetMonitorHeight(int monitor);                          // Get specified monitor height (current video mode used by monitor) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetMonitorHeight(int monitor);

        // int GetMonitorPhysicalWidth(int monitor);                   // Get specified monitor physical width in millimetres 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetMonitorPhysicalWidth(int monitor);

        // int GetMonitorPhysicalHeight(int monitor);                  // Get specified monitor physical height in millimetres 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetMonitorPhysicalHeight(int monitor);

        // int GetMonitorRefreshRate(int monitor);                     // Get specified monitor refresh rate 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetMonitorRefreshRate(int monitor);

        // Vector2 GetWindowPosition(void);                            // Get window position XY on monitor 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetWindowPosition();

        // Vector2 GetWindowScaleDPI(void);                            // Get window scale DPI factor 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetWindowScaleDPI();

        // string GetMonitorName(int monitor);                    // Get the human-readable, UTF-8 encoded name of the specified monitor 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string GetMonitorName(int monitor);

        // void SetClipboardText(string text);                    // Set clipboard text content 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetClipboardText([MarshalAs(UnmanagedType.LPStr)] string text);

        // string GetClipboardText(void);                         // Get clipboard text content 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string GetClipboardText();

        // void EnableEventWaiting(void);                              // Enable waiting for events on EndDrawing(), no automatic event polling 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EnableEventWaiting();

        // void DisableEventWaiting(void);                             // Disable waiting for events on EndDrawing(), automatic events polling 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DisableEventWaiting();

        //  Custom frame control functions 

        //  NOTE: Those functions are intended for advance users that want full control over the frame processing 

        //  By default EndDrawing() does this job: draws everything + SwapScreenBuffer() + manage frame timing + PollInputEvents() 

        //  To avoid that behaviour and control frame processes manually, enable in config.h: SUPPORT_CUSTOM_FRAME_CONTROL 

        // void SwapScreenBuffer(void);                                // Swap back buffer with front buffer (screen drawing) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SwapScreenBuffer();

        // void PollInputEvents(void);                                 // Register all input events 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void PollInputEvents();

        // void WaitTime(double seconds);                              // Wait for some time (halt program execution) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void WaitTime(double seconds);

        //  Cursor-related functions 

        // void ShowCursor(void);                                      // Shows cursor 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ShowCursor();

        // void HideCursor(void);                                      // Hides cursor 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void HideCursor();

        // bool IsCursorHidden(void);                                  // Check if cursor is not visible 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsCursorHidden();

        // void EnableCursor(void);                                    // Enables cursor (unlock cursor) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EnableCursor();

        // void DisableCursor(void);                                   // Disables cursor (lock cursor) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DisableCursor();

        // bool IsCursorOnScreen(void);                                // Check if cursor is on the screen 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsCursorOnScreen();

        //  Drawing-related functions 

        // void ClearBackground(Structs.Color color);                          // Set background color (framebuffer clear color) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ClearBackground(Structs.Color color);

        // void BeginDrawing(void);                                    // Setup canvas (framebuffer) to start drawing 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginDrawing();

        // void EndDrawing(void);                                      // End canvas drawing and swap buffers (double buffering) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndDrawing();

        // void BeginMode2D(Structs.Camera2D camera);                          // Begin 2D mode with custom camera (2D) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginMode2D(Structs.Camera2D camera);

        // void EndMode2D(void);                                       // Ends 2D mode with custom camera 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndMode2D();

        // void BeginMode3D(Structs.Camera3D camera);                          // Begin 3D mode with custom camera (3D) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginMode3D(Structs.Camera3D camera);

        // void EndMode3D(void);                                       // Ends 3D mode and returns to default 2D orthographic mode 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndMode3D();

        // void BeginTextureMode(Structs.RenderTexture2D target);              // Begin drawing to render texture 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginTextureMode(Structs.RenderTexture2D target);

        // void EndTextureMode(void);                                  // Ends drawing to render texture 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndTextureMode();

        // void BeginShaderMode(Structs.Shader shader);                        // Begin custom shader drawing 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginShaderMode(Structs.Shader shader);

        // void EndShaderMode(void);                                   // End custom shader drawing (use default shader) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndShaderMode();

        // void BeginBlendMode(int mode);                              // Begin blending mode (alpha, additive, multiplied, subtract, custom) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginBlendMode(int mode);

        // void EndBlendMode(void);                                    // End blending mode (reset to default: alpha blending) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndBlendMode();

        // void BeginScissorMode(int x, int y, int width, int height); // Begin scissor mode (define screen area for following drawing) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginScissorMode(int x, int y, int width, int height);

        // void EndScissorMode(void);                                  // End scissor mode 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndScissorMode();

        // void BeginVrStereoMode(Structs.VrStereoConfig config);              // Begin stereo rendering (requires VR simulator) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginVrStereoMode(Structs.VrStereoConfig config);

        // void EndVrStereoMode(void);                                 // End stereo rendering (requires VR simulator) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndVrStereoMode();

        //  VR stereo config functions for VR simulator 

        // Structs.VrStereoConfig LoadVrStereoConfig(VrDeviceInfo device);     // Load VR stereo config for VR simulator device parameters 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.VrStereoConfig LoadVrStereoConfig(Structs.VrDeviceInfo device);

        // void UnloadVrStereoConfig(Structs.VrStereoConfig config);           // Unload VR stereo config 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadVrStereoConfig(Structs.VrStereoConfig config);

        //  Structs.Shader management functions 

        //  NOTE: Structs.Shader functionality is not available on OpenGL 1.1 

        // Structs.Shader LoadShader(string vsFileName, string fsFileName);   // Load shader from files and bind default locations 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Shader LoadShader([MarshalAs(UnmanagedType.LPStr)] string vsFileName, [MarshalAs(UnmanagedType.LPStr)] string fsFileName);

        // Structs.Shader LoadShaderFromMemory(string vsCode, string fsCode); // Load shader from code strings and bind default locations 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Shader LoadShaderFromMemory([MarshalAs(UnmanagedType.LPStr)] string vsCode, [MarshalAs(UnmanagedType.LPStr)] string fsCode);

        // bool IsShaderReady(Structs.Shader shader);                                   // Check if a shader is ready 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsShaderReady(Structs.Shader shader);

        // int GetShaderLocation(Structs.Shader shader, string uniformName);       // Get shader uniform location 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetShaderLocation(Structs.Shader shader, [MarshalAs(UnmanagedType.LPStr)] string uniformName);

        // int GetShaderLocationAttrib(Structs.Shader shader, string attribName);  // Get shader attribute location 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetShaderLocationAttrib(Structs.Shader shader, [MarshalAs(UnmanagedType.LPStr)] string attribName);

        // void SetShaderValue(Structs.Shader shader, int locIndex, void* value, int uniformType);               // Set shader uniform value 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe void SetShaderValue(Structs.Shader shader, int locIndex, void* value, int uniformType);

        // void SetShaderValueV(Structs.Shader shader, int locIndex, void* value, int uniformType, int count);   // Set shader uniform value vector 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe void SetShaderValueV(Structs.Shader shader, int locIndex, void* value, int uniformType, int count);

        // void SetShaderValueMatrix(Structs.Shader shader, int locIndex, Matrix mat);         // Set shader uniform value (matrix 4x4) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetShaderValueMatrix(Structs.Shader shader, int locIndex, Matrix4x4 mat);

        // void SetShaderValueTexture(Structs.Shader shader, int locIndex, Structs.Texture2D texture); // Set shader uniform value for texture (sampler2d) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetShaderValueTexture(Structs.Shader shader, int locIndex, Structs.Texture2D texture);

        // void UnloadShader(Structs.Shader shader);                                    // Unload shader from GPU memory (VRAM) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadShader(Structs.Shader shader);

        //  Screen-space-related functions 

        // Ray GetMouseRay(Vector2 mousePosition, Camera camera);      // Get a ray trace from mouse position 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Ray GetMouseRay(System.Numerics.Vector2 mousePosition, Structs.Camera3D camera);

        // Matrix GetCameraMatrix(Camera camera);                      // Get camera transform matrix (view matrix) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Matrix4x4 GetCameraMatrix(Structs.Camera3D camera);

        // Matrix GetCameraMatrix2D(Structs.Camera2D camera);                  // Get camera 2d transform matrix 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Matrix4x4 GetCameraMatrix2D(Structs.Camera2D camera);

        // Vector2 GetWorldToScreen(System.Numerics.Vector3 position, Camera camera);  // Get the screen space position for a 3d world space position 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetWorldToScreen(System.Numerics.Vector3 position, Structs.Camera3D camera);

        // Vector2 GetScreenToWorld2D(Vector2 position, Structs.Camera2D camera); // Get the world space position for a 2d camera screen space position 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetScreenToWorld2D(System.Numerics.Vector2 position, Structs.Camera2D camera);

        // Vector2 GetWorldToScreenEx(System.Numerics.Vector3 position, Camera camera, int width, int height); // Get size position for a 3d world space position 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetWorldToScreenEx(System.Numerics.Vector3 position, Structs.Camera3D camera, int width, int height);

        // Vector2 GetWorldToScreen2D(Vector2 position, Structs.Camera2D camera); // Get the screen space position for a 2d camera world space position 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetWorldToScreen2D(System.Numerics.Vector2 position, Structs.Camera2D camera);

        //  Timing-related functions 

        // void SetTargetFPS(int fps);                                 // Set target FPS (maximum) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetTargetFPS(int fps);

        // int GetFPS(void);                                           // Get current FPS 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetFPS();

        // float GetFrameTime(void);                                   // Get time in seconds for last frame drawn (delta time) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static float GetFrameTime();

        // double GetTime(void);                                       // Get elapsed time in seconds since InitWindow() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static double GetTime();

        //  Misc. functions 

        // int GetRandomValue(int min, int max);                       // Get a random value between min and max (both included) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetRandomValue(int min, int max);

        // void SetRandomSeed(uint seed);                      // Set the seed for the random number generator 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetRandomSeed(uint seed);

        // void TakeScreenshot(string fileName);                  // Takes a screenshot of current screen (filename extension defines format) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void TakeScreenshot([MarshalAs(UnmanagedType.LPStr)] string fileName);

        // void SetConfigFlags(uint flags);                    // Setup init configuration flags (view FLAGS) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetConfigFlags(uint flags);

        // void TraceLog(int logLevel, string text, __arglist);         // Show trace log messages (LOG_DEBUG, LOG_INFO, LOG_WARNING, LOG_ERROR__arglist) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void TraceLog(int logLevel, [MarshalAs(UnmanagedType.LPStr)] string text, __arglist);

        // void SetTraceLogLevel(int logLevel);                        // Set the current threshold (minimum) log level 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetTraceLogLevel(int logLevel);

        // void *MemAlloc(uint size);                          // Internal memory allocator 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe void* MemAlloc(uint size);

        // void *MemRealloc(void *ptr, uint size);             // Internal memory reallocator 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe void* MemRealloc();

        // void MemFree(void *ptr);                                    // Internal memory free 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void MemFree();

        // void OpenURL(string url);                              // Open URL with default system browser (if available) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void OpenURL([MarshalAs(UnmanagedType.LPStr)] string url);

        //  Files management functions 

        // string LoadFileData(string fileName, IntPtr bytesRead);       // Load file data as byte array (read) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string LoadFileData([MarshalAs(UnmanagedType.LPStr)] string fileName, [MarshalAs(UnmanagedType.LPStr)] ref string bytesRead);

        // void UnloadFileData(string data);                   // Unload file data allocated by LoadFileData() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadFileData([MarshalAs(UnmanagedType.LPStr)] string data);

        // bool SaveFileData(string fileName, void *data, uint bytesToWrite);   // Save data to file from byte array (write), returns true on success 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe bool SaveFileData([MarshalAs(UnmanagedType.LPStr)] string fileName, void* data, uint bytesToWrite);

        // bool ExportDataAsCode(string data, uint size, string fileName); // Export data to code (.h), returns true on success 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool ExportDataAsCode([MarshalAs(UnmanagedType.LPStr)] string data, uint size, [MarshalAs(UnmanagedType.LPStr)] string fileName);

        // string LoadFileText(string fileName);                   // Load text data from file (read), returns a '\0' terminated string 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string LoadFileText([MarshalAs(UnmanagedType.LPStr)] string fileName);

        // void UnloadFileText(string text);                            // Unload file text data allocated by LoadFileText() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadFileText([MarshalAs(UnmanagedType.LPStr)] string text);

        // bool SaveFileText(string fileName, string text);        // Save text data to file (write), string must be '\0' terminated, returns true on success 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool SaveFileText([MarshalAs(UnmanagedType.LPStr)] string fileName, [MarshalAs(UnmanagedType.LPStr)] string text);

        // bool FileExists(string fileName);                      // Check if file exists 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool FileExists([MarshalAs(UnmanagedType.LPStr)] string fileName);

        // bool DirectoryExists(string dirPath);                  // Check if a directory path exists 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool DirectoryExists([MarshalAs(UnmanagedType.LPStr)] string dirPath);

        // bool IsFileExtension(string fileName, string ext); // Check file extension (including point: .png, .wav) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsFileExtension([MarshalAs(UnmanagedType.LPStr)] string fileName, [MarshalAs(UnmanagedType.LPStr)] string ext);

        // int GetFileLength(string fileName);                    // Get file length in bytes (NOTE: GetFileSize() conflicts with windows.h) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetFileLength([MarshalAs(UnmanagedType.LPStr)] string fileName);

        // string GetFileExtension(string fileName);         // Get pointer to extension for a filename string (includes dot: '.png') 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string GetFileExtension([MarshalAs(UnmanagedType.LPStr)] string fileName);

        // string GetFileName(string filePath);              // Get pointer to filename for a path string 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string GetFileName([MarshalAs(UnmanagedType.LPStr)] string filePath);

        // string GetFileNameWithoutExt(string filePath);    // Get filename string without extension (uses static string) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string GetFileNameWithoutExt([MarshalAs(UnmanagedType.LPStr)] string filePath);

        // string GetDirectoryPath(string filePath);         // Get full path for a given fileName with path (uses static string) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string GetDirectoryPath([MarshalAs(UnmanagedType.LPStr)] string filePath);

        // string GetPrevDirectoryPath(string dirPath);      // Get previous directory path for a given path (uses static string) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string GetPrevDirectoryPath([MarshalAs(UnmanagedType.LPStr)] string dirPath);

        // string GetWorkingDirectory(void);                      // Get current working directory (uses static string) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string GetWorkingDirectory();

        // string GetApplicationDirectory(void);                  // Get the directory if the running application (uses static string) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string GetApplicationDirectory();

        // bool ChangeDirectory(string dir);                      // Change working directory, return true on success 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool ChangeDirectory([MarshalAs(UnmanagedType.LPStr)] string dir);

        // bool IsPathFile(string path);                          // Check if a given path is a file or a directory 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsPathFile([MarshalAs(UnmanagedType.LPStr)] string path);

        // Structs.FilePathList LoadDirectoryFiles(string dirPath);       // Load directory filepaths 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.FilePathList LoadDirectoryFiles([MarshalAs(UnmanagedType.LPStr)] string dirPath);

        // Structs.FilePathList LoadDirectoryFilesEx(string basePath, string filter, bool scanSubdirs); // Load directory filepaths with extension filtering and recursive directory scan 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.FilePathList LoadDirectoryFilesEx([MarshalAs(UnmanagedType.LPStr)] string basePath, [MarshalAs(UnmanagedType.LPStr)] string filter, bool scanSubdirs);

        // void UnloadDirectoryFiles(Structs.FilePathList files);              // Unload filepaths 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadDirectoryFiles(Structs.FilePathList files);

        // bool IsFileDropped(void);                                   // Check if a file has been dropped into window 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsFileDropped();

        // Structs.FilePathList LoadDroppedFiles(void);                        // Load dropped filepaths 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.FilePathList LoadDroppedFiles();

        // void UnloadDroppedFiles(Structs.FilePathList files);                // Unload dropped filepaths 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadDroppedFiles(Structs.FilePathList files);

        // long GetFileModTime(string fileName);                  // Get file modification time (last write time) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static long GetFileModTime([MarshalAs(UnmanagedType.LPStr)] string fileName);

        //  Compression/Encoding functionality 

        // string CompressData(string data, int dataSize, IntPtr compDataSize);        // Compress data (DEFLATE algorithm), memory must be MemFree() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string CompressData([MarshalAs(UnmanagedType.LPStr)] string data, int dataSize, int compDataSize);

        // string DecompressData(string compData, int compDataSize, IntPtr dataSize);  // Decompress data (DEFLATE algorithm), memory must be MemFree() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string DecompressData([MarshalAs(UnmanagedType.LPStr)] string compData, int compDataSize, int dataSize);

        // string EncodeDataBase64(string data, int dataSize, IntPtr outputSize);               // Encode data to Base64 string, memory must be MemFree() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string EncodeDataBase64([MarshalAs(UnmanagedType.LPStr)] string data, int dataSize, int outputSize);

        // string DecodeDataBase64(string data, IntPtr outputSize);                    // Decode Base64 string data, memory must be MemFree() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string DecodeDataBase64([MarshalAs(UnmanagedType.LPStr)] string data, int outputSize);

        // ------------------------------------------------------------------------------------ 

        //  Input Handling Functions (Module: core) 

        // ------------------------------------------------------------------------------------ 

        //  Input-related functions: keyboard 

        // bool IsKeyPressed(int key);                             // Check if a key has been pressed once 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsKeyPressed(int key);

        // bool IsKeyDown(int key);                                // Check if a key is being pressed 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsKeyDown(int key);

        // bool IsKeyReleased(int key);                            // Check if a key has been released once 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsKeyReleased(int key);

        // bool IsKeyUp(int key);                                  // Check if a key is NOT being pressed 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsKeyUp(int key);

        // void SetExitKey(int key);                               // Set a custom key to exit program (default is ESC) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetExitKey(int key);

        // int GetKeyPressed(void);                                // Get key pressed (keycode), call it multiple times for keys queued, returns 0 when the queue is empty 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetKeyPressed();

        // int GetCharPressed(void);                               // Get char pressed (unicode), call it multiple times for chars queued, returns 0 when the queue is empty 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetCharPressed();

        //  Input-related functions: gamepads 

        // bool IsGamepadAvailable(int gamepad);                   // Check if a gamepad is available 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsGamepadAvailable(int gamepad);

        // string GetGamepadName(int gamepad);                // Get gamepad internal name id 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string GetGamepadName(int gamepad);

        // bool IsGamepadButtonPressed(int gamepad, int button);   // Check if a gamepad button has been pressed once 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsGamepadButtonPressed(int gamepad, int button);

        // bool IsGamepadButtonDown(int gamepad, int button);      // Check if a gamepad button is being pressed 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsGamepadButtonDown(int gamepad, int button);

        // bool IsGamepadButtonReleased(int gamepad, int button);  // Check if a gamepad button has been released once 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsGamepadButtonReleased(int gamepad, int button);

        // bool IsGamepadButtonUp(int gamepad, int button);        // Check if a gamepad button is NOT being pressed 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsGamepadButtonUp(int gamepad, int button);

        // int GetGamepadButtonPressed(void);                      // Get the last gamepad button pressed 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetGamepadButtonPressed();

        // int GetGamepadAxisCount(int gamepad);                   // Get gamepad axis count for a gamepad 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetGamepadAxisCount(int gamepad);

        // float GetGamepadAxisMovement(int gamepad, int axis);    // Get axis movement value for a gamepad axis 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static float GetGamepadAxisMovement(int gamepad, int axis);

        // int SetGamepadMappings(string mappings);           // Set internal gamepad mappings (SDL_GameControllerDB) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int SetGamepadMappings([MarshalAs(UnmanagedType.LPStr)] string mappings);

        //  Input-related functions: mouse 

        // bool IsMouseButtonPressed(int button);                  // Check if a mouse button has been pressed once 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsMouseButtonPressed(int button);

        // bool IsMouseButtonDown(int button);                     // Check if a mouse button is being pressed 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsMouseButtonDown(int button);

        // bool IsMouseButtonReleased(int button);                 // Check if a mouse button has been released once 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsMouseButtonReleased(int button);

        // bool IsMouseButtonUp(int button);                       // Check if a mouse button is NOT being pressed 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsMouseButtonUp(int button);

        // int GetMouseX(void);                                    // Get mouse position X 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetMouseX();

        // int GetMouseY(void);                                    // Get mouse position Y 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetMouseY();

        // Vector2 GetMousePosition(void);                         // Get mouse position XY 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetMousePosition();

        // Vector2 GetMouseDelta(void);                            // Get mouse delta between frames 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetMouseDelta();

        // void SetMousePosition(int x, int y);                    // Set mouse position XY 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetMousePosition(int x, int y);

        // void SetMouseOffset(int offsetX, int offsetY);          // Set mouse offset 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetMouseOffset(int offsetX, int offsetY);

        // void SetMouseScale(float scaleX, float scaleY);         // Set mouse scaling 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetMouseScale(float scaleX, float scaleY);

        // float GetMouseWheelMove(void);                          // Get mouse wheel movement for X or Y, whichever is larger 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static float GetMouseWheelMove();

        // Vector2 GetMouseWheelMoveV(void);                       // Get mouse wheel movement for both X and Y 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetMouseWheelMoveV();

        // void SetMouseCursor(int cursor);                        // Set mouse cursor 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetMouseCursor(int cursor);

        //  Input-related functions: touch 

        // int GetTouchX(void);                                    // Get touch position X for touch point 0 (relative to screen size) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetTouchX();

        // int GetTouchY(void);                                    // Get touch position Y for touch point 0 (relative to screen size) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetTouchY();

        // Vector2 GetTouchPosition(int index);                    // Get touch position XY for a touch point index (relative to screen size) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetTouchPosition(int index);

        // int GetTouchPointId(int index);                         // Get touch point identifier for given index 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetTouchPointId(int index);

        // int GetTouchPointCount(void);                           // Get number of touch points 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetTouchPointCount();

        // ------------------------------------------------------------------------------------ 

        //  Gestures and Touch Handling Functions (Module: rgestures) 

        // ------------------------------------------------------------------------------------ 

        // void SetGesturesEnabled(uint flags);      // Enable a set of gestures using flags 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetGesturesEnabled(uint flags);

        // bool IsGestureDetected(int gesture);              // Check if a gesture have been detected 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsGestureDetected(int gesture);

        // int GetGestureDetected(void);                     // Get latest detected gesture 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetGestureDetected();

        // float GetGestureHoldDuration(void);               // Get gesture hold time in milliseconds 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static float GetGestureHoldDuration();

        // Vector2 GetGestureDragVector(void);               // Get gesture drag vector 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetGestureDragVector();

        // float GetGestureDragAngle(void);                  // Get gesture drag angle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static float GetGestureDragAngle();

        // Vector2 GetGesturePinchVector(void);              // Get gesture pinch delta 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetGesturePinchVector();

        // float GetGesturePinchAngle(void);                 // Get gesture pinch angle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static float GetGesturePinchAngle();

        // ------------------------------------------------------------------------------------ 

        //  Camera System Functions (Module: rcamera) 

        // ------------------------------------------------------------------------------------ 

        // void UpdateCamera(Camera *camera, int mode);      // Update camera position for selected mode 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe void UpdateCamera(Structs.Camera3D* camera, int mode);

        // void UpdateCameraPro(Camera *camera, System.Numerics.Vector3 movement, System.Numerics.Vector3 rotation, float zoom); // Update camera movement/rotation 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe void UpdateCameraPro(Structs.Camera3D* camera, System.Numerics.Vector3 movement, System.Numerics.Vector3 rotation, float zoom);

        #endregion

        #region RShapes

        //  NOTE: It can be useful when using basic shapes and one single font, 

        //  defining a font char white rectangle would allow drawing everything in a single draw call 

        // void SetShapesTexture(Structs.Texture2D texture, Structs.Rectangle source);       // Set texture and rectangle to be used on shapes drawing 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetShapesTexture(Structs.Texture2D texture, Structs.Rectangle source);

        //  Basic shapes drawing functions 

        // void DrawPixel(int posX, int posY, Structs.Color color);                                                   // Draw a pixel 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawPixel(int posX, int posY, Structs.Color color);

        // void DrawPixelV(Vector2 position, Structs.Color color);                                                    // Draw a pixel (Vector version) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawPixelV(System.Numerics.Vector2 position, Structs.Color color);

        // void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Structs.Color color);                // Draw a line 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Structs.Color color);

        // void DrawLineV(Vector2 startPos, Vector2 endPos, Structs.Color color);                                     // Draw a line (Vector version) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawLineV(System.Numerics.Vector2 startPos, System.Numerics.Vector2 endPos, Structs.Color color);

        // void DrawLineEx(Vector2 startPos, Vector2 endPos, float thick, Structs.Color color);                       // Draw a line defining thickness 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawLineEx(System.Numerics.Vector2 startPos, System.Numerics.Vector2 endPos, float thick, Structs.Color color);

        // void DrawLineBezier(Vector2 startPos, Vector2 endPos, float thick, Structs.Color color);                   // Draw a line using cubic-bezier curves in-out 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawLineBezier(System.Numerics.Vector2 startPos, System.Numerics.Vector2 endPos, float thick, Structs.Color color);

        // void DrawLineBezierQuad(Vector2 startPos, Vector2 endPos, Vector2 controlPos, float thick, Structs.Color color); // Draw line using quadratic bezier curves with a control point 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawLineBezierQuad(System.Numerics.Vector2 startPos, System.Numerics.Vector2 endPos, System.Numerics.Vector2 controlPos, float thick, Structs.Color color);

        // void DrawLineBezierCubic(Vector2 startPos, Vector2 endPos, Vector2 startControlPos, Vector2 endControlPos, float thick, Structs.Color color); // Draw line using cubic bezier curves with 2 control points 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawLineBezierCubic(System.Numerics.Vector2 startPos, System.Numerics.Vector2 endPos, System.Numerics.Vector2 startControlPos, System.Numerics.Vector2 endControlPos, float thick, Structs.Color color);

        // void DrawLineStrip(Vector2[] points, int pointCount, Structs.Color color);                                  // Draw lines sequence 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawLineStrip(System.Numerics.Vector2[] points, int pointCount, Structs.Color color);

        // void DrawCircle(int centerX, int centerY, float radius, Structs.Color color);                              // Draw a color-filled circle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawCircle(int centerX, int centerY, float radius, Structs.Color color);

        // void DrawCircleSector(Vector2 center, float radius, float startAngle, float endAngle, int segments, Structs.Color color);      // Draw a piece of a circle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawCircleSector(System.Numerics.Vector2 center, float radius, float startAngle, float endAngle, int segments, Structs.Color color);

        // void DrawCircleSectorLines(Vector2 center, float radius, float startAngle, float endAngle, int segments, Structs.Color color); // Draw circle sector outline 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawCircleSectorLines(System.Numerics.Vector2 center, float radius, float startAngle, float endAngle, int segments, Structs.Color color);

        // void DrawCircleGradient(int centerX, int centerY, float radius, Structs.Color color1, Structs.Color color2);       // Draw a gradient-filled circle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawCircleGradient(int centerX, int centerY, float radius, Structs.Color color1, Structs.Color color2);

        // void DrawCircleV(Vector2 center, float radius, Structs.Color color);                                       // Draw a color-filled circle (Vector version) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawCircleV(System.Numerics.Vector2 center, float radius, Structs.Color color);

        // void DrawCircleLines(int centerX, int centerY, float radius, Structs.Color color);                         // Draw circle outline 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawCircleLines(int centerX, int centerY, float radius, Structs.Color color);

        // void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Structs.Color color);             // Draw ellipse 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Structs.Color color);

        // void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Structs.Color color);        // Draw ellipse outline 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Structs.Color color);

        // void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Structs.Color color); // Draw ring 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRing(System.Numerics.Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Structs.Color color);

        // void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Structs.Color color);    // Draw ring outline 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRingLines(System.Numerics.Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Structs.Color color);

        // void DrawRectangle(int posX, int posY, int width, int height, Structs.Color color);                        // Draw a color-filled rectangle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRectangle(int posX, int posY, int width, int height, Structs.Color color);

        // void DrawRectangleV(Vector2 position, Vector2 size, Structs.Color color);                                  // Draw a color-filled rectangle (Vector version) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRectangleV(System.Numerics.Vector2 position, System.Numerics.Vector2 size, Structs.Color color);

        // void DrawRectangleRec(Structs.Rectangle rec, Structs.Color color);                                                 // Draw a color-filled rectangle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRectangleRec(Structs.Rectangle rec, Structs.Color color);

        // void DrawRectanglePro(Structs.Rectangle rec, Vector2 origin, float rotation, Structs.Color color);                 // Draw a color-filled rectangle with pro parameters 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRectanglePro(Structs.Rectangle rec, System.Numerics.Vector2 origin, float rotation, Structs.Color color);

        // void DrawRectangleGradientV(int posX, int posY, int width, int height, Structs.Color color1, Structs.Color color2);// Draw a vertical-gradient-filled rectangle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRectangleGradientV(int posX, int posY, int width, int height, Structs.Color color1, Structs.Color color2);

        // void DrawRectangleGradientH(int posX, int posY, int width, int height, Structs.Color color1, Structs.Color color2);// Draw a horizontal-gradient-filled rectangle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRectangleGradientH(int posX, int posY, int width, int height, Structs.Color color1, Structs.Color color2);

        // void DrawRectangleGradientEx(Structs.Rectangle rec, Structs.Color col1, Structs.Color col2, Structs.Color col3, Structs.Color col4);       // Draw a gradient-filled rectangle with custom vertex colors 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRectangleGradientEx(Structs.Rectangle rec, Structs.Color col1, Structs.Color col2, Structs.Color col3, Structs.Color col4);

        // void DrawRectangleLines(int posX, int posY, int width, int height, Structs.Color color);                   // Draw rectangle outline 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRectangleLines(int posX, int posY, int width, int height, Structs.Color color);

        // void DrawRectangleLinesEx(Structs.Rectangle rec, float lineThick, Structs.Color color);                            // Draw rectangle outline with extended parameters 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRectangleLinesEx(Structs.Rectangle rec, float lineThick, Structs.Color color);

        // void DrawRectangleRounded(Structs.Rectangle rec, float roundness, int segments, Structs.Color color);              // Draw rectangle with rounded edges 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRectangleRounded(Structs.Rectangle rec, float roundness, int segments, Structs.Color color);

        // void DrawRectangleRoundedLines(Structs.Rectangle rec, float roundness, int segments, float lineThick, Structs.Color color); // Draw rectangle with rounded edges outline 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawRectangleRoundedLines(Structs.Rectangle rec, float roundness, int segments, float lineThick, Structs.Color color);

        // void DrawTriangle(Vector2 v1, Vector2 v2, Vector2 v3, Structs.Color color);                                // Draw a color-filled triangle (vertex in counter-clockwise order!) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTriangle(System.Numerics.Vector2 v1, System.Numerics.Vector2 v2, System.Numerics.Vector2 v3, Structs.Color color);

        // void DrawTriangleLines(Vector2 v1, Vector2 v2, Vector2 v3, Structs.Color color);                           // Draw triangle outline (vertex in counter-clockwise order!) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTriangleLines(System.Numerics.Vector2 v1, System.Numerics.Vector2 v2, System.Numerics.Vector2 v3, Structs.Color color);

        // void DrawTriangleFan(Vector2[] points, int pointCount, Structs.Color color);                                // Draw a triangle fan defined by points (first vertex is the center) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTriangleFan(System.Numerics.Vector2[] points, int pointCount, Structs.Color color);

        // void DrawTriangleStrip(Vector2[] points, int pointCount, Structs.Color color);                              // Draw a triangle strip defined by points 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTriangleStrip(System.Numerics.Vector2[] points, int pointCount, Structs.Color color);

        // void DrawPoly(Vector2 center, int sides, float radius, float rotation, Structs.Color color);               // Draw a regular polygon (Vector version) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawPoly(System.Numerics.Vector2 center, int sides, float radius, float rotation, Structs.Color color);

        // void DrawPolyLines(Vector2 center, int sides, float radius, float rotation, Structs.Color color);          // Draw a polygon outline of n sides 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawPolyLines(System.Numerics.Vector2 center, int sides, float radius, float rotation, Structs.Color color);

        // void DrawPolyLinesEx(Vector2 center, int sides, float radius, float rotation, float lineThick, Structs.Color color); // Draw a polygon outline of n sides with extended parameters 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawPolyLinesEx(System.Numerics.Vector2 center, int sides, float radius, float rotation, float lineThick, Structs.Color color);

        //  Basic shapes collision detection functions 

        // bool CheckCollisionRecs(Structs.Rectangle rec1, Structs.Rectangle rec2);                                           // Check collision between two rectangles 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool CheckCollisionRecs(Structs.Rectangle rec1, Structs.Rectangle rec2);

        // bool CheckCollisionCircles(Vector2 center1, float radius1, Vector2 center2, float radius2);        // Check collision between two circles 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool CheckCollisionCircles(System.Numerics.Vector2 center1, float radius1, System.Numerics.Vector2 center2, float radius2);

        // bool CheckCollisionCircleRec(Vector2 center, float radius, Structs.Rectangle rec);                         // Check collision between circle and rectangle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool CheckCollisionCircleRec(System.Numerics.Vector2 center, float radius, Structs.Rectangle rec);

        // bool CheckCollisionPointRec(Vector2 point, Structs.Rectangle rec);                                         // Check if point is inside rectangle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool CheckCollisionPointRec(System.Numerics.Vector2 point, Structs.Rectangle rec);

        // bool CheckCollisionPointCircle(Vector2 point, Vector2 center, float radius);                       // Check if point is inside circle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool CheckCollisionPointCircle(System.Numerics.Vector2 point, System.Numerics.Vector2 center, float radius);

        // bool CheckCollisionPointTriangle(Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3);               // Check if point is inside a triangle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool CheckCollisionPointTriangle(System.Numerics.Vector2 point, System.Numerics.Vector2 p1, System.Numerics.Vector2 p2, System.Numerics.Vector2 p3);

        // bool CheckCollisionPointPoly(Vector2 point, Vector2[] points, int pointCount);                      // Check if point is within a polygon described by array of vertices 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool CheckCollisionPointPoly(System.Numerics.Vector2 point, System.Numerics.Vector2[] points, int pointCount);

        // bool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, Vector2[] collisionPoint); // Check the collision between two lines defined by two points each, returns collision point by reference 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool CheckCollisionLines(System.Numerics.Vector2 startPos1, System.Numerics.Vector2 endPos1, System.Numerics.Vector2 startPos2, System.Numerics.Vector2 endPos2, System.Numerics.Vector2[] collisionPoint);

        // bool CheckCollisionPointLine(Vector2 point, Vector2 p1, Vector2 p2, int threshold);                // Check if point belongs to line created between two points [p1] and [p2] with defined margin in pixels [threshold] 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool CheckCollisionPointLine(System.Numerics.Vector2 point, System.Numerics.Vector2 p1, System.Numerics.Vector2 p2, int threshold);

        // Structs.Rectangle GetCollisionRec(Structs.Rectangle rec1, Structs.Rectangle rec2);                                         // Get collision rectangle for two rectangles collisio 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Rectangle GetCollisionRec(Structs.Rectangle rec1, Structs.Rectangle rec2);

        #endregion

        #region RText

        //  Structs.Font loading/unloading functions 

        // Structs.Font GetFontDefault(void);                                                            // Get the default Structs.Font 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Font GetFontDefault();

        // Structs.Font LoadFont(string fileName);                                                  // Load font from file into GPU memory (VRAM) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Font LoadFont([MarshalAs(UnmanagedType.LPStr)] string fileName);

        // Structs.Font LoadFontEx(string fileName, int fontSize, IntPtr fontChars, int glyphCount);  // Load font from file with extended parameters, use NULL for fontChars and 0 for glyphCount to load the default character set 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Font LoadFontEx([MarshalAs(UnmanagedType.LPStr)] string fileName, int fontSize, IntPtr fontChars, int glyphCount);

        // Structs.Font LoadFontFromImage(Structs.Image image, Structs.Color key, int firstChar);                        // Load font from Structs.Image (XNA style) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Font LoadFontFromImage(Structs.Image image, Structs.Color key, int firstChar);

        // Structs.Font LoadFontFromMemory(string fileType, string fileData, int dataSize, int fontSize, IntPtr fontChars, int glyphCount); // Load font from memory buffer, fileType refers to extension: i.e. '.ttf' 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Font LoadFontFromMemory([MarshalAs(UnmanagedType.LPStr)] string fileType, [MarshalAs(UnmanagedType.LPStr)] string fileData, int dataSize, int fontSize, IntPtr fontChars, int glyphCount);

        // bool IsFontReady(Structs.Font font);                                                          // Check if a font is ready 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsFontReady(Structs.Font font);

        // Structs.GlyphInfo[] LoadFontData(string fileData, int dataSize, int fontSize, IntPtr fontChars, int glyphCount, int type); // Load font data for further use 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.GlyphInfo[] LoadFontData([MarshalAs(UnmanagedType.LPStr)] string fileData, int dataSize, int fontSize, IntPtr fontChars, int glyphCount, int type);

        // Structs.Image GenImageFontAtlas(Structs.GlyphInfo[] chars, Structs.Rectangle **recs, int glyphCount, int fontSize, int padding, int packMethod); // Generate image font atlas using chars info 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe Structs.Image GenImageFontAtlas(Structs.GlyphInfo[] chars, Structs.Rectangle[]* recs, int glyphCount, int fontSize, int padding, int packMethod);

        // void UnloadFontData(Structs.GlyphInfo[] chars, int glyphCount);                                // Unload font chars info data (RAM) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadFontData(Structs.GlyphInfo[] chars, int glyphCount);

        // void UnloadFont(Structs.Font font);                                                           // Unload font from GPU memory (VRAM) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadFont(Structs.Font font);

        // bool ExportFontAsCode(Structs.Font font, string fileName);                               // Export font as code file, returns true on success 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool ExportFontAsCode(Structs.Font font, [MarshalAs(UnmanagedType.LPStr)] string fileName);

        //  Text drawing functions 

        // void DrawFPS(int posX, int posY);                                                     // Draw current FPS 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawFPS(int posX, int posY);

        // void DrawText(string text, int posX, int posY, int fontSize, Structs.Color color);       // Draw text (using default font) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawText([MarshalAs(UnmanagedType.LPStr)] string text, int posX, int posY, int fontSize, Structs.Color color);

        // void DrawTextEx(Structs.Font font, string text, Vector2 position, float fontSize, float spacing, Structs.Color tint); // Draw text using font and additional parameters 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTextEx(Structs.Font font, [MarshalAs(UnmanagedType.LPStr)] string text, System.Numerics.Vector2 position, float fontSize, float spacing, Structs.Color tint);

        // void DrawTextPro(Structs.Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Structs.Color tint); // Draw text using Structs.Font and pro parameters (rotation) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTextPro(Structs.Font font, [MarshalAs(UnmanagedType.LPStr)] string text, System.Numerics.Vector2 position, System.Numerics.Vector2 origin, float rotation, float fontSize, float spacing, Structs.Color tint);

        // void DrawTextCodepoint(Structs.Font font, int codepoint, Vector2 position, float fontSize, Structs.Color tint); // Draw one character (codepoint) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTextCodepoint(Structs.Font font, int codepoint, System.Numerics.Vector2 position, float fontSize, Structs.Color tint);

        // void DrawTextCodepoints(Structs.Font font, IntPtr codepoints, int count, Vector2 position, float fontSize, float spacing, Structs.Color tint); // Draw multiple character (codepoint) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTextCodepoints(Structs.Font font, IntPtr codepoints, int count, System.Numerics.Vector2 position, float fontSize, float spacing, Structs.Color tint);

        //  Text font info functions 

        // int MeasureText(string text, int fontSize);                                      // Measure string width for default font 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int MeasureText([MarshalAs(UnmanagedType.LPStr)] string text, int fontSize);

        // Vector2 MeasureTextEx(Structs.Font font, string text, float fontSize, float spacing);    // Measure string size for Structs.Font 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 MeasureTextEx(Structs.Font font, [MarshalAs(UnmanagedType.LPStr)] string text, float fontSize, float spacing);

        // int GetGlyphIndex(Structs.Font font, int codepoint);                                          // Get glyph index position in font for a codepoint (unicode character), fallback to '?' if not found 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetGlyphIndex(Structs.Font font, int codepoint);

        // Structs.GlyphInfo GetGlyphInfo(Structs.Font font, int codepoint);                                     // Get glyph font info data for a codepoint (unicode character), fallback to '?' if not found 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.GlyphInfo GetGlyphInfo(Structs.Font font, int codepoint);

        // Structs.Rectangle GetGlyphAtlasRec(Structs.Font font, int codepoint);                                 // Get glyph rectangle in font atlas for a codepoint (unicode character), fallback to '?' if not found 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Rectangle GetGlyphAtlasRec(Structs.Font font, int codepoint);

        //  Text codepoints management functions (unicode characters) 

        // string LoadUTF8(IntPtr codepoints, int length);                // Load UTF-8 text encoded from codepoints array 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string LoadUTF8(IntPtr codepoints, int length);

        // void UnloadUTF8(string text);                                      // Unload UTF-8 text encoded from codepoints array 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadUTF8([MarshalAs(UnmanagedType.LPStr)] string text);

        // IntPtr LoadCodepoints(string text, IntPtr count);                // Load all codepoints from a UTF-8 text string, codepoints count returned by parameter 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr LoadCodepoints([MarshalAs(UnmanagedType.LPStr)] string text, IntPtr count);

        // void UnloadCodepoints(IntPtr codepoints);                           // Unload codepoints data from memory 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadCodepoints(IntPtr codepoints);

        // int GetCodepointCount(string text);                          // Get total number of codepoints in a UTF-8 encoded string 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetCodepointCount([MarshalAs(UnmanagedType.LPStr)] string text);

        // int GetCodepoint(string text, IntPtr codepointSize);           // Get next codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetCodepoint([MarshalAs(UnmanagedType.LPStr)] string text, int codepointSize);

        // int GetCodepointNext(string text, IntPtr codepointSize);       // Get next codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetCodepointNext([MarshalAs(UnmanagedType.LPStr)] string text, int codepointSize);

        // int GetCodepointPrevious(string text, IntPtr codepointSize);   // Get previous codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetCodepointPrevious([MarshalAs(UnmanagedType.LPStr)] string text, int codepointSize);

        // string CodepointToUTF8(int codepoint, IntPtr utf8Size);        // Encode one codepoint into UTF-8 byte array (array length returned as parameter) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string CodepointToUTF8(int codepoint, int utf8Size);

        //  Text strings management functions (no UTF-8 strings, only byte chars) 

        //  NOTE: Some strings allocate memory internally for returned strings, just be careful! 

        // int TextCopy(string dst, string src);                                             // Copy one string to another, returns bytes copied 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int TextCopy([MarshalAs(UnmanagedType.LPStr)] string dst, [MarshalAs(UnmanagedType.LPStr)] string src);

        // bool TextIsEqual(string text1, string text2);                               // Check if two text string are equal 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool TextIsEqual([MarshalAs(UnmanagedType.LPStr)] string text1, [MarshalAs(UnmanagedType.LPStr)] string text2);

        // uint TextLength(string text);                                            // Get text length, checks for '\0' ending 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static uint TextLength([MarshalAs(UnmanagedType.LPStr)] string text);

        // string TextFormat(string text, __arglist);                                        // Text formatting with variables (sprintf() style) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string TextFormat([MarshalAs(UnmanagedType.LPStr)] string text, __arglist);

        // string TextSubtext(string text, int position, int length);                  // Get a piece of a text string 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string TextSubtext([MarshalAs(UnmanagedType.LPStr)] string text, int position, int length);

        // string TextReplace(string text, string replace, string by);                   // Replace text string (WARNING: memory must be freed!) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string TextReplace([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string replace, [MarshalAs(UnmanagedType.LPStr)] string by);

        // string TextInsert(string text, string insert, int position);                 // Insert text in a position (WARNING: memory must be freed!) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string TextInsert([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string insert, int position);

        // string TextJoin(string *textList, int count, string delimiter);        // Join text strings with delimiter 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string TextJoin([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] textList, int count, [MarshalAs(UnmanagedType.LPStr)] string delimiter);

        // string *TextSplit(string text, char delimiter, IntPtr count);                 // Split text into multiple strings 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)]
        public extern static string[] TextSplit([MarshalAs(UnmanagedType.LPStr)] string text, char delimiter, int count);

        // void TextAppend(string text, string append, IntPtr position);                       // Append text at specific position and move cursor! 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void TextAppend([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string append, int position);

        // int TextFindIndex(string text, string find);                                // Find first text occurrence within a string 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int TextFindIndex([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string find);

        // string TextToUpper(string text);                      // Get upper case version of provided string 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string TextToUpper([MarshalAs(UnmanagedType.LPStr)] string text);

        // string TextToLower(string text);                      // Get lower case version of provided string 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string TextToLower([MarshalAs(UnmanagedType.LPStr)] string text);

        // string TextToPascal(string text);                     // Get Pascal case notation version of provided string 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public extern static string TextToPascal([MarshalAs(UnmanagedType.LPStr)] string text);

        // int TextToInteger(string text);                            // Get integer value from text (negative values not supported 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int TextToInteger([MarshalAs(UnmanagedType.LPStr)] string text);

        #endregion

        #region RTextures

        //  Structs.Image loading functions 

        //  NOTE: These functions do not require GPU access 

        // Structs.Image LoadImage(string fileName);                                                             // Load image from file into CPU memory (RAM) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image LoadImage([MarshalAs(UnmanagedType.LPStr)] string fileName);

        // Structs.Image LoadImageRaw(string fileName, int width, int height, int format, int headerSize);       // Load image from RAW file data 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image LoadImageRaw([MarshalAs(UnmanagedType.LPStr)] string fileName, int width, int height, int format, int headerSize);

        // Structs.Image LoadImageAnim(string fileName, IntPtr frames);                                            // Load image sequence from file (frames appended to image.data) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image LoadImageAnim([MarshalAs(UnmanagedType.LPStr)] string fileName, IntPtr frames);

        // Structs.Image LoadImageFromMemory(string fileType, string fileData, int dataSize);      // Load image from memory buffer, fileType refers to extension: i.e. '.png' 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image LoadImageFromMemory([MarshalAs(UnmanagedType.LPStr)] string fileType, [MarshalAs(UnmanagedType.LPStr)] string fileData, int dataSize);

        // Structs.Image LoadImageFromTexture(Structs.Texture2D texture);                                                     // Load image from GPU texture data 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image LoadImageFromTexture(Structs.Texture2D texture);

        // Structs.Image LoadImageFromScreen(void);                                                                   // Load image from screen buffer and (screenshot) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image LoadImageFromScreen();

        // bool IsImageReady(Structs.Image image);                                                                    // Check if an image is ready 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsImageReady(Structs.Image image);

        // void UnloadImage(Structs.Image image);                                                                     // Unload image from CPU memory (RAM) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadImage(Structs.Image image);

        // bool ExportImage(Structs.Image image, string fileName);                                               // Export image data to file, returns true on success 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool ExportImage(Structs.Image image, [MarshalAs(UnmanagedType.LPStr)] string fileName);

        // bool ExportImageAsCode(Structs.Image image, string fileName);                                         // Export image as code file defining an array of bytes, returns true on success 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool ExportImageAsCode(Structs.Image image, [MarshalAs(UnmanagedType.LPStr)] string fileName);

        //  Structs.Image generation functions 

        // Structs.Image GenImageColor(int width, int height, Structs.Color color);                                           // Generate image: plain color 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image GenImageColor(int width, int height, Structs.Color color);

        // Structs.Image GenImageGradientLinear(int width, int height, int direction, Structs.Color start, Structs.Color end);        // Generate image: linear gradient, direction in degrees [0..360], 0=Vertical gradient 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image GenImageGradientLinear(int width, int height, int direction, Structs.Color start, Structs.Color end);

        // Structs.Image GenImageGradientRadial(int width, int height, float density, Structs.Color inner, Structs.Color outer);      // Generate image: radial gradient 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image GenImageGradientRadial(int width, int height, float density, Structs.Color inner, Structs.Color outer);

        // Structs.Image GenImageGradientSquare(int width, int height, float density, Structs.Color inner, Structs.Color outer);      // Generate image: square gradient 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image GenImageGradientSquare(int width, int height, float density, Structs.Color inner, Structs.Color outer);

        // Structs.Image GenImageChecked(int width, int height, int checksX, int checksY, Structs.Color col1, Structs.Color col2);    // Generate image: checked 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image GenImageChecked(int width, int height, int checksX, int checksY, Structs.Color col1, Structs.Color col2);

        // Structs.Image GenImageWhiteNoise(int width, int height, float factor);                                     // Generate image: white noise 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image GenImageWhiteNoise(int width, int height, float factor);

        // Structs.Image GenImagePerlinNoise(int width, int height, int offsetX, int offsetY, float scale);           // Generate image: perlin noise 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image GenImagePerlinNoise(int width, int height, int offsetX, int offsetY, float scale);

        // Structs.Image GenImageCellular(int width, int height, int tileSize);                                       // Generate image: cellular algorithm, bigger tileSize means bigger cells 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image GenImageCellular(int width, int height, int tileSize);

        // Structs.Image GenImageText(int width, int height, string text);                                       // Generate image: grayscale image from text data 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image GenImageText(int width, int height, [MarshalAs(UnmanagedType.LPStr)] string text);

        //  Structs.Image manipulation functions 

        // Structs.Image Structs.ImageCopy(Structs.Image image);                                                                      // Create an image duplicate (useful for transformations) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image ImageCopy(Structs.Image image);

        // Structs.Image Structs.ImageFromImage(Structs.Image image, Structs.Rectangle rec);                                                  // Create an image from another image piece 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image ImageFromImage(Structs.Image image, Structs.Rectangle rec);

        // Structs.Image Structs.ImageText(string text, int fontSize, Structs.Color color);                                      // Create an image from text (default font) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image ImageText([MarshalAs(UnmanagedType.LPStr)] string text, int fontSize, Structs.Color color);

        // Structs.Image Structs.ImageTextEx(Structs.Font font, string text, float fontSize, float spacing, Structs.Color tint);         // Create an image from text (custom sprite font) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Image ImageTextEx(Structs.Font font, [MarshalAs(UnmanagedType.LPStr)] string text, float fontSize, float spacing, Structs.Color tint);

        // void Structs.ImageFormat(Structs.Image[] image, int newFormat);                                                     // Convert image data to desired format 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageFormat(Structs.Image[] image, int newFormat);

        // void Structs.ImageToPOT(Structs.Image[] image, Structs.Color fill);                                                         // Convert image to POT (power-of-two) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageToPOT(Structs.Image[] image, Structs.Color fill);

        // void Structs.ImageCrop(Structs.Image[] image, Structs.Rectangle crop);                                                      // Crop an image to a defined rectangle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageCrop(Structs.Image[] image, Structs.Rectangle crop);

        // void Structs.ImageAlphaCrop(Structs.Image[] image, float threshold);                                                // Crop image depending on alpha value 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageAlphaCrop(Structs.Image[] image, float threshold);

        // void Structs.ImageAlphaClear(Structs.Image[] image, Structs.Color color, float threshold);                                  // Clear alpha channel to desired color 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageAlphaClear(Structs.Image[] image, Structs.Color color, float threshold);

        // void Structs.ImageAlphaMask(Structs.Image[] image, Structs.Image alphaMask);                                                // Apply alpha mask to image 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageAlphaMask(Structs.Image[] image, Structs.Image alphaMask);

        // void Structs.ImageAlphaPremultiply(Structs.Image[] image);                                                          // Premultiply alpha channel 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageAlphaPremultiply(Structs.Image[] image);

        // void Structs.ImageBlurGaussian(Structs.Image[] image, int blurSize);                                                // Apply Gaussian blur using a box blur approximation 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageBlurGaussian(Structs.Image[] image, int blurSize);

        // void Structs.ImageResize(Structs.Image[] image, int newWidth, int newHeight);                                       // Resize image (Bicubic scaling algorithm) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageResize(Structs.Image[] image, int newWidth, int newHeight);

        // void Structs.ImageResizeNN(Structs.Image[] image, int newWidth,int newHeight);                                      // Resize image (Nearest-Neighbor scaling algorithm) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageResizeNN(Structs.Image[] image, int newWidth, int newHeight);

        // void Structs.ImageResizeCanvas(Structs.Image[] image, int newWidth, int newHeight, int offsetX, int offsetY, Structs.Color fill);  // Resize canvas and fill with color 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageResizeCanvas(Structs.Image[] image, int newWidth, int newHeight, int offsetX, int offsetY, Structs.Color fill);

        // void Structs.ImageMipmaps(Structs.Image[] image);                                                                   // Compute all mipmap levels for a provided image 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageMipmaps(Structs.Image[] image);

        // void Structs.ImageDither(Structs.Image[] image, int rBpp, int gBpp, int bBpp, int aBpp);                            // Dither image data to 16bpp or lower (Floyd-Steinberg dithering) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDither(Structs.Image[] image, int rBpp, int gBpp, int bBpp, int aBpp);

        // void Structs.ImageFlipVertical(Structs.Image[] image);                                                              // Flip image vertically 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageFlipVertical(Structs.Image[] image);

        // void Structs.ImageFlipHorizontal(Structs.Image[] image);                                                            // Flip image horizontally 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageFlipHorizontal(Structs.Image[] image);

        // void Structs.ImageRotate(Structs.Image[] image, int degrees);                                                       // Rotate image by input angle in degrees (-359 to 359)  
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageRotate(Structs.Image[] image, int degrees);

        // void Structs.ImageRotateCW(Structs.Image[] image);                                                                  // Rotate image clockwise 90deg 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageRotateCW(Structs.Image[] image);

        // void Structs.ImageRotateCCW(Structs.Image[] image);                                                                 // Rotate image counter-clockwise 90deg 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageRotateCCW(Structs.Image[] image);

        // void Structs.ImageColorTint(Structs.Image[] image, Structs.Color color);                                                    // Modify image color: tint 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageColorTint(Structs.Image[] image, Structs.Color color);

        // void Structs.ImageColorInvert(Structs.Image[] image);                                                               // Modify image color: invert 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageColorInvert(Structs.Image[] image);

        // void Structs.ImageColorGrayscale(Structs.Image[] image);                                                            // Modify image color: grayscale 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageColorGrayscale(Structs.Image[] image);

        // void Structs.ImageColorContrast(Structs.Image[] image, float contrast);                                             // Modify image color: contrast (-100 to 100) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageColorContrast(Structs.Image[] image, float contrast);

        // void Structs.ImageColorBrightness(Structs.Image[] image, int brightness);                                           // Modify image color: brightness (-255 to 255) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageColorBrightness(Structs.Image[] image, int brightness);

        // void Structs.ImageColorReplace(Structs.Image[] image, Structs.Color color, Structs.Color replace);                                  // Modify image color: replace color 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageColorReplace(Structs.Image[] image, Structs.Color color, Structs.Color replace);

        // Structs.Color *LoadImageColors(Structs.Image image);                                                               // Load color data from image as a Structs.Color array (RGBA - 32bit) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color[] LoadImageColors(Structs.Image image);

        // Structs.Color *LoadImagePalette(Structs.Image image, int maxPaletteSize, int colorCount);                         // Load colors palette from image as a Structs.Color array (RGBA - 32bit) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color[] LoadImagePalette(Structs.Image image, int maxPaletteSize, int colorCount);

        // void UnloadImageColors(Structs.Color *colors);                                                             // Unload color data loaded with LoadImageColors() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadImageColors(Structs.Color[] colors);

        // void UnloadImagePalette(Structs.Color *colors);                                                            // Unload colors palette loaded with LoadImagePalette() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadImagePalette(Structs.Color[] colors);

        // Structs.Rectangle GetImageAlphaBorder(Structs.Image image, float threshold);                                       // Get image alpha border rectangle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Rectangle GetImageAlphaBorder(Structs.Image image, float threshold);

        // Structs.Color GetImageColor(Structs.Image image, int x, int y);                                                    // Get image pixel color at (x, y) position 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color GetImageColor(Structs.Image image, int x, int y);

        //  Structs.Image drawing functions 

        //  NOTE: Structs.Image software-rendering functions (CPU) 

        // void Structs.ImageClearBackground(Structs.Image[] dst, Structs.Color color);                                                // Clear image background with given color 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageClearBackground(Structs.Image[] dst, Structs.Color color);

        // void Structs.ImageDrawPixel(Structs.Image[] dst, int posX, int posY, Structs.Color color);                                  // Draw pixel within an image 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawPixel(Structs.Image[] dst, int posX, int posY, Structs.Color color);

        // void Structs.ImageDrawPixelV(Structs.Image[] dst, Vector2 position, Structs.Color color);                                   // Draw pixel within an image (Vector version) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawPixelV(Structs.Image[] dst, System.Numerics.Vector2 position, Structs.Color color);

        // void Structs.ImageDrawLine(Structs.Image[] dst, int startPosX, int startPosY, int endPosX, int endPosY, Structs.Color color); // Draw line within an image 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawLine(Structs.Image[] dst, int startPosX, int startPosY, int endPosX, int endPosY, Structs.Color color);

        // void Structs.ImageDrawLineV(Structs.Image[] dst, Vector2 start, Vector2 end, Structs.Color color);                          // Draw line within an image (Vector version) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawLineV(Structs.Image[] dst, System.Numerics.Vector2 start, System.Numerics.Vector2 end, Structs.Color color);

        // void Structs.ImageDrawCircle(Structs.Image[] dst, int centerX, int centerY, int radius, Structs.Color color);               // Draw a filled circle within an image 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawCircle(Structs.Image[] dst, int centerX, int centerY, int radius, Structs.Color color);

        // void Structs.ImageDrawCircleV(Structs.Image[] dst, Vector2 center, int radius, Structs.Color color);                        // Draw a filled circle within an image (Vector version) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawCircleV(Structs.Image[] dst, System.Numerics.Vector2 center, int radius, Structs.Color color);

        // void Structs.ImageDrawCircleLines(Structs.Image[] dst, int centerX, int centerY, int radius, Structs.Color color);          // Draw circle outline within an image 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawCircleLines(Structs.Image[] dst, int centerX, int centerY, int radius, Structs.Color color);

        // void Structs.ImageDrawCircleLinesV(Structs.Image[] dst, Vector2 center, int radius, Structs.Color color);                   // Draw circle outline within an image (Vector version) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawCircleLinesV(Structs.Image[] dst, System.Numerics.Vector2 center, int radius, Structs.Color color);

        // void Structs.ImageDrawRectangle(Structs.Image[] dst, int posX, int posY, int width, int height, Structs.Color color);       // Draw rectangle within an image 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawRectangle(Structs.Image[] dst, int posX, int posY, int width, int height, Structs.Color color);

        // void Structs.ImageDrawRectangleV(Structs.Image[] dst, Vector2 position, Vector2 size, Structs.Color color);                 // Draw rectangle within an image (Vector version) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawRectangleV(Structs.Image[] dst, System.Numerics.Vector2 position, System.Numerics.Vector2 size, Structs.Color color);

        // void Structs.ImageDrawRectangleRec(Structs.Image[] dst, Structs.Rectangle rec, Structs.Color color);                                // Draw rectangle within an image 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawRectangleRec(Structs.Image[] dst, Structs.Rectangle rec, Structs.Color color);

        // void Structs.ImageDrawRectangleLines(Structs.Image[] dst, Structs.Rectangle rec, int thick, Structs.Color color);                   // Draw rectangle lines within an image 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawRectangleLines(Structs.Image[] dst, Structs.Rectangle rec, int thick, Structs.Color color);

        // void Structs.ImageDraw(Structs.Image[] dst, Structs.Image src, Structs.Rectangle srcRec, Structs.Rectangle dstRec, Structs.Color tint);             // Draw a source image within a destination image (tint applied to source) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDraw(Structs.Image[] dst, Structs.Image src, Structs.Rectangle srcRec, Structs.Rectangle dstRec, Structs.Color tint);

        // void Structs.ImageDrawText(Structs.Image[] dst, string text, int posX, int posY, int fontSize, Structs.Color color);   // Draw text (using default font) within an image (destination) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawText(Structs.Image[] dst, [MarshalAs(UnmanagedType.LPStr)] string text, int posX, int posY, int fontSize, Structs.Color color);

        // void Structs.ImageDrawTextEx(Structs.Image[] dst, Structs.Font font, string text, Vector2 position, float fontSize, float spacing, Structs.Color tint); // Draw text (custom sprite font) within an image (destination) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ImageDrawTextEx(Structs.Image[] dst, Structs.Font font, [MarshalAs(UnmanagedType.LPStr)] string text, System.Numerics.Vector2 position, float fontSize, float spacing, Structs.Color tint);

        //  Texture loading functions 

        //  NOTE: These functions require GPU access 

        // Structs.Texture2D LoadTexture(string fileName);                                                       // Load texture from file into GPU memory (VRAM) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Texture2D LoadTexture([MarshalAs(UnmanagedType.LPStr)] string fileName);

        // Structs.Texture2D LoadTextureFromImage(Structs.Image image);                                                       // Load texture from image data 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Texture2D LoadTextureFromImage(Structs.Image image);

        // TextureCubemap LoadTextureCubemap(Structs.Image image, int layout);                                        // Load cubemap from image, multiple image cubemap layouts supported 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Texture2D LoadTextureCubemap(Structs.Image image, int layout);

        // Structs.RenderTexture2D LoadRenderTexture(int width, int height);                                          // Load texture for rendering (framebuffer) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.RenderTexture2D LoadRenderTexture(int width, int height);

        // bool IsTextureReady(Structs.Texture2D texture);                                                            // Check if a texture is ready 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsTextureReady(Structs.Texture2D texture);

        // void UnloadTexture(Structs.Texture2D texture);                                                             // Unload texture from GPU memory (VRAM) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadTexture(Structs.Texture2D texture);

        // bool IsRenderTextureReady(Structs.RenderTexture2D target);                                                       // Check if a render texture is ready 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsRenderTextureReady(Structs.RenderTexture2D target);

        // void UnloadRenderTexture(Structs.RenderTexture2D target);                                                  // Unload render texture from GPU memory (VRAM) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadRenderTexture(Structs.RenderTexture2D target);

        // void UpdateTexture(Structs.Texture2D texture, void* pixels);                                         // Update GPU texture with new data 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe void UpdateTexture(Structs.Texture2D texture, void* pixels);

        // void UpdateTextureRec(Structs.Texture2D texture, Structs.Rectangle rec, void* pixels);                       // Update GPU texture rectangle with new data 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe void UpdateTextureRec(Structs.Texture2D texture, Structs.Rectangle rec, void* pixels);

        //  Texture configuration functions 

        // void GenTextureMipmaps(Structs.Texture2D *texture);                                                        // Generate GPU mipmaps for a texture 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void GenTextureMipmaps(Structs.Texture2D[] texture);

        // void SetTextureFilter(Structs.Texture2D texture, int filter);                                              // Set texture scaling filter mode 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetTextureFilter(Structs.Texture2D texture, int filter);

        // void SetTextureWrap(Structs.Texture2D texture, int wrap);                                                  // Set texture wrapping mode 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetTextureWrap(Structs.Texture2D texture, int wrap);

        //  Texture drawing functions 

        // void DrawTexture(Structs.Texture2D texture, int posX, int posY, Structs.Color tint);                               // Draw a Structs.Texture2D 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTexture(Structs.Texture2D texture, int posX, int posY, Structs.Color tint);

        // void DrawTextureV(Structs.Texture2D texture, Vector2 position, Structs.Color tint);                                // Draw a Structs.Texture2D with position defined as Vector2 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTextureV(Structs.Texture2D texture, System.Numerics.Vector2 position, Structs.Color tint);

        // void DrawTextureEx(Structs.Texture2D texture, Vector2 position, float rotation, float scale, Structs.Color tint);  // Draw a Structs.Texture2D with extended parameters 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTextureEx(Structs.Texture2D texture, System.Numerics.Vector2 position, float rotation, float scale, Structs.Color tint);

        // void DrawTextureRec(Structs.Texture2D texture, Structs.Rectangle source, Vector2 position, Structs.Color tint);            // Draw a part of a texture defined by a rectangle 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTextureRec(Structs.Texture2D texture, Structs.Rectangle source, System.Numerics.Vector2 position, Structs.Color tint);

        // void DrawTexturePro(Structs.Texture2D texture, Structs.Rectangle source, Structs.Rectangle dest, Vector2 origin, float rotation, Structs.Color tint); // Draw a part of a texture defined by a rectangle with 'pro' parameters 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTexturePro(Structs.Texture2D texture, Structs.Rectangle source, Structs.Rectangle dest, System.Numerics.Vector2 origin, float rotation, Structs.Color tint);

        // void DrawTextureNPatch(Structs.Texture2D texture, NPatchInfo nPatchInfo, Structs.Rectangle dest, Vector2 origin, float rotation, Structs.Color tint); // Draws a texture (or part of it) that stretches or shrinks nicely 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void DrawTextureNPatch(Structs.Texture2D texture, NPatchInfo nPatchInfo, Structs.Rectangle dest, System.Numerics.Vector2 origin, float rotation, Structs.Color tint);

        //  Structs.Color/pixel related functions 

        // Structs.Color Fade(Structs.Color color, float alpha);                                 // Get color with alpha applied, alpha goes from 0.0f to 1.0f 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color Fade(Structs.Color color, float alpha);

        // int Structs.ColorToInt(Structs.Color color);                                          // Get hexadecimal value for a Structs.Color 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int ColorToInt(Structs.Color color);

        // Vector4 Structs.ColorNormalize(Structs.Color color);                                  // Get Structs.Color normalized as float [0..1] 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Vector4 ColorNormalize(Structs.Color color);

        // Structs.Color Structs.ColorFromNormalized(Vector4 normalized);                        // Get Structs.Color from normalized values [0..1] 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color ColorFromNormalized(Vector4 normalized);

        // System.Numerics.Vector3 Structs.ColorToHSV(Structs.Color color);                                      // Get HSV values for a Structs.Color, hue [0..360], saturation/value [0..1] 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector3 ColorToHSV(Structs.Color color);

        // Structs.Color Structs.ColorFromHSV(float hue, float saturation, float value);         // Get a Structs.Color from HSV values, hue [0..360], saturation/value [0..1] 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color ColorFromHSV(float hue, float saturation, float value);

        // Structs.Color Structs.ColorTint(Structs.Color color, Structs.Color tint);                             // Get color multiplied with another color 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color ColorTint(Structs.Color color, Structs.Color tint);

        // Structs.Color Structs.ColorBrightness(Structs.Color color, float factor);                     // Get color with brightness correction, brightness factor goes from -1.0f to 1.0f 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color ColorBrightness(Structs.Color color, float factor);

        // Structs.Color Structs.ColorContrast(Structs.Color color, float contrast);                     // Get color with contrast correction, contrast values between -1.0f and 1.0f 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color ColorContrast(Structs.Color color, float contrast);

        // Structs.Color Structs.ColorAlpha(Structs.Color color, float alpha);                           // Get color with alpha applied, alpha goes from 0.0f to 1.0f 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color ColorAlpha(Structs.Color color, float alpha);

        // Structs.Color Structs.ColorAlphaBlend(Structs.Color dst, Structs.Color src, Structs.Color tint);              // Get src alpha-blended into dst color with tint 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color ColorAlphaBlend(Structs.Color dst, Structs.Color src, Structs.Color tint);

        // Structs.Color GetColor(uint hexValue);                                // Get Structs.Color structure from hexadecimal value 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color GetColor(uint hexValue);

        // Structs.Color GetPixelColor(void *srcPtr, int format);                        // Get Structs.Color from a source pixel pointer of certain format 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Structs.Color GetPixelColor();

        // void SetPixelColor(void *dstPtr, Structs.Color color, int format);            // Set color formatted into destination pixel pointer 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetPixelColor();

        // int GetPixelDataSize(int width, int height, int format);              // Get pixel data size in bytes for certain forma 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetPixelDataSize(int width, int height, int format);

        #endregion

        public static void Main(string[] args)
        {
            InitWindow(800, 600, "test");
            while (!WindowShouldClose())
            {
                BeginDrawing();
                ClearBackground(Structs.Color.BLACK);
                DrawText("test", 100, 100, 50, Structs.Color.WHITE);
                DrawFPS(10, 10);
                EndDrawing();
            }
            CloseWindow();
        }

    }
}
