public class Solution {
    private void Pattern7(int n)
    {
        for(int i=0; i<n; i++){
            for(int j=0; j<n-i-1; j++){
                Console.Write(" ");
            }
            for(int j=0; j<(2*i)+1; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    private void pattern8(int n) {
        for ( int i = 0; i < n ; i++){
            for ( int j = 0; j < i; j ++ ){
                Console.Write(" ");
            }
            for ( int j = 0; j < 2* (n-i) - 1; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public void pattern9(int n) {
        Solution sol = new Solution();
        sol.Pattern7( n );
        sol.pattern8( n );
    }
}