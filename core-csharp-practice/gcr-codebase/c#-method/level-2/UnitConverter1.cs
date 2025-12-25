using System.Runtime.InteropServices;

class UnitConverter1
{
    public static double ConvertKmToMiles(double km)
    {
        return km*0.621371;
    }
    public static double ConvertMilesToKm(double miles)
    {
        return miles*1.60934;
    }
    public static double ConvertMetersToFeet(double m)
    {
        return m*3.28084;
    }
    public static double ConvertFeetToMeters(double f)
    {
        return f*0.3048;
    }
}