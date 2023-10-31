using Stenguage.Runtime.Values;
using Stenguage.Runtime;
using Stenguage;
using RayLibStenguage.Classes;

namespace RayLibStenguage
{
    public class RTextures
    {
        public static RuntimeResult LoadImage(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue fileName)
        {
            return new RuntimeResult().Success(new Image(Imports.LoadImage(fileName.Value)));
        }
        public static RuntimeResult LoadImageRaw(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue fileName, NumberValue width, NumberValue height, NumberValue format, NumberValue headerSize)
        {
            Structs.Image image = Imports.LoadImageRaw(
                fileName.Value,
                (int)width.Value,
                (int)height.Value,
                (int)format.Value,
                (int)headerSize.Value
            );
            return new RuntimeResult().Success(new Image(image));
        }
        // Image LoadImageAnim(string fileName, int *frames);
        // Image LoadImageFromMemory(string fileType, constunsignedchar* fileData, int dataSize);
        // Image LoadImageFromTexture(Texture2D texture);
        public static RuntimeResult LoadImageFromScreen(Stenguage.Runtime.Environment scope, Position start, Position end)
        {
            Structs.Image image = Imports.LoadImageFromScreen();
            return new RuntimeResult().Success(new Image(image));
        }
        public static RuntimeResult IsImageReady(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.IsImageReady(image.Source)));
        }
        public static RuntimeResult UnloadImage(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image)
        {
            Imports.UnloadImage(image.Source);
            return RuntimeResult.Null();
        }
        public static RuntimeResult ExportImage(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image, StringValue fileName)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.ExportImage(
                image.Source,
                fileName.Value
            )));
        }
        public static RuntimeResult ExportImageAsCode(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image, StringValue fileName)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.ExportImageAsCode(
                image.Source,
                fileName.Value
            )));
        }
        public static RuntimeResult GenImageColor(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, Color color)
        {
            Structs.Image image = Imports.GenImageColor(
                (int)width.Value,
                (int)height.Value,
                new Structs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return new RuntimeResult().Success(new Image(image));
        }
        public static RuntimeResult GenImageGradientRadial(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue density, Color inner, Color outer)
        {
            Structs.Image image = Imports.GenImageGradientRadial(
                (int)width.Value,
                (int)height.Value,
                (float)density.Value,
                new Structs.Color(
                    (byte)inner.R.Value,
                    (byte)inner.G.Value,
                    (byte)inner.B.Value,
                    (byte)inner.A.Value
                ),
                new Structs.Color(
                    (byte)outer.R.Value,
                    (byte)outer.G.Value,
                    (byte)outer.B.Value,
                    (byte)outer.A.Value
                )
            );
            return new RuntimeResult().Success(new Image(image));
        }
        public static RuntimeResult GenImageChecked(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue checksX, NumberValue checksY, Color col1, Color col2)
        {
            Structs.Image image = Imports.GenImageChecked(
                (int)width.Value,
                (int)height.Value,
                (int)checksX.Value,
                (int)checksY.Value,
                new Structs.Color(
                    (byte)col1.R.Value,
                    (byte)col1.G.Value,
                    (byte)col1.B.Value,
                    (byte)col1.A.Value
                ),
                new Structs.Color(
                    (byte)col2.R.Value,
                    (byte)col2.G.Value,
                    (byte)col2.B.Value,
                    (byte)col2.A.Value
                )
            );
            return new RuntimeResult().Success(new Image(image));
        }
        public static RuntimeResult GenImageWhiteNoise(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue factor)
        {
            Structs.Image image = Imports.GenImageWhiteNoise(
                (int)width.Value,
                (int)height.Value,
                (float)factor.Value
            );
            return new RuntimeResult().Success(new Image(image));
        }
        public static RuntimeResult GenImagePerlinNoise(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue offsetX, NumberValue offsetY, NumberValue scale)
        {
            Structs.Image image = Imports.GenImagePerlinNoise(
                (int)width.Value,
                (int)height.Value,
                (int)offsetX.Value,
                (int)offsetY.Value,
                (float)scale.Value
            );
            return new RuntimeResult().Success(new Image(image));
        }
        public static RuntimeResult GenImageCellular(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue tileSize)
        {
            Structs.Image image = Imports.GenImageCellular(
                (int)width.Value,
                (int)height.Value,
                (int)tileSize.Value
            );
            return new RuntimeResult().Success(new Image(image));
        }
        public unsafe static RuntimeResult GenImageText(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, StringValue text)
        {
            Structs.Image image = Imports.GenImageText(
                (int)width.Value,
                (int)height.Value,
                text.Value
            );
            return new RuntimeResult().Success(new Image(image));
        }
        public static RuntimeResult ImageCopy(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image)
        {
            return new RuntimeResult().Success(new Image(Imports.ImageCopy(image.Source)));
        }
        public static RuntimeResult ImageFromImage(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image, Rectangle rec)
        {
            return new RuntimeResult().Success(new Image(
                Imports.ImageFromImage(
                    image.Source,
                    new Structs.Rectangle(
                        (float)rec.X.Value,
                        (float)rec.Y.Value,
                        (float)rec.Width.Value,
                        (float)rec.Height.Value
                    )
                )
            ));
        }
        public static RuntimeResult ImageText(Stenguage.Runtime.Environment scope, Position start, Position end,
            StringValue text, NumberValue fontSize, Color color)
        {
            return new RuntimeResult().Success(new Image(
                Imports.ImageText(
                    text.Value,
                    (int)fontSize.Value,
                    new Structs.Color(
                        (byte)color.R.Value,
                        (byte)color.G.Value,
                        (byte)color.B.Value,
                        (byte)color.A.Value
                    )
                )
            ));
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
            Structs.Rectangle r = Imports.GetImageAlphaBorder(
                image.Source,
                (float)threshold.Value
            );
            return new RuntimeResult().Success(new Rectangle(
                new NumberValue(r.x),
                new NumberValue(r.y),
                new NumberValue(r.width),
                new NumberValue(r.height)
            ));
        }
        public static RuntimeResult GetImageColor(Stenguage.Runtime.Environment scope, Position start, Position end,
            Image image, NumberValue x, NumberValue y)
        {
            Structs.Color c = Imports.GetImageColor(
                image.Source,
                (int)x.Value,
                (int)y.Value
            );
            return new RuntimeResult().Success(new Color(
                new NumberValue(c.r),
                new NumberValue(c.g),
                new NumberValue(c.b),
                new NumberValue(c.a)
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
            Structs.Color c = Imports.Fade(
                new Structs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                ),
                (float)alpha.Value
            );
            return new RuntimeResult().Success(new Color(
                new NumberValue(c.r),
                new NumberValue(c.g),
                new NumberValue(c.b),
                new NumberValue(c.a)
            ));
        }
        public static RuntimeResult ColorToInt(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color color)
        {
            return new RuntimeResult().Success(new NumberValue(
                Imports.ColorToInt(
                    new Structs.Color(
                        (byte)color.R.Value,
                        (byte)color.G.Value,
                        (byte)color.B.Value,
                        (byte)color.A.Value
                    )
                )
            ));
        }
        // Vector4 ColorNormalize(Color color);
        // Color ColorFromNormalized(Vector4 normalized);
        // Vector3 ColorToHSV(Color color);
        public static RuntimeResult ColorFromHSV(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue hue, NumberValue saturation, NumberValue value)
        {
            Structs.Color c = Imports.ColorFromHSV(
                (float)hue.Value,
                (float)saturation.Value,
                (float)value.Value
            );
            return new RuntimeResult().Success(new Color(
                new NumberValue(c.r),
                new NumberValue(c.g),
                new NumberValue(c.b),
                new NumberValue(c.a)
            ));
        }
        public static RuntimeResult ColorTint(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color color, Color tint)
        {
            Structs.Color c = Imports.ColorTint(
                new Structs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                ),
                new Structs.Color(
                    (byte)tint.R.Value,
                    (byte)tint.G.Value,
                    (byte)tint.B.Value,
                    (byte)tint.A.Value
                )
            );
            return new RuntimeResult().Success(new Color(
                new NumberValue(c.r),
                new NumberValue(c.g),
                new NumberValue(c.b),
                new NumberValue(c.a)
            ));
        }
        public static RuntimeResult ColorBrightness(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color color, NumberValue factor)
        {
            Structs.Color c = Imports.ColorBrightness(
                new Structs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                ),
                (float)factor.Value
            );
            return new RuntimeResult().Success(new Color(
                new NumberValue(c.r),
                new NumberValue(c.g),
                new NumberValue(c.b),
                new NumberValue(c.a)
            ));
        }
        public static RuntimeResult ColorContrast(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color color, NumberValue contrast)
        {
            Structs.Color c = Imports.ColorContrast(
                new Structs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                ),
                (float)contrast.Value
            );
            return new RuntimeResult().Success(new Color(
                new NumberValue(c.r),
                new NumberValue(c.g),
                new NumberValue(c.b),
                new NumberValue(c.a)
            ));
        }
        public static RuntimeResult ColorAlpha(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color color, NumberValue alpha)
        {
            Structs.Color c = Imports.ColorAlpha(
                new Structs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                ),
                (float)alpha.Value
            );
            return new RuntimeResult().Success(new Color(
                new NumberValue(c.r),
                new NumberValue(c.g),
                new NumberValue(c.b),
                new NumberValue(c.a)
            ));
        }
        public static RuntimeResult ColorAlphaBlend(Stenguage.Runtime.Environment scope, Position start, Position end,
            Color dst, Color src, Color tint)
        {
            Structs.Color c = Imports.ColorAlphaBlend(
                new Structs.Color(
                    (byte)dst.R.Value,
                    (byte)dst.G.Value,
                    (byte)dst.B.Value,
                    (byte)dst.A.Value
                ),
                new Structs.Color(
                    (byte)src.R.Value,
                    (byte)src.G.Value,
                    (byte)src.B.Value,
                    (byte)src.A.Value
                ),
                new Structs.Color(
                    (byte)tint.R.Value,
                    (byte)tint.G.Value,
                    (byte)tint.B.Value,
                    (byte)tint.A.Value
                )
            );
            return new RuntimeResult().Success(new Color(
                new NumberValue(c.r),
                new NumberValue(c.g),
                new NumberValue(c.b),
                new NumberValue(c.a)
            ));
        }
        // Color GetColor(unsigned int hexValue);
        // Color GetPixelColor(void *srcPtr, int format);
        // void SetPixelColor(void *dstPtr, Color color, int format);
        public static RuntimeResult GetPixelDataSize(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue width, NumberValue height, NumberValue format)
        {
            return new RuntimeResult().Success(new NumberValue(
                Imports.GetPixelDataSize(
                    (int)width.Value,
                    (int)height.Value,
                    (int)format.Value
                )
            ));
        }

    }
}
