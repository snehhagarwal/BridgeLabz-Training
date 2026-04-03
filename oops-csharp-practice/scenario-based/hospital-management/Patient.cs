using System;

public abstract class Patient
{
  // Property to store unique patient ID
  public int PatientId
  {
    get;
    set;
  }
  // Property to store patient name
  public string Name
  {
    get;
    set;
  }
  // Property to store patient age
  public int Age
  {
    get;
    set;
  }
  
  // Abstract method to display patient details
  protected abstract void Display();
}
    
