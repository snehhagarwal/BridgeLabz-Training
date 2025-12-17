
import java.util.Scanner;

public class VolumeOfCylinder{
      public static void main(String[] args) {
        // read input
        Scanner sc=new Scanner(System.in);

        System.out.print("Enter the radius of the cylinder: ");
        int radius=sc.nextInt();  //take input

        System.out.print("Enter the height of the cylinder: ");
        int height=sc.nextInt();  //take input 

        //formula to calculate the volume of cylinder
        double volume=Math.PI * Math.pow(radius,2) * height;

        //printing the volume 
        System.out.println("The volume of the cylinder is :" + volume);

      }
}