import java.util.Scanner;

public class CelsuisToFahrenheit {
    public static void main(String[] args) {
        //read input
        Scanner sc=new Scanner(System.in);

        System.out.print("Enter the temperature in celsius: ");
        double celsuis=sc.nextDouble(); //take input temp in celsius

        //conversion to fahrenheit
        double fahrenheit=(celsuis*9/5)+32;

        //printing the output
        System.out.println("Temperature in Fahrenheit: "+ fahrenheit);
    }
}
