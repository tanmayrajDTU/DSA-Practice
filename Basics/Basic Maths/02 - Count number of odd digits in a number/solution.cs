class Solution {
    public int countOddDigit(int n) {
        int countOdd = 0;
        while ( n > 0 ){
            int digit = n % 10;
            if((digit & 1) == 1){
                countOdd++;
            }
            n = n / 10;
        }
        return countOdd;
    }
}