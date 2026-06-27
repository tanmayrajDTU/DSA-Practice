class Solution{
    public void Pattern19(int n){
       //upper part
       for ( int i = 1; i <= n; i++){
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
        //lower part
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
}
