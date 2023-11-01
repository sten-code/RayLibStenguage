using Raylib_cs;
using System.Numerics;
using System.Runtime.InteropServices;

namespace RayLibStenguage
{
    public class Structs
    {
        #region Input

        /// <summary>
        /// Keyboard keys (US keyboard layout)<br/>
        /// NOTE: Use GetKeyPressed() to allow redefining required keys for alternative layouts
        /// </summary>
        public enum KeyboardKey
        {
            /// <summary>
            /// NULL, used for no key pressed
            /// </summary>
            KEY_NULL = 0,

            // Alphanumeric keys
            KEY_APOSTROPHE = 39,
            KEY_COMMA = 44,
            KEY_MINUS = 45,
            KEY_PERIOD = 46,
            KEY_SLASH = 47,
            KEY_ZERO = 48,
            KEY_ONE = 49,
            KEY_TWO = 50,
            KEY_THREE = 51,
            KEY_FOUR = 52,
            KEY_FIVE = 53,
            KEY_SIX = 54,
            KEY_SEVEN = 55,
            KEY_EIGHT = 56,
            KEY_NINE = 57,
            KEY_SEMICOLON = 59,
            KEY_EQUAL = 61,
            KEY_A = 65,
            KEY_B = 66,
            KEY_C = 67,
            KEY_D = 68,
            KEY_E = 69,
            KEY_F = 70,
            KEY_G = 71,
            KEY_H = 72,
            KEY_I = 73,
            KEY_J = 74,
            KEY_K = 75,
            KEY_L = 76,
            KEY_M = 77,
            KEY_N = 78,
            KEY_O = 79,
            KEY_P = 80,
            KEY_Q = 81,
            KEY_R = 82,
            KEY_S = 83,
            KEY_T = 84,
            KEY_U = 85,
            KEY_V = 86,
            KEY_W = 87,
            KEY_X = 88,
            KEY_Y = 89,
            KEY_Z = 90,

            // Function keys
            KEY_SPACE = 32,
            KEY_ESCAPE = 256,
            KEY_ENTER = 257,
            KEY_TAB = 258,
            KEY_BACKSPACE = 259,
            KEY_INSERT = 260,
            KEY_DELETE = 261,
            KEY_RIGHT = 262,
            KEY_LEFT = 263,
            KEY_DOWN = 264,
            KEY_UP = 265,
            KEY_PAGE_UP = 266,
            KEY_PAGE_DOWN = 267,
            KEY_HOME = 268,
            KEY_END = 269,
            KEY_CAPS_LOCK = 280,
            KEY_SCROLL_LOCK = 281,
            KEY_NUM_LOCK = 282,
            KEY_PRINT_SCREEN = 283,
            KEY_PAUSE = 284,
            KEY_F1 = 290,
            KEY_F2 = 291,
            KEY_F3 = 292,
            KEY_F4 = 293,
            KEY_F5 = 294,
            KEY_F6 = 295,
            KEY_F7 = 296,
            KEY_F8 = 297,
            KEY_F9 = 298,
            KEY_F10 = 299,
            KEY_F11 = 300,
            KEY_F12 = 301,
            KEY_LEFT_SHIFT = 340,
            KEY_LEFT_CONTROL = 341,
            KEY_LEFT_ALT = 342,
            KEY_LEFT_SUPER = 343,
            KEY_RIGHT_SHIFT = 344,
            KEY_RIGHT_CONTROL = 345,
            KEY_RIGHT_ALT = 346,
            KEY_RIGHT_SUPER = 347,
            KEY_KB_MENU = 348,
            KEY_LEFT_BRACKET = 91,
            KEY_BACKSLASH = 92,
            KEY_RIGHT_BRACKET = 93,
            KEY_GRAVE = 96,

            // Keypad keys
            KEY_KP_0 = 320,
            KEY_KP_1 = 321,
            KEY_KP_2 = 322,
            KEY_KP_3 = 323,
            KEY_KP_4 = 324,
            KEY_KP_5 = 325,
            KEY_KP_6 = 326,
            KEY_KP_7 = 327,
            KEY_KP_8 = 328,
            KEY_KP_9 = 329,
            KEY_KP_DECIMAL = 330,
            KEY_KP_DIVIDE = 331,
            KEY_KP_MULTIPLY = 332,
            KEY_KP_SUBTRACT = 333,
            KEY_KP_ADD = 334,
            KEY_KP_ENTER = 335,
            KEY_KP_EQUAL = 336,

            // Android key buttons
            KEY_BACK = 4,
            KEY_MENU = 82,
            KEY_VOLUME_UP = 24,
            KEY_VOLUME_DOWN = 25
        }

        /// <summary>
        /// Mouse buttons
        /// </summary>
        public enum MouseButton
        {
            /// <summary>
            /// Mouse button left
            /// </summary>
            MOUSE_BUTTON_LEFT = 0,

            /// <summary>
            /// Mouse button right
            /// </summary>
            MOUSE_BUTTON_RIGHT = 1,

            /// <summary>
            /// Mouse button middle (pressed wheel)
            /// </summary>
            MOUSE_BUTTON_MIDDLE = 2,

            /// <summary>
            /// Mouse button side (advanced mouse device)
            /// </summary>
            MOUSE_BUTTON_SIDE = 3,

            /// <summary>
            /// Mouse button extra (advanced mouse device)
            /// </summary>
            MOUSE_BUTTON_EXTRA = 4,

            /// <summary>
            /// Mouse button forward (advanced mouse device)
            /// </summary>
            MOUSE_BUTTON_FORWARD = 5,

            /// <summary>
            /// Mouse button back (advanced mouse device)
            /// </summary>
            MOUSE_BUTTON_BACK = 6,

            MOUSE_LEFT_BUTTON = MOUSE_BUTTON_LEFT,
            MOUSE_RIGHT_BUTTON = MOUSE_BUTTON_RIGHT,
            MOUSE_MIDDLE_BUTTON = MOUSE_BUTTON_MIDDLE,
        }

        /// <summary>
        /// Mouse cursor
        /// </summary>
        public enum MouseCursor
        {
            /// <summary>
            /// Default pointer shape
            /// </summary>
            MOUSE_CURSOR_DEFAULT = 0,

            /// <summary>
            /// Arrow shape
            /// </summary>
            MOUSE_CURSOR_ARROW = 1,

            /// <summary>
            /// Text writing cursor shape
            /// </summary>
            MOUSE_CURSOR_IBEAM = 2,

            /// <summary>
            /// Cross shape
            /// </summary>
            MOUSE_CURSOR_CROSSHAIR = 3,

            /// <summary>
            /// Pointing hand cursor
            /// </summary>
            MOUSE_CURSOR_POINTING_HAND = 4,

            /// <summary>
            /// Horizontal resize/move arrow shape
            /// </summary>
            MOUSE_CURSOR_RESIZE_EW = 5,

            /// <summary>
            /// Vertical resize/move arrow shape
            /// </summary>
            MOUSE_CURSOR_RESIZE_NS = 6,

            /// <summary>
            /// Top-left to bottom-right diagonal resize/move arrow shape
            /// </summary>
            MOUSE_CURSOR_RESIZE_NWSE = 7,

            /// <summary>
            /// The top-right to bottom-left diagonal resize/move arrow shape
            /// </summary>
            MOUSE_CURSOR_RESIZE_NESW = 8,

            /// <summary>
            /// The omnidirectional resize/move cursor shape
            /// </summary>
            MOUSE_CURSOR_RESIZE_ALL = 9,

            /// <summary>
            /// The operation-not-allowed shape
            /// </summary>
            MOUSE_CURSOR_NOT_ALLOWED = 10
        }

        /// <summary>Gamepad axis</summary>
        public enum GamepadAxis
        {
            /// <summary>
            /// Gamepad left stick X axis
            /// </summary>
            GAMEPAD_AXIS_LEFT_X = 0,

            /// <summary>
            /// Gamepad left stick Y axis
            /// </summary>
            GAMEPAD_AXIS_LEFT_Y = 1,

            /// <summary>
            /// Gamepad right stick X axis
            /// </summary>
            GAMEPAD_AXIS_RIGHT_X = 2,

            /// <summary>
            /// Gamepad right stick Y axis
            /// </summary>
            GAMEPAD_AXIS_RIGHT_Y = 3,

            /// <summary>
            /// Gamepad back trigger left, pressure level: [1..-1]
            /// </summary>
            GAMEPAD_AXIS_LEFT_TRIGGER = 4,

            /// <summary>
            /// Gamepad back trigger right, pressure level: [1..-1]
            /// </summary>
            GAMEPAD_AXIS_RIGHT_TRIGGER = 5
        }

        /// <summary>
        /// Gamepad buttons
        /// </summary>
        public enum GamepadButton
        {
            /// <summary>
            /// Unknown button, just for error checking
            /// </summary>
            GAMEPAD_BUTTON_UNKNOWN = 0,

            /// <summary>
            /// Gamepad left DPAD up button
            /// </summary>
            GAMEPAD_BUTTON_LEFT_FACE_UP,

            /// <summary>
            /// Gamepad left DPAD right button
            /// </summary>
            GAMEPAD_BUTTON_LEFT_FACE_RIGHT,

            /// <summary>
            /// Gamepad left DPAD down button
            /// </summary>
            GAMEPAD_BUTTON_LEFT_FACE_DOWN,

            /// <summary>
            /// Gamepad left DPAD left button
            /// </summary>
            GAMEPAD_BUTTON_LEFT_FACE_LEFT,

            /// <summary>
            /// Gamepad right button up (i.e. PS3: Triangle, Xbox: Y)
            /// </summary>
            GAMEPAD_BUTTON_RIGHT_FACE_UP,

            /// <summary>
            /// Gamepad right button right (i.e. PS3: Square, Xbox: X)
            /// </summary>
            GAMEPAD_BUTTON_RIGHT_FACE_RIGHT,

            /// <summary>
            /// Gamepad right button down (i.e. PS3: Cross, Xbox: A)
            /// </summary>
            GAMEPAD_BUTTON_RIGHT_FACE_DOWN,

            /// <summary>
            /// Gamepad right button left (i.e. PS3: Circle, Xbox: B)
            /// </summary>
            GAMEPAD_BUTTON_RIGHT_FACE_LEFT,

            /// <summary>
            /// Gamepad top/back trigger left (first), it could be a trailing button
            /// </summary>
            GAMEPAD_BUTTON_LEFT_TRIGGER_1,

            /// <summary>
            /// Gamepad top/back trigger left (second), it could be a trailing button
            /// </summary>
            GAMEPAD_BUTTON_LEFT_TRIGGER_2,

            /// <summary>
            /// Gamepad top/back trigger right (first), it could be a trailing button
            /// </summary>
            GAMEPAD_BUTTON_RIGHT_TRIGGER_1,

            /// <summary>
            /// Gamepad top/back trigger right (second), it could be a trailing button
            /// </summary>
            GAMEPAD_BUTTON_RIGHT_TRIGGER_2,

            /// <summary>
            /// Gamepad center buttons, left one (i.e. PS3: Select)
            /// </summary>
            GAMEPAD_BUTTON_MIDDLE_LEFT,

            /// <summary>
            /// Gamepad center buttons, middle one (i.e. PS3: PS, Xbox: XBOX)
            /// </summary>
            GAMEPAD_BUTTON_MIDDLE,

            /// <summary>
            /// Gamepad center buttons, right one (i.e. PS3: Start)
            /// </summary>
            GAMEPAD_BUTTON_MIDDLE_RIGHT,

            /// <summary>
            /// Gamepad joystick pressed button left
            /// </summary>
            GAMEPAD_BUTTON_LEFT_THUMB,

            /// <summary>
            /// Gamepad joystick pressed button right
            /// </summary>
            GAMEPAD_BUTTON_RIGHT_THUMB
        }

        /// <summary>
        /// Gesture
        /// NOTE: It could be used as flags to enable only some gestures
        /// </summary>
        [Flags]
        public enum Gesture : uint
        {
            GESTURE_NONE = 0,
            GESTURE_TAP = 1,
            GESTURE_DOUBLETAP = 2,
            GESTURE_HOLD = 4,
            GESTURE_DRAG = 8,
            GESTURE_SWIPE_RIGHT = 16,
            GESTURE_SWIPE_LEFT = 32,
            GESTURE_SWIPE_UP = 64,
            GESTURE_SWIPE_DOWN = 128,
            GESTURE_PINCH_IN = 256,
            GESTURE_PINCH_OUT = 512
        }

        /// <summary>
        /// Head-Mounted-Display device parameters
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct VrDeviceInfo
        {
            /// <summary>
            /// HMD horizontal resolution in pixels
            /// </summary>
            public int hResolution;

            /// <summary>
            /// HMD vertical resolution in pixels
            /// </summary>
            public int vResolution;

            /// <summary>
            /// HMD horizontal size in meters
            /// </summary>
            public float hScreenSize;

            /// <summary>
            /// HMD vertical size in meters
            /// </summary>
            public float vScreenSize;

            /// <summary>
            /// HMD screen center in meters
            /// </summary>
            public float vScreenCenter;

            /// <summary>
            /// HMD distance between eye and display in meters
            /// </summary>
            public float eyeToScreenDistance;

            /// <summary>
            /// HMD lens separation distance in meters
            /// </summary>
            public float lensSeparationDistance;

            /// <summary>
            /// HMD IPD (distance between pupils) in meters
            /// </summary>
            public float interpupillaryDistance;

            /// <summary>
            /// HMD lens distortion constant parameters
            /// </summary>
            public fixed float lensDistortionValues[4];

            /// <summary>
            /// HMD chromatic aberration correction parameters
            /// </summary>
            public fixed float chromaAbCorrection[4];
        }

        /// <summary>
        /// VR Stereo rendering configuration for simulator
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public partial struct VrStereoConfig
        {
            /// <summary>
            /// VR projection matrices (per eye)
            /// </summary>
            public Matrix4x4 projection1;

            /// <summary>
            /// VR projection matrices (per eye)
            /// </summary>
            public Matrix4x4 projection2;

            /// <summary>
            /// VR view offset matrices (per eye)
            /// </summary>
            public Matrix4x4 viewOffset1;

            /// <summary>
            /// VR view offset matrices (per eye)
            /// </summary>
            public Matrix4x4 viewOffset2;

            /// <summary>
            /// VR left lens center
            /// </summary>
            public System.Numerics.Vector2 leftLensCenter;

            /// <summary>
            /// VR right lens center
            /// </summary>
            public System.Numerics.Vector2 rightLensCenter;

            /// <summary>
            /// VR left screen center
            /// </summary>
            public System.Numerics.Vector2 leftScreenCenter;

            /// <summary>
            /// VR right screen center
            /// </summary>
            public System.Numerics.Vector2 rightScreenCenter;

            /// <summary>
            /// VR distortion scale
            /// </summary>
            public System.Numerics.Vector2 scale;

            /// <summary>
            /// VR distortion scale in
            /// </summary>
            public System.Numerics.Vector2 scaleIn;
        }

        #endregion

        #region Shader

        /// <summary>
        /// Shader location index
        /// </summary>
        public enum ShaderLocationIndex
        {
            SHADER_LOC_VERTEX_POSITION = 0,
            SHADER_LOC_VERTEX_TEXCOORD01,
            SHADER_LOC_VERTEX_TEXCOORD02,
            SHADER_LOC_VERTEX_NORMAL,
            SHADER_LOC_VERTEX_TANGENT,
            SHADER_LOC_VERTEX_COLOR,
            SHADER_LOC_MATRIX_MVP,
            SHADER_LOC_MATRIX_VIEW,
            SHADER_LOC_MATRIX_PROJECTION,
            SHADER_LOC_MATRIX_MODEL,
            SHADER_LOC_MATRIX_NORMAL,
            SHADER_LOC_VECTOR_VIEW,
            SHADER_LOC_COLOR_DIFFUSE,
            SHADER_LOC_COLOR_SPECULAR,
            SHADER_LOC_COLOR_AMBIENT,
            SHADER_LOC_MAP_ALBEDO,
            SHADER_LOC_MAP_METALNESS,
            SHADER_LOC_MAP_NORMAL,
            SHADER_LOC_MAP_ROUGHNESS,
            SHADER_LOC_MAP_OCCLUSION,
            SHADER_LOC_MAP_EMISSION,
            SHADER_LOC_MAP_HEIGHT,
            SHADER_LOC_MAP_CUBEMAP,
            SHADER_LOC_MAP_IRRADIANCE,
            SHADER_LOC_MAP_PREFILTER,
            SHADER_LOC_MAP_BRDF,

            SHADER_LOC_MAP_DIFFUSE = SHADER_LOC_MAP_ALBEDO,
            SHADER_LOC_MAP_SPECULAR = SHADER_LOC_MAP_METALNESS,
        }

        /// <summary>
        /// Shader attribute data types
        /// </summary>
        public enum ShaderAttributeDataType
        {
            SHADER_ATTRIB_FLOAT = 0,
            SHADER_ATTRIB_VEC2,
            SHADER_ATTRIB_VEC3,
            SHADER_ATTRIB_VEC4
        }

        /// <summary>
        /// Shader uniform data type
        /// </summary>
        public enum ShaderUniformDataType
        {
            SHADER_UNIFORM_FLOAT = 0,
            SHADER_UNIFORM_VEC2,
            SHADER_UNIFORM_VEC3,
            SHADER_UNIFORM_VEC4,
            SHADER_UNIFORM_INT,
            SHADER_UNIFORM_IVEC2,
            SHADER_UNIFORM_IVEC3,
            SHADER_UNIFORM_IVEC4,
            SHADER_UNIFORM_SAMPLER2D
        }

        /// <summary>
        /// Shader type (generic)
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct Shader
        {
            /// <summary>
            /// Shader program id
            /// </summary>
            public uint id;

            /// <summary>
            /// Shader locations array (MAX_SHADER_LOCATIONS, int *)
            /// </summary>
            public int[] locs;
        }

        #endregion

        #region Texture2D

        /// <summary>
        /// Texture parameters: filter mode<br/>
        /// NOTE 1: Filtering considers mipmaps if available in the texture<br/>
        /// NOTE 2: Filter is accordingly set for minification and magnification
        /// </summary>
        public enum TextureFilter
        {
            /// <summary>
            /// No filter, just pixel aproximation
            /// </summary>
            TEXTURE_FILTER_POINT = 0,

            /// <summary>
            /// Linear filtering
            /// </summary>
            TEXTURE_FILTER_BILINEAR,

            /// <summary>
            /// Trilinear filtering (linear with mipmaps)
            /// </summary>
            TEXTURE_FILTER_TRILINEAR,

            /// <summary>
            /// Anisotropic filtering 4x
            /// </summary>
            TEXTURE_FILTER_ANISOTROPIC_4X,

            /// <summary>
            /// Anisotropic filtering 8x
            /// </summary>
            TEXTURE_FILTER_ANISOTROPIC_8X,

            /// <summary>
            /// Anisotropic filtering 16x
            /// </summary>
            TEXTURE_FILTER_ANISOTROPIC_16X,
        }

        /// <summary>
        /// Texture parameters: wrap mode
        /// </summary>
        public enum TextureWrap
        {
            /// <summary>
            /// Repeats texture in tiled mode
            /// </summary>
            TEXTURE_WRAP_REPEAT = 0,

            /// <summary>
            /// Clamps texture to edge pixel in tiled mode
            /// </summary>
            TEXTURE_WRAP_CLAMP,

            /// <summary>
            /// Mirrors and repeats the texture in tiled mode
            /// </summary>
            TEXTURE_WRAP_MIRROR_REPEAT,

            /// <summary>
            /// Mirrors and clamps to border the texture in tiled mode
            /// </summary>
            TEXTURE_WRAP_MIRROR_CLAMP
        }

        /// <summary>
        /// Cubemap layouts
        /// </summary>
        public enum CubemapLayout
        {
            /// <summary>
            /// Automatically detect layout type
            /// </summary>
            CUBEMAP_LAYOUT_AUTO_DETECT = 0,

            /// <summary>
            /// Layout is defined by a vertical line with faces
            /// </summary>
            CUBEMAP_LAYOUT_LINE_VERTICAL,

            /// <summary>
            /// Layout is defined by a horizontal line with faces
            /// </summary>
            CUBEMAP_LAYOUT_LINE_HORIZONTAL,

            /// <summary>
            /// Layout is defined by a 3x4 cross with cubemap faces
            /// </summary>
            CUBEMAP_LAYOUT_CROSS_THREE_BY_FOUR,

            /// <summary>
            /// Layout is defined by a 4x3 cross with cubemap faces
            /// </summary>
            CUBEMAP_LAYOUT_CROSS_FOUR_BY_THREE,

            /// <summary>
            /// Layout is defined by a panorama image (equirectangular map)
            /// </summary>
            CUBEMAP_LAYOUT_PANORAMA
        }

        /// <summary>
        /// Texture2D type<br/>
        /// NOTE: Data stored in GPU memory
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public partial struct Texture2D
        {
            /// <summary>
            /// OpenGL texture id
            /// </summary>
            public uint id;

            /// <summary>
            /// Texture base width
            /// </summary>
            public int width;

            /// <summary>
            /// Texture base height
            /// </summary>
            public int height;

            /// <summary>
            /// Mipmap levels, 1 by default
            /// </summary>
            public int mipmaps;

            /// <summary>
            /// Data format (PixelFormat type)
            /// </summary>
            public PixelFormat format;
        }

        #endregion

        #region Camera3D

        /// <summary>
        /// Camera system modes
        /// </summary>
        public enum CameraMode
        {
            CAMERA_CUSTOM = 0,
            CAMERA_FREE,
            CAMERA_ORBITAL,
            CAMERA_FIRST_PERSON,
            CAMERA_THIRD_PERSON
        }

        /// <summary>
        /// Camera projection
        /// </summary>
        public enum CameraProjection
        {
            CAMERA_PERSPECTIVE = 0,
            CAMERA_ORTHOGRAPHIC
        }

        /// <summary>
        /// Camera3D, defines position/orientation in 3d space
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public partial struct Camera3D
        {
            /// <summary>
            /// Camera position
            /// </summary>
            public System.Numerics.Vector3 position;

            /// <summary>
            /// Camera target it looks-at
            /// </summary>
            public System.Numerics.Vector3 target;

            /// <summary>
            /// Camera up vector (rotation over its axis)
            /// </summary>
            public System.Numerics.Vector3 up;

            /// <summary>
            /// Camera field-of-view apperture in Y (degrees) in perspective, used as near plane width in orthographic
            /// </summary>
            public float fovy;

            /// <summary>
            /// Camera type, defines projection type: CAMERA_PERSPECTIVE or CAMERA_ORTHOGRAPHIC
            /// </summary>
            public CameraProjection projection;

            public Camera3D(System.Numerics.Vector3 position, System.Numerics.Vector3 target, System.Numerics.Vector3 up, float fovy, CameraProjection projection)
            {
                this.position = position;
                this.target = target;
                this.up = up;
                this.fovy = fovy;
                this.projection = projection;
            }
        }

        #endregion

        #region Camera2D

        /// <summary>
        /// Camera2D, defines position/orientation in 2d space
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public partial struct Camera2D
        {
            /// <summary>
            /// Camera offset (displacement from target)
            /// </summary>
            public System.Numerics.Vector2 offset;

            /// <summary>
            /// Camera target (rotation and zoom origin)
            /// </summary>
            public System.Numerics.Vector2 target;

            /// <summary>
            ///  Camera rotation in degrees
            /// </summary>
            public float rotation;

            /// <summary>
            /// Camera zoom (scaling), should be 1.0f by default
            /// </summary>
            public float zoom;

            public Camera2D(System.Numerics.Vector2 offset, System.Numerics.Vector2 target, float rotation, float zoom)
            {
                this.offset = offset;
                this.target = target;
                this.rotation = rotation;
                this.zoom = zoom;
            }
        }

        #endregion

        #region Ray

        /// <summary>
        /// Ray, ray for raycasting
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public partial struct Ray
        {
            /// <summary>
            /// Ray position (origin)
            /// </summary>
            public System.Numerics.Vector3 position;

            /// <summary>
            /// Ray direction
            /// </summary>
            public System.Numerics.Vector3 direction;

            public Ray(System.Numerics.Vector3 position, System.Numerics.Vector3 direction)
            {
                this.position = position;
                this.direction = direction;
            }
        }

        /// <summary>
        /// Raycast hit information
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public partial struct RayCollision
        {
            /// <summary>
            /// Did the ray hit something?
            /// </summary>
            public CBool hit;

            /// <summary>
            /// Distance to the nearest hit
            /// </summary>
            public float distance;

            /// <summary>
            /// Point of the nearest hit
            /// </summary>
            public System.Numerics.Vector3 point;

            /// <summary>
            /// Surface normal of hit
            /// </summary>
            public System.Numerics.Vector3 normal;
        }

        #endregion

        #region FilePathList

        /// <summary>
        /// File path list
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct FilePathList
        {
            /// <summary>
            /// Filepaths max entries
            /// </summary>
            public uint capacity;

            /// <summary>
            /// Filepaths entries count
            /// </summary>
            public uint count;

            /// <summary>
            /// Filepaths entries
            /// </summary>
            public byte** paths;
        }

        #endregion

        #region RenderTexture2D

        /// <summary>
        /// RenderTexture2D type, for texture rendering
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public partial struct RenderTexture2D
        {
            /// <summary>
            /// OpenGL Framebuffer Object (FBO) id
            /// </summary>
            public uint id;

            /// <summary>
            ///  Color buffer attachment texture
            /// </summary>
            public Texture2D texture;

            /// <summary>
            /// Depth buffer attachment texture
            /// </summary>
            public Texture2D depth;
        }

        #endregion

        #region Font

        /// <summary>
        /// Font type, defines generation method
        /// </summary>
        public enum FontType
        {
            /// <summary>
            /// Default font generation, anti-aliased
            /// </summary>
            FONT_DEFAULT = 0,

            /// <summary>
            /// Bitmap font generation, no anti-aliasing
            /// </summary>
            FONT_BITMAP,

            /// <summary>
            /// SDF font generation, requires external shader
            /// </summary>
            FONT_SDF
        }

        /// <summary>
        /// GlyphInfo, font characters glyphs info
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public partial struct GlyphInfo
        {
            /// <summary>
            /// Character value (Unicode)
            /// </summary>
            public int value;

            /// <summary>
            /// Character offset X when drawing
            /// </summary>
            public int offsetX;

            /// <summary>
            /// Character offset Y when drawing
            /// </summary>
            public int offsetY;

            /// <summary>
            /// Character advance position X
            /// </summary>
            public int advanceX;

            /// <summary>
            /// Character image data
            /// </summary>
            public Image image;
        }

        /// <summary>
        /// Font, font texture and GlyphInfo array data
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct Font
        {
            /// <summary>
            /// Base size (default chars height)
            /// </summary>
            public int baseSize;

            /// <summary>
            /// Number of characters
            /// </summary>
            public int glyphCount;

            /// <summary>
            /// Padding around the glyph characters
            /// </summary>
            public int glyphPadding;

            /// <summary>
            /// Texture atlas containing the glyphs
            /// </summary>
            public Texture2D texture;

            /// <summary>
            /// Rectangles in texture for the glyphs
            /// </summary>
            public Rectangle[] recs;

            /// <summary>
            /// Glyphs info data
            /// </summary>
            public GlyphInfo[] glyphs;
        }

        #endregion

        #region Color

        /// <summary>
        /// Color type, RGBA (32bit)
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public partial struct Color
        {
            public byte r;
            public byte g;
            public byte b;
            public byte a;

            // Example - Color.RED instead of RED
            // Custom raylib color palette for amazing visuals
            public static readonly Color LIGHTGRAY = new Color(200, 200, 200, 255);
            public static readonly Color GRAY = new Color(130, 130, 130, 255);
            public static readonly Color DARKGRAY = new Color(80, 80, 80, 255);
            public static readonly Color YELLOW = new Color(253, 249, 0, 255);
            public static readonly Color GOLD = new Color(255, 203, 0, 255);
            public static readonly Color ORANGE = new Color(255, 161, 0, 255);
            public static readonly Color PINK = new Color(255, 109, 194, 255);
            public static readonly Color RED = new Color(230, 41, 55, 255);
            public static readonly Color MAROON = new Color(190, 33, 55, 255);
            public static readonly Color GREEN = new Color(0, 228, 48, 255);
            public static readonly Color LIME = new Color(0, 158, 47, 255);
            public static readonly Color DARKGREEN = new Color(0, 117, 44, 255);
            public static readonly Color SKYBLUE = new Color(102, 191, 255, 255);
            public static readonly Color BLUE = new Color(0, 121, 241, 255);
            public static readonly Color DARKBLUE = new Color(0, 82, 172, 255);
            public static readonly Color PURPLE = new Color(200, 122, 255, 255);
            public static readonly Color VIOLET = new Color(135, 60, 190, 255);
            public static readonly Color DARKPURPLE = new Color(112, 31, 126, 255);
            public static readonly Color BEIGE = new Color(211, 176, 131, 255);
            public static readonly Color BROWN = new Color(127, 106, 79, 255);
            public static readonly Color DARKBROWN = new Color(76, 63, 47, 255);
            public static readonly Color WHITE = new Color(255, 255, 255, 255);
            public static readonly Color BLACK = new Color(0, 0, 0, 255);
            public static readonly Color BLANK = new Color(0, 0, 0, 0);
            public static readonly Color MAGENTA = new Color(255, 0, 255, 255);
            public static readonly Color RAYWHITE = new Color(245, 245, 245, 255);

            public Color(byte r, byte g, byte b, byte a)
            {
                this.r = r;
                this.g = g;
                this.b = b;
                this.a = a;
            }

            public Color(int r, int g, int b, int a)
            {
                this.r = Convert.ToByte(r);
                this.g = Convert.ToByte(g);
                this.b = Convert.ToByte(b);
                this.a = Convert.ToByte(a);
            }

            public override string ToString()
            {
                return $"{{R:{r} G:{g} B:{b} A:{a}}}";
            }
        }

        #endregion

        #region NPathInfo

        /// <summary>
        /// N-patch layout
        /// </summary>
        public enum NPatchLayout
        {
            /// <summary>
            /// Npatch defined by 3x3 tiles
            /// </summary>
            NPATCH_NINE_PATCH = 0,

            /// <summary>
            /// Npatch defined by 1x3 tiles
            /// </summary>
            NPATCH_THREE_PATCH_VERTICAL,

            /// <summary>
            /// Npatch defined by 3x1 tiles
            /// </summary>
            NPATCH_THREE_PATCH_HORIZONTAL
        }

        /// <summary>
        /// N-Patch layout info
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public partial struct NPatchInfo
        {
            /// <summary>
            /// Texture source rectangle
            /// </summary>
            public Rectangle source;

            /// <summary>
            /// Left border offset
            /// </summary>
            public int left;

            /// <summary>
            /// Top border offset
            /// </summary>
            public int top;

            /// <summary>
            /// Right border offset
            /// </summary>
            public int right;

            /// <summary>
            /// Bottom border offset
            /// </summary>
            public int bottom;

            /// <summary>
            /// Layout of the n-patch: 3x3, 1x3 or 3x1
            /// </summary>
            public NPatchLayout layout;
        }

        #endregion

        #region Image

        /// <summary>
        /// Pixel formats<br/>
        /// NOTE: Support depends on OpenGL version and platform
        /// </summary>
        public enum PixelFormat
        {
            /// <summary>
            /// 8 bit per pixel (no alpha)
            /// </summary>
            PIXELFORMAT_UNCOMPRESSED_GRAYSCALE = 1,

            /// <summary>
            /// 8*2 bpp (2 channels)
            /// </summary>
            PIXELFORMAT_UNCOMPRESSED_GRAY_ALPHA,

            /// <summary>
            /// 16 bpp
            /// </summary>
            PIXELFORMAT_UNCOMPRESSED_R5G6B5,

            /// <summary>
            /// 24 bpp
            /// </summary>
            PIXELFORMAT_UNCOMPRESSED_R8G8B8,

            /// <summary>
            /// 16 bpp (1 bit alpha)
            /// </summary>
            PIXELFORMAT_UNCOMPRESSED_R5G5B5A1,

            /// <summary>
            /// 16 bpp (4 bit alpha)
            /// </summary>
            PIXELFORMAT_UNCOMPRESSED_R4G4B4A4,

            /// <summary>
            /// 32 bpp
            /// </summary>
            PIXELFORMAT_UNCOMPRESSED_R8G8B8A8,

            /// <summary>
            /// 32 bpp (1 channel - float)
            /// </summary>
            PIXELFORMAT_UNCOMPRESSED_R32,

            /// <summary>
            /// 32*3 bpp (3 channels - float)
            /// </summary>
            PIXELFORMAT_UNCOMPRESSED_R32G32B32,

            /// <summary>
            /// 32*4 bpp (4 channels - float)
            /// </summary>
            PIXELFORMAT_UNCOMPRESSED_R32G32B32A32,

            /// <summary>
            /// 4 bpp (no alpha)
            /// </summary>
            PIXELFORMAT_COMPRESSED_DXT1_RGB,

            /// <summary>
            /// 4 bpp (1 bit alpha)
            /// </summary>
            PIXELFORMAT_COMPRESSED_DXT1_RGBA,

            /// <summary>
            /// 8 bpp
            /// </summary>
            PIXELFORMAT_COMPRESSED_DXT3_RGBA,

            /// <summary>
            /// 8 bpp
            /// </summary>
            PIXELFORMAT_COMPRESSED_DXT5_RGBA,

            /// <summary>
            /// 4 bpp
            /// </summary>
            PIXELFORMAT_COMPRESSED_ETC1_RGB,

            /// <summary>
            /// 4 bpp
            /// </summary>
            PIXELFORMAT_COMPRESSED_ETC2_RGB,

            /// <summary>
            /// 8 bpp
            /// </summary>
            PIXELFORMAT_COMPRESSED_ETC2_EAC_RGBA,

            /// <summary>
            /// 4 bpp
            /// </summary>
            PIXELFORMAT_COMPRESSED_PVRT_RGB,

            /// <summary>
            /// 4 bpp
            /// </summary>
            PIXELFORMAT_COMPRESSED_PVRT_RGBA,

            /// <summary>
            /// 8 bpp
            /// </summary>
            PIXELFORMAT_COMPRESSED_ASTC_4x4_RGBA,

            /// <summary>
            /// 2 bpp
            /// </summary>
            PIXELFORMAT_COMPRESSED_ASTC_8x8_RGBA
        }

        /// <summary>
        /// Image, pixel data stored in CPU memory (RAM)
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct Image
        {
            /// <summary>
            /// Image raw data
            /// </summary>
            public void* data;

            /// <summary>
            /// Image base width
            /// </summary>
            public int width;

            /// <summary>
            /// Image base height
            /// </summary>
            public int height;

            /// <summary>
            /// Mipmap levels, 1 by default
            /// </summary>
            public int mipmaps;

            /// <summary>
            /// Data format (PixelFormat type)
            /// </summary>
            public PixelFormat format;
        }

        #endregion

        #region Rectangle

        /// <summary>
        /// Rectangle type
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public partial struct Rectangle
        {
            public float x;
            public float y;
            public float width;
            public float height;

            public Rectangle(float x, float y, float width, float height)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }

            public override string ToString()
            {
                return $"{{X:{x} Y:{y} Width:{width} Height:{height}}}";
            }
        }

        #endregion

    }
}
