import java.util.*;

public class PalindromeString {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);

        //Enter the string 
        String str=sc.nextLine();

        System.out.println(func(str));
    }

    //function to check the palindrome string
    public static boolean func(String s){
        //solved using two pointer approach
        int left=0;  
        int right=s.length()-1;

        //condition to break the loop 
        while(left<right){
            //checks the letters from both the ends of the string
            if(s.charAt(left)!=s.charAt(right)){
                return false;
            }
            left++;  //increase the starting pointer
            right--; //decrease the ending pointer
        }
        //if all the letters are same then the string is palindrome
        return true;
    }
}

