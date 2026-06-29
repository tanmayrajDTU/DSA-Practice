public class Solution
{
    public int SumHighestAndLowestFrequency(int[] nums)
    {
        int[] visited = new int[10001];
        for(int i = 0; i< nums.Length; i++){
            visited[nums[i]]++;
        }
        int maxFreq = 0, minFreq = 10001;
        for(int i = 0; i< 10001; i++){
            if (visited[i] != 0){
                maxFreq = Math.Max(maxFreq, visited[i]);
                minFreq = Math.Min(minFreq, visited[i]);
            }
        }
        return maxFreq + minFreq;
    }
}