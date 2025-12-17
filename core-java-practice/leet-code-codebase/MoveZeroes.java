public class MoveZeroes {
    public static void movezeroes(int[] num){
          int j=0; //position 

          for(int i=0;i<num.length;i++){
            if(num[i]!=0){
                num[j++]=num[i]; //move non zero
            }
            while(j<num.length){
                num[j++]=0; //fill the zeroes
            }
          }

    }
    
}
