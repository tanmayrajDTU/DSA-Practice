public class Solution
{
    public int ReverseNumber(int n)
    {
        int reverseNo = 0;
        while ( n > 0 ){
            int rem = n % 10;
            reverseNo = reverseNo * 10 + rem;
            n = n/10;
        }
        return reverseNo;
    }
}