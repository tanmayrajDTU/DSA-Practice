public class Solution
{
    private int ReverseNumber(int n)
    {
        int reverseNo = 0;
        while ( n > 0 ){
            int rem = n % 10;
            reverseNo = reverseNo * 10 + rem;
            n = n/10;
        }
        return reverseNo;
    }
    public bool IsPalindrome(int n)
    {
        Solution sol = new Solution();
        int revNo = sol.ReverseNumber(n);
        if( n == revNo){
            return true;
        }
        return false;
    }
}