using System;

namespace FoursLibrary;
public class Quadratic
{

    // Solves the quadratic equation ax^2 + bx + c = 0
    public static (double PlusAns, double NegAns) SolveEquation(double a, double b, double c)
    {
        double discriminant = SolveDiscriminant(a, b, c);
        double plusans = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double negans = (-b - Math.Sqrt(discriminant)) / (2 * a);

        return (plusans, negans);
    }

    // Solves the discriminant of the quadratic equation
    public static double SolveDiscriminant(double a, double b, double c) =>
        (b * b) - (4 * a * c);

    // Tries to solve the quadratic equation ax^2 + bx + c = 0 and is much safer than SolveEquation
    public static (double Plus, double Neg)? TrySolveEquation(double a, double b, double c)
    {
        if (!HasRealRoots(a, b, c))
        {
            return null;
        }
        return SolveEquation(a, b, c);
    }

    // Checks if the quadratic equation has real roots
    public static bool HasRealRoots(double a, double b, double c) =>
        SolveDiscriminant(a, b, c) >= 0;

    // Solves the direction of the graph (smile: true, frown: false)
    public static bool GraphDirection(double a) =>
        a > 0;

    // Solves the y value
    public static double FindY(double a, double b, double c, double x) =>
        (a * x * x) + (b * x) + c;

}
