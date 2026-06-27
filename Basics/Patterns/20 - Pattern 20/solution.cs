class Solution {
    private void LowerPart(int n){
        for ( int i = 2; i <= n; i++){
            for ( int j = 1; j <= n-i+1 ; j++){
                Console.Write("*");
            }
            for ( int j = 1; j <= 2*(i-1) ; j++){
                Console.Write(" ");
            }
            for ( int j = 1; j <= n-i+1 ; j++){
                Console.Write("*");
            }
            Console.WriteLine();
       }
    }
    private void UpperPart( int n){
        for ( int i = 1; i <= n; i++){
            for ( int j = 1; j <= i ; j++){
                Console.Write("*");
            }
            for ( int j = 1; j <= 2*(n-i) ; j++){
                Console.Write(" ");
            }
            for ( int j = 1; j <= i ; j++){
                Console.Write("*");
            }
            Console.WriteLine();
       }
    }
    public void pattern20(int n) {
        Solution sol = new Solution();
        sol.UpperPart(n);
        sol.LowerPart(n);
    }
}