using System.Numerics;
using System.Runtime.InteropServices;

namespace RayLibStenguage
{
	public class Imports
	{
		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void InitWindow(int width, int height, [MarshalAs(UnmanagedType.LPStr)] string title);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool WindowShouldClose();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void CloseWindow();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsWindowReady();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsWindowFullscreen();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsWindowHidden();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsWindowMinimized();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsWindowMaximized();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsWindowFocused();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsWindowResized();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsWindowState(uint flag);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowState(uint flags);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ClearWindowState(uint flags);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ToggleFullscreen();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void MaximizeWindow();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void MinimizeWindow();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RestoreWindow();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowIcon(Structs.Image image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowIcons(Structs.Image[] images, int count);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowTitle([MarshalAs(UnmanagedType.LPStr)] string title);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowPosition(int x, int y);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowMonitor(int monitor);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowMinSize(int width, int height);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowSize(int width, int height);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowOpacity(float opacity);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GetWindowHandle();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetScreenWidth();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetScreenHeight();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetRenderWidth();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetRenderHeight();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetMonitorCount();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetCurrentMonitor();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetMonitorPosition(int monitor);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetMonitorWidth(int monitor);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetMonitorHeight(int monitor);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetMonitorPhysicalWidth(int monitor);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetMonitorPhysicalHeight(int monitor);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetMonitorRefreshRate(int monitor);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetWindowPosition();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetWindowScaleDPI();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string GetMonitorName(int monitor);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetClipboardText([MarshalAs(UnmanagedType.LPStr)] string text);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string GetClipboardText();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EnableEventWaiting();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DisableEventWaiting();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SwapScreenBuffer();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PollInputEvents();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WaitTime(double seconds);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShowCursor();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void HideCursor();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsCursorHidden();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EnableCursor();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DisableCursor();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsCursorOnScreen();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ClearBackground(Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginDrawing();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndDrawing();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginMode2D(Structs.Camera2D camera);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndMode2D();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginMode3D(Structs.Camera3D camera);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndMode3D();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginTextureMode(Structs.RenderTexture2D target);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndTextureMode();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginShaderMode(Structs.Shader shader);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndShaderMode();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginBlendMode(int mode);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndBlendMode();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginScissorMode(int x, int y, int width, int height);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndScissorMode();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginVrStereoMode(Structs.VrStereoConfig config);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndVrStereoMode();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.VrStereoConfig LoadVrStereoConfig(Structs.VrDeviceInfo device);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadVrStereoConfig(Structs.VrStereoConfig config);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Shader LoadShader([MarshalAs(UnmanagedType.LPStr)] string vsFileName, [MarshalAs(UnmanagedType.LPStr)] string fsFileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Shader LoadShaderFromMemory([MarshalAs(UnmanagedType.LPStr)] string vsCode, [MarshalAs(UnmanagedType.LPStr)] string fsCode);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsShaderReady(Structs.Shader shader);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetShaderLocation(Structs.Shader shader, [MarshalAs(UnmanagedType.LPStr)] string uniformName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetShaderLocationAttrib(Structs.Shader shader, [MarshalAs(UnmanagedType.LPStr)] string attribName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void SetShaderValue(Structs.Shader shader, int locIndex, void* value, int uniformType);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void SetShaderValueV(Structs.Shader shader, int locIndex, void* value, int uniformType, int count);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetShaderValueMatrix(Structs.Shader shader, int locIndex, Matrix4x4 mat);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetShaderValueTexture(Structs.Shader shader, int locIndex, Structs.Texture2D texture);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadShader(Structs.Shader shader);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Ray GetMouseRay(Vector2 mousePosition, Structs.Camera3D camera);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Matrix4x4 GetCameraMatrix(Structs.Camera3D camera);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Matrix4x4 GetCameraMatrix2D(Structs.Camera2D camera);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetWorldToScreen(Vector3 position, Structs.Camera3D camera);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetScreenToWorld2D(Vector2 position, Structs.Camera2D camera);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetWorldToScreenEx(Vector3 position, Structs.Camera3D camera, int width, int height);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetWorldToScreen2D(Vector2 position, Structs.Camera2D camera);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetTargetFPS(int fps);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetFPS();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetFrameTime();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern double GetTime();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetRandomValue(int min, int max);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetRandomSeed(uint seed);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TakeScreenshot([MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetConfigFlags(uint flags);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TraceLog(int logLevel, [MarshalAs(UnmanagedType.LPStr)] string text, __arglist);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetTraceLogLevel(int logLevel);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void* MemAlloc(uint size);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void* MemRealloc();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void MemFree();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void OpenURL([MarshalAs(UnmanagedType.LPStr)] string url);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string LoadFileData([MarshalAs(UnmanagedType.LPStr)] string fileName, [MarshalAs(UnmanagedType.LPStr)] ref string bytesRead);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadFileData([MarshalAs(UnmanagedType.LPStr)] string data);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern bool SaveFileData([MarshalAs(UnmanagedType.LPStr)] string fileName, void* data, uint bytesToWrite);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ExportDataAsCode([MarshalAs(UnmanagedType.LPStr)] string data, uint size, [MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string LoadFileText([MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadFileText([MarshalAs(UnmanagedType.LPStr)] string text);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool SaveFileText([MarshalAs(UnmanagedType.LPStr)] string fileName, [MarshalAs(UnmanagedType.LPStr)] string text);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool FileExists([MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool DirectoryExists([MarshalAs(UnmanagedType.LPStr)] string dirPath);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsFileExtension([MarshalAs(UnmanagedType.LPStr)] string fileName, [MarshalAs(UnmanagedType.LPStr)] string ext);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetFileLength([MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string GetFileExtension([MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string GetFileName([MarshalAs(UnmanagedType.LPStr)] string filePath);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string GetFileNameWithoutExt([MarshalAs(UnmanagedType.LPStr)] string filePath);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string GetDirectoryPath([MarshalAs(UnmanagedType.LPStr)] string filePath);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string GetPrevDirectoryPath([MarshalAs(UnmanagedType.LPStr)] string dirPath);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string GetWorkingDirectory();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string GetApplicationDirectory();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ChangeDirectory([MarshalAs(UnmanagedType.LPStr)] string dir);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsPathFile([MarshalAs(UnmanagedType.LPStr)] string path);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.FilePathList LoadDirectoryFiles([MarshalAs(UnmanagedType.LPStr)] string dirPath);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.FilePathList LoadDirectoryFilesEx([MarshalAs(UnmanagedType.LPStr)] string basePath, [MarshalAs(UnmanagedType.LPStr)] string filter, bool scanSubdirs);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadDirectoryFiles(Structs.FilePathList files);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsFileDropped();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.FilePathList LoadDroppedFiles();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadDroppedFiles(Structs.FilePathList files);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern long GetFileModTime([MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string CompressData([MarshalAs(UnmanagedType.LPStr)] string data, int dataSize, int compDataSize);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string DecompressData([MarshalAs(UnmanagedType.LPStr)] string compData, int compDataSize, int dataSize);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string EncodeDataBase64([MarshalAs(UnmanagedType.LPStr)] string data, int dataSize, int outputSize);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string DecodeDataBase64([MarshalAs(UnmanagedType.LPStr)] string data, int outputSize);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsKeyPressed(int key);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsKeyDown(int key);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsKeyReleased(int key);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsKeyUp(int key);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetExitKey(int key);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetKeyPressed();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetCharPressed();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsGamepadAvailable(int gamepad);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string GetGamepadName(int gamepad);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsGamepadButtonPressed(int gamepad, int button);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsGamepadButtonDown(int gamepad, int button);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsGamepadButtonReleased(int gamepad, int button);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsGamepadButtonUp(int gamepad, int button);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetGamepadButtonPressed();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetGamepadAxisCount(int gamepad);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetGamepadAxisMovement(int gamepad, int axis);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int SetGamepadMappings([MarshalAs(UnmanagedType.LPStr)] string mappings);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsMouseButtonPressed(int button);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsMouseButtonDown(int button);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsMouseButtonReleased(int button);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsMouseButtonUp(int button);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetMouseX();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetMouseY();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetMousePosition();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetMouseDelta();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetMousePosition(int x, int y);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetMouseOffset(int offsetX, int offsetY);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetMouseScale(float scaleX, float scaleY);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetMouseWheelMove();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetMouseWheelMoveV();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetMouseCursor(int cursor);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetTouchX();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetTouchY();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetTouchPosition(int index);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetTouchPointId(int index);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetTouchPointCount();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetGesturesEnabled(uint flags);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsGestureDetected(int gesture);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetGestureDetected();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetGestureHoldDuration();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetGestureDragVector();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetGestureDragAngle();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 GetGesturePinchVector();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetGesturePinchAngle();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void UpdateCamera(Structs.Camera3D* camera, int mode);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void UpdateCameraPro(Structs.Camera3D* camera, Vector3 movement, Vector3 rotation, float zoom);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetShapesTexture(Structs.Texture2D texture, Structs.Rectangle source);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawPixel(int posX, int posY, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawPixelV(Vector2 position, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawLineV(Vector2 startPos, Vector2 endPos, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawLineEx(Vector2 startPos, Vector2 endPos, float thick, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawLineBezier(Vector2 startPos, Vector2 endPos, float thick, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawLineBezierQuad(Vector2 startPos, Vector2 endPos, Vector2 controlPos, float thick, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawLineBezierCubic(Vector2 startPos, Vector2 endPos, Vector2 startControlPos, Vector2 endControlPos, float thick, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawLineStrip(Vector2[] points, int pointCount, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawCircle(int centerX, int centerY, float radius, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawCircleSector(Vector2 center, float radius, float startAngle, float endAngle, int segments, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawCircleSectorLines(Vector2 center, float radius, float startAngle, float endAngle, int segments, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawCircleGradient(int centerX, int centerY, float radius, Structs.Color color1, Structs.Color color2);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawCircleV(Vector2 center, float radius, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawCircleLines(int centerX, int centerY, float radius, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRectangle(int posX, int posY, int width, int height, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRectangleV(Vector2 position, Vector2 size, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRectangleRec(Structs.Rectangle rec, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRectanglePro(Structs.Rectangle rec, Vector2 origin, float rotation, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRectangleGradientV(int posX, int posY, int width, int height, Structs.Color color1, Structs.Color color2);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRectangleGradientH(int posX, int posY, int width, int height, Structs.Color color1, Structs.Color color2);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRectangleGradientEx(Structs.Rectangle rec, Structs.Color col1, Structs.Color col2, Structs.Color col3, Structs.Color col4);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRectangleLines(int posX, int posY, int width, int height, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRectangleLinesEx(Structs.Rectangle rec, float lineThick, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRectangleRounded(Structs.Rectangle rec, float roundness, int segments, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawRectangleRoundedLines(Structs.Rectangle rec, float roundness, int segments, float lineThick, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTriangle(Vector2 v1, Vector2 v2, Vector2 v3, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTriangleLines(Vector2 v1, Vector2 v2, Vector2 v3, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTriangleFan(Vector2[] points, int pointCount, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTriangleStrip(Vector2[] points, int pointCount, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawPoly(Vector2 center, int sides, float radius, float rotation, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawPolyLines(Vector2 center, int sides, float radius, float rotation, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawPolyLinesEx(Vector2 center, int sides, float radius, float rotation, float lineThick, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool CheckCollisionRecs(Structs.Rectangle rec1, Structs.Rectangle rec2);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool CheckCollisionCircles(Vector2 center1, float radius1, Vector2 center2, float radius2);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool CheckCollisionCircleRec(Vector2 center, float radius, Structs.Rectangle rec);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool CheckCollisionPointRec(Vector2 point, Structs.Rectangle rec);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool CheckCollisionPointCircle(Vector2 point, Vector2 center, float radius);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool CheckCollisionPointTriangle(Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool CheckCollisionPointPoly(Vector2 point, Vector2[] points, int pointCount);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern bool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, Vector2* collisionPoint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool CheckCollisionPointLine(Vector2 point, Vector2 p1, Vector2 p2, int threshold);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Rectangle GetCollisionRec(Structs.Rectangle rec1, Structs.Rectangle rec2);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Font GetFontDefault();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Font LoadFont([MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Font LoadFontEx([MarshalAs(UnmanagedType.LPStr)] string fileName, int fontSize, IntPtr fontChars, int glyphCount);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Font LoadFontFromImage(Structs.Image image, Structs.Color key, int firstChar);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Font LoadFontFromMemory([MarshalAs(UnmanagedType.LPStr)] string fileType, [MarshalAs(UnmanagedType.LPStr)] string fileData, int dataSize, int fontSize, IntPtr fontChars, int glyphCount);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsFontReady(Structs.Font font);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.GlyphInfo[] LoadFontData([MarshalAs(UnmanagedType.LPStr)] string fileData, int dataSize, int fontSize, IntPtr fontChars, int glyphCount, int type);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern Structs.Image GenImageFontAtlas(Structs.GlyphInfo[] chars, Structs.Rectangle[]* recs, int glyphCount, int fontSize, int padding, int packMethod);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadFontData(Structs.GlyphInfo[] chars, int glyphCount);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadFont(Structs.Font font);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ExportFontAsCode(Structs.Font font, [MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawFPS(int posX, int posY);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawText([MarshalAs(UnmanagedType.LPStr)] string text, int posX, int posY, int fontSize, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTextEx(Structs.Font font, [MarshalAs(UnmanagedType.LPStr)] string text, Vector2 position, float fontSize, float spacing, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTextPro(Structs.Font font, [MarshalAs(UnmanagedType.LPStr)] string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTextCodepoint(Structs.Font font, int codepoint, Vector2 position, float fontSize, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTextCodepoints(Structs.Font font, IntPtr codepoints, int count, Vector2 position, float fontSize, float spacing, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int MeasureText([MarshalAs(UnmanagedType.LPStr)] string text, int fontSize);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2 MeasureTextEx(Structs.Font font, [MarshalAs(UnmanagedType.LPStr)] string text, float fontSize, float spacing);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetGlyphIndex(Structs.Font font, int codepoint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.GlyphInfo GetGlyphInfo(Structs.Font font, int codepoint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Rectangle GetGlyphAtlasRec(Structs.Font font, int codepoint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string LoadUTF8(IntPtr codepoints, int length);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadUTF8([MarshalAs(UnmanagedType.LPStr)] string text);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int LoadCodepoints([MarshalAs(UnmanagedType.LPStr)] string text, int count);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadCodepoints(IntPtr codepoints);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetCodepointCount([MarshalAs(UnmanagedType.LPStr)] string text);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetCodepoint([MarshalAs(UnmanagedType.LPStr)] string text, int codepointSize);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetCodepointNext([MarshalAs(UnmanagedType.LPStr)] string text, int codepointSize);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetCodepointPrevious([MarshalAs(UnmanagedType.LPStr)] string text, int codepointSize);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string CodepointToUTF8(int codepoint, int utf8Size);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int TextCopy([MarshalAs(UnmanagedType.LPStr)] string dst, [MarshalAs(UnmanagedType.LPStr)] string src);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool TextIsEqual([MarshalAs(UnmanagedType.LPStr)] string text1, [MarshalAs(UnmanagedType.LPStr)] string text2);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint TextLength([MarshalAs(UnmanagedType.LPStr)] string text);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string TextFormat([MarshalAs(UnmanagedType.LPStr)] string text, __arglist);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string TextSubtext([MarshalAs(UnmanagedType.LPStr)] string text, int position, int length);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string TextReplace([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string replace, [MarshalAs(UnmanagedType.LPStr)] string by);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string TextInsert([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string insert, int position);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string TextJoin([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] textList, int count, [MarshalAs(UnmanagedType.LPStr)] string delimiter);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)]
		public static extern string[] TextSplit([MarshalAs(UnmanagedType.LPStr)] string text, char delimiter, int count);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TextAppend([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string append, int position);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int TextFindIndex([MarshalAs(UnmanagedType.LPStr)] string text, [MarshalAs(UnmanagedType.LPStr)] string find);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string TextToUpper([MarshalAs(UnmanagedType.LPStr)] string text);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string TextToLower([MarshalAs(UnmanagedType.LPStr)] string text);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPStr)]
		public static extern string TextToPascal([MarshalAs(UnmanagedType.LPStr)] string text);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int TextToInteger([MarshalAs(UnmanagedType.LPStr)] string text);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image LoadImage([MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image LoadImageRaw([MarshalAs(UnmanagedType.LPStr)] string fileName, int width, int height, int format, int headerSize);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image LoadImageAnim([MarshalAs(UnmanagedType.LPStr)] string fileName, IntPtr frames);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image LoadImageFromMemory([MarshalAs(UnmanagedType.LPStr)] string fileType, [MarshalAs(UnmanagedType.LPStr)] string fileData, int dataSize);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image LoadImageFromTexture(Structs.Texture2D texture);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image LoadImageFromScreen();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsImageReady(Structs.Image image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadImage(Structs.Image image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ExportImage(Structs.Image image, [MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool ExportImageAsCode(Structs.Image image, [MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image GenImageColor(int width, int height, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image GenImageGradientLinear(int width, int height, int direction, Structs.Color start, Structs.Color end);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image GenImageGradientRadial(int width, int height, float density, Structs.Color inner, Structs.Color outer);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image GenImageGradientSquare(int width, int height, float density, Structs.Color inner, Structs.Color outer);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image GenImageChecked(int width, int height, int checksX, int checksY, Structs.Color col1, Structs.Color col2);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image GenImageWhiteNoise(int width, int height, float factor);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image GenImagePerlinNoise(int width, int height, int offsetX, int offsetY, float scale);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image GenImageCellular(int width, int height, int tileSize);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image GenImageText(int width, int height, [MarshalAs(UnmanagedType.LPStr)] string text);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image ImageCopy(Structs.Image image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image ImageFromImage(Structs.Image image, Structs.Rectangle rec);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image ImageText([MarshalAs(UnmanagedType.LPStr)] string text, int fontSize, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Image ImageTextEx(Structs.Font font, [MarshalAs(UnmanagedType.LPStr)] string text, float fontSize, float spacing, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageFormat(Structs.Image* image, int newFormat);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageToPOT(Structs.Image* image, Structs.Color fill);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageCrop(Structs.Image* image, Structs.Rectangle crop);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageAlphaCrop(Structs.Image* image, float threshold);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageAlphaClear(Structs.Image* image, Structs.Color color, float threshold);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageAlphaMask(Structs.Image* image, Structs.Image alphaMask);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageAlphaPremultiply(Structs.Image* image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageBlurGaussian(Structs.Image* image, int blurSize);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageResize(Structs.Image* image, int newWidth, int newHeight);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageResizeNN(Structs.Image* image, int newWidth, int newHeight);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageResizeCanvas(Structs.Image* image, int newWidth, int newHeight, int offsetX, int offsetY, Structs.Color fill);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageMipmaps(Structs.Image* image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDither(Structs.Image* image, int rBpp, int gBpp, int bBpp, int aBpp);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageFlipVertical(Structs.Image* image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageFlipHorizontal(Structs.Image* image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageRotate(Structs.Image* image, int degrees);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageRotateCW(Structs.Image* image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageRotateCCW(Structs.Image* image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageColorTint(Structs.Image* image, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageColorInvert(Structs.Image* image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageColorGrayscale(Structs.Image* image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageColorContrast(Structs.Image* image, float contrast);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageColorBrightness(Structs.Image* image, int brightness);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageColorReplace(Structs.Image* image, Structs.Color color, Structs.Color replace);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color[] LoadImageColors(Structs.Image image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color[] LoadImagePalette(Structs.Image image, int maxPaletteSize, int colorCount);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadImageColors(Structs.Color[] colors);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadImagePalette(Structs.Color[] colors);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Rectangle GetImageAlphaBorder(Structs.Image image, float threshold);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color GetImageColor(Structs.Image image, int x, int y);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageClearBackground(Structs.Image* dst, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawPixel(Structs.Image* dst, int posX, int posY, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawPixelV(Structs.Image* dst, Vector2 position, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawLine(Structs.Image* dst, int startPosX, int startPosY, int endPosX, int endPosY, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawLineV(Structs.Image* dst, Vector2 start, Vector2 end, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawCircle(Structs.Image* dst, int centerX, int centerY, int radius, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawCircleV(Structs.Image* dst, Vector2 center, int radius, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawCircleLines(Structs.Image* dst, int centerX, int centerY, int radius, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawCircleLinesV(Structs.Image* dst, Vector2 center, int radius, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawRectangle(Structs.Image* dst, int posX, int posY, int width, int height, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawRectangleV(Structs.Image* dst, Vector2 position, Vector2 size, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawRectangleRec(Structs.Image* dst, Structs.Rectangle rec, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawRectangleLines(Structs.Image* dst, Structs.Rectangle rec, int thick, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDraw(Structs.Image* dst, Structs.Image src, Structs.Rectangle srcRec, Structs.Rectangle dstRec, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawText(Structs.Image* dst, [MarshalAs(UnmanagedType.LPStr)] string text, int posX, int posY, int fontSize, Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void ImageDrawTextEx(Structs.Image* dst, Structs.Font font, [MarshalAs(UnmanagedType.LPStr)] string text, Vector2 position, float fontSize, float spacing, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Texture2D LoadTexture([MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Texture2D LoadTextureFromImage(Structs.Image image);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Texture2D LoadTextureCubemap(Structs.Image image, int layout);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.RenderTexture2D LoadRenderTexture(int width, int height);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsTextureReady(Structs.Texture2D texture);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadTexture(Structs.Texture2D texture);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool IsRenderTextureReady(Structs.RenderTexture2D target);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnloadRenderTexture(Structs.RenderTexture2D target);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void UpdateTexture(Structs.Texture2D texture, void* pixels);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void UpdateTextureRec(Structs.Texture2D texture, Structs.Rectangle rec, void* pixels);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void GenTextureMipmaps(Structs.Texture2D* texture);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetTextureFilter(Structs.Texture2D texture, int filter);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetTextureWrap(Structs.Texture2D texture, int wrap);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTexture(Structs.Texture2D texture, int posX, int posY, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTextureV(Structs.Texture2D texture, Vector2 position, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTextureEx(Structs.Texture2D texture, Vector2 position, float rotation, float scale, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTextureRec(Structs.Texture2D texture, Structs.Rectangle source, Vector2 position, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTexturePro(Structs.Texture2D texture, Structs.Rectangle source, Structs.Rectangle dest, Vector2 origin, float rotation, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DrawTextureNPatch(Structs.Texture2D texture, Structs.NPatchInfo nPatchInfo, Structs.Rectangle dest, Vector2 origin, float rotation, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color Fade(Structs.Color color, float alpha);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ColorToInt(Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector4 ColorNormalize(Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color ColorFromNormalized(Vector4 normalized);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector3 ColorToHSV(Structs.Color color);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color ColorFromHSV(float hue, float saturation, float value);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color ColorTint(Structs.Color color, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color ColorBrightness(Structs.Color color, float factor);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color ColorContrast(Structs.Color color, float contrast);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color ColorAlpha(Structs.Color color, float alpha);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color ColorAlphaBlend(Structs.Color dst, Structs.Color src, Structs.Color tint);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color GetColor(uint hexValue);

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Structs.Color GetPixelColor();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetPixelColor();

		[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetPixelDataSize(int width, int height, int format);

		public static void Main(string[] args)
		{
			Imports.InitWindow(800, 600, "test");
			Structs.Texture2D tex = Imports.LoadTexture("C:\\Users\\stent\\Desktop\\Images\\canvas.png");
			while (!Imports.WindowShouldClose())
			{
				Imports.BeginDrawing();
				Imports.ClearBackground(Structs.Color.BLACK);
				Imports.DrawTexture(tex, 0, 0, Structs.Color.WHITE);
				DrawRectangle(100, 100, 100, 100, Structs.Color.WHITE);
				Imports.DrawFPS(10, 10);
				Imports.EndDrawing();
			}
			Imports.CloseWindow();
		}
	}
}
