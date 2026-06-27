public class Solution {
    public int countDigit(int n) {
        if(n==0)return 1;
        return (int)Math.Log10(n)+1;
    }
}