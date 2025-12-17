import java.util.*;

public class ValidParentheses {
    public static boolean check(String str){
            //initializing stack for open brackets
            Stack<Character> st =new Stack<>();
            for(char ch: str.toCharArray()){
                //storing the open brackets
                if(ch=='[' || ch=='{' || ch=='('){
                    st.push(ch);
                }
                else{
                    //if already empty stack so false
                    if(st.isEmpty()){
                        return false;
                    }
                    //top character in stack
                    char top=st.pop();
                    //checking all the edge cases
                    if(ch==')' && top!='('){
                        return false;
                    }
                    if(ch==']' && top!='['){
                        return false;
                    }
                    if(ch=='}' && top!='{'){
                        return false;
                    }
                }
            }
            return st.isEmpty();
    }
}
