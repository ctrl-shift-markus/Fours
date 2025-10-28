using System;

namespace FoursLibrary;
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
}