public class Solution
{
    public int arraySum(int[] nums)
    {
        return this.Sum(nums, 0);
    }
    private int Sum(int[] nums, int left){
        if(left >= nums.Length){
            return 0;
        }
        return nums[left] + this.Sum(nums, left+1);
    }
}