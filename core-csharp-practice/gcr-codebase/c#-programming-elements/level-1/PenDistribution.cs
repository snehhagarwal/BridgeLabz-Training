using System;

class PenDistribution{
    static void Main(){
          //pen available
          int pen = 14;

          //to be distributed among 
          int students = 3;
          
          //pen per student
          int penstudent= pen/student ;

          //remaining pens
          int remainingpens = pen%students ;

          Console.WriteLine("The pen per student is " + penstudent + " and the remaining pen not distributed is " + remainingpens);
    }
}