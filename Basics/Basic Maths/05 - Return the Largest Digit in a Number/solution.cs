public class Solution
{
    public int LargestDigit(int n)
    {
        int largestDigit = 0;
        while ( n > 0 ){
            int rem = n % 10;
            n = n / 10;
            largestDigit = Math.Max(largestDigit, rem);
        }
        return largestDigit;
    }
}