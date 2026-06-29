public class Solution
{
    public void reverse(int[] arr, int n)
    {
        int start = 0, end = n-1;
        while ( start < end ){
            arr[start] = arr[start] + arr[end];
            arr[end] = arr[start] - arr[end];
            arr[start] = arr[start] - arr[end];
            start++;
            end--;
        }
    }
}
