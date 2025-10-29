using System;
using System.Diagnostics;

namespace Fours;

public class Conversions
{
    public class Temperature
    {
        // Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double celsius) =>
            (celsius * 1.8) + 32.0;

        // Fahrenheit to Celsius
        public static double FahrenheitToCelsius(double fahrenheit) =>
            (fahrenheit - 32.0) * (5.0 / 9.0);

        // Celsius to Kelvin
        public static double CelsiusToKelvin(double celsius) =>
            celsius + 273.15;

        // Kelvin to Celsius
        public static double KelvinToCelsius(double kelvin) =>
            kelvin - 273.15;

        // Fahrenheit to Kelvin
        public static double FahrenheitToKelvin(double fahrenheit) =>
            (fahrenheit - 32.0) * (5.0 / 9.0) + 273.15;

        // Kelvin to Fahrenheit
        public static double KelvinToFahrenheit(double kelvin) =>
            (kelvin - 273.15) * (9.0 / 5.0) + 32.0;
    }

    public class Distance
    {
        // Kilometers to Miles
        public static double KilometersToMiles(double kilometers) =>
            kilometers * 0.621371;

        // Miles to Kilometers
        public static double MilesToKilometers(double miles) =>
            miles / 0.621371;

        // Meters to Feet
        public static double MetersToFeet(double meters) =>
            meters * 3.28084;

        // Feet to Meters
        public static double FeetToMeters(double feet) =>
            feet / 3.28084;

        // Centimeters to Inches
        public static double CentimetersToInches(double centimeters) =>
            centimeters / 2.54;

        // Inches to Centimeters
        public static double InchesToCentimeters(double inches) =>
            inches * 2.54;
    }

    public class Weight
    {
        // Kilograms to Pounds
        public static double KilogramsToPounds(double kilograms) =>
            kilograms * 2.20462;

        // Pounds to Kilograms
        public static double PoundsToKilograms(double pounds) =>
            pounds / 2.20462;

        // Kilograms to Stones
        public static double KilogramsToStones(double kilograms) =>
            kilograms * 0.157473;

        // Stones to Kilograms
        public static double StonesToKilograms(double stones) =>
            stones / 0.157473;

        // Pounds to Stones
        public static double PoundsToStones(double pounds) =>
            pounds * 0.0714286;

        // Stones to Pounds
        public static double StonesToPounds(double stones) =>
            stones / 0.0714286;

        // Grams to Ounces
        public static double GramsToOunces(double grams) =>
            grams * 0.035274;

        // Ounces to Grams
        public static double OuncesToGrams(double ounces) =>
            ounces / 0.035274;
    }

    public class Volume
    {
        // Meters^3 to Feet^3
        public static double MetersCubedToFeetCubed(double metersCubed) =>
            metersCubed * 35.3147;

        // Feet^3 to Meters^3
        public static double FeetCubedToMetersCubed(double feetCubed) =>
            feetCubed / 35.3147;

        // Meters^3 to Inches^3
        public static double MetersCubedToInchesCubed(double metersCubed) =>
            metersCubed * 61023.7;

        // Inches^3 to Meters^3
        public static double InchesCubedToMetersCubed(double inchesCubed) =>
            inchesCubed / 61023.7;

        // Kilometers^3 to Meters^3
        public static double KilometersCubedToMetersCubed(double kilometersCubed) =>
            kilometersCubed * 1000000000.0;

        // Meters^3 to Kilometers^3
        public static double MetersCubedToKilometersCubed(double metersCubed) =>
            metersCubed / 1000000000.0;

        // Centimeters^3 to Meters^3
        public static double CentimetersCubedToMetersCubed(double centimetersCubed) =>
            centimetersCubed / 1000000.0;

        // Meters^3 to Centimeters^3
        public static double MetersCubedToCentimetersCubed(double metersCubed) =>
            metersCubed * 1000000.0;

        // Feet^3 to Inches^3
        public static double FeetCubedToInchesCubed(double feetCubed) =>
            feetCubed * 1728.0;

        // Inches^3 to Feet^3
        public static double InchesCubedToFeetCubed(double inchesCubed) =>
            inchesCubed / 1728.0;

        // Centimeters^3 to Inches^3
        public static double CentimetersCubedToInchesCubed(double centimetersCubed) =>
            centimetersCubed * 0.0610237;

        // Inches^3 to Centimeters^3
        public static double InchesCubedToCentimetersCubed(double inchesCubed) =>
            inchesCubed / 0.0610237;
    }

    public class Area
    {
        // Meters^2 to Feet^2
        public static double MetersSquaredToFeetSquared(double metersSquared) =>
            metersSquared * 10.7639;

        // Feet^2 to Meters^2
        public static double FeetSquaredToMetersSquared(double feetSquared) =>
            feetSquared / 10.7639;

        // Meters^2 to Inches^2
        public static double MetersSquaredToInchesSquared(double metersSquared) =>
            metersSquared * 1550.0;

        // Inches^2 to Meters^2
        public static double InchesSquaredToMetersSquared(double inchesSquared) =>
            inchesSquared / 1550.0;

        // Kilometers^2 to Meters^2
        public static double KilometersSquaredToMetersSquared(double kilometersSquared) =>
            kilometersSquared * 1000000.0;

        // Meters^2 to Kilometers^2
        public static double MetersSquaredToKilometersSquared(double metersSquared) =>
            metersSquared / 1000000.0;

        // Centimeters^2 to Meters^2
        public static double CentimetersSquaredToMetersSquared(double centimetersSquared) =>
            centimetersSquared / 10000.0;

        // Meters^2 to Centimeters^2
        public static double MetersSquaredToCentimetersSquared(double metersSquared) =>
            metersSquared * 10000.0;

        // Feet^2 to Inches^2
        public static double FeetSquaredToInchesSquared(double feetSquared) =>
            feetSquared * 144.0;

        // Inches^2 to Feet^2
        public static double InchesSquaredToFeetSquared(double inchesSquared) =>
            inchesSquared / 144.0;

        // Centimeters^2 to Inches^2
        public static double CentimetersSquaredToInchesSquared(double centimetersSquared) =>
            centimetersSquared * 0.155000;

        // Inches^2 to Centimeters^2
        public static double InchesSquaredToCentimetersSquared(double inchesSquared) =>
            inchesSquared / 0.155000;
    }

    public class Speed
    {
        // km/h to mph
        public static double KmhToMph(double kmh) =>
            kmh * 0.621371;

        // mph to km/h
        public static double MphToKmh(double mph) =>
            mph / 0.621371;
    }

    public class Angles
    {
        // Degrees to Radians
        public static double DegreesToRadians(double degrees) =>
            degrees * (Math.PI / 180.0);

        // Radians to Degrees
        public static double RadiansToDegrees(double radians) =>
            radians * (180.0 / Math.PI);
    }

    public class Time
    {
        // Seconds to Minutes
        public static double SecondsToMinutes(double seconds) =>
            seconds / 60.0;

        // Minutes to Seconds
        public static double MinutesToSeconds(double minutes) =>
            minutes * 60.0;

        // Minutes to Hours
        public static double MinutesToHours(double minutes) =>
            minutes / 60.0;

        // Hours to Minutes
        public static double HoursToMinutes(double hours) =>
            hours * 60.0;

        // Hours to Days
        public static double HoursToDays(double hours) =>
            hours / 24.0;

        // Days to Hours
        public static double DaysToHours(double days) =>
            days * 24.0;

        // Days to Weeks
        public static double DaysToWeeks(double days) =>
            days / 7.0;

        // Weeks to Days
        public static double WeeksToDays(double weeks) =>
            weeks * 7.0;

        // Milliseconds to Seconds
        public static double MillisecondsToSeconds(double milliseconds) =>
            milliseconds / 1000.0;

        // Seconds to Milliseconds
        public static double SecondsToMilliseconds(double seconds) =>
            seconds * 1000.0;
    }

    public class Data
    {
        // Kilobytes to Megabytes
        public static double KilobytesToMegabytes(double kilobytes) =>
            kilobytes / 1024.0;

        // Megabytes to Kilobytes
        public static double MegabytesToKilobytes(double megabytes) =>
            megabytes * 1024.0;

        // Megabytes to Gigabytes
        public static double MegabytesToGigabytes(double megabytes) =>
            megabytes / 1024.0;

        // Gigabytes to Megabytes
        public static double GigabytesToMegabytes(double gigabytes) =>
            gigabytes * 1024.0;

        // Gigabytes to Terabytes
        public static double GigabytesToTerabytes(double gigabytes) =>
            gigabytes / 1024.0;

        // Terabytes to Gigabytes
        public static double TerabytesToGigabytes(double terabytes) =>
            terabytes * 1024.0;
    }
}