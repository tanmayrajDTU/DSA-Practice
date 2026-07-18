public class Solution {
    public int[] SelectionSort(int[] nums) {
        for(int i = 0; i< nums.Length-1; i++){
            int mini = i;
            for(int j = i; j <= nums.Length - 1; j++){
                if(nums[j] < nums[mini]){
                    mini = j;
                }
            }
            int temp = nums[i];
            nums[i] = nums[mini];
            nums[mini] = temp;
        }
        return nums;
    }
}