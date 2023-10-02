using Raylib_cs;
using Stenguage.Runtime.Values;
using Stenguage.Runtime;
using Stenguage;

namespace RayLibStenguage
{
    public class RShapes
    {
        // void SetShapesTexture(Texture2D texture, Rectangle source);
        public static RuntimeResult DrawPixel(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue posX, NumberValue posY, Color color)
        {
            Raylib.DrawPixel(
                (int)posX.Value, 
                (int)posY.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value, 
                    (byte)color.G.Value, 
                    (byte)color.B.Value, 
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawPixelV(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 position, Color color)
        {
            Raylib.DrawPixelV(
                new System.Numerics.Vector2((float)position.X.Value, (float)position.Y.Value),
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value, 
                    (byte)color.B.Value, 
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawLine(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue startPosX, NumberValue startPosY, NumberValue endPosX, NumberValue endPosY, Color color)
        {
            Raylib.DrawLine(
                (int)startPosX.Value, 
                (int)startPosY.Value, 
                (int)endPosX.Value,
                (int)endPosY.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value, 
                    (byte)color.G.Value, 
                    (byte)color.B.Value, 
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawLineV(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 startPos, Vector2 endPos, Color color)
        {
            Raylib.DrawLineV(
                new System.Numerics.Vector2((float)startPos.X.Value, (float)startPos.Y.Value),
                new System.Numerics.Vector2((float)endPos.X.Value, (float)endPos.Y.Value),
                new Raylib_cs.Color(
                    (byte)color.R.Value, 
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawLineEx(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 startPos, Vector2 endPos, NumberValue thick, Color color)
        {
            Raylib.DrawLineEx(
                new System.Numerics.Vector2((float)startPos.X.Value, (float)startPos.Y.Value),
                new System.Numerics.Vector2((float)endPos.X.Value, (float)endPos.Y.Value),
                (float)thick.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value, 
                    (byte)color.G.Value, 
                    (byte)color.B.Value, 
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawLineBezier(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 startPos, Vector2 endPos, NumberValue thick, Color color)
        {
            Raylib.DrawLineBezier(
                new System.Numerics.Vector2((float)startPos.X.Value, (float)startPos.Y.Value),
                new System.Numerics.Vector2((float)endPos.X.Value, (float)endPos.Y.Value),
                (float)thick.Value,
                new Raylib_cs.Color(
                    (byte)color.R.Value, 
                    (byte)color.G.Value, 
                    (byte)color.B.Value, 
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawLineBezierQuad(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 startPos, Vector2 endPos, Vector2 controlPos, NumberValue thick, Color color)
        {
            Raylib.DrawLineBezierQuad(
                new System.Numerics.Vector2((float)startPos.X.Value, (float)startPos.Y.Value),
                new System.Numerics.Vector2((float)endPos.X.Value, (float)endPos.Y.Value),
                new System.Numerics.Vector2((float)controlPos.X.Value, (float)controlPos.Y.Value),
                (float)thick.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawLineBezierCubic(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 startPos, Vector2 endPos, Vector2 startControlPos, Vector2 endControlPos, NumberValue thick, Color color)
        {
            Raylib.DrawLineBezierCubic(
                new System.Numerics.Vector2((float)startPos.X.Value, (float)startPos.Y.Value),
                new System.Numerics.Vector2((float)endPos.X.Value, (float)endPos.Y.Value),
                new System.Numerics.Vector2((float)startControlPos.X.Value, (float)startControlPos.Y.Value),
                new System.Numerics.Vector2((float)endControlPos.X.Value, (float)endControlPos.Y.Value),
                (float)thick.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        // void DrawLineStrip(Vector2 *points, int pointCount, Color color);
        public static RuntimeResult DrawCircle(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue centerX, NumberValue centerY, NumberValue radius, Color color)
        {
            Raylib.DrawCircle(
                (int)centerX.Value, 
                (int)centerY.Value, 
                (float)radius.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawCircleSector(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 center, NumberValue radius, NumberValue startAngle, NumberValue endAngle, NumberValue segments, Color color)
        {
            Raylib.DrawCircleSector(
                new System.Numerics.Vector2((float)center.X.Value, (float)center.Y.Value),
                (float)radius.Value,
                (float)startAngle.Value, 
                (float)endAngle.Value, 
                (int)segments.Value,
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawCircleSectorLines(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 center, NumberValue radius, NumberValue startAngle, NumberValue endAngle, NumberValue segments, Color color)
        {
            Raylib.DrawCircleSectorLines(
                new System.Numerics.Vector2((float)center.X.Value, (float)center.Y.Value),
                (float)radius.Value,
                (float)startAngle.Value,
                (float)endAngle.Value,
                (int)segments.Value,
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawCircleGradient(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue centerX, NumberValue centerY, NumberValue radius, Color color1, Color color2)
        {
            Raylib.DrawCircleGradient(
                (int)centerX.Value, 
                (int)centerY.Value,
                (float)radius.Value,
                new Raylib_cs.Color(
                    (byte)color1.R.Value,
                    (byte)color1.G.Value,
                    (byte)color1.B.Value,
                    (byte)color1.A.Value
                ),
                new Raylib_cs.Color(
                    (byte)color2.R.Value,
                    (byte)color2.G.Value,
                    (byte)color2.B.Value,
                    (byte)color2.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawCircleV(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 center, NumberValue radius, Color color)
        {
            Raylib.DrawCircleV(
                new System.Numerics.Vector2((float)center.X.Value, (float)center.Y.Value),
                (float)radius.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawCircleLines(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue centerX, NumberValue centerY, NumberValue radius, Color color)
        {
            Raylib.DrawCircleLines(
                (int)centerX.Value, 
                (int)centerY.Value,
                (float)radius.Value,
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawEllipse(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue centerX, NumberValue centerY, NumberValue radiusH, NumberValue radiusV, Color color)
        {
            Raylib.DrawEllipse(
                (int)centerX.Value,
                (int)centerY.Value, 
                (float)radiusH.Value, 
                (float)radiusV.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawEllipseLines(Stenguage.Runtime.Environment scope, Position start, Position end,
            NumberValue centerX, NumberValue centerY, NumberValue radiusH, NumberValue radiusV, Color color)
        {
            Raylib.DrawEllipseLines(
                (int)centerX.Value,
                (int)centerY.Value, 
                (float)radiusH.Value,
                (float)radiusV.Value,
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRing(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 center, NumberValue innerRadius, NumberValue outerRadius, NumberValue startAngle, NumberValue endAngle, NumberValue segments, Color color)
        {
            Raylib.DrawRing(
                new System.Numerics.Vector2((float)center.X.Value, (float)center.Y.Value),
                (float)innerRadius.Value,
                (float)outerRadius.Value,
                (float)startAngle.Value, 
                (float)endAngle.Value, 
                (int)segments.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRingLines(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 center, NumberValue innerRadius, NumberValue outerRadius, NumberValue startAngle, NumberValue endAngle, NumberValue segments, Color color)
        {
            Raylib.DrawRingLines(
                new System.Numerics.Vector2((float)center.X.Value, (float)center.Y.Value),
                (float)innerRadius.Value, 
                (float)outerRadius.Value,
                (float)startAngle.Value,
                (float)endAngle.Value, 
                (int)segments.Value,
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangle(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, Color color)
        {
            Raylib.DrawRectangle(
                (int)posX.Value, 
                (int)posY.Value, 
                (int)width.Value, 
                (int)height.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleV(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 position, Vector2 size, Color color)
        {
            Raylib.DrawRectangleV(
                new System.Numerics.Vector2((float)position.X.Value, (float)position.Y.Value),
                new System.Numerics.Vector2((float)size.X.Value, (float)size.Y.Value),
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleRec(Stenguage.Runtime.Environment scope, Position start, Position end, 
            Rectangle rec, Color color)
        {
            Raylib.DrawRectangleRec(
                new Raylib_cs.Rectangle(
                    (float)rec.X.Value, 
                    (float)rec.Y.Value,
                    (float)rec.Width.Value, 
                    (float)rec.Height.Value
                ), 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectanglePro(Stenguage.Runtime.Environment scope, Position start, Position end, 
            Rectangle rec, Vector2 origin, NumberValue rotation, Color color)
        {
            Raylib.DrawRectanglePro(
                new Raylib_cs.Rectangle(
                    (float)rec.X.Value,
                    (float)rec.Y.Value,
                    (float)rec.Width.Value,
                    (float)rec.Height.Value
                ),

                new System.Numerics.Vector2((float)origin.X.Value, (float)origin.Y.Value),
                (float)rotation.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleGradientV(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, Color color1, Color color2)
        {
            Raylib.DrawRectangleGradientV(
                (int)posX.Value,
                (int)posY.Value,
                (int)width.Value,
                (int)height.Value,
                new Raylib_cs.Color(
                    (byte)color1.R.Value,
                    (byte)color1.G.Value,
                    (byte)color1.B.Value,
                    (byte)color1.A.Value
                ),
                new Raylib_cs.Color(
                    (byte)color2.R.Value,
                    (byte)color2.G.Value,
                    (byte)color2.B.Value,
                    (byte)color2.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleGradientH(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, Color color1, Color color2)
        {
            Raylib.DrawRectangleGradientH(
                (int)posX.Value, 
                (int)posY.Value, 
                (int)width.Value, 
                (int)height.Value,
                new Raylib_cs.Color(
                    (byte)color1.R.Value,
                    (byte)color1.G.Value,
                    (byte)color1.B.Value,
                    (byte)color1.A.Value
                ),
                new Raylib_cs.Color(
                    (byte)color2.R.Value,
                    (byte)color2.G.Value,
                    (byte)color2.B.Value,
                    (byte)color2.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleGradientEx(Stenguage.Runtime.Environment scope, Position start, Position end, 
            Rectangle rec, Color col1, Color col2, Color col3, Color col4)
        {
            Raylib.DrawRectangleGradientEx(
                new Raylib_cs.Rectangle(
                    (float)rec.X.Value,
                    (float)rec.Y.Value,
                    (float)rec.Width.Value,
                    (float)rec.Height.Value
                ),
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
                ),
                new Raylib_cs.Color(
                    (byte)col3.R.Value,
                    (byte)col3.G.Value,
                    (byte)col3.B.Value,
                    (byte)col3.A.Value
                ),
                new Raylib_cs.Color(
                    (byte)col4.R.Value,
                    (byte)col4.G.Value,
                    (byte)col4.B.Value,
                    (byte)col4.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleLines(Stenguage.Runtime.Environment scope, Position start, Position end, 
            NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, Color color)
        {
            Raylib.DrawRectangleLines(
                (int)posX.Value, 
                (int)posY.Value,
                (int)width.Value,
                (int)height.Value,
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleLinesEx(Stenguage.Runtime.Environment scope, Position start, Position end,
            Rectangle rec, NumberValue lineThick, Color color)
        {
            Raylib.DrawRectangleLinesEx(
                new Raylib_cs.Rectangle(
                    (float)rec.X.Value,
                    (float)rec.Y.Value,
                    (float)rec.Width.Value,
                    (float)rec.Height.Value
                ),
                (float)lineThick.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleRounded(Stenguage.Runtime.Environment scope, Position start, Position end,
            Rectangle rec, NumberValue roundness, NumberValue segments, Color color)
        {
            Raylib.DrawRectangleRounded(
                new Raylib_cs.Rectangle(
                    (float)rec.X.Value,
                    (float)rec.Y.Value,
                    (float)rec.Width.Value,
                    (float)rec.Height.Value
                ), 
                (float)roundness.Value,
                (int)segments.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawRectangleRoundedLines(Stenguage.Runtime.Environment scope, Position start, Position end,
            Rectangle rec, NumberValue roundness, NumberValue segments, NumberValue lineThick, Color color)
        {
            Raylib.DrawRectangleRoundedLines(
                new Raylib_cs.Rectangle(
                    (float)rec.X.Value,
                    (float)rec.Y.Value,
                    (float)rec.Width.Value,
                    (float)rec.Height.Value
                ), 
                (float)roundness.Value,
                (int)segments.Value,
                (float)lineThick.Value,
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawTriangle(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 v1, Vector2 v2, Vector2 v3, Color color)
        {
            Raylib.DrawTriangle(
                new System.Numerics.Vector2((float)v1.X.Value, (float)v1.Y.Value),
                new System.Numerics.Vector2((float)v2.X.Value, (float)v2.Y.Value),
                new System.Numerics.Vector2((float)v3.X.Value, (float)v3.Y.Value),
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawTriangleLines(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 v1, Vector2 v2, Vector2 v3, Color color)
        {
            Raylib.DrawTriangleLines(
                new System.Numerics.Vector2((float)v1.X.Value, (float)v1.Y.Value),
                new System.Numerics.Vector2((float)v2.X.Value, (float)v2.Y.Value),
                new System.Numerics.Vector2((float)v3.X.Value, (float)v3.Y.Value),
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        // void DrawTriangleFan(Vector2 *points, int pointCount, Color color);
        // void DrawTriangleStrip(Vector2 *points, int pointCount, Color color);
        public static RuntimeResult DrawPoly(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 center, NumberValue sides, NumberValue radius, NumberValue rotation, Color color)
        {
            Raylib.DrawPoly(
                new System.Numerics.Vector2((float)center.X.Value, (float)center.Y.Value),
                (int)sides.Value,
                (float)radius.Value,
                (float)rotation.Value,
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawPolyLines(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 center, NumberValue sides, NumberValue radius, NumberValue rotation, Color color)
        {
            Raylib.DrawPolyLines(
                new System.Numerics.Vector2((float)center.X.Value, (float)center.Y.Value),
                (int)sides.Value, 
                (float)radius.Value,
                (float)rotation.Value,
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult DrawPolyLinesEx(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 center, NumberValue sides, NumberValue radius, NumberValue rotation, NumberValue lineThick, Color color)
        {
            Raylib.DrawPolyLinesEx(
                new System.Numerics.Vector2((float)center.X.Value, (float)center.Y.Value),
                (int)sides.Value,
                (float)radius.Value,
                (float)rotation.Value,
                (float)lineThick.Value, 
                new Raylib_cs.Color(
                    (byte)color.R.Value,
                    (byte)color.G.Value,
                    (byte)color.B.Value,
                    (byte)color.A.Value
                )
            );
            return RuntimeResult.Null(scope.SourceCode, start, end);
        }
        public static RuntimeResult CheckCollisionRecs(Stenguage.Runtime.Environment scope, Position start, Position end,
            Rectangle rec1, Rectangle rec2)
        {
            return new RuntimeResult().Success(new BooleanValue(Raylib.CheckCollisionRecs(
                new Raylib_cs.Rectangle(
                    (float)rec1.X.Value,
                    (float)rec1.Y.Value,
                    (float)rec1.Width.Value,
                    (float)rec1.Height.Value
                ), 
                new Raylib_cs.Rectangle(
                    (float)rec2.X.Value,
                    (float)rec2.Y.Value,
                    (float)rec2.Width.Value,
                    (float)rec2.Height.Value
                )
            ), scope.SourceCode, start, end));
        }
        public static RuntimeResult CheckCollisionCircles(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 center1, NumberValue radius1, Vector2 center2, NumberValue radius2)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.CheckCollisionCircles(
                    new System.Numerics.Vector2((float)center1.X.Value, (float)center1.Y.Value),
                    (float)radius1.Value,
                    new System.Numerics.Vector2((float)center2.X.Value, (float)center2.Y.Value),
                    (float)radius2.Value
                ), 
            scope.SourceCode, start, end));
        }
        public static RuntimeResult CheckCollisionCircleRec(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 center, NumberValue radius, Rectangle rec)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.CheckCollisionCircleRec(
                    new System.Numerics.Vector2((float)center.X.Value, (float)center.Y.Value),
                    (float)radius.Value, 
                    new Raylib_cs.Rectangle(
                        (float)rec.X.Value,
                        (float)rec.Y.Value,
                        (float)rec.Width.Value,
                        (float)rec.Height.Value
                    )
                ), 
            scope.SourceCode, start, end));
        }
        public static RuntimeResult CheckCollisionPointRec(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 point, Rectangle rec)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.CheckCollisionPointRec(
                    new System.Numerics.Vector2((float)point.X.Value, (float)point.Y.Value),
                    new Raylib_cs.Rectangle(
                        (float)rec.X.Value,
                        (float)rec.Y.Value,
                        (float)rec.Width.Value,
                        (float)rec.Height.Value
                    )
                ), 
            scope.SourceCode, start, end));
        }
        public static RuntimeResult CheckCollisionPointCircle(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 point, Vector2 center, NumberValue radius)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.CheckCollisionPointCircle(
                    new System.Numerics.Vector2((float)point.X.Value, (float)point.Y.Value),
                    new System.Numerics.Vector2((float)center.X.Value, (float)center.Y.Value),
                    (float)radius.Value
                ), 
            scope.SourceCode, start, end));
        }
        public static RuntimeResult CheckCollisionPointTriangle(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.CheckCollisionPointTriangle(
                    new System.Numerics.Vector2((float)point.X.Value, (float)point.Y.Value),
                    new System.Numerics.Vector2((float)p1.X.Value, (float)p1.Y.Value),
                    new System.Numerics.Vector2((float)p2.X.Value, (float)p2.Y.Value),
                    new System.Numerics.Vector2((float)p3.X.Value, (float)p3.Y.Value)
                ), 
            scope.SourceCode, start, end));
        }
        // bool CheckCollisionPointPoly(Vector2 point, Vector2 *points, int pointCount);
        // bool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, Vector2 *collisionPoint);
        public static RuntimeResult CheckCollisionPointLine(Stenguage.Runtime.Environment scope, Position start, Position end,
            Vector2 point, Vector2 p1, Vector2 p2, NumberValue threshold)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.CheckCollisionPointLine(
                    new System.Numerics.Vector2((float)point.X.Value, (float)point.Y.Value),
                    new System.Numerics.Vector2((float)p1.X.Value, (float)p1.Y.Value), 
                    new System.Numerics.Vector2((float)p2.X.Value, (float)p2.Y.Value),
                    (int)threshold.Value
                ),
            scope.SourceCode, start, end));
        }
        public static RuntimeResult GetCollisionRec(Stenguage.Runtime.Environment scope, Position start, Position end,
            Rectangle rec1, Rectangle rec2)
        {
            Raylib_cs.Rectangle rect = Raylib.GetCollisionRec(
                new Raylib_cs.Rectangle(
                    (float)rec1.X.Value,
                    (float)rec1.Y.Value,
                    (float)rec1.Width.Value,
                    (float)rec1.Height.Value
                ),
                new Raylib_cs.Rectangle(
                    (float)rec2.X.Value,
                    (float)rec2.Y.Value,
                    (float)rec2.Width.Value,
                    (float)rec2.Height.Value
                )
            );
            return new RuntimeResult().Success(new Rectangle(scope.SourceCode, start, end,
                new NumberValue(rect.x, scope.SourceCode, start, end), 
                new NumberValue(rect.y, scope.SourceCode, start, end),
                new NumberValue(rect.width, scope.SourceCode, start, end), 
                new NumberValue(rect.height, scope.SourceCode, start, end) 
            ));
        }
    }
}
