class Solution {
    private int countDigit(int n) {
        if(n==0)return 1;
        return (int)Math.Log10(n)+1;
    }
    public bool isArmstrong(int n) {
        Solution sol = new Solution();
        int digits = sol.countDigit(n);
        int originalNo = n;
        int newNo = 0;
        while ( n > 0 ){
            int rem = n % 10;
            n = n / 10;
            newNo += (int)Math.Pow(rem,digits);
        }
        if(newNo == originalNo){
            return true;
        }
        return false;
    }
}