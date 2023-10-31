
using Stenguage.Runtime.Values;
using Stenguage.Runtime;
using RayLibStenguage.Classes;
using System.Runtime.InteropServices;

namespace RayLibStenguage
{
    public class RText
    {
        //  Font loading/unloading functions 

        // Font GetFontDefault(void);                                                            // Get the default Font 
        public static RuntimeResult GetFontDefault(Context ctx)
        {
            return new RuntimeResult().Success(new Font(Imports.GetFontDefault()));
        }

        // Font LoadFont(string fileName);                                                  // Load font from file into GPU memory (VRAM) 
        public static RuntimeResult LoadFont(Context ctx,
            StringValue fileName)
        {
            return new RuntimeResult().Success(new Font(Imports.LoadFont(fileName.Value)));
        }

        // Font LoadFontEx(string fileName, int fontSize, IntPtr fontChars, int glyphCount);  // Load font from file with extended parameters, use NULL for fontChars and 0 for glyphCount to load the default character set 
        public static RuntimeResult LoadFontEx(Context ctx,
            StringValue fileName, NumberValue fontSize, IntPtr fontChars, NumberValue glyphCount)
        {
            return new RuntimeResult().Success(new Font(Imports.LoadFontEx(fileName.Value, (int)fontSize.Value, fontChars, (int)glyphCount.Value)));
        }

        // Font LoadFontFromImage(Image image, Color key, int firstChar);                        // Load font from Image (XNA style) 
        public static RuntimeResult LoadFontFromImage(Context ctx,
            Image image, Color key, NumberValue firstChar)
        {
            return new RuntimeResult().Success(new Font(Imports.LoadFontFromImage(image.Source, key.Struct, (int)firstChar.Value)));
        }

        // Font LoadFontFromMemory(string fileType, string fileData, int dataSize, int fontSize, IntPtr fontChars, int glyphCount); // Load font from memory buffer, fileType refers to extension: i.e. '.ttf' 
        public static RuntimeResult LoadFontFromMemory(Context ctx,
            StringValue fileType, StringValue fileData, NumberValue dataSize, NumberValue fontSize, IntPtr fontChars, NumberValue glyphCount)
        {
            return new RuntimeResult().Success(new Font(Imports.LoadFontFromMemory(fileType.Value, fileData.Value, (int)dataSize.Value, (int)fontSize.Value, fontChars, (int)glyphCount.Value)));
        }

        // bool IsFontReady(Font font);                                                          // Check if a font is ready 
        public static RuntimeResult IsFontReady(Context ctx,
            Font font)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsFontReady(font.Struct)));
        }

        // TODO: Fix the fontChars
        // GlyphInfo[] LoadFontData(string fileData, int dataSize, int fontSize, IntPtr fontChars, int glyphCount, int type); // Load font data for further use 
        public static RuntimeResult LoadFontData(Context ctx,
            StringValue fileData, NumberValue dataSize, NumberValue fontSize, IntPtr fontChars, NumberValue glyphCount, NumberValue type)
        {
            return new RuntimeResult().Success(new ListValue(
                Imports.LoadFontData(
                    fileData.Value, 
                    (int)dataSize.Value, 
                    (int)fontSize.Value, 
                    fontChars, 
                    (int)glyphCount.Value,
                    (int)type.Value
                ).Select(x => new GlyphInfo(x)).Cast<RuntimeValue>().ToList()
            ));
        }

        // Image GenImageFontAtlas(GlyphInfo[] chars, Rectangle **recs, int glyphCount, int fontSize, int padding, int packMethod); // Generate image font atlas using chars info 
        public static unsafe RuntimeResult GenImageFontAtlas(Context ctx,
            ListValue chars, ListValue recs, NumberValue glyphCount, NumberValue fontSize, NumberValue padding, NumberValue packMethod)
        {
            GCHandle recsHandle = GCHandle.Alloc(
                recs.Items
                    .Where(x => x.GetType() == typeof(Rectangle))
                    .Select(x => ((Rectangle)x).Struct)
                    .ToArray(), 
                GCHandleType.Pinned
            );
            Structs.Image image = Imports.GenImageFontAtlas(
                chars.Items
                    .Where(x => x.GetType() == typeof(GlyphInfo))
                    .Select(x => ((GlyphInfo)x).Struct)
                    .ToArray(),
                (Structs.Rectangle[]*)((IntPtr)(&recsHandle)).ToPointer(), 
                (int)glyphCount.Value, 
                (int)fontSize.Value, 
                (int)padding.Value, 
                (int)packMethod.Value
            );
            return new RuntimeResult().Success(new Image(Imports.GenImageFontAtlas(chars, **recs.Struct, (int)glyphCount.Value, (int)fontSize.Value, (int)padding.Value, (int)packMethod.Value)));
        }

        // void UnloadFontData(GlyphInfo[] chars, int glyphCount);                                // Unload font chars info data (RAM) 
        public static RuntimeResult UnloadFontData(Context ctx,
            ListValue chars, NumberValue glyphCount)
        {
            Imports.UnloadFontData(
                chars.Items
                    .Where(x => x.GetType() == typeof(GlyphInfo))
                    .Select(x => ((GlyphInfo)x).Struct)
                    .ToArray(), 
                (int)glyphCount.Value);
            return RuntimeResult.Null();
        }

        // void UnloadFont(Font font);                                                           // Unload font from GPU memory (VRAM) 
        public static RuntimeResult UnloadFont(Context ctx,
            Font font)
        {
            Imports.UnloadFont(font.Struct);
            return RuntimeResult.Null();
        }

        // bool ExportFontAsCode(Font font, string fileName);                               // Export font as code file, returns true on success 
        public static RuntimeResult ExportFontAsCode(Context ctx,
            Font font, StringValue fileName)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.ExportFontAsCode(font.Struct, fileName.Value)));
        }

        //  Text drawing functions 

        // void DrawFPS(int posX, int posY);                                                     // Draw current FPS 
        public static RuntimeResult DrawFPS(Context ctx,
            NumberValue posX, NumberValue posY)
        {
            Imports.DrawFPS((int)posX.Value, (int)posY.Value);
            return RuntimeResult.Null();
        }

        // void DrawText(string text, int posX, int posY, int fontSize, Color color);       // Draw text (using default font) 
        public static RuntimeResult DrawText(Context ctx,
            StringValue text, NumberValue posX, NumberValue posY, NumberValue fontSize, Color color)
        {
            Imports.DrawText(text.Value, (int)posX.Value, (int)posY.Value, (int)fontSize.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint); // Draw text using font and additional parameters 
        public static RuntimeResult DrawTextEx(Context ctx,
            Font font, StringValue text, Vector2 position, NumberValue fontSize, NumberValue spacing, Color tint)
        {
            Imports.DrawTextEx(font.Struct, text.Value, position.Struct, (float)fontSize.Value, (float)spacing.Value, tint.Struct);
            return RuntimeResult.Null();
        }

        // void DrawTextPro(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint); // Draw text using Font and pro parameters (rotation) 
        public static RuntimeResult DrawTextPro(Context ctx,
            Font font, StringValue text, Vector2 position, Vector2 origin, NumberValue rotation, NumberValue fontSize, NumberValue spacing, Color tint)
        {
            Imports.DrawTextPro(font.Struct, text.Value, position.Struct, origin.Struct, (float)rotation.Value, (float)fontSize.Value, (float)spacing.Value, tint.Struct);
            return RuntimeResult.Null();
        }

        // void DrawTextCodepoint(Font font, int codepoint, Vector2 position, float fontSize, Color tint); // Draw one character (codepoint) 
        public static RuntimeResult DrawTextCodepoint(Context ctx,
            Font font, NumberValue codepoint, Vector2 position, NumberValue fontSize, Color tint)
        {
            Imports.DrawTextCodepoint(font.Struct, (int)codepoint.Value, position.Struct, (float)fontSize.Value, tint.Struct);
            return RuntimeResult.Null();
        }

        // void DrawTextCodepoints(Font font, IntPtr codepoints, int count, Vector2 position, float fontSize, float spacing, Color tint); // Draw multiple character (codepoint) 
        public static RuntimeResult DrawTextCodepoints(Context ctx,
            Font font, IntPtr codepoints, NumberValue count, Vector2 position, NumberValue fontSize, NumberValue spacing, Color tint)
        {
            Imports.DrawTextCodepoints(font.Struct, codepoints, (int)count.Value, position.Struct, (float)fontSize.Value, (float)spacing.Value, tint.Struct);
            return RuntimeResult.Null();
        }

        //  Text font info functions 

        // int MeasureText(string text, int fontSize);                                      // Measure string width for default font 
        public static RuntimeResult MeasureText(Context ctx,
            StringValue text, NumberValue fontSize)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.MeasureText(text.Value, (int)fontSize.Value)));
        }

        // Vector2 MeasureTextEx(Font font, string text, float fontSize, float spacing);    // Measure string size for Font 
        public static RuntimeResult MeasureTextEx(Context ctx,
            Font font, StringValue text, NumberValue fontSize, NumberValue spacing)
        {
            return new RuntimeResult().Success(new Vector2(Imports.MeasureTextEx(font.Struct, text.Value, (float)fontSize.Value, (float)spacing.Value)));
        }

        // int GetGlyphIndex(Font font, int codepoint);                                          // Get glyph index position in font for a codepoint (unicode character), fallback to '?' if not found 
        public static RuntimeResult GetGlyphIndex(Context ctx,
            Font font, NumberValue codepoint)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetGlyphIndex(font.Struct, (int)codepoint.Value)));
        }

        // GlyphInfo GetGlyphInfo(Font font, int codepoint);                                     // Get glyph font info data for a codepoint (unicode character), fallback to '?' if not found 
        public static RuntimeResult GetGlyphInfo(Context ctx,
            Font font, NumberValue codepoint)
        {
            return new RuntimeResult().Success(new GlyphInfo(Imports.GetGlyphInfo(font.Struct, (int)codepoint.Value)));
        }

        // Rectangle GetGlyphAtlasRec(Font font, int codepoint);                                 // Get glyph rectangle in font atlas for a codepoint (unicode character), fallback to '?' if not found 
        public static RuntimeResult GetGlyphAtlasRec(Context ctx,
            Font font, NumberValue codepoint)
        {
            return new RuntimeResult().Success(new Rectangle(Imports.GetGlyphAtlasRec(font.Struct, (int)codepoint.Value)));
        }

        //  Text codepoints management functions (unicode characters) 

        // string LoadUTF8(IntPtr codepoints, int length);                // Load UTF-8 text encoded from codepoints array 
        public static RuntimeResult LoadUTF8(Context ctx,
            IntPtr codepoints, NumberValue length)
        {
            return new RuntimeResult().Success(new StringValue(Imports.LoadUTF8(codepoints, (int)length.Value)));
        }

        // void UnloadUTF8(string text);                                      // Unload UTF-8 text encoded from codepoints array 
        public static RuntimeResult UnloadUTF8(Context ctx,
            StringValue text)
        {
            Imports.UnloadUTF8(text.Value);
            return RuntimeResult.Null();
        }

        // IntPtr LoadCodepoints(string text, IntPtr count);                // Load all codepoints from a UTF-8 text string, codepoints count returned by parameter 
        public static RuntimeResult LoadCodepoints(Context ctx,
            StringValue text, NumberValue count)
        {
            return new RuntimeResult().Success(new IntPtr(Imports.LoadCodepoints(text.Value, (int)count.Value)));
        }

        // void UnloadCodepoints(IntPtr codepoints);                           // Unload codepoints data from memory 
        public static RuntimeResult UnloadCodepoints(Context ctx,
            IntPtr codepoints)
        {
            Imports.UnloadCodepoints(codepoints);
            return RuntimeResult.Null();
        }

        // int GetCodepointCount(string text);                          // Get total number of codepoints in a UTF-8 encoded string 
        public static RuntimeResult GetCodepointCount(Context ctx,
            StringValue text)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetCodepointCount(text.Value)));
        }

        // int GetCodepoint(string text, IntPtr codepointSize);           // Get next codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure 
        public static RuntimeResult GetCodepoint(Context ctx,
            StringValue text, NumberValue codepointSize)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetCodepoint(text.Value, (int)codepointSize.Value)));
        }

        // int GetCodepointNext(string text, IntPtr codepointSize);       // Get next codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure 
        public static RuntimeResult GetCodepointNext(Context ctx,
            StringValue text, NumberValue codepointSize)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetCodepointNext(text.Value, (int)codepointSize.Value)));
        }

        // int GetCodepointPrevious(string text, IntPtr codepointSize);   // Get previous codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure 
        public static RuntimeResult GetCodepointPrevious(Context ctx,
            StringValue text, NumberValue codepointSize)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.GetCodepointPrevious(text.Value, (int)codepointSize.Value)));
        }

        // string CodepointToUTF8(int codepoint, IntPtr utf8Size);        // Encode one codepoint into UTF-8 byte array (array length returned as parameter) 
        public static RuntimeResult CodepointToUTF8(Context ctx,
            NumberValue codepoint, NumberValue utf8Size)
        {
            return new RuntimeResult().Success(new StringValue(Imports.CodepointToUTF8((int)codepoint.Value, (int)utf8Size.Value)));
        }

        //  Text strings management functions (no UTF-8 strings, only byte chars) 

        //  NOTE: Some strings allocate memory internally for returned strings, just be careful! 

        // int TextCopy(string dst, string src);                                             // Copy one string to another, returns bytes copied 
        public static RuntimeResult TextCopy(Context ctx,
            StringValue dst, StringValue src)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.TextCopy(dst.Value, src.Value)));
        }

        // bool TextIsEqual(string text1, string text2);                               // Check if two text string are equal 
        public static RuntimeResult TextIsEqual(Context ctx,
            StringValue text1, StringValue text2)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.TextIsEqual(text1.Value, text2.Value)));
        }

        // uint TextLength(string text);                                            // Get text length, checks for '\0' ending 
        public static RuntimeResult TextLength(Context ctx,
            StringValue text)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.TextLength(text.Value)));
        }

        // string TextFormat(string text, __arglist);                                        // Text formatting with variables (sprintf() style) 
        public static RuntimeResult TextFormat(Context ctx,
            StringValue text, ListValue args)
        {
            return new RuntimeResult().Success(new StringValue(
                Imports.TextFormat(
                    text.Value, 
                    __arglist(Utils.GetValue(args))
                )
            ));
        }

        // string TextSubtext(string text, int position, int length);                  // Get a piece of a text string 
        public static RuntimeResult TextSubtext(Context ctx,
            StringValue text, NumberValue position, NumberValue length)
        {
            return new RuntimeResult().Success(new StringValue(Imports.TextSubtext(text.Value, (int)position.Value, (int)length.Value)));
        }

        // string TextReplace(string text, string replace, string by);                   // Replace text string (WARNING: memory must be freed!) 
        public static RuntimeResult TextReplace(Context ctx,
            StringValue text, StringValue replace, StringValue by)
        {
            return new RuntimeResult().Success(new StringValue(Imports.TextReplace(text.Value, replace.Value, by.Value)));
        }

        // string TextInsert(string text, string insert, int position);                 // Insert text in a position (WARNING: memory must be freed!) 
        public static RuntimeResult TextInsert(Context ctx,
            StringValue text, StringValue insert, NumberValue position)
        {
            return new RuntimeResult().Success(new StringValue(Imports.TextInsert(text.Value, insert.Value, (int)position.Value)));
        }

        // string TextJoin(string *textList, int count, string delimiter);        // Join text strings with delimiter 
        public static RuntimeResult TextJoin(Context ctx,
            ListValue textList, NumberValue count, StringValue delimiter)
        {
            return new RuntimeResult().Success(new StringValue(
                Imports.TextJoin(
                    textList.Items
                        .Where(x => x.Type == RuntimeValueType.String)
                        .Select(x => ((StringValue)x).Value)
                        .ToArray(), 
                    (int)count.Value, 
                    delimiter.Value
                )
            ));
        }

        // string *TextSplit(string text, char delimiter, IntPtr count);                 // Split text into multiple strings 
        public static RuntimeResult TextSplit(Context ctx,
            StringValue text, char delimiter, NumberValue count)
        {
            return new RuntimeResult().Success(new ListValue(
                Imports.TextSplit(text.Value, delimiter, (int)count.Value)
                    .Select(x => new StringValue(x))
                    .Cast<RuntimeValue>()
                    .ToList()
            ));
        }

        // void TextAppend(string text, string append, IntPtr position);                       // Append text at specific position and move cursor! 
        public static RuntimeResult TextAppend(Context ctx,
            StringValue text, StringValue append, NumberValue position)
        {
            Imports.TextAppend(text.Value, append.Value, (int)position.Value);
            return RuntimeResult.Null();
        }

        // int TextFindIndex(string text, string find);                                // Find first text occurrence within a string 
        public static RuntimeResult TextFindIndex(Context ctx,
            StringValue text, StringValue find)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.TextFindIndex(text.Value, find.Value)));
        }

        // string TextToUpper(string text);                      // Get upper case version of provided string 
        public static RuntimeResult TextToUpper(Context ctx,
            StringValue text)
        {
            return new RuntimeResult().Success(new StringValue(Imports.TextToUpper(text.Value)));
        }

        // string TextToLower(string text);                      // Get lower case version of provided string 
        public static RuntimeResult TextToLower(Context ctx,
            StringValue text)
        {
            return new RuntimeResult().Success(new StringValue(Imports.TextToLower(text.Value)));
        }

        // string TextToPascal(string text);                     // Get Pascal case notation version of provided string 
        public static RuntimeResult TextToPascal(Context ctx,
            StringValue text)
        {
            return new RuntimeResult().Success(new StringValue(Imports.TextToPascal(text.Value)));
        }

        // int TextToInteger(string text);                            // Get integer value from text (negative values not supported 
        public static RuntimeResult TextToInteger(Context ctx,
            StringValue text)
        {
            return new RuntimeResult().Success(new NumberValue(Imports.TextToInteger(text.Value)));
        }

    }
}
