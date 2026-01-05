using System;

// Bill utility class
public class Bill
{
  public static void Generate(IPayable payable)
  {
        // Generates bill using interface
        Console.WriteLine("Bill Amount: " + payable.CalculateBill());
  }
}
