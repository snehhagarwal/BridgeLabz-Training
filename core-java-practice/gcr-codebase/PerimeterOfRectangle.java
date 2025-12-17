import java.util.Scanner;

public class PerimeterOfRectangle {
    public static void main(String[] args) {
        //read input
        Scanner sc=new Scanner(System.in);

        System.out.println("Enter the length: ");
        int length=sc.nextInt(); //take length as input

        System.out.println("Enter the breadth: ");
        int breadth=sc.nextInt(); //take breadth as input

        //calculate the perimeter
        int perimeter=2*length*breadth;

        System.out.print("The perimeter of the rectangle is: "+ perimeter);

    }
}
