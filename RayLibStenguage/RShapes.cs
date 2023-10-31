using Raylib_cs;
using Stenguage.Runtime.Values;
using Stenguage.Runtime;
using Stenguage;

namespace RayLibStenguage
{
    public class RShapes
    {
        // void SetShapesTexture(Texture2D texture, Rectangle source);
        public static RuntimeResult DrawPixel(Context ctx, 
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawPixelV(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawLine(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawLineV(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawLineEx(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawLineBezier(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawLineBezierQuad(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawLineBezierCubic(Context ctx,
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
            return RuntimeResult.Null();
        }
        // void DrawLineStrip(Vector2 *points, int pointCount, Color color);
        public static RuntimeResult DrawCircle(Context ctx, 
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawCircleSector(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawCircleSectorLines(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawCircleGradient(Context ctx, 
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawCircleV(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawCircleLines(Context ctx, 
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawEllipse(Context ctx, 
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawEllipseLines(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRing(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRingLines(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRectangle(Context ctx, 
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRectangleV(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRectangleRec(Context ctx, 
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRectanglePro(Context ctx, 
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRectangleGradientV(Context ctx, 
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRectangleGradientH(Context ctx, 
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRectangleGradientEx(Context ctx, 
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRectangleLines(Context ctx, 
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRectangleLinesEx(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRectangleRounded(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawRectangleRoundedLines(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawTriangle(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawTriangleLines(Context ctx,
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
            return RuntimeResult.Null();
        }
        // void DrawTriangleFan(Vector2 *points, int pointCount, Color color);
        // void DrawTriangleStrip(Vector2 *points, int pointCount, Color color);
        public static RuntimeResult DrawPoly(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawPolyLines(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult DrawPolyLinesEx(Context ctx,
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
            return RuntimeResult.Null();
        }
        public static RuntimeResult CheckCollisionRecs(Context ctx,
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
            )));
        }
        public static RuntimeResult CheckCollisionCircles(Context ctx,
            Vector2 center1, NumberValue radius1, Vector2 center2, NumberValue radius2)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.CheckCollisionCircles(
                    new System.Numerics.Vector2((float)center1.X.Value, (float)center1.Y.Value),
                    (float)radius1.Value,
                    new System.Numerics.Vector2((float)center2.X.Value, (float)center2.Y.Value),
                    (float)radius2.Value
                )
            ));
        }
        public static RuntimeResult CheckCollisionCircleRec(Context ctx,
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
                )
            ));
        }
        public static RuntimeResult CheckCollisionPointRec(Context ctx,
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
                )
            ));
        }
        public static RuntimeResult CheckCollisionPointCircle(Context ctx,
            Vector2 point, Vector2 center, NumberValue radius)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.CheckCollisionPointCircle(
                    new System.Numerics.Vector2((float)point.X.Value, (float)point.Y.Value),
                    new System.Numerics.Vector2((float)center.X.Value, (float)center.Y.Value),
                    (float)radius.Value
                )
            ));
        }
        public static RuntimeResult CheckCollisionPointTriangle(Context ctx,
            Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.CheckCollisionPointTriangle(
                    new System.Numerics.Vector2((float)point.X.Value, (float)point.Y.Value),
                    new System.Numerics.Vector2((float)p1.X.Value, (float)p1.Y.Value),
                    new System.Numerics.Vector2((float)p2.X.Value, (float)p2.Y.Value),
                    new System.Numerics.Vector2((float)p3.X.Value, (float)p3.Y.Value)
                )
            ));
        }
        // bool CheckCollisionPointPoly(Vector2 point, Vector2 *points, int pointCount);
        // bool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, Vector2 *collisionPoint);
        public static RuntimeResult CheckCollisionPointLine(Context ctx,
            Vector2 point, Vector2 p1, Vector2 p2, NumberValue threshold)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Raylib.CheckCollisionPointLine(
                    new System.Numerics.Vector2((float)point.X.Value, (float)point.Y.Value),
                    new System.Numerics.Vector2((float)p1.X.Value, (float)p1.Y.Value), 
                    new System.Numerics.Vector2((float)p2.X.Value, (float)p2.Y.Value),
                    (int)threshold.Value
                )
            ));
        }
        public static RuntimeResult GetCollisionRec(Context ctx,
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
            return new RuntimeResult().Success(new Rectangle(
                new NumberValue(rect.x), 
                new NumberValue(rect.y),
                new NumberValue(rect.width), 
                new NumberValue(rect.height) 
            ));
        }
    }
}
