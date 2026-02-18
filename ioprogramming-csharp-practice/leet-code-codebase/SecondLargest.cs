public class Solution {
    public int SecondLargest(int[] nums) {

        int first = int.MinValue;
        int second = int.MinValue;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > first)
            {
                second = first;
                first = nums[i];
            }
            else if(nums[i] > second && nums[i] != first)
            {
                second = nums[i];
            }
        }

        return second;
    }
}
