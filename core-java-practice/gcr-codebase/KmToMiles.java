import java.util.Scanner;

public class KmToMiles {
    public static void main(String[] args){
        //read input
        Scanner sc=new Scanner(System.in);

        System.out.println("Enter the distance in kilometers: ");
        double dist=sc.nextDouble(); //take input as km 
  
        //convert in miles
        double miles=dist * 0.621371;

        System.out.println("The distance in Miles is: " + miles);
        
    }
}
