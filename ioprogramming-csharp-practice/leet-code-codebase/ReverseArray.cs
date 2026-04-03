public class Solution {
    public void Reverse(int[] nums) {

        int left = 0;
        int right = nums.Length - 1;

        while(left < right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;

            left++;
            right--;
        }
    }
}
