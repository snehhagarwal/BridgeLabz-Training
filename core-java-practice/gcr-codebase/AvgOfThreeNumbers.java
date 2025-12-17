import java.util.Scanner;
import java.util.*;

public class AvgOfThreeNumbers {
    public static void main(String[] args) {
        //read input
        Scanner sc=new Scanner(System.in);

        System.out.println("Enter the first number: ");
        int n1=sc.nextInt(); //take number 1 as input

        System.out.println("Enter the second number: ");
        int n2=sc.nextInt(); //take number 2 as input

        System.out.println("Enter the thirs number: ");
        int n3=sc.nextInt(); //take number 3 as input

        //calculate the average
        int average=(n1+n2+n3)/3;

        //printing the avg
        System.out.println("The average of three numbers is: "+ average);
        
    }
}
