using System;

class TwoSum{
    public static int[] TwoSum(int[] nums,int target){

        int[] result=new int[2]; //storing the possible pairs
        for(int i=0;i<nums.Length;i++){  
            for(int j=i+1;j<nums.Length;j++){
                if(nums[i]+nums[j]==target){  //if sums upto target
                    result[0]=i;              //first number
                    result[1]=j;              //second number
                    return result;
                }
            }
        }
    }
}