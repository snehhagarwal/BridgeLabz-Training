public class Solution {
    public bool IsSorted(int[] nums) {

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] < nums[i-1])
                return false;
        }

        return true;
    }
}
