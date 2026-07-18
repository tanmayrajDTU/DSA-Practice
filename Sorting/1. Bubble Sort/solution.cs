public class Solution {
    public int[] BubbleSort(int[] nums) {
        // Write your code here
        int n = nums.Length;
        for(int i = 0; i < n-1; i++ ){
            int didSwap = 0;
            for(int j = 0; j < n-i-1; j++){
                if(nums[j] > nums[j+1]){
                    int temp = nums[j];
                    nums[j] = nums[j+1];
                    nums[j+1] = temp;
                    didSwap++;
                }
            }
            if(didSwap == 0){
                break;
            }
        }
        return nums;
    }
}