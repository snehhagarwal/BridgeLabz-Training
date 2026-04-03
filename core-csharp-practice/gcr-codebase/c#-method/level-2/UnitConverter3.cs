using System;

class UnitConverter3
{
    public static double FahrenheitToCelsius(double f)
    {
        return (f-32)*5/9;
    }
    public static double CelsiusToFahrenheit(double c)
    {
        return (c*9/5)+32;
    }
    public static double PoundsToKg(double p)
    {
        return p*0.453592;
    }
    public static double KgToPounds(double k)
    {
        return k*2.20462;
    }
    public static double GallonsToLitres(double g)
    {
        return g*3.78541;
    }
    public static double LitresToGallons(double l)
    {
        return l*0.264172;
    }
}