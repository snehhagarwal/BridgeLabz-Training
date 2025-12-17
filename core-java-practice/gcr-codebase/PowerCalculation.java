import java.util.*;

public class PowerCalculation {
    public static void main(String[] args) {
        //read input
        Scanner sc=new Scanner(System.in);

        System.out.println("Enter the base");
        double base=sc.nextDouble(); //take base as input

        System.out.println("Enter the exponent");
        double exponent=sc.nextDouble(); //take exponent as input

        //calculate the power
        double power=Math.pow(base,exponent);

        System.out.println("The solution of power calculation is: " + power);

    }
}
