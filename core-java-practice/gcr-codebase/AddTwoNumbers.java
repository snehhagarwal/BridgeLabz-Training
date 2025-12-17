import java.util.Scanner;

public class AddTwoNumbers {
    public static void main(String[] args) {
        //read input
        Scanner sc=new Scanner(System.in);

        int number1=sc.nextInt(); //take number 1
        int number2=sc.nextInt(); //take number 2

        //variable to store the sum of numbers
        int c=number1+number2;
        
        //printing the sum 
        System.out.println("The sum of the two numbers is: " + c);
    }
}
