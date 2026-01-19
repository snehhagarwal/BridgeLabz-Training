using System;
class BMI : Fitness
{
    public override void bmi()
    {
        int calc = weight / (height * height);
        return calc;
    }
}