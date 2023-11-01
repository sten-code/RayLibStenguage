using Stenguage.Runtime.Values;
using Stenguage.Runtime;
using RayLibStenguage.Classes;

namespace RayLibStenguage
{
	public class RShapes
	{
        //  NOTE: It can be useful when using basic shapes and one single font, 

        //  defining a font char white rectangle would allow drawing everything in a single draw call 

        // void SetShapesTexture(Texture2D texture, Rectangle source);       // Set texture and rectangle to be used on shapes drawing 
        public static RuntimeResult SetShapesTexture(Context ctx,
            Texture2D texture, Rectangle source)
        {
            Imports.SetShapesTexture(texture.Struct, source.Struct);
            return RuntimeResult.Null();
        }

        //  Basic shapes drawing functions 

        // void DrawPixel(int posX, int posY, Color color);                                                   // Draw a pixel 
        public static RuntimeResult DrawPixel(Context ctx,
            NumberValue posX, NumberValue posY, Color color)
        {
            Imports.DrawPixel((int)posX.Value, (int)posY.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawPixelV(Classes.Vector2 position, Color color);                                                    // Draw a pixel (Vector version) 
        public static RuntimeResult DrawPixelV(Context ctx,
            Classes.Vector2 position, Color color)
        {
            Imports.DrawPixelV(position.Struct, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color);                // Draw a line 
        public static RuntimeResult DrawLine(Context ctx,
            NumberValue startPosX, NumberValue startPosY, NumberValue endPosX, NumberValue endPosY, Color color)
        {
            Imports.DrawLine((int)startPosX.Value, (int)startPosY.Value, (int)endPosX.Value, (int)endPosY.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawLineV(Classes.Vector2 startPos, Classes.Vector2 endPos, Color color);                                     // Draw a line (Vector version) 
        public static RuntimeResult DrawLineV(Context ctx,
            Classes.Vector2 startPos, Classes.Vector2 endPos, Color color)
        {
            Imports.DrawLineV(startPos.Struct, endPos.Struct, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawLineEx(Classes.Vector2 startPos, Classes.Vector2 endPos, float thick, Color color);                       // Draw a line defining thickness 
        public static RuntimeResult DrawLineEx(Context ctx,
            Classes.Vector2 startPos, Classes.Vector2 endPos, NumberValue thick, Color color)
        {
            Imports.DrawLineEx(startPos.Struct, endPos.Struct, (float)thick.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawLineBezier(Classes.Vector2 startPos, Classes.Vector2 endPos, float thick, Color color);                   // Draw a line using cubic-bezier curves in-out 
        public static RuntimeResult DrawLineBezier(Context ctx,
            Classes.Vector2 startPos, Classes.Vector2 endPos, NumberValue thick, Color color)
        {
            Imports.DrawLineBezier(startPos.Struct, endPos.Struct, (float)thick.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawLineBezierQuad(Classes.Vector2 startPos, Classes.Vector2 endPos, Classes.Vector2 controlPos, float thick, Color color); // Draw line using quadratic bezier curves with a control point 
        public static RuntimeResult DrawLineBezierQuad(Context ctx,
            Classes.Vector2 startPos, Classes.Vector2 endPos, Classes.Vector2 controlPos, NumberValue thick, Color color)
        {
            Imports.DrawLineBezierQuad(startPos.Struct, endPos.Struct, controlPos.Struct, (float)thick.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawLineBezierCubic(Classes.Vector2 startPos, Classes.Vector2 endPos, Classes.Vector2 startControlPos, Classes.Vector2 endControlPos, float thick, Color color); // Draw line using cubic bezier curves with 2 control points 
        public static RuntimeResult DrawLineBezierCubic(Context ctx,
            Classes.Vector2 startPos, Classes.Vector2 endPos, Classes.Vector2 startControlPos, Classes.Vector2 endControlPos, NumberValue thick, Color color)
        {
            Imports.DrawLineBezierCubic(startPos.Struct, endPos.Struct, startControlPos.Struct, endControlPos.Struct, (float)thick.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawLineStrip(Classes.Vector2 *points, int pointCount, Color color);                                  // Draw lines sequence 
        public static RuntimeResult DrawLineStrip(Context ctx,
            ListValue points, NumberValue pointCount, Color color)
        {
            Imports.DrawLineStrip(
                points.Items
                    .Where(x => x.GetType() == typeof(Vector2))
                    .Select(x => ((Vector2)x).Struct)
                    .ToArray(), 
                (int)pointCount.Value, 
                color.Struct
            );
            return RuntimeResult.Null();
        }

        // void DrawCircle(int centerX, int centerY, float radius, Color color);                              // Draw a color-filled circle 
        public static RuntimeResult DrawCircle(Context ctx,
            NumberValue centerX, NumberValue centerY, NumberValue radius, Color color)
        {
            Imports.DrawCircle((int)centerX.Value, (int)centerY.Value, (float)radius.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawCircleSector(Classes.Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);      // Draw a piece of a circle 
        public static RuntimeResult DrawCircleSector(Context ctx,
            Classes.Vector2 center, NumberValue radius, NumberValue startAngle, NumberValue endAngle, NumberValue segments, Color color)
        {
            Imports.DrawCircleSector(center.Struct, (float)radius.Value, (float)startAngle.Value, (float)endAngle.Value, (int)segments.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawCircleSectorLines(Classes.Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color); // Draw circle sector outline 
        public static RuntimeResult DrawCircleSectorLines(Context ctx,
            Classes.Vector2 center, NumberValue radius, NumberValue startAngle, NumberValue endAngle, NumberValue segments, Color color)
        {
            Imports.DrawCircleSectorLines(center.Struct, (float)radius.Value, (float)startAngle.Value, (float)endAngle.Value, (int)segments.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawCircleGradient(int centerX, int centerY, float radius, Color color1, Color color2);       // Draw a gradient-filled circle 
        public static RuntimeResult DrawCircleGradient(Context ctx,
            NumberValue centerX, NumberValue centerY, NumberValue radius, Color color1, Color color2)
        {
            Imports.DrawCircleGradient((int)centerX.Value, (int)centerY.Value, (float)radius.Value, color1.Struct, color2.Struct);
            return RuntimeResult.Null();
        }

        // void DrawCircleV(Classes.Vector2 center, float radius, Color color);                                       // Draw a color-filled circle (Vector version) 
        public static RuntimeResult DrawCircleV(Context ctx,
            Classes.Vector2 center, NumberValue radius, Color color)
        {
            Imports.DrawCircleV(center.Struct, (float)radius.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawCircleLines(int centerX, int centerY, float radius, Color color);                         // Draw circle outline 
        public static RuntimeResult DrawCircleLines(Context ctx,
            NumberValue centerX, NumberValue centerY, NumberValue radius, Color color)
        {
            Imports.DrawCircleLines((int)centerX.Value, (int)centerY.Value, (float)radius.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Color color);             // Draw ellipse 
        public static RuntimeResult DrawEllipse(Context ctx,
            NumberValue centerX, NumberValue centerY, NumberValue radiusH, NumberValue radiusV, Color color)
        {
            Imports.DrawEllipse((int)centerX.Value, (int)centerY.Value, (float)radiusH.Value, (float)radiusV.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Color color);        // Draw ellipse outline 
        public static RuntimeResult DrawEllipseLines(Context ctx,
            NumberValue centerX, NumberValue centerY, NumberValue radiusH, NumberValue radiusV, Color color)
        {
            Imports.DrawEllipseLines((int)centerX.Value, (int)centerY.Value, (float)radiusH.Value, (float)radiusV.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRing(Classes.Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color); // Draw ring 
        public static RuntimeResult DrawRing(Context ctx,
            Classes.Vector2 center, NumberValue innerRadius, NumberValue outerRadius, NumberValue startAngle, NumberValue endAngle, NumberValue segments, Color color)
        {
            Imports.DrawRing(center.Struct, (float)innerRadius.Value, (float)outerRadius.Value, (float)startAngle.Value, (float)endAngle.Value, (int)segments.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRingLines(Classes.Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);    // Draw ring outline 
        public static RuntimeResult DrawRingLines(Context ctx,
            Classes.Vector2 center, NumberValue innerRadius, NumberValue outerRadius, NumberValue startAngle, NumberValue endAngle, NumberValue segments, Color color)
        {
            Imports.DrawRingLines(center.Struct, (float)innerRadius.Value, (float)outerRadius.Value, (float)startAngle.Value, (float)endAngle.Value, (int)segments.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRectangle(int posX, int posY, int width, int height, Color color);                        // Draw a color-filled rectangle 
        public static RuntimeResult DrawRectangle(Context ctx,
            NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, Color color)
        {
            Imports.DrawRectangle((int)posX.Value, (int)posY.Value, (int)width.Value, (int)height.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRectangleV(Classes.Vector2 position, Classes.Vector2 size, Color color);                                  // Draw a color-filled rectangle (Vector version) 
        public static RuntimeResult DrawRectangleV(Context ctx,
            Classes.Vector2 position, Classes.Vector2 size, Color color)
        {
            Imports.DrawRectangleV(position.Struct, size.Struct, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRectangleRec(Rectangle rec, Color color);                                                 // Draw a color-filled rectangle 
        public static RuntimeResult DrawRectangleRec(Context ctx,
            Rectangle rec, Color color)
        {
            Imports.DrawRectangleRec(rec.Struct, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRectanglePro(Rectangle rec, Classes.Vector2 origin, float rotation, Color color);                 // Draw a color-filled rectangle with pro parameters 
        public static RuntimeResult DrawRectanglePro(Context ctx,
            Rectangle rec, Classes.Vector2 origin, NumberValue rotation, Color color)
        {
            Imports.DrawRectanglePro(rec.Struct, origin.Struct, (float)rotation.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRectangleGradientV(int posX, int posY, int width, int height, Color color1, Color color2);// Draw a vertical-gradient-filled rectangle 
        public static RuntimeResult DrawRectangleGradientV(Context ctx,
            NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, Color color1, Color color2)
        {
            Imports.DrawRectangleGradientV((int)posX.Value, (int)posY.Value, (int)width.Value, (int)height.Value, color1.Struct, color2.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRectangleGradientH(int posX, int posY, int width, int height, Color color1, Color color2);// Draw a horizontal-gradient-filled rectangle 
        public static RuntimeResult DrawRectangleGradientH(Context ctx,
            NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, Color color1, Color color2)
        {
            Imports.DrawRectangleGradientH((int)posX.Value, (int)posY.Value, (int)width.Value, (int)height.Value, color1.Struct, color2.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRectangleGradientEx(Rectangle rec, Color col1, Color col2, Color col3, Color col4);       // Draw a gradient-filled rectangle with custom vertex colors 
        public static RuntimeResult DrawRectangleGradientEx(Context ctx,
            Rectangle rec, Color col1, Color col2, Color col3, Color col4)
        {
            Imports.DrawRectangleGradientEx(rec.Struct, col1.Struct, col2.Struct, col3.Struct, col4.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRectangleLines(int posX, int posY, int width, int height, Color color);                   // Draw rectangle outline 
        public static RuntimeResult DrawRectangleLines(Context ctx,
            NumberValue posX, NumberValue posY, NumberValue width, NumberValue height, Color color)
        {
            Imports.DrawRectangleLines((int)posX.Value, (int)posY.Value, (int)width.Value, (int)height.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRectangleLinesEx(Rectangle rec, float lineThick, Color color);                            // Draw rectangle outline with extended parameters 
        public static RuntimeResult DrawRectangleLinesEx(Context ctx,
            Rectangle rec, NumberValue lineThick, Color color)
        {
            Imports.DrawRectangleLinesEx(rec.Struct, (float)lineThick.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRectangleRounded(Rectangle rec, float roundness, int segments, Color color);              // Draw rectangle with rounded edges 
        public static RuntimeResult DrawRectangleRounded(Context ctx,
            Rectangle rec, NumberValue roundness, NumberValue segments, Color color)
        {
            Imports.DrawRectangleRounded(rec.Struct, (float)roundness.Value, (int)segments.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawRectangleRoundedLines(Rectangle rec, float roundness, int segments, float lineThick, Color color); // Draw rectangle with rounded edges outline 
        public static RuntimeResult DrawRectangleRoundedLines(Context ctx,
            Rectangle rec, NumberValue roundness, NumberValue segments, NumberValue lineThick, Color color)
        {
            Imports.DrawRectangleRoundedLines(rec.Struct, (float)roundness.Value, (int)segments.Value, (float)lineThick.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawTriangle(Classes.Vector2 v1, Classes.Vector2 v2, Classes.Vector2 v3, Color color);                                // Draw a color-filled triangle (vertex in counter-clockwise order!) 
        public static RuntimeResult DrawTriangle(Context ctx,
            Classes.Vector2 v1, Classes.Vector2 v2, Classes.Vector2 v3, Color color)
        {
            Imports.DrawTriangle(v1.Struct, v2.Struct, v3.Struct, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawTriangleLines(Classes.Vector2 v1, Classes.Vector2 v2, Classes.Vector2 v3, Color color);                           // Draw triangle outline (vertex in counter-clockwise order!) 
        public static RuntimeResult DrawTriangleLines(Context ctx,
            Classes.Vector2 v1, Classes.Vector2 v2, Classes.Vector2 v3, Color color)
        {
            Imports.DrawTriangleLines(v1.Struct, v2.Struct, v3.Struct, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawTriangleFan(Classes.Vector2 *points, int pointCount, Color color);                                // Draw a triangle fan defined by points (first vertex is the center) 
        public static RuntimeResult DrawTriangleFan(Context ctx,
            ListValue points, NumberValue pointCount, Color color)
        {
            Imports.DrawTriangleFan(
                points.Items
                        .Where(x => x.GetType() == typeof(Vector2))
                        .Select(x => ((Vector2)x).Struct)
                        .ToArray(),
                (int)pointCount.Value, 
                color.Struct
            );
            return RuntimeResult.Null();
        }

        // void DrawTriangleStrip(Classes.Vector2 *points, int pointCount, Color color);                              // Draw a triangle strip defined by points 
        public static RuntimeResult DrawTriangleStrip(Context ctx,
            ListValue points, NumberValue pointCount, Color color)
        {
            Imports.DrawTriangleStrip(
                points.Items
                    .Where(x => x.GetType() == typeof(Vector2))
                    .Select(x => ((Vector2)x).Struct)
                    .ToArray(), 
                (int)pointCount.Value,
                color.Struct
            );
            return RuntimeResult.Null();
        }

        // void DrawPoly(Classes.Vector2 center, int sides, float radius, float rotation, Color color);               // Draw a regular polygon (Vector version) 
        public static RuntimeResult DrawPoly(Context ctx,
            Classes.Vector2 center, NumberValue sides, NumberValue radius, NumberValue rotation, Color color)
        {
            Imports.DrawPoly(center.Struct, (int)sides.Value, (float)radius.Value, (float)rotation.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawPolyLines(Classes.Vector2 center, int sides, float radius, float rotation, Color color);          // Draw a polygon outline of n sides 
        public static RuntimeResult DrawPolyLines(Context ctx,
            Classes.Vector2 center, NumberValue sides, NumberValue radius, NumberValue rotation, Color color)
        {
            Imports.DrawPolyLines(center.Struct, (int)sides.Value, (float)radius.Value, (float)rotation.Value, color.Struct);
            return RuntimeResult.Null();
        }

        // void DrawPolyLinesEx(Classes.Vector2 center, int sides, float radius, float rotation, float lineThick, Color color); // Draw a polygon outline of n sides with extended parameters 
        public static RuntimeResult DrawPolyLinesEx(Context ctx,
            Classes.Vector2 center, NumberValue sides, NumberValue radius, NumberValue rotation, NumberValue lineThick, Color color)
        {
            Imports.DrawPolyLinesEx(center.Struct, (int)sides.Value, (float)radius.Value, (float)rotation.Value, (float)lineThick.Value, color.Struct);
            return RuntimeResult.Null();
        }

        //  Basic shapes collision detection functions 

        // bool CheckCollisionRecs(Rectangle rec1, Rectangle rec2);                                           // Check collision between two rectangles 
        public static RuntimeResult CheckCollisionRecs(Context ctx,
            Rectangle rec1, Rectangle rec2)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.CheckCollisionRecs(rec1.Struct, rec2.Struct)));
        }

        // bool CheckCollisionCircles(Classes.Vector2 center1, float radius1, Classes.Vector2 center2, float radius2);        // Check collision between two circles 
        public static RuntimeResult CheckCollisionCircles(Context ctx,
            Classes.Vector2 center1, NumberValue radius1, Classes.Vector2 center2, NumberValue radius2)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.CheckCollisionCircles(center1.Struct, (float)radius1.Value, center2.Struct, (float)radius2.Value)));
        }

        // bool CheckCollisionCircleRec(Classes.Vector2 center, float radius, Rectangle rec);                         // Check collision between circle and rectangle 
        public static RuntimeResult CheckCollisionCircleRec(Context ctx,
            Classes.Vector2 center, NumberValue radius, Rectangle rec)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.CheckCollisionCircleRec(center.Struct, (float)radius.Value, rec.Struct)));
        }

        // bool CheckCollisionPointRec(Classes.Vector2 point, Rectangle rec);                                         // Check if point is inside rectangle 
        public static RuntimeResult CheckCollisionPointRec(Context ctx,
            Classes.Vector2 point, Rectangle rec)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.CheckCollisionPointRec(point.Struct, rec.Struct)));
        }

        // bool CheckCollisionPointCircle(Classes.Vector2 point, Classes.Vector2 center, float radius);                       // Check if point is inside circle 
        public static RuntimeResult CheckCollisionPointCircle(Context ctx,
            Classes.Vector2 point, Classes.Vector2 center, NumberValue radius)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.CheckCollisionPointCircle(point.Struct, center.Struct, (float)radius.Value)));
        }

        // bool CheckCollisionPointTriangle(Classes.Vector2 point, Classes.Vector2 p1, Classes.Vector2 p2, Classes.Vector2 p3);               // Check if point is inside a triangle 
        public static RuntimeResult CheckCollisionPointTriangle(Context ctx,
            Classes.Vector2 point, Classes.Vector2 p1, Classes.Vector2 p2, Classes.Vector2 p3)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.CheckCollisionPointTriangle(point.Struct, p1.Struct, p2.Struct, p3.Struct)));
        }

        // bool CheckCollisionPointPoly(Classes.Vector2 point, Classes.Vector2 *points, int pointCount);                      // Check if point is within a polygon described by array of vertices 
        public static RuntimeResult CheckCollisionPointPoly(Context ctx,
            Classes.Vector2 point, ListValue points, NumberValue pointCount)
        {
            return new RuntimeResult().Success(new BooleanValue(
                Imports.CheckCollisionPointPoly(
                    point.Struct, 
                    points.Items
                        .Where(x => x.GetType() == typeof(Vector2))
                        .Select(x => ((Vector2)x).Struct)
                        .ToArray(), 
                    (int)pointCount.Value
                )
            ));
        }

        // bool CheckCollisionLines(Classes.Vector2 startPos1, Classes.Vector2 endPos1, Classes.Vector2 startPos2, Classes.Vector2 endPos2, Classes.Vector2 *collisionPoint); // Check the collision between two lines defined by two points each, returns collision point by reference 
        public unsafe static RuntimeResult CheckCollisionLines(Context ctx,
            Classes.Vector2 startPos1, Classes.Vector2 endPos1, Classes.Vector2 startPos2, Classes.Vector2 endPos2, Classes.Vector2 collisionPoint)
        {
            System.Numerics.Vector2 vec = collisionPoint.Struct;
            return new RuntimeResult().Success(new BooleanValue(Imports.CheckCollisionLines(startPos1.Struct, endPos1.Struct, startPos2.Struct, endPos2.Struct, &vec)));
        }

        // bool CheckCollisionPointLine(Classes.Vector2 point, Classes.Vector2 p1, Classes.Vector2 p2, int threshold);                // Check if point belongs to line created between two points [p1] and [p2] with defined margin in pixels [threshold] 
        public static RuntimeResult CheckCollisionPointLine(Context ctx,
            Classes.Vector2 point, Classes.Vector2 p1, Classes.Vector2 p2, NumberValue threshold)
        {
            return new RuntimeResult().Success(new BooleanValue(Imports.CheckCollisionPointLine(point.Struct, p1.Struct, p2.Struct, (int)threshold.Value)));
        }

        // Rectangle GetCollisionRec(Rectangle rec1, Rectangle rec2);                                         // Get collision rectangle for two rectangles collisio 
        public static RuntimeResult GetCollisionRec(Context ctx,
            Rectangle rec1, Rectangle rec2)
        {
            return new RuntimeResult().Success(new Rectangle(Imports.GetCollisionRec(rec1.Struct, rec2.Struct)));
        }
    }
}
