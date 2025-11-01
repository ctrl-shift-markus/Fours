# Fours

## About
Fours is an open-source 'ever-growing maths library' coded and maintained by [ctrl-shift-markus](https://www.github.com/ctrl-shift-markus). Originally meant to be a CLI tool for solving standard form quadratic equations, Fours has evolved into a maths library (with quadratic equation functions). The name (when it used to be a CLI tool for solving standard form quadratic equations) was based on '**quad**ratic' having '**quad**' in the word - which means four - but as a maths library, the name can refer to there being **four** basic arithmetic operations. Fours is programmed and designed for C# only.

## Installation
### Pre-compiled (Recommended)
- Download Fours.dll from the [Releases](https://www.github.com/ctrl-shift-markus/fours/releases) page
---
- Open your project you wish to use Fours with
- Open your Solution Explorer (View -> Solution Explorer)
- Right-click 'Dependencies' in the Solution Explorer and click 'Add Project Reference' on the dropdown
- Click 'Browse' at the bottom of the window
- Select Fours.dll (this should be where you built the file)

### Manual
- Clone the repository using `git clone https://github.com/ctrl-shift-markus/Fours.git`
- Enter the cloned repository using `cd Fours`
- Build the .dll using `dotnet build --configuration Release` or `dotnet build -c Release` - they're the same
---
- Open your project you wish to use Fours with
- Open your Solution Explorer (View -> Solution Explorer)
- Right-click 'Dependencies' in the Solution Explorer and click 'Add Project Reference' on the dropdown
- Click 'Browse' at the bottom of the window
- Select Fours.dll (this should be where you built the file)

## .NET
Fours' framework is currently **.NET 8.0**, the latest LTS version of .NET, which has improved features and new additions all while having a long support term, and will always only upgrade to the latest LTS version of .NET, so that this library can stay stable and backwards compatible. With the upcoming release of **.NET 10.0**, Fours will be upgraded in December - a month after - so that there is enough time to upgrade your runtime and projects.

## Wiki
For a wiki dedicated to Fours, including **every single** variable, function and class, please feel free to pop by the [Fours wiki](https://github.com/ctrl-shift-markus/Fours/wiki). The wiki contains readable yet useful information about each class and how to use their functions.
