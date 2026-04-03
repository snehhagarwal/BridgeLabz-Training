using System;

class DataTypes{
    public static void Main(string[] args){

        Console.WriteLine("Primitive datatypes are: ");

        //byte data type
        byte num1=2;
        Console.WriteLine("The byte number(8 bit) is: " + num1);

        //short data type
        short num2=3200;
        Console.WriteLine("The short number(16 bit) is: " + num2);

        //integer data type
        int num3=30000;
        Console.WriteLine("The integer number(32 bit) is: " + num3);

        //long data type
        long num4=5000000000L;
        Console.WriteLine("The long number(64 bit) is:" + num4);

        //float data type
        float num5=34.67F;
        Console.WriteLine("The float number(32 bit) is: " + num5);

        //double data type
        double num6=34568.345;
        Console.WriteLine("The double number(64 bit) is: " + num6);

        //char data type
        char ch='A';
        Console.WriteLine("The char value(16 bit) is: " + ch);

        //bool data type
        bool valid=true;
        Console.WriteLine("The boolean value is: " + valid);

        //TYPE CONVERSION
        //Implicit conversion(smaller to larger)
        //1
        int val=78;
        double di=val;
        Console.WriteLine("The integer number converted to double is: " + di);

       //2
        byte b=5;
        int t=b;
        Console.WriteLine("The byte number coverted to int is: " + t);

        //Explicit Type conversion (larger to smaller)
        //1
        double dou=7890.3456;
        int din=(int)dou;

        //using Convert.To
        //2
        int r=Convert.ToInt32(13.57);
        bool p=Convert.ToBoolean("true");
        char c=Convert.ToChar("T");
        
    }
}