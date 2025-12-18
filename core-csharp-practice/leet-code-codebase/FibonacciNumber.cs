using System;

class FibonacciNumber{
    public int(int n){
        //base case
        if(n<=1){
            return n;
        }

        int a=0;  //first fibonacci number
        int b=1;  //second fibonacci number

        for(int i=2;i<=n;i++){
            int c=a+b;  //next fibonacci number
            a=b;        //shift
            b=c;
        }

        return b;
    }
}