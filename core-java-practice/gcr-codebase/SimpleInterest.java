import java.util.Scanner;

public class SimpleInterest {
    public static void main(String[] args) {
        //read input
        Scanner sc=new Scanner(System.in);

        System.out.println("Enter the Principal amount: ");
        int principal = sc.nextInt(); //take principal as input

        System.out.println("Enter the rate: ");
        int rate=sc.nextInt(); //take rate as input

        System.out.println("Enter the time: ");
        int time=sc.nextInt(); //take time as input

        //calculate the simple interest
        int si=(principal*rate*time) /100;
        
        System.out.println("The simple interest is: "+ si);


    }
}
