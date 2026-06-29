public class Solution
{
    public int SecondMostFrequentElement(int[] nums)
    {
        int[] visited = new int[10001];
        for(int i = 0; i< nums.Length; i++){
            visited[nums[i]]++;
        }
        int maxFreq1 = 0,maxFreq2 = 0;
        int element1 = -1 , element2 = -1;
        for ( int i = 0; i < 10001; i++){
            if(visited[i] != 0 ){
                if(visited[i]> maxFreq1){
                    maxFreq2 = maxFreq1;
                    element2 = element1;
                    maxFreq1 = visited[i];
                    element1 = i;
                }
                else if(visited[i] == maxFreq1){
                    if( element1 > i){
                        element1 = i;
                    }
                }
                else if (visited[i] == maxFreq2 && element2 > i){
                    element2 = i;
                }
                else if (visited[i] > maxFreq2){
                    maxFreq2 = visited[i];
                    element2 = i;
                }
            }
        }
        return element2;     
    }
}