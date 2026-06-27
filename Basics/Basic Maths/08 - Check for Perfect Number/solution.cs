class Solution {
    public bool IsPerfect(int n) {
        if( n == 1) return false;
        int divisorSum = 1;
        for ( int i = 2; i * i <= n; i++ ){
            if( n % i == 0){
                divisorSum += i;
                if (( n / i) != i){
                    divisorSum += ( n / i);
                } 
            }
        }
        if( divisorSum == n ){
            return true;
        }
        return false;
    }
}