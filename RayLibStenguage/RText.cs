using Raylib_cs;
using Stenguage.Runtime.Values;
using Stenguage.Runtime;
using Stenguage;
using System.Runtime.InteropServices;

namespace RayLibStenguage
{
    public class RText
    {
        // Font GetFontDefault(void);
        // Font LoadFont(string fileName);
        // Font LoadFontEx(string fileName, int fontSize, int *fontChars, int glyphCount);
        // Font LoadFontFromImage(Image image, Color key, int firstChar);
        // Font LoadFontFromMemory(string fileType, const unsigned char *fileData, int dataSize, int fontSize, int *fontChars, int glyphCount);
        // bool IsFontReady(Font font);
        // GlyphInfo *LoadFontData(const unsigned char *fileData, int dataSize, int fontSize, int *fontChars, int glyphCount, int type);
        // Image GenImageFontAtlas(const GlyphInfo *chars, Rectangle **recs, int glyphCount, int fontSize, int padding, int packMethod);
        // void UnloadFontData(GlyphInfo *chars, int glyphCount);
        // void UnloadFont(Font font);
        // bool ExportFontAsCode(Font font, string fileName);
        public static RuntimeResult DrawFPS(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue posX, NumberValue posY)
        {
            Raylib.DrawFPS((int)posX.Value, (int)posY.Value);
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawText(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue text, NumberValue posX, NumberValue posY, NumberValue fontSize, Color color)
        {
            Raylib.DrawText(
                text.Value, 
                (int)posX.Value, 
                (int)posY.Value, 
                (int)fontSize.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        // void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);
        // void DrawTextPro(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint);
        // void DrawTextCodepoint(Font font, int codepoint, Vector2 position, float fontSize, Color tint);
        // void DrawTextCodepoints(Font font, const int *codepoints, int count, Vector2 position, float fontSize, float spacing, Color tint);
        public static RuntimeResult MeasureText(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue text, NumberValue fontSize)
        {
            return new RuntimeResult().Success(new NumberValue(
                Raylib.MeasureText(
                    text.Value,
                    (int)fontSize.Value
                ),
            scope.SourceCode, start, end));
        }
        // Vector2 MeasureTextEx(Font font, string text, float fontSize, float spacing);
        // int GetGlyphIndex(Font font, int codepoint);
        // GlyphInfo GetGlyphInfo(Font font, int codepoint);
        // Rectangle GetGlyphAtlasRec(Font font, int codepoint);
        // char *LoadUTF8(const int *codepoints, int length);
        // void UnloadUTF8(char *text);
        // int *LoadCodepoints(string text, int *count);
        // void UnloadCodepoints(int *codepoints);
        public static RuntimeResult GetCodepointCount(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue text)
        {
            return new RuntimeResult().Success(new NumberValue(Raylib.GetCodepointCount(text.Value), scope.SourceCode, start, end));
        }
        // int GetCodepoint(string text, int *codepointSize);
        // int GetCodepointNext(string text, int *codepointSize);
        // int GetCodepointPrevious(string text, int *codepointSize);
        // string CodepointToUTF8(int codepoint, int *utf8Size);
        // int TextCopy(char *dst, string src);
        public unsafe static RuntimeResult TextIsEqual(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue text1, StringValue text2)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.TextIsEqual(
                    Utils.StringToSBytePtr(text1.Value),
                    Utils.StringToSBytePtr(text2.Value)
                ),
            scope.SourceCode, start, end));
        }
        // unsigned int TextLength(string text);
        // string TextFormat(string text, ...);
        public unsafe static RuntimeResult TextSubtext(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue text, NumberValue position, NumberValue length)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.TextSubtext(
                        Utils.StringToSBytePtr(text.Value), 
                        (int)position.Value,
                        (int)length.Value
                    )
                ),
            scope.SourceCode, start, end));
        }
        // char *TextReplace(char *text, string replace, string by);
        // char *TextInsert(string text, string insert, int position);
        // string TextJoin(string *textList, int count, string delimiter);
        // string *TextSplit(string text, char delimiter, int *count);
        // void TextAppend(char *text, string append, int *position);
        public unsafe static RuntimeResult TextFindIndex(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue text, StringValue find)
        {
            return new RuntimeResult().Success(new NumberValue(
                Raylib.TextFindIndex(
                    Utils.StringToSBytePtr(text.Value),
                    Utils.StringToSBytePtr(find.Value)
                ),
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult TextToUpper(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue text)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.TextToUpper(
                        Utils.StringToSBytePtr(text.Value)
                    )
                ),
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult TextToLower(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue text)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.TextToLower(
                        Utils.StringToSBytePtr(text.Value)
                    )
                ),
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult TextToPascal(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue text)
        {
            return new RuntimeResult().Success(new StringValue(
                Marshal.PtrToStringAnsi(
                    (IntPtr)Raylib.TextToPascal(
                        Utils.StringToSBytePtr(text.Value)
                    )
                ),
            scope.SourceCode, start, end));
        }
        public unsafe static RuntimeResult TextToInteger(Stenguage.Runtime.Environment scope, Position start, Position end, 
            StringValue text)
        {
            return new RuntimeResult().Success(new NumberValue(
                Raylib.TextToInteger(
                    Utils.StringToSBytePtr(text.Value)
                ),
            scope.SourceCode, start, end));
        }
    }
}
