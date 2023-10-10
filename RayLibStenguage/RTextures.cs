using Raylib_cs;
using Stenguage.Runtime.Values;
using Stenguage.Runtime;
using Stenguage;

namespace RayLibStenguage
{
    public class RTextures
    {
        public static RuntimeResult LoadImage(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue fileName)
        {
            Raylib_cs.Image image = Raylib.LoadImage(fileName.Value);
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = image });
        }
        public static RuntimeResult LoadImageRaw(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue fileName, NumberValue width, NumberValue height, NumberValue format, NumberValue headerSize)
        {
            Raylib_cs.Image image = Raylib.LoadImageRaw(
                fileName.Value,
                (int)width.Value,
                (int)height.Value,
                (PixelFormat)format.Value,
                (int)headerSize.Value
            );
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = image });
        }
        // Image LoadImageAnim(string fileName, int *frames);
        // Image LoadImageFromMemory(string fileType, constunsignedchar* fileData, int dataSize);
        // Image LoadImageFromTexture(Texture2D texture);
        public static RuntimeResult LoadImageFromScreen(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Raylib_cs.Image image = Raylib.LoadImageFromScreen();
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = image });
        }
        public static RuntimeResult IsImageReady(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.IsImageReady(image.Source), scope.SourceCode));
        }
        public static RuntimeResult UnloadImage(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image)
        {
            Raylib.UnloadImage(image.Source);
            return RuntimeResult.Null(scope.SourceCode);
        }
        public static RuntimeResult ExportImage(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image, StringValue fileName)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.ExportImage(
                image.Source,
                fileName.Value
            ), scope.SourceCode));
        }
        public static RuntimeResult ExportImageAsCode(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image, StringValue fileName)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.ExportImageAsCode(
                image.Source,
                fileName.Value
            ), scope.SourceCode));
        }
        public static RuntimeResult GenImageColor(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, Color color)
        {
            Raylib_cs.Image image = Raylib.GenImageColor(
                (int)width.Value,
                (int)height.Value,
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = image });
        }
        public static RuntimeResult GenImageGradientRadial(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue density, Color inner, Color outer)
        {
            Raylib_cs.Image image = Raylib.GenImageGradientRadial(
                (int)width.Value,
                (int)height.Value,
                (float)density.Value,
                new Raylib_cs.Color(
                    (byte)inner.R.Value,
                    (byte)inner.G.Value,
                    (byte)inner.B.Value,
                    (byte)inner.A.Value
                ),
                new Raylib_cs.Color(
                    (byte)outer.R.Value,
                    (byte)outer.G.Value,
                    (byte)outer.B.Value,
                    (byte)outer.A.Value
                )
            );
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = image });
        }
        public static RuntimeResult GenImageChecked(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue checksX, NumberValue checksY, Color col1, Color col2)
        {
            Raylib_cs.Image image = Raylib.GenImageChecked(
                (int)width.Value,
                (int)height.Value,
                (int)checksX.Value,
                (int)checksY.Value,
                new Raylib_cs.Color(
                    (byte)col1.R.Value,
                    (byte)col1.G.Value,
                    (byte)col1.B.Value,
                    (byte)col1.A.Value
                ),
                new Raylib_cs.Color(
                    (byte)col2.R.Value,
                    (byte)col2.G.Value,
                    (byte)col2.B.Value,
                    (byte)col2.A.Value
                )
            );
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = image });
        }
        public static RuntimeResult GenImageWhiteNoise(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue factor)
        {
            Raylib_cs.Image image = Raylib.GenImageWhiteNoise(
                (int)width.Value,
                (int)height.Value,
                (float)factor.Value
            );
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = image });
        }
        public static RuntimeResult GenImagePerlinNoise(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue offsetX, NumberValue offsetY, NumberValue scale)
        {
            Raylib_cs.Image image = Raylib.GenImagePerlinNoise(
                (int)width.Value,
                (int)height.Value,
                (int)offsetX.Value,
                (int)offsetY.Value,
                (float)scale.Value
            );
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = image });
        }
        public static RuntimeResult GenImageCellular(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue tileSize)
        {
            Raylib_cs.Image image = Raylib.GenImageCellular(
                (int)width.Value,
                (int)height.Value,
                (int)tileSize.Value
            );
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = image });
        }
        public unsafe static RuntimeResult GenImageText(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue tileSize)
        {
            Raylib_cs.Image image = Raylib.GenImageText(
                (int)width.Value,
                (int)height.Value,
                (int)tileSize.Value
            );
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = image });
        }
        public static RuntimeResult ImageCopy(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image)
        {
            Raylib_cs.Image img = Raylib.ImageCopy(image.Source);
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = img });
        }
        public static RuntimeResult ImageFromImage(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image, Rectangle rec)
        {
            Raylib_cs.Image img = Raylib.ImageFromImage(
                image.Source,
                new Raylib_cs.Rectangle(
                    (float)rec.X.Value,
                    (float)rec.Y.Value,
                    (float)rec.Width.Value,
                    (float)rec.Height.Value
                )
            );
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = img });
        }
        public static RuntimeResult ImageText(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue text, NumberValue fontSize, Color color)
        {
            Raylib_cs.Image image = Raylib.ImageText(
                text.Value,
                (int)fontSize.Value,
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return new RuntimeResult().Success(new Image(scope.SourceCode) { Source = image });
        }
        // Image ImageTextEx(Font font, string text, float fontSize, float spacing, Color tint);
        // void ImageFormat(Image *image, int newFormat);
        // void ImageToPOT(Image *image, Color fill);
        // void ImageCrop(Image *image, Rectangle crop);
        // void ImageAlphaCrop(Image *image, float threshold);
        // void ImageAlphaClear(Image *image, Color color, float threshold);
        // void ImageAlphaMask(Image *image, Image alphaMask);
        // void ImageAlphaPremultiply(Image *image);
        // void ImageBlurGaussian(Image *image, int blurSize);
        // void ImageResize(Image *image, int newWidth, int newHeight);
        // void ImageResizeNN(Image *image, int newWidth,int newHeight);
        // void ImageResizeCanvas(Image *image, int newWidth, int newHeight, int offsetX, int offsetY, Color fill);
        // void ImageMipmaps(Image *image);
        // void ImageDither(Image *image, int rBpp, int gBpp, int bBpp, int aBpp);
        // void ImageFlipVertical(Image *image);
        // void ImageFlipHorizontal(Image *image);
        // void ImageRotate(Image *image, int degrees);
        // void ImageRotateCW(Image *image);
        // void ImageRotateCCW(Image *image);
        // void ImageColorTint(Image *image, Color color);
        // void ImageColorInvert(Image *image);
        // void ImageColorGrayscale(Image *image);
        // void ImageColorContrast(Image *image, float contrast);
        // void ImageColorBrightness(Image *image, int brightness);
        // void ImageColorReplace(Image *image, Color color, Color replace);
        // Color *LoadImageColors(Image image);
        // Color *LoadImagePalette(Image image, int maxPaletteSize, int *colorCount);
        // void UnloadImageColors(Color *colors);
        // void UnloadImagePalette(Color *colors);
        public static RuntimeResult GetImageAlphaBorder(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image, NumberValue threshold)
        {
            Raylib_cs.Rectangle r = Raylib.GetImageAlphaBorder(
                image.Source,
                (float)threshold.Value
            );
            return new RuntimeResult().Success(new Rectangle(scope.SourceCode,
                new NumberValue(r.x, scope.SourceCode),
                new NumberValue(r.y, scope.SourceCode),
                new NumberValue(r.width, scope.SourceCode),
                new NumberValue(r.height, scope.SourceCode)
            ));
        }
        public static RuntimeResult GetImageColor(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image, NumberValue x, NumberValue y)
        {
            Raylib_cs.Color c = Raylib.GetImageColor(
                image.Source,
                (int)x.Value,
                (int)y.Value
            );
            return new RuntimeResult().Success(new Color(scope.SourceCode,
                new NumberValue(c.r, scope.SourceCode),
                new NumberValue(c.g, scope.SourceCode),
                new NumberValue(c.b, scope.SourceCode),
                new NumberValue(c.a, scope.SourceCode)
            ));
        }
        // void ImageClearBackground(Image *dst, Color color);
        // void ImageDrawPixel(Image *dst, int posX, int posY, Color color);
        // void ImageDrawPixelV(Image *dst, Vector2 position, Color color);
        // void ImageDrawLine(Image *dst, int startPosX, int startPosY, int endPosX, int endPosY, Color color);
        // void ImageDrawLineV(Image *dst, Vector2 start, Vector2 end, Color color);
        // void ImageDrawCircle(Image *dst, int centerX, int centerY, int radius, Color color);
        // void ImageDrawCircleV(Image *dst, Vector2 center, int radius, Color color);
        // void ImageDrawCircleLines(Image *dst, int centerX, int centerY, int radius, Color color);
        // void ImageDrawCircleLinesV(Image *dst, Vector2 center, int radius, Color color);
        // void ImageDrawRectangle(Image *dst, int posX, int posY, int width, int height, Color color);
        // void ImageDrawRectangleV(Image *dst, Vector2 position, Vector2 size, Color color);
        // void ImageDrawRectangleRec(Image *dst, Rectangle rec, Color color);
        // void ImageDrawRectangleLines(Image *dst, Rectangle rec, int thick, Color color);
        // void ImageDraw(Image *dst, Image src, Rectangle srcRec, Rectangle dstRec, Color tint);
        // void ImageDrawText(Image *dst, string text, int posX, int posY, int fontSize, Color color);
        // void ImageDrawTextEx(Image *dst, Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);
        // Texture2D LoadTexture(string fileName);
        // Texture2D LoadTextureFromImage(Image image);
        // TextureCubemap LoadTextureCubemap(Image image, int layout);
        // RenderTexture2D LoadRenderTexture(int width, int height);
        // bool IsTextureReady(Texture2D texture);
        // void UnloadTexture(Texture2D texture);
        // bool IsRenderTextureReady(RenderTexture2D target);
        // void UnloadRenderTexture(RenderTexture2D target);
        // void UpdateTexture(Texture2D texture, constvoid* pixels);
        // void UpdateTextureRec(Texture2D texture, Rectangle rec, constvoid* pixels);
        // void GenTextureMipmaps(Texture2D *texture);
        // void SetTextureFilter(Texture2D texture, int filter);
        // void SetTextureWrap(Texture2D texture, int wrap);
        // void DrawTexture(Texture2D texture, int posX, int posY, Color tint);
        // void DrawTextureV(Texture2D texture, Vector2 position, Color tint);
        // void DrawTextureEx(Texture2D texture, Vector2 position, float rotation, float scale, Color tint);
        // void DrawTextureRec(Texture2D texture, Rectangle source, Vector2 position, Color tint);
        // void DrawTexturePro(Texture2D texture, Rectangle source, Rectangle dest, Vector2 origin, float rotation, Color tint);
        // void DrawTextureNPatch(Texture2D texture, NPatchInfo nPatchInfo, Rectangle dest, Vector2 origin, float rotation, Color tint);
        public static RuntimeResult Fade(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color color, NumberValue alpha)
        {
            Raylib_cs.Color c = Raylib.Fade(
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                ),
                (float)alpha.Value
            );
            return new RuntimeResult().Success(new Color(scope.SourceCode,
                new NumberValue(c.r, scope.SourceCode),
                new NumberValue(c.g, scope.SourceCode),
                new NumberValue(c.b, scope.SourceCode),
                new NumberValue(c.a, scope.SourceCode)
            ));
        }
        public static RuntimeResult ColorToInt(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color color)
        {
            return new RuntimeResult().Success(new NumberValue(
                Raylib.ColorToInt(
                    new Raylib_cs.Color(
                        (byte)color.R.Value,
                        (byte)color.G.Value,
                        (byte)color.B.Value,
                        (byte)color.A.Value
                    )
                ),
            scope.SourceCode));
        }
        // Vector4 ColorNormalize(Color color);
        // Color ColorFromNormalized(Vector4 normalized);
        // Vector3 ColorToHSV(Color color);
        public static RuntimeResult ColorFromHSV(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue hue, NumberValue saturation, NumberValue value)
        {
            Raylib_cs.Color c = Raylib.ColorFromHSV(
                (float)hue.Value,
                (float)saturation.Value,
                (float)value.Value
            );
            return new RuntimeResult().Success(new Color(scope.SourceCode,
                new NumberValue(c.r, scope.SourceCode),
                new NumberValue(c.g, scope.SourceCode),
                new NumberValue(c.b, scope.SourceCode),
                new NumberValue(c.a, scope.SourceCode)
            ));
        }
        public static RuntimeResult ColorTint(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color color, Color tint)
        {
            Raylib_cs.Color c = Raylib.ColorTint(
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                ),
                new Raylib_cs.Color(
                    (byte)tint.R.Value,
                    (byte)tint.G.Value,
                    (byte)tint.B.Value,
                    (byte)tint.A.Value
                )
            );
            return new RuntimeResult().Success(new Color(scope.SourceCode,
                new NumberValue(c.r, scope.SourceCode),
                new NumberValue(c.g, scope.SourceCode),
                new NumberValue(c.b, scope.SourceCode),
                new NumberValue(c.a, scope.SourceCode)
            ));
        }
        public static RuntimeResult ColorBrightness(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color color, NumberValue factor)
        {
            Raylib_cs.Color c = Raylib.ColorBrightness(
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                ),
                (float)factor.Value
            );
            return new RuntimeResult().Success(new Color(scope.SourceCode,
                new NumberValue(c.r, scope.SourceCode),
                new NumberValue(c.g, scope.SourceCode),
                new NumberValue(c.b, scope.SourceCode),
                new NumberValue(c.a, scope.SourceCode)
            ));
        }
        public static RuntimeResult ColorContrast(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color color, NumberValue contrast)
        {
            Raylib_cs.Color c = Raylib.ColorContrast(
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                ),
                (float)contrast.Value
            );
            return new RuntimeResult().Success(new Color(scope.SourceCode,
                new NumberValue(c.r, scope.SourceCode),
                new NumberValue(c.g, scope.SourceCode),
                new NumberValue(c.b, scope.SourceCode),
                new NumberValue(c.a, scope.SourceCode)
            ));
        }
        public static RuntimeResult ColorAlpha(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color color, NumberValue alpha)
        {
            Raylib_cs.Color c = Raylib.ColorAlpha(
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                ),
                (float)alpha.Value
            );
            return new RuntimeResult().Success(new Color(scope.SourceCode,
                new NumberValue(c.r, scope.SourceCode),
                new NumberValue(c.g, scope.SourceCode),
                new NumberValue(c.b, scope.SourceCode),
                new NumberValue(c.a, scope.SourceCode)
            ));
        }
        public static RuntimeResult ColorAlphaBlend(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color dst, Color src, Color tint)
        {
            Raylib_cs.Color c = Raylib.ColorAlphaBlend(
                new Raylib_cs.Color(
                    (byte)dst.R.Value,
                    (byte)dst.G.Value,
                    (byte)dst.B.Value,
                    (byte)dst.A.Value
                ),
                new Raylib_cs.Color(
                    (byte)src.R.Value,
                    (byte)src.G.Value,
                    (byte)src.B.Value,
                    (byte)src.A.Value
                ),
                new Raylib_cs.Color(
                    (byte)tint.R.Value,
                    (byte)tint.G.Value,
                    (byte)tint.B.Value,
                    (byte)tint.A.Value
                )
            );
            return new RuntimeResult().Success(new Color(scope.SourceCode,
                new NumberValue(c.r, scope.SourceCode),
                new NumberValue(c.g, scope.SourceCode),
                new NumberValue(c.b, scope.SourceCode),
                new NumberValue(c.a, scope.SourceCode)
            ));
        }
        // Color GetColor(unsigned int hexValue);
        // Color GetPixelColor(void *srcPtr, int format);
        // void SetPixelColor(void *dstPtr, Color color, int format);
        public static RuntimeResult GetPixelDataSize(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue format)
        {
            return new RuntimeResult().Success(new NumberValue(
                Raylib.GetPixelDataSize(
                    (int)width.Value,
                    (int)height.Value,
                    (PixelFormat)format.Value
                ), 
            scope.SourceCode));
        }

    }
}
