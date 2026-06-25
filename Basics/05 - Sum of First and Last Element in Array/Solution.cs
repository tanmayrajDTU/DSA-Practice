public class Solution {
    public int sumOfFirstAndLast(int[] nums) {
        int sum = nums[0] + nums[nums.Length-1];
        return sum;
    }
}