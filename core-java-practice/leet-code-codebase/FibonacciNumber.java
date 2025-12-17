
public class FibonacciNumber {
    public int func(int n){
        //base case
        if(n<=1){
            return n;
        }
        int a=0; //first fibonacci
        int b=1; //second fibonacci
        for(int i=2;i<=n;i++){
            int c=a+b; //next fib
            a=b;       //shift
            b=c;
        }

        return b;    //nth fibonacci number
    }
}
