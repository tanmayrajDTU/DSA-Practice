public class Solution
{
    public static int MostFrequentElement(int[] nums)
    {
        int[] visited = new int[10001];
        for(int i = 0; i< nums.Length; i++){
            visited[nums[i]]++;
        }
        int maxFreq = 0, element = -1;
        for ( int i = 0; i < 10001; i++){
            if(visited[i] != 0 ){
                if(visited[i]> maxFreq){
                    maxFreq = visited[i];
                    element = i;
                }
            }
        }
        return element;
    }
}
