public class ReverseString {
    public void reverseString(char[] s){
        int l=0;             //left pointer
        int r=s.length-1;  //right pointer

        //swap the characters until the points meet 
        while(l<r){
             char temp=s[l];   //third variable to store left char
             s[l]=s[r];        //move right char to left
             s[r]=temp;        //move left char to right

             l++;              //move left forward 
             r--;              //move right backward
        }
    }
}
