class Solution
{
    public bool IsPrime(int n){
       if ( n== 1)return false;
       for ( int i = 2; i * i <= n; i++ ){
        if ( n % i == 0){
            return false;
        }
       }
       return true;
    }
    public static int PrimeUptoN(int n)
    {
        if ( n == 0) return 0;
        Solution sol = new Solution();
        int countOfPrimes = 1;//including for 2 earlier
        for(int i = 3; i <= n ; i+=2){
            if(sol.IsPrime(i) == true)countOfPrimes++;
        }
        return countOfPrimes;
    }
}