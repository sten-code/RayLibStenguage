using Raylib_cs;
using Stenguage.Runtime.Values;
using Stenguage.Runtime;
using Stenguage;
using System.Numerics;

namespace RayLibStenguage
{
    public class RShapes
    {
        // void SetShapesTexture(Texture2D texture, Rectangle source);
        public static RuntimeResult DrawPixel(Stenguage.Runtime.Environment scope, Position start, Position end, NumberValue posX, NumberValue posY, ListValue color)
        {
            Raylib.DrawPixel((int)posX.Value, (int)posY.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawPixelV(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue position, ListValue color)
        {
            Raylib.DrawPixelV(new Vector2((float)((NumberValue)position.Items[0]).Value, (float)((NumberValue)position.Items[1]).Value), new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawLine(Stenguage.Runtime.Environment scope, Position start, Position end, NumberValue startPosX, NumberValue startPosY, NumberValue endPosX, NumberValue endPosY, ListValue color)
        {
            Raylib.DrawLine((int)startPosX.Value, (int)startPosY.Value, (int)endPosX.Value, (int)endPosY.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawLineV(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue startPos, ListValue endPos, ListValue color)
        {
            Raylib.DrawLineV(new Vector2((float)((NumberValue)startPos.Items[0]).Value, (float)((NumberValue)startPos.Items[1]).Value), new Vector2((float)((NumberValue)endPos.Items[0]).Value, (float)((NumberValue)endPos.Items[1]).Value), new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawLineEx(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue startPos, ListValue endPos, NumberValue thick, ListValue color)
        {
            Raylib.DrawLineEx(new Vector2((float)((NumberValue)startPos.Items[0]).Value, (float)((NumberValue)startPos.Items[1]).Value), new Vector2((float)((NumberValue)endPos.Items[0]).Value, (float)((NumberValue)endPos.Items[1]).Value), (float)thick.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawLineBezier(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue startPos, ListValue endPos, NumberValue thick, ListValue color)
        {
            Raylib.DrawLineBezier(new Vector2((float)((NumberValue)startPos.Items[0]).Value, (float)((NumberValue)startPos.Items[1]).Value), new Vector2((float)((NumberValue)endPos.Items[0]).Value, (float)((NumberValue)endPos.Items[1]).Value), (float)thick.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawLineBezierQuad(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue startPos, ListValue endPos, ListValue controlPos, NumberValue thick, ListValue color)
        {
            Raylib.DrawLineBezierQuad(new Vector2((float)((NumberValue)startPos.Items[0]).Value, (float)((NumberValue)startPos.Items[1]).Value), new Vector2((float)((NumberValue)endPos.Items[0]).Value, (float)((NumberValue)endPos.Items[1]).Value), new Vector2((float)((NumberValue)controlPos.Items[0]).Value, (float)((NumberValue)controlPos.Items[1]).Value), (float)thick.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawLineBezierCubic(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue startPos, ListValue endPos, ListValue startControlPos, ListValue endControlPos, NumberValue thick, ListValue color)
        {
            Raylib.DrawLineBezierCubic(new Vector2((float)((NumberValue)startPos.Items[0]).Value, (float)((NumberValue)startPos.Items[1]).Value), new Vector2((float)((NumberValue)endPos.Items[0]).Value, (float)((NumberValue)endPos.Items[1]).Value), new Vector2((float)((NumberValue)startControlPos.Items[0]).Value, (float)((NumberValue)startControlPos.Items[1]).Value), new Vector2((float)((NumberValue)endControlPos.Items[0]).Value, (float)((NumberValue)endControlPos.Items[1]).Value), (float)thick.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        // void DrawLineStrip(Vector2 *points, int pointCount, Color color);
        public static RuntimeResult DrawCircle(Stenguage.Runtime.Environment scope, Position start, Position end, NumberValue centerX, NumberValue centerY, NumberValue radius, ListValue color)
        {
            Raylib.DrawCircle((int)centerX.Value, (int)centerY.Value, (float)radius.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawCircleSector(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue center, NumberValue radius, NumberValue startAngle, NumberValue endAngle, NumberValue segments, ListValue color)
        {
            Raylib.DrawCircleSector(new Vector2((float)((NumberValue)center.Items[0]).Value, (float)((NumberValue)center.Items[1]).Value), (float)radius.Value, (float)startAngle.Value, (float)endAngle.Value, (int)segments.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawCircleSectorLines(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue center, NumberValue radius, NumberValue startAngle, NumberValue endAngle, NumberValue segments, ListValue color)
        {
            Raylib.DrawCircleSectorLines(new Vector2((float)((NumberValue)center.Items[0]).Value, (float)((NumberValue)center.Items[1]).Value), (float)radius.Value, (float)startAngle.Value, (float)endAngle.Value, (int)segments.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawCircleGradient(Stenguage.Runtime.Environment scope, Position start, Position end, NumberValue centerX, NumberValue centerY, NumberValue radius, ListValue color1, ListValue color2)
        {
            Raylib.DrawCircleGradient((int)centerX.Value, (int)centerY.Value, (float)radius.Value, new Color((byte)((NumberValue)color1.Items[0]).Value, (byte)((NumberValue)color1.Items[1]).Value, (byte)((NumberValue)color1.Items[2]).Value, (byte)((NumberValue)color1.Items[3]).Value), new Color((byte)((NumberValue)color2.Items[0]).Value, (byte)((NumberValue)color2.Items[1]).Value, (byte)((NumberValue)color2.Items[2]).Value, (byte)((NumberValue)color2.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawCircleV(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue center, NumberValue radius, ListValue color)
        {
            Raylib.DrawCircleV(new Vector2((float)((NumberValue)center.Items[0]).Value, (float)((NumberValue)center.Items[1]).Value), (float)radius.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawCircleLines(Stenguage.Runtime.Environment scope, Position start, Position end, NumberValue centerX, NumberValue centerY, NumberValue radius, ListValue color)
        {
            Raylib.DrawCircleLines((int)centerX.Value, (int)centerY.Value, (float)radius.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawEllipse(Stenguage.Runtime.Environment scope, Position start, Position end, NumberValue centerX, NumberValue centerY, NumberValue radiusH, NumberValue radiusV, ListValue color)
        {
            Raylib.DrawEllipse((int)centerX.Value, (int)centerY.Value, (float)radiusH.Value, (float)radiusV.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawEllipseLines(Stenguage.Runtime.Environment scope, Position start, Position end, NumberValue centerX, NumberValue centerY, NumberValue radiusH, NumberValue radiusV, ListValue color)
        {
            Raylib.DrawEllipseLines((int)centerX.Value, (int)centerY.Value, (float)radiusH.Value, (float)radiusV.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRing(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue center, NumberValue innerRadius, NumberValue outerRadius, NumberValue startAngle, NumberValue endAngle, NumberValue segments, ListValue color)
        {
            Raylib.DrawRing(new Vector2((float)((NumberValue)center.Items[0]).Value, (float)((NumberValue)center.Items[1]).Value), (float)innerRadius.Value, (float)outerRadius.Value, (float)startAngle.Value, (float)endAngle.Value, (int)segments.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRingLines(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue center, NumberValue innerRadius, NumberValue outerRadius, NumberValue startAngle, NumberValue endAngle, NumberValue segments, ListValue color)
        {
            Raylib.DrawRingLines(new Vector2((float)((NumberValue)center.Items[0]).Value, (float)((NumberValue)center.Items[1]).Value), (float)innerRadius.Value, (float)outerRadius.Value, (float)startAngle.Value, (float)endAngle.Value, (int)segments.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangle(Stenguage.Runtime.Environment scope, Position start, Position end, NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, ListValue color)
        {
            Raylib.DrawRectangle((int)posX.Value, (int)posY.Value, (int)width.Value, (int)height.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleV(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue position, ListValue size, ListValue color)
        {
            Raylib.DrawRectangleV(new Vector2((float)((NumberValue)position.Items[0]).Value, (float)((NumberValue)position.Items[1]).Value), new Vector2((float)((NumberValue)size.Items[0]).Value, (float)((NumberValue)size.Items[1]).Value), new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleRec(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue rec, ListValue color)
        {
            Raylib.DrawRectangleRec(new Rectangle((float)((NumberValue)rec.Items[0]).Value, (float)((NumberValue)rec.Items[1]).Value, (float)((NumberValue)rec.Items[2]).Value, (float)((NumberValue)rec.Items[3]).Value), new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectanglePro(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue rec, ListValue origin, NumberValue rotation, ListValue color)
        {
            Raylib.DrawRectanglePro(new Rectangle((float)((NumberValue)rec.Items[0]).Value, (float)((NumberValue)rec.Items[1]).Value, (float)((NumberValue)rec.Items[2]).Value, (float)((NumberValue)rec.Items[3]).Value), new Vector2((float)((NumberValue)origin.Items[0]).Value, (float)((NumberValue)origin.Items[1]).Value), (float)rotation.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleGradientV(Stenguage.Runtime.Environment scope, Position start, Position end, NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, ListValue color1, ListValue color2)
        {
            Raylib.DrawRectangleGradientV((int)posX.Value, (int)posY.Value, (int)width.Value, (int)height.Value, new Color((byte)((NumberValue)color1.Items[0]).Value, (byte)((NumberValue)color1.Items[1]).Value, (byte)((NumberValue)color1.Items[2]).Value, (byte)((NumberValue)color1.Items[3]).Value), new Color((byte)((NumberValue)color2.Items[0]).Value, (byte)((NumberValue)color2.Items[1]).Value, (byte)((NumberValue)color2.Items[2]).Value, (byte)((NumberValue)color2.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleGradientH(Stenguage.Runtime.Environment scope, Position start, Position end, NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, ListValue color1, ListValue color2)
        {
            Raylib.DrawRectangleGradientH((int)posX.Value, (int)posY.Value, (int)width.Value, (int)height.Value, new Color((byte)((NumberValue)color1.Items[0]).Value, (byte)((NumberValue)color1.Items[1]).Value, (byte)((NumberValue)color1.Items[2]).Value, (byte)((NumberValue)color1.Items[3]).Value), new Color((byte)((NumberValue)color2.Items[0]).Value, (byte)((NumberValue)color2.Items[1]).Value, (byte)((NumberValue)color2.Items[2]).Value, (byte)((NumberValue)color2.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleGradientEx(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue rec, ListValue col1, ListValue col2, ListValue col3, ListValue col4)
        {
            Raylib.DrawRectangleGradientEx(new Rectangle((float)((NumberValue)rec.Items[0]).Value, (float)((NumberValue)rec.Items[1]).Value, (float)((NumberValue)rec.Items[2]).Value, (float)((NumberValue)rec.Items[3]).Value), new Color((byte)((NumberValue)col1.Items[0]).Value, (byte)((NumberValue)col1.Items[1]).Value, (byte)((NumberValue)col1.Items[2]).Value, (byte)((NumberValue)col1.Items[3]).Value), new Color((byte)((NumberValue)col2.Items[0]).Value, (byte)((NumberValue)col2.Items[1]).Value, (byte)((NumberValue)col2.Items[2]).Value, (byte)((NumberValue)col2.Items[3]).Value), new Color((byte)((NumberValue)col3.Items[0]).Value, (byte)((NumberValue)col3.Items[1]).Value, (byte)((NumberValue)col3.Items[2]).Value, (byte)((NumberValue)col3.Items[3]).Value), new Color((byte)((NumberValue)col4.Items[0]).Value, (byte)((NumberValue)col4.Items[1]).Value, (byte)((NumberValue)col4.Items[2]).Value, (byte)((NumberValue)col4.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleLines(Stenguage.Runtime.Environment scope, Position start, Position end, NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, ListValue color)
        {
            Raylib.DrawRectangleLines((int)posX.Value, (int)posY.Value, (int)width.Value, (int)height.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleLinesEx(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue rec, NumberValue lineThick, ListValue color)
        {
            Raylib.DrawRectangleLinesEx(new Rectangle((float)((NumberValue)rec.Items[0]).Value, (float)((NumberValue)rec.Items[1]).Value, (float)((NumberValue)rec.Items[2]).Value, (float)((NumberValue)rec.Items[3]).Value), (float)lineThick.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleRounded(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue rec, NumberValue roundness, NumberValue segments, ListValue color)
        {
            Raylib.DrawRectangleRounded(new Rectangle((float)((NumberValue)rec.Items[0]).Value, (float)((NumberValue)rec.Items[1]).Value, (float)((NumberValue)rec.Items[2]).Value, (float)((NumberValue)rec.Items[3]).Value), (float)roundness.Value, (int)segments.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleRoundedLines(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue rec, NumberValue roundness, NumberValue segments, NumberValue lineThick, ListValue color)
        {
            Raylib.DrawRectangleRoundedLines(new Rectangle((float)((NumberValue)rec.Items[0]).Value, (float)((NumberValue)rec.Items[1]).Value, (float)((NumberValue)rec.Items[2]).Value, (float)((NumberValue)rec.Items[3]).Value), (float)roundness.Value, (int)segments.Value, (float)lineThick.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawTriangle(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue v1, ListValue v2, ListValue v3, ListValue color)
        {
            Raylib.DrawTriangle(new Vector2((float)((NumberValue)v1.Items[0]).Value, (float)((NumberValue)v1.Items[1]).Value), new Vector2((float)((NumberValue)v2.Items[0]).Value, (float)((NumberValue)v2.Items[1]).Value), new Vector2((float)((NumberValue)v3.Items[0]).Value, (float)((NumberValue)v3.Items[1]).Value), new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawTriangleLines(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue v1, ListValue v2, ListValue v3, ListValue color)
        {
            Raylib.DrawTriangleLines(new Vector2((float)((NumberValue)v1.Items[0]).Value, (float)((NumberValue)v1.Items[1]).Value), new Vector2((float)((NumberValue)v2.Items[0]).Value, (float)((NumberValue)v2.Items[1]).Value), new Vector2((float)((NumberValue)v3.Items[0]).Value, (float)((NumberValue)v3.Items[1]).Value), new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        // void DrawTriangleFan(Vector2 *points, int pointCount, Color color);
        // void DrawTriangleStrip(Vector2 *points, int pointCount, Color color);
        public static RuntimeResult DrawPoly(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue center, NumberValue sides, NumberValue radius, NumberValue rotation, ListValue color)
        {
            Raylib.DrawPoly(new Vector2((float)((NumberValue)center.Items[0]).Value, (float)((NumberValue)center.Items[1]).Value), (int)sides.Value, (float)radius.Value, (float)rotation.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawPolyLines(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue center, NumberValue sides, NumberValue radius, NumberValue rotation, ListValue color)
        {
            Raylib.DrawPolyLines(new Vector2((float)((NumberValue)center.Items[0]).Value, (float)((NumberValue)center.Items[1]).Value), (int)sides.Value, (float)radius.Value, (float)rotation.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawPolyLinesEx(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue center, NumberValue sides, NumberValue radius, NumberValue rotation, NumberValue lineThick, ListValue color)
        {
            Raylib.DrawPolyLinesEx(new Vector2((float)((NumberValue)center.Items[0]).Value, (float)((NumberValue)center.Items[1]).Value), (int)sides.Value, (float)radius.Value, (float)rotation.Value, (float)lineThick.Value, new Color((byte)((NumberValue)color.Items[0]).Value, (byte)((NumberValue)color.Items[1]).Value, (byte)((NumberValue)color.Items[2]).Value, (byte)((NumberValue)color.Items[3]).Value));
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult CheckCollisionRecs(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue rec1, ListValue rec2)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.CheckCollisionRecs(new Rectangle((float)((NumberValue)rec1.Items[0]).Value, (float)((NumberValue)rec1.Items[1]).Value, (float)((NumberValue)rec1.Items[2]).Value, (float)((NumberValue)rec1.Items[3]).Value), new Rectangle((float)((NumberValue)rec2.Items[0]).Value, (float)((NumberValue)rec2.Items[1]).Value, (float)((NumberValue)rec2.Items[2]).Value, (float)((NumberValue)rec2.Items[3]).Value)), scope.SourceCode, start, end));
        }
        public static RuntimeResult CheckCollisionCircles(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue center1, NumberValue radius1, ListValue center2, NumberValue radius2)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.CheckCollisionCircles(new Vector2((float)((NumberValue)center1.Items[0]).Value, (float)((NumberValue)center1.Items[1]).Value), (float)radius1.Value, new Vector2((float)((NumberValue)center2.Items[0]).Value, (float)((NumberValue)center2.Items[1]).Value), (float)radius2.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult CheckCollisionCircleRec(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue center, NumberValue radius, ListValue rec)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.CheckCollisionCircleRec(new Vector2((float)((NumberValue)center.Items[0]).Value, (float)((NumberValue)center.Items[1]).Value), (float)radius.Value, new Rectangle((float)((NumberValue)rec.Items[0]).Value, (float)((NumberValue)rec.Items[1]).Value, (float)((NumberValue)rec.Items[2]).Value, (float)((NumberValue)rec.Items[3]).Value)), scope.SourceCode, start, end));
        }
        public static RuntimeResult CheckCollisionPointRec(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue point, ListValue rec)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.CheckCollisionPointRec(new Vector2((float)((NumberValue)point.Items[0]).Value, (float)((NumberValue)point.Items[1]).Value), new Rectangle((float)((NumberValue)rec.Items[0]).Value, (float)((NumberValue)rec.Items[1]).Value, (float)((NumberValue)rec.Items[2]).Value, (float)((NumberValue)rec.Items[3]).Value)), scope.SourceCode, start, end));
        }
        public static RuntimeResult CheckCollisionPointCircle(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue point, ListValue center, NumberValue radius)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.CheckCollisionPointCircle(new Vector2((float)((NumberValue)point.Items[0]).Value, (float)((NumberValue)point.Items[1]).Value), new Vector2((float)((NumberValue)center.Items[0]).Value, (float)((NumberValue)center.Items[1]).Value), (float)radius.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult CheckCollisionPointTriangle(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue point, ListValue p1, ListValue p2, ListValue p3)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.CheckCollisionPointTriangle(new Vector2((float)((NumberValue)point.Items[0]).Value, (float)((NumberValue)point.Items[1]).Value), new Vector2((float)((NumberValue)p1.Items[0]).Value, (float)((NumberValue)p1.Items[1]).Value), new Vector2((float)((NumberValue)p2.Items[0]).Value, (float)((NumberValue)p2.Items[1]).Value), new Vector2((float)((NumberValue)p3.Items[0]).Value, (float)((NumberValue)p3.Items[1]).Value)), scope.SourceCode, start, end));
        }
        // bool CheckCollisionPointPoly(Vector2 point, Vector2 *points, int pointCount);
        // bool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, Vector2 *collisionPoint);
        public static RuntimeResult CheckCollisionPointLine(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue point, ListValue p1, ListValue p2, NumberValue threshold)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.CheckCollisionPointLine(new Vector2((float)((NumberValue)point.Items[0]).Value, (float)((NumberValue)point.Items[1]).Value), new Vector2((float)((NumberValue)p1.Items[0]).Value, (float)((NumberValue)p1.Items[1]).Value), new Vector2((float)((NumberValue)p2.Items[0]).Value, (float)((NumberValue)p2.Items[1]).Value), (int)threshold.Value), scope.SourceCode, start, end));
        }
        public static RuntimeResult GetCollisionRec(Stenguage.Runtime.Environment scope, Position start, Position end, ListValue rec1, ListValue rec2)
        {
            Rectangle rect = Raylib.GetCollisionRec(new Rectangle((float)((NumberValue)rec1.Items[0]).Value, (float)((NumberValue)rec1.Items[1]).Value, (float)((NumberValue)rec1.Items[2]).Value, (float)((NumberValue)rec1.Items[3]).Value), new Rectangle((float)((NumberValue)rec2.Items[0]).Value, (float)((NumberValue)rec2.Items[1]).Value, (float)((NumberValue)rec2.Items[2]).Value, (float)((NumberValue)rec2.Items[3]).Value));
            return new RuntimeResult().Success(new ListValue(new List<RuntimeValue> { new NumberValue(rect.x, scope.SourceCode, start, end), new NumberValue(rect.y, scope.SourceCode, start, end), new NumberValue(rect.width, scope.SourceCode, start, end), new NumberValue(rect.height, scope.SourceCode, start, end) }, scope.SourceCode, start, end));
        }
    }
}
