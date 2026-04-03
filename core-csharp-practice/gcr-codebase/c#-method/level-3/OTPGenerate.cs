using System;

class OTPGenerate
{
    static void Main(string[] args)
    {
        int[] otp=new int[10];

        for(int i = 0; i < otp.Length; i++)
        {
            otp[i]=Generate();
        }

        Console.WriteLine("Generated OTPs: ");
        for(int i = 0; i < otp.Length; i++)
        {
            Console.WriteLine("OTP " + (i+1) + " : " + otp[i]);
        }

        bool isUnique=Unique(otp);
        if (isUnique)
        {
            Console.WriteLine("All OTPs are Unique");
        }
        else
        {
            Console.WriteLine("OTPs are not Unique");
        }
    }

    public static int Generate()
    {
        Random r=new Random();
        int otp=r.Next(100000,1000000);
        return otp;
    }

    public static bool Unique(int[] otp)
    {
        for(int i = 0; i < otp.Length; i++)
        {
            for(int j = i + 1; j < otp.Length; j++)
            {
                if (otp[i] == otp[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}