# Fours

## About
Fours is an open-source 'ever-growing maths library' coded and maintained by [ctrl-shift-markus](https://www.github.com/ctrl-shift-markus). Originally meant to be a CLI tool for solving standard form quadratic equations, Fours has evolved into a maths library (with quadratic equation functions). The name (when it used to be a CLI tool for solving standard form quadratic equations) was based on '**quad**ratic' having '**quad**' in the word - which means four - but as a maths library, the name can refer to there being **four** basic arithmetic operations. Fours is programmed and designed for C# only.

## Installation
### Pre-compiled (Recommended)
- Download the compiled Fours.dll file from the [Releases](https://www.github.com/ctrl-shift-markus/fours/releases) page
- Open your Solution Explorer for your project
- Right-click 'Dependencies' and click 'Add Project Reference'
- Click 'Browse'
- Select Fours.dll (this should be in your downloads)

### Manual
- Download source code
- `cd` to the root folder (where the .sln file is)
- Run `dotnet build`
- Open your Solution Explorer for your project
- Right-click 'Dependencies' and click 'Add Project Reference'
- Click 'Browse'
- Select Fours.dll (this should be where you built the file)

## Usage
As of v1.0.0, Fours has 3 classes with working functions: `Quadratics`, `Geometry.Area` and `Geometry.Volume`. Here are the functions for each one:

### Quadratics
- `SolveEquation(double a, double b, double c)` - Solves the quadratic equation ax^2 + bx + c = 0
- `SolveDiscriminant(double a, double b, double c)` - Solves the discriminant of the quadratic equation
- `TrySolveEquation(double a, double b, double c)` - Tries to solve the quadratic equation ax^2 + bx + c = 0 and is much safer than SolveEquation
- `HasRealRoots(double a, double b, double c)` - Checks if the quadratic equation has real roots
- `GraphDirection(double a)` - Solves the direction of the graph (smile: true, frown: false)
- `FindY(double a, double b, double c, double x)` - Finds the y coordinate on the parabola at a specific x position

### Geometry.Area
- `Square(double side)` - Multiplies one side of a square (all sides are identical) to get the area
- `Rectangle(double length, double width)` - Multiplies length and width to get the area
- `Triangle(double length, double verticalHeight)` - Multiplies 1/2, base, and vertical height to get the area
- `Circle(double radius)` - Multiplies Pi by r^2 to get the area

### Geometry.Volume
- `Cube(double side)` - Cubes the side length to get the volume
- `Cuboid(double length, double height, double width)` - Multiplies length, height, and width to get the volume
- `Cylinder(double radius, double length)` - Multiplies the circular base area by length to get the volume
- `Sphere(double radius)` - Multiplies 4/3 by Pi by r³ to get the volume
- `Cone(double radius, double verticalHeight)` - Multiplies 1/3 by the circular base area by vertical height to get the volume

## Contributing
If you notice something wrong or want to improve, feel free to open an issue!