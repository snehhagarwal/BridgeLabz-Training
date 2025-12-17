
import java.util.Scanner;

public class PowerCalculation {
    public static void main(String[] args) {
        //read input
        Scanner sc=new Scanner(System.in);

        System.out.println("Enter the base");
        int base=sc.nextInt(); //take base as input

        System.out.println("Enter the exponent");
        int exponent=sc.nextInt(); //take exponent as input

        //calculate the power
        double power=Math.pow(base, exponent);

        System.out.println("The solution of power calculation is: " + power);

    }
}
