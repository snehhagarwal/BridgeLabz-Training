using System;

class ValidParetheses{
      public static bool isValid(string str){
        Stack<char> st=new Stack<>();

        foreach(char ch in str){
            //push opening brackets
            if(ch=='(' || ch=='{' || ch=='['){
                st.push(ch);
            }
            else{
                //edge case
                if(st.Count==0){
                    return false;
                }
                //top element of stack
                char top=st.Pop();
                
                if(ch==']' && top!='['){
                    return false;
                }
                if(ch==')' && top!='('){
                    return false;
                }
                if(ch=='}' && top!='{'){
                    return false;
                }
            }
        }
        return st.Count==0; //if the stack is empty string is valid
      }
}