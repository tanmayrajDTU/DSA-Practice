class Solution{
    public int countOdd(int[] arr, int n) {
        int cntOdd = 0;
        for ( int i = 0; i < n ; i++){
            if ( (arr[i] & 1) == 1) cntOdd++;
        }
        return cntOdd;
    }
}