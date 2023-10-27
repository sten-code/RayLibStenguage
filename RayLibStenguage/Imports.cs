using Raylib_cs;
using System.Numerics;
using System.Runtime.InteropServices;

namespace RayLibStenguage
{
    public class Imports
    {
        public const string LibName = "raylib.dll";

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

        // void SetWindowIcon(Image image);                            // Set icon for window (single image, RGBA 32bit, only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetWindowIcon(Image image);

        // void SetWindowIcons(Image[] images, int count);              // Set icon for window (multiple images, RGBA 32bit, only PLATFORM_DESKTOP) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetWindowIcons(Image[] images, int count);

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
        public extern static unsafe void* GetWindowHandle();

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
        public extern static string GetMonitorName(int monitor);

        // void SetClipboardText(string text);                    // Set clipboard text content 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetClipboardText([MarshalAs(UnmanagedType.LPStr)] string text);

        // string GetClipboardText(void);                         // Get clipboard text content 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
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

        // void ClearBackground(Color color);                          // Set background color (framebuffer clear color) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ClearBackground(Color color);

        // void BeginDrawing(void);                                    // Setup canvas (framebuffer) to start drawing 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginDrawing();

        // void EndDrawing(void);                                      // End canvas drawing and swap buffers (double buffering) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndDrawing();

        // void BeginMode2D(Camera2D camera);                          // Begin 2D mode with custom camera (2D) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginMode2D(Camera2D camera);

        // void EndMode2D(void);                                       // Ends 2D mode with custom camera 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndMode2D();

        // void BeginMode3D(Camera3D camera);                          // Begin 3D mode with custom camera (3D) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginMode3D(Camera3D camera);

        // void EndMode3D(void);                                       // Ends 3D mode and returns to default 2D orthographic mode 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndMode3D();

        // void BeginTextureMode(RenderTexture2D target);              // Begin drawing to render texture 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginTextureMode(RenderTexture2D target);

        // void EndTextureMode(void);                                  // Ends drawing to render texture 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndTextureMode();

        // void BeginShaderMode(Shader shader);                        // Begin custom shader drawing 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginShaderMode(Shader shader);

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

        // void BeginVrStereoMode(VrStereoConfig config);              // Begin stereo rendering (requires VR simulator) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BeginVrStereoMode(VrStereoConfig config);

        // void EndVrStereoMode(void);                                 // End stereo rendering (requires VR simulator) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void EndVrStereoMode();

        //  VR stereo config functions for VR simulator 

        // VrStereoConfig LoadVrStereoConfig(VrDeviceInfo device);     // Load VR stereo config for VR simulator device parameters 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static VrStereoConfig LoadVrStereoConfig(VrDeviceInfo device);

        // void UnloadVrStereoConfig(VrStereoConfig config);           // Unload VR stereo config 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadVrStereoConfig(VrStereoConfig config);

        //  Shader management functions 

        //  NOTE: Shader functionality is not available on OpenGL 1.1 

        // Shader LoadShader(string vsFileName, string fsFileName);   // Load shader from files and bind default locations 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Shader LoadShader([MarshalAs(UnmanagedType.LPStr)] string vsFileName, [MarshalAs(UnmanagedType.LPStr)] string fsFileName);

        // Shader LoadShaderFromMemory(string vsCode, string fsCode); // Load shader from code strings and bind default locations 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Shader LoadShaderFromMemory([MarshalAs(UnmanagedType.LPStr)] string vsCode, [MarshalAs(UnmanagedType.LPStr)] string fsCode);

        // bool IsShaderReady(Shader shader);                                   // Check if a shader is ready 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsShaderReady(Shader shader);

        // int GetShaderLocation(Shader shader, string uniformName);       // Get shader uniform location 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetShaderLocation(Shader shader, [MarshalAs(UnmanagedType.LPStr)] string uniformName);

        // int GetShaderLocationAttrib(Shader shader, string attribName);  // Get shader attribute location 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetShaderLocationAttrib(Shader shader, [MarshalAs(UnmanagedType.LPStr)] string attribName);

        // void SetShaderValue(Shader shader, int locIndex, void* value, int uniformType);               // Set shader uniform value 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe void SetShaderValue(Shader shader, int locIndex, void* value, int uniformType);

        // void SetShaderValueV(Shader shader, int locIndex, void* value, int uniformType, int count);   // Set shader uniform value vector 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe void SetShaderValueV(Shader shader, int locIndex, void* value, int uniformType, int count);

        // void SetShaderValueMatrix(Shader shader, int locIndex, Matrix mat);         // Set shader uniform value (matrix 4x4) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetShaderValueMatrix(Shader shader, int locIndex, Matrix4x4 mat);

        // void SetShaderValueTexture(Shader shader, int locIndex, Texture2D texture); // Set shader uniform value for texture (sampler2d) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetShaderValueTexture(Shader shader, int locIndex, Texture2D texture);

        // void UnloadShader(Shader shader);                                    // Unload shader from GPU memory (VRAM) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadShader(Shader shader);

        //  Screen-space-related functions 

        // Ray GetMouseRay(Vector2 mousePosition, Camera camera);      // Get a ray trace from mouse position 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Ray GetMouseRay(System.Numerics.Vector2 mousePosition, Camera3D camera);

        // Matrix GetCameraMatrix(Camera camera);                      // Get camera transform matrix (view matrix) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Matrix4x4 GetCameraMatrix(Camera3D camera);

        // Matrix GetCameraMatrix2D(Camera2D camera);                  // Get camera 2d transform matrix 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static Matrix4x4 GetCameraMatrix2D(Camera2D camera);

        // Vector2 GetWorldToScreen(Vector3 position, Camera camera);  // Get the screen space position for a 3d world space position 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetWorldToScreen(Vector3 position, Camera3D camera);

        // Vector2 GetScreenToWorld2D(Vector2 position, Camera2D camera); // Get the world space position for a 2d camera screen space position 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetScreenToWorld2D(System.Numerics.Vector2 position, Camera2D camera);

        // Vector2 GetWorldToScreenEx(Vector3 position, Camera camera, int width, int height); // Get size position for a 3d world space position 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetWorldToScreenEx(Vector3 position, Camera3D camera, int width, int height);

        // Vector2 GetWorldToScreen2D(Vector2 position, Camera2D camera); // Get the screen space position for a 2d camera world space position 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static System.Numerics.Vector2 GetWorldToScreen2D(System.Numerics.Vector2 position, Camera2D camera);

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
        public extern static string LoadFileData([MarshalAs(UnmanagedType.LPStr)] string fileName, IntPtr bytesRead);

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
        public extern static string GetFileExtension([MarshalAs(UnmanagedType.LPStr)] string fileName);

        // string GetFileName(string filePath);              // Get pointer to filename for a path string 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static string GetFileName([MarshalAs(UnmanagedType.LPStr)] string filePath);

        // string GetFileNameWithoutExt(string filePath);    // Get filename string without extension (uses static string) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static string GetFileNameWithoutExt([MarshalAs(UnmanagedType.LPStr)] string filePath);

        // string GetDirectoryPath(string filePath);         // Get full path for a given fileName with path (uses static string) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static string GetDirectoryPath([MarshalAs(UnmanagedType.LPStr)] string filePath);

        // string GetPrevDirectoryPath(string dirPath);      // Get previous directory path for a given path (uses static string) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static string GetPrevDirectoryPath([MarshalAs(UnmanagedType.LPStr)] string dirPath);

        // string GetWorkingDirectory(void);                      // Get current working directory (uses static string) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static string GetWorkingDirectory();

        // string GetApplicationDirectory(void);                  // Get the directory if the running application (uses static string) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static string GetApplicationDirectory();

        // bool ChangeDirectory(string dir);                      // Change working directory, return true on success 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool ChangeDirectory([MarshalAs(UnmanagedType.LPStr)] string dir);

        // bool IsPathFile(string path);                          // Check if a given path is a file or a directory 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsPathFile([MarshalAs(UnmanagedType.LPStr)] string path);

        // FilePathList LoadDirectoryFiles(string dirPath);       // Load directory filepaths 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static FilePathList LoadDirectoryFiles([MarshalAs(UnmanagedType.LPStr)] string dirPath);

        // FilePathList LoadDirectoryFilesEx(string basePath, string filter, bool scanSubdirs); // Load directory filepaths with extension filtering and recursive directory scan 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static FilePathList LoadDirectoryFilesEx([MarshalAs(UnmanagedType.LPStr)] string basePath, [MarshalAs(UnmanagedType.LPStr)] string filter, bool scanSubdirs);

        // void UnloadDirectoryFiles(FilePathList files);              // Unload filepaths 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadDirectoryFiles(FilePathList files);

        // bool IsFileDropped(void);                                   // Check if a file has been dropped into window 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static bool IsFileDropped();

        // FilePathList LoadDroppedFiles(void);                        // Load dropped filepaths 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static FilePathList LoadDroppedFiles();

        // void UnloadDroppedFiles(FilePathList files);                // Unload dropped filepaths 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void UnloadDroppedFiles(FilePathList files);

        // long GetFileModTime(string fileName);                  // Get file modification time (last write time) 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static long GetFileModTime([MarshalAs(UnmanagedType.LPStr)] string fileName);

        //  Compression/Encoding functionality 

        // string CompressData(string data, int dataSize, IntPtr compDataSize);        // Compress data (DEFLATE algorithm), memory must be MemFree() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static string CompressData([MarshalAs(UnmanagedType.LPStr)] string data, int dataSize, IntPtr compDataSize);

        // string DecompressData(string compData, int compDataSize, IntPtr dataSize);  // Decompress data (DEFLATE algorithm), memory must be MemFree() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static string DecompressData([MarshalAs(UnmanagedType.LPStr)] string compData, int compDataSize, IntPtr dataSize);

        // string EncodeDataBase64(string data, int dataSize, IntPtr outputSize);               // Encode data to Base64 string, memory must be MemFree() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static string EncodeDataBase64([MarshalAs(UnmanagedType.LPStr)] string data, int dataSize, IntPtr outputSize);

        // string DecodeDataBase64(string data, IntPtr outputSize);                    // Decode Base64 string data, memory must be MemFree() 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static string DecodeDataBase64([MarshalAs(UnmanagedType.LPStr)] string data, IntPtr outputSize);

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
        public extern static unsafe void UpdateCamera(Camera3D* camera, int mode);

        // void UpdateCameraPro(Camera *camera, Vector3 movement, Vector3 rotation, float zoom); // Update camera movement/rotation 
        [DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static unsafe void UpdateCameraPro(Camera3D* camera, Vector3 movement, Vector3 rotation, float zoom);

        public static void Main(string[] args)
        {
            Console.WriteLine(LibName);
            InitWindow(800, 600, "test");
        }
    }
}
