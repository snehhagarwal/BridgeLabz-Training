using System;

class MoveZeroes{
    static void func(int[] num){
        int j=0; //for position

        for(int i=0;i<num.Length;i++){
            if(num[i]!=0){
                num[j++]=num[i];  //move non zero
            }
        }
            while(j<num.Length){
                num[j++]=0;      //fill the zero in last 
            }
    }
}