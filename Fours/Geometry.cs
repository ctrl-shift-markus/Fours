using System;

namespace Fours;
public class Geometry
{

    public class Area
    {

        // Multiplies one side of a square (all sides are identical) to get the area
        public static double Square(double side) =>
            side * side;

        // Multiplies length and width to get the area
        public static double Rectangle(double length, double width) =>
            length * width;

        // Multiplies 1/2, base, and vertical height to get the area
        public static double Triangle(double length, double verticalHeight) =>
            (1.0 / 2.0) * length * verticalHeight;

        // Multiplies Pi by r^2 to get the area
        public static double Circle(double radius) =>
            Math.PI * Math.Pow(radius, 2);
    }

    public class Volume
    {
        // Cubes one side of a cube (all sides are identical) to get the volume
        public static double Cube(double side) =>
            Math.Pow(side, 3);

        // Multiplies length, height, and width to get the volume
        public static double Cuboid(double length, double height, double width) =>
            length * height * width;

        // Multiplies the area of a circle by the length of the cylinder to get the volume
        public static double Cylinder(double radius, double length) =>
            Area.Circle(radius) * length;

        // Multiplies 4/3 by Pi by r^3 to get the volume
        public static double Sphere(double radius) =>
            (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

        // Multiplies 1/3 by Pi by r^2 by vertical height to get the volume
        public static double Cone(double radius, double verticalHeight) =>
            (1.0 / 3.0) * Area.Circle(radius) * verticalHeight;
    }

    public class Angle
    {
        // Common angle measurements in degrees
        public const double FullTurn = 360.0;
        public const double ThreeQuarterTurn = 270.0;
        public const double HalfTurn = 180.0;
        public const double QuarterTurn = 90.0;
        public const double StraightAngle = 180.0;
        public const double RightAngle = 90.0;
        public const double EquilateralTriangleAngle = 60.0;
        public const double SquareAngle = 90.0;

        // Finds the missing angle in a triangle using two angles
        public static double FindMissingTriangleAngle(double knownAngle1, double knownAngle2) =>
            HalfTurn - (knownAngle1 + knownAngle2);

        // Finds the missing angle in a quadrilateral using three angles
        public static double FindMissingQuadrilateralAngle(double knownAngle1, double knownAngle2, double knownAngle3) =>
            FullTurn - (knownAngle1 + knownAngle2 + knownAngle3);

        // Finds what each angle in a regular polygon is using number of sides and returns null if the number cannot be a polygon (e.g. a circle is 1 side and not a polygon so 'null is returned')
        public static double? RegularPolygonInteriorAngle(int numberOfSides)
        {
            if (numberOfSides < 3)
                return null;

            if (numberOfSides == 3)
                return EquilateralTriangleAngle;

            if (numberOfSides == 4)
                return SquareAngle;
            return ((numberOfSides - 2) * StraightAngle) / numberOfSides;
        }

        // Finds what each exterior angle in a regular polygon is using number of sides and returns null if the number cannot be a polygon (e.g. a circle is 1 side and not a polygon so 'null is returned')
        public static double? RegularPolygonExteriorAngle(int numberOfSides)
        {
            if (numberOfSides < 3)
                return null;
            return FullTurn / numberOfSides;
        }

        // Checks if a angle is acute or not
        public static bool IsAcute(double angle) =>
            angle < RightAngle && angle > 0.0;

        // Checks if a angle is obtuse or not
        public static bool IsObtuse(double angle) =>
            angle > RightAngle && angle < StraightAngle;

        // Checks if a angle is reflex or not
        public static bool IsReflex(double angle) =>
            angle > StraightAngle && angle < FullTurn;

        // Checks if a angle is a right angle or not
        public static bool IsRightAngle(double angle) =>
            angle == RightAngle;

        // Checks if a angle is straight or not
        public static bool IsStraightAngle(double angle) =>
            angle == StraightAngle;
    }
}