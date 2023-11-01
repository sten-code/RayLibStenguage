using RayLibStenguage.Classes;
using Stenguage.Runtime;
using Stenguage.Runtime.Values;

namespace RayLibStenguage
{
	public class RTextures
	{
		public static RuntimeResult LoadImage(Context ctx, StringValue fileName)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.LoadImage(fileName.Value)));
		}

		public static RuntimeResult LoadImageRaw(Context ctx, StringValue fileName, NumberValue width, NumberValue height, NumberValue format, NumberValue headerSize)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.LoadImageRaw(fileName.Value, (int)width.Value, (int)height.Value, (int)format.Value, (int)headerSize.Value)));
		}

		public static RuntimeResult LoadImageAnim(Context ctx, StringValue fileName, IntPtr frames)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.LoadImageAnim(fileName.Value, frames)));
		}

		public static RuntimeResult LoadImageFromMemory(Context ctx, StringValue fileType, StringValue fileData, NumberValue dataSize)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.LoadImageFromMemory(fileType.Value, fileData.Value, (int)dataSize.Value)));
		}

		public static RuntimeResult LoadImageFromTexture(Context ctx, Classes.Texture2D texture)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.LoadImageFromTexture(texture.Struct)));
		}

		public static RuntimeResult LoadImageFromScreen(Context ctx)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.LoadImageFromScreen()));
		}

		public static RuntimeResult IsImageReady(Context ctx, Classes.Image image)
		{
			return new RuntimeResult().Success(new BooleanValue(Imports.IsImageReady(image.Source)));
		}

		public static RuntimeResult UnloadImage(Context ctx, Classes.Image image)
		{
			Imports.UnloadImage(image.Source);
			return RuntimeResult.Null();
		}

		public static RuntimeResult ExportImage(Context ctx, Classes.Image image, StringValue fileName)
		{
			return new RuntimeResult().Success(new BooleanValue(Imports.ExportImage(image.Source, fileName.Value)));
		}

		public static RuntimeResult ExportImageAsCode(Context ctx, Classes.Image image, StringValue fileName)
		{
			return new RuntimeResult().Success(new BooleanValue(Imports.ExportImageAsCode(image.Source, fileName.Value)));
		}

		public static RuntimeResult GenImageColor(Context ctx, NumberValue width, NumberValue height, Classes.Color color)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.GenImageColor((int)width.Value, (int)height.Value, color.Struct)));
		}

		public static RuntimeResult GenImageGradientLinear(Context ctx, NumberValue width, NumberValue height, NumberValue direction, Classes.Color start, Classes.Color end)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.GenImageGradientLinear((int)width.Value, (int)height.Value, (int)direction.Value, start.Struct, end.Struct)));
		}

		public static RuntimeResult GenImageGradientRadial(Context ctx, NumberValue width, NumberValue height, NumberValue density, Classes.Color inner, Classes.Color outer)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.GenImageGradientRadial((int)width.Value, (int)height.Value, (float)density.Value, inner.Struct, outer.Struct)));
		}

		public static RuntimeResult GenImageGradientSquare(Context ctx, NumberValue width, NumberValue height, NumberValue density, Classes.Color inner, Classes.Color outer)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.GenImageGradientSquare((int)width.Value, (int)height.Value, (float)density.Value, inner.Struct, outer.Struct)));
		}

		public static RuntimeResult GenImageChecked(Context ctx, NumberValue width, NumberValue height, NumberValue checksX, NumberValue checksY, Classes.Color col1, Classes.Color col2)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.GenImageChecked((int)width.Value, (int)height.Value, (int)checksX.Value, (int)checksY.Value, col1.Struct, col2.Struct)));
		}

		public static RuntimeResult GenImageWhiteNoise(Context ctx, NumberValue width, NumberValue height, NumberValue factor)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.GenImageWhiteNoise((int)width.Value, (int)height.Value, (float)factor.Value)));
		}

		public static RuntimeResult GenImagePerlinNoise(Context ctx, NumberValue width, NumberValue height, NumberValue offsetX, NumberValue offsetY, NumberValue scale)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.GenImagePerlinNoise((int)width.Value, (int)height.Value, (int)offsetX.Value, (int)offsetY.Value, (float)scale.Value)));
		}

		public static RuntimeResult GenImageCellular(Context ctx, NumberValue width, NumberValue height, NumberValue tileSize)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.GenImageCellular((int)width.Value, (int)height.Value, (int)tileSize.Value)));
		}

		public static RuntimeResult GenImageText(Context ctx, NumberValue width, NumberValue height, StringValue text)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.GenImageText((int)width.Value, (int)height.Value, text.Value)));
		}

		public static RuntimeResult ImageCopy(Context ctx, Classes.Image image)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.ImageCopy(image.Source)));
		}

		public static RuntimeResult ImageFromImage(Context ctx, Classes.Image image, Classes.Rectangle rec)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.ImageFromImage(image.Source, rec.Struct)));
		}

		public static RuntimeResult ImageText(Context ctx, StringValue text, NumberValue fontSize, Classes.Color color)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.ImageText(text.Value, (int)fontSize.Value, color.Struct)));
		}

		public static RuntimeResult ImageTextEx(Context ctx, Classes.Font font, StringValue text, NumberValue fontSize, NumberValue spacing, Classes.Color tint)
		{
			return new RuntimeResult().Success(new Classes.Image(Imports.ImageTextEx(font.Struct, text.Value, (float)fontSize.Value, (float)spacing.Value, tint.Struct)));
		}

		public unsafe static RuntimeResult ImageFormat(Context ctx, Classes.Image image, NumberValue newFormat)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageFormat(ptr, (int)newFormat.Value);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageToPOT(Context ctx, Classes.Image image, Classes.Color fill)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageToPOT(ptr, fill.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageCrop(Context ctx, Classes.Image image, Classes.Rectangle crop)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageCrop(ptr, crop.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageAlphaCrop(Context ctx, Classes.Image image, NumberValue threshold)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageAlphaCrop(ptr, (float)threshold.Value);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageAlphaClear(Context ctx, Classes.Image image, Classes.Color color, NumberValue threshold)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageAlphaClear(ptr, color.Struct, (float)threshold.Value);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageAlphaMask(Context ctx, Classes.Image image, Classes.Image alphaMask)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageAlphaMask(ptr, alphaMask.Source);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageAlphaPremultiply(Context ctx, Classes.Image image)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageAlphaPremultiply(ptr);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageBlurGaussian(Context ctx, Classes.Image image, NumberValue blurSize)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageBlurGaussian(ptr, (int)blurSize.Value);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageResize(Context ctx, Classes.Image image, NumberValue newWidth, NumberValue newHeight)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageResize(ptr, (int)newWidth.Value, (int)newHeight.Value);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageResizeNN(Context ctx, Classes.Image image, NumberValue newWidth, NumberValue newHeight)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageResizeNN(ptr, (int)newWidth.Value, (int)newHeight.Value);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageResizeCanvas(Context ctx, Classes.Image image, NumberValue newWidth, NumberValue newHeight, NumberValue offsetX, NumberValue offsetY, Classes.Color fill)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageResizeCanvas(ptr, (int)newWidth.Value, (int)newHeight.Value, (int)offsetX.Value, (int)offsetY.Value, fill.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageMipmaps(Context ctx, Classes.Image image)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageMipmaps(ptr);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDither(Context ctx, Classes.Image image, NumberValue rBpp, NumberValue gBpp, NumberValue bBpp, NumberValue aBpp)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageDither(ptr, (int)rBpp.Value, (int)gBpp.Value, (int)bBpp.Value, (int)aBpp.Value);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageFlipVertical(Context ctx, Classes.Image image)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageFlipVertical(ptr);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageFlipHorizontal(Context ctx, Classes.Image image)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageFlipHorizontal(ptr);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageRotate(Context ctx, Classes.Image image, NumberValue degrees)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageRotate(ptr, (int)degrees.Value);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageRotateCW(Context ctx, Classes.Image image)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageRotateCW(ptr);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageRotateCCW(Context ctx, Classes.Image image)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageRotateCCW(ptr);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageColorTint(Context ctx, Classes.Image image, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageColorTint(ptr, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageColorInvert(Context ctx, Classes.Image image)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageColorInvert(ptr);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageColorGrayscale(Context ctx, Classes.Image image)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageColorGrayscale(ptr);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageColorContrast(Context ctx, Classes.Image image, NumberValue contrast)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageColorContrast(ptr, (float)contrast.Value);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageColorBrightness(Context ctx, Classes.Image image, NumberValue brightness)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageColorBrightness(ptr, (int)brightness.Value);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageColorReplace(Context ctx, Classes.Image image, Classes.Color color, Classes.Color replace)
		{
			fixed (Structs.Image* ptr = &image.Source)
			{
				Imports.ImageColorReplace(ptr, color.Struct, replace.Struct);
			}
			return RuntimeResult.Null();
		}

		public static RuntimeResult LoadImageColors(Context ctx, Classes.Image image)
		{
			return new RuntimeResult().Success(new ListValue((from x in Imports.LoadImageColors(image.Source)
			select new Color(x)).Cast<RuntimeValue>().ToList<RuntimeValue>()));
		}

		public static RuntimeResult LoadImagePalette(Context ctx, Classes.Image image, NumberValue maxPaletteSize, NumberValue colorCount)
		{
			return new RuntimeResult().Success(new ListValue((from x in Imports.LoadImagePalette(image.Source, (int)maxPaletteSize.Value, (int)colorCount.Value)
			select new Color(x)).Cast<RuntimeValue>().ToList<RuntimeValue>()));
		}

		public static RuntimeResult UnloadImageColors(Context ctx, ListValue colors)
		{
			Imports.UnloadImageColors((from x in colors.Items
			where x.GetType() == typeof(Color)
			select ((Color)x).Struct).ToArray<Structs.Color>());
			return RuntimeResult.Null();
		}

		public static RuntimeResult UnloadImagePalette(Context ctx, ListValue colors)
		{
			Imports.UnloadImagePalette((from x in colors.Items
			where x.GetType() == typeof(Color)
			select ((Color)x).Struct).ToArray<Structs.Color>());
			return RuntimeResult.Null();
		}

		public static RuntimeResult GetImageAlphaBorder(Context ctx, Classes.Image image, NumberValue threshold)
		{
			return new RuntimeResult().Success(new Rectangle(Imports.GetImageAlphaBorder(image.Source, (float)threshold.Value)));
		}

		public static RuntimeResult GetImageColor(Context ctx, Classes.Image image, NumberValue x, NumberValue y)
		{
			return new RuntimeResult().Success(new Color(Imports.GetImageColor(image.Source, (int)x.Value, (int)y.Value)));
		}

		public unsafe static RuntimeResult ImageClearBackground(Context ctx, Classes.Image dst, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageClearBackground(ptr, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawPixel(Context ctx, Classes.Image dst, NumberValue posX, NumberValue posY, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawPixel(ptr, (int)posX.Value, (int)posY.Value, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawPixelV(Context ctx, Classes.Image dst, Vector2 position, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawPixelV(ptr, position.Struct, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawLine(Context ctx, Classes.Image dst, NumberValue startPosX, NumberValue startPosY, NumberValue endPosX, NumberValue endPosY, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawLine(ptr, (int)startPosX.Value, (int)startPosY.Value, (int)endPosX.Value, (int)endPosY.Value, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawLineV(Context ctx, Classes.Image dst, Vector2 start, Vector2 end, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawLineV(ptr, start.Struct, end.Struct, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawCircle(Context ctx, Classes.Image dst, NumberValue centerX, NumberValue centerY, NumberValue radius, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawCircle(ptr, (int)centerX.Value, (int)centerY.Value, (int)radius.Value, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawCircleV(Context ctx, Classes.Image dst, Vector2 center, NumberValue radius, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawCircleV(ptr, center.Struct, (int)radius.Value, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawCircleLines(Context ctx, Classes.Image dst, NumberValue centerX, NumberValue centerY, NumberValue radius, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawCircleLines(ptr, (int)centerX.Value, (int)centerY.Value, (int)radius.Value, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawCircleLinesV(Context ctx, Classes.Image dst, Vector2 center, NumberValue radius, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawCircleLinesV(ptr, center.Struct, (int)radius.Value, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawRectangle(Context ctx, Classes.Image dst, NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawRectangle(ptr, (int)posX.Value, (int)posY.Value, (int)width.Value, (int)height.Value, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawRectangleV(Context ctx, Classes.Image dst, Vector2 position, Vector2 size, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawRectangleV(ptr, position.Struct, size.Struct, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawRectangleRec(Context ctx, Classes.Image dst, Classes.Rectangle rec, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawRectangleRec(ptr, rec.Struct, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawRectangleLines(Context ctx, Classes.Image dst, Classes.Rectangle rec, NumberValue thick, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawRectangleLines(ptr, rec.Struct, (int)thick.Value, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDraw(Context ctx, Classes.Image dst, Classes.Image src, Classes.Rectangle srcRec, Classes.Rectangle dstRec, Classes.Color tint)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDraw(ptr, src.Source, srcRec.Struct, dstRec.Struct, tint.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawText(Context ctx, Classes.Image dst, StringValue text, NumberValue posX, NumberValue posY, NumberValue fontSize, Classes.Color color)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawText(ptr, text.Value, (int)posX.Value, (int)posY.Value, (int)fontSize.Value, color.Struct);
			}
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult ImageDrawTextEx(Context ctx, Classes.Image dst, Classes.Font font, StringValue text, Vector2 position, NumberValue fontSize, NumberValue spacing, Classes.Color tint)
		{
			fixed (Structs.Image* ptr = &dst.Source)
			{
				Imports.ImageDrawTextEx(ptr, font.Struct, text.Value, position.Struct, (float)fontSize.Value, (float)spacing.Value, tint.Struct);
			}
			return RuntimeResult.Null();
		}

		public static RuntimeResult LoadTexture(Context ctx, StringValue fileName)
		{
			return new RuntimeResult().Success(new Texture2D(Imports.LoadTexture(fileName.Value)));
		}

		public static RuntimeResult LoadTextureFromImage(Context ctx, Classes.Image image)
		{
			return new RuntimeResult().Success(new Texture2D(Imports.LoadTextureFromImage(image.Source)));
		}

		public static RuntimeResult LoadTextureCubemap(Context ctx, Classes.Image image, NumberValue layout)
		{
			return new RuntimeResult().Success(new Texture2D(Imports.LoadTextureCubemap(image.Source, (int)layout.Value)));
		}

		public static RuntimeResult LoadRenderTexture(Context ctx, NumberValue width, NumberValue height)
		{
			return new RuntimeResult().Success(new RenderTexture2D(Imports.LoadRenderTexture((int)width.Value, (int)height.Value)));
		}

		public static RuntimeResult IsTextureReady(Context ctx, Classes.Texture2D texture)
		{
			return new RuntimeResult().Success(new BooleanValue(Imports.IsTextureReady(texture.Struct)));
		}

		public static RuntimeResult UnloadTexture(Context ctx, Classes.Texture2D texture)
		{
			Imports.UnloadTexture(texture.Struct);
			return RuntimeResult.Null();
		}

		public static RuntimeResult IsRenderTextureReady(Context ctx, RenderTexture2D target)
		{
			return new RuntimeResult().Success(new BooleanValue(Imports.IsRenderTextureReady(target.Struct)));
		}

		public static RuntimeResult UnloadRenderTexture(Context ctx, RenderTexture2D target)
		{
			Imports.UnloadRenderTexture(target.Struct);
			return RuntimeResult.Null();
		}

		public unsafe static RuntimeResult GenTextureMipmaps(Context ctx, Classes.Texture2D texture)
		{
			fixed (Structs.Texture2D* ptr = &texture.Source)
			{
				Imports.GenTextureMipmaps(ptr);
			}
			return RuntimeResult.Null();
		}

		public static RuntimeResult SetTextureFilter(Context ctx, Classes.Texture2D texture, NumberValue filter)
		{
			Imports.SetTextureFilter(texture.Struct, (int)filter.Value);
			return RuntimeResult.Null();
		}

		public static RuntimeResult SetTextureWrap(Context ctx, Classes.Texture2D texture, NumberValue wrap)
		{
			Imports.SetTextureWrap(texture.Struct, (int)wrap.Value);
			return RuntimeResult.Null();
		}

		public static RuntimeResult DrawTexture(Context ctx, Classes.Texture2D texture, NumberValue posX, NumberValue posY, Classes.Color tint)
		{
			Imports.DrawTexture(texture.Struct, (int)posX.Value, (int)posY.Value, tint.Struct);
			return RuntimeResult.Null();
		}

		public static RuntimeResult DrawTextureV(Context ctx, Classes.Texture2D texture, Vector2 position, Classes.Color tint)
		{
			Imports.DrawTextureV(texture.Struct, position.Struct, tint.Struct);
			return RuntimeResult.Null();
		}

		public static RuntimeResult DrawTextureEx(Context ctx, Classes.Texture2D texture, Vector2 position, NumberValue rotation, NumberValue scale, Classes.Color tint)
		{
			Imports.DrawTextureEx(texture.Struct, position.Struct, (float)rotation.Value, (float)scale.Value, tint.Struct);
			return RuntimeResult.Null();
		}

		public static RuntimeResult DrawTextureRec(Context ctx, Classes.Texture2D texture, Classes.Rectangle source, Vector2 position, Classes.Color tint)
		{
			Imports.DrawTextureRec(texture.Struct, source.Struct, position.Struct, tint.Struct);
			return RuntimeResult.Null();
		}

		public static RuntimeResult DrawTexturePro(Context ctx, Classes.Texture2D texture, Classes.Rectangle source, Classes.Rectangle dest, Vector2 origin, NumberValue rotation, Classes.Color tint)
		{
			Imports.DrawTexturePro(texture.Struct, source.Struct, dest.Struct, origin.Struct, (float)rotation.Value, tint.Struct);
			return RuntimeResult.Null();
		}

		public static RuntimeResult DrawTextureNPatch(Context ctx, Classes.Texture2D texture, NPatchInfo nPatchInfo, Classes.Rectangle dest, Vector2 origin, NumberValue rotation, Classes.Color tint)
		{
			Imports.DrawTextureNPatch(texture.Struct, nPatchInfo.Struct, dest.Struct, origin.Struct, (float)rotation.Value, tint.Struct);
			return RuntimeResult.Null();
		}

		public static RuntimeResult Fade(Context ctx, Classes.Color color, NumberValue alpha)
		{
			return new RuntimeResult().Success(new Color(Imports.Fade(color.Struct, (float)alpha.Value)));
		}

		public static RuntimeResult ColorToInt(Context ctx, Classes.Color color)
		{
			return new RuntimeResult().Success(new NumberValue((double)Imports.ColorToInt(color.Struct)));
		}

		public static RuntimeResult ColorNormalize(Context ctx, Classes.Color color)
		{
			return new RuntimeResult().Success(new Vector4(Imports.ColorNormalize(color.Struct)));
		}

		public static RuntimeResult ColorFromNormalized(Context ctx, Vector4 normalized)
		{
			return new RuntimeResult().Success(new Color(Imports.ColorFromNormalized(normalized.Struct)));
		}

		public static RuntimeResult ColorToHSV(Context ctx, Classes.Color color)
		{
			return new RuntimeResult().Success(new Vector3(Imports.ColorToHSV(color.Struct)));
		}

		public static RuntimeResult ColorFromHSV(Context ctx, NumberValue hue, NumberValue saturation, NumberValue value)
		{
			return new RuntimeResult().Success(new Color(Imports.ColorFromHSV((float)hue.Value, (float)saturation.Value, (float)value.Value)));
		}

		public static RuntimeResult ColorTint(Context ctx, Classes.Color color, Classes.Color tint)
		{
			return new RuntimeResult().Success(new Color(Imports.ColorTint(color.Struct, tint.Struct)));
		}

		public static RuntimeResult ColorBrightness(Context ctx, Classes.Color color, NumberValue factor)
		{
			return new RuntimeResult().Success(new Color(Imports.ColorBrightness(color.Struct, (float)factor.Value)));
		}

		public static RuntimeResult ColorContrast(Context ctx, Classes.Color color, NumberValue contrast)
		{
			return new RuntimeResult().Success(new Color(Imports.ColorContrast(color.Struct, (float)contrast.Value)));
		}

		public static RuntimeResult ColorAlpha(Context ctx, Classes.Color color, NumberValue alpha)
		{
			return new RuntimeResult().Success(new Color(Imports.ColorAlpha(color.Struct, (float)alpha.Value)));
		}

		public static RuntimeResult ColorAlphaBlend(Context ctx, Classes.Color dst, Classes.Color src, Classes.Color tint)
		{
			return new RuntimeResult().Success(new Color(Imports.ColorAlphaBlend(dst.Struct, src.Struct, tint.Struct)));
		}

		public static RuntimeResult GetColor(Context ctx, uint hexValue)
		{
			return new RuntimeResult().Success(new Color(Imports.GetColor(hexValue)));
		}

		public static RuntimeResult GetPixelColor(Context ctx)
		{
			return new RuntimeResult().Success(new Color(Imports.GetPixelColor()));
		}

		public static RuntimeResult SetPixelColor(Context ctx)
		{
			Imports.SetPixelColor();
			return RuntimeResult.Null();
		}

		public static RuntimeResult GetPixelDataSize(Context ctx, NumberValue width, NumberValue height, NumberValue format)
		{
			return new RuntimeResult().Success(new NumberValue((double)Imports.GetPixelDataSize((int)width.Value, (int)height.Value, (int)format.Value)));
		}
	}
}
