import java.util.*;

public class AreaOfCircle {
    public static void main(String[] args) {
        //read input
        Scanner sc=new Scanner(System.in);

        System.out.print("Enter the radius of the circle: ");
        int radius =sc.nextInt(); //take radius as input

        //formula to calculate the area
        double area=Math.PI * radius * radius;

        System.out.println("The area of the circle is: " + area);
 
    }
}
