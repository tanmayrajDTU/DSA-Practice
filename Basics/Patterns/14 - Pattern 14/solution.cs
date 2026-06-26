class Solution {
    public void Pattern14(int n) {
        for ( int i = 1; i <= n ; i++ ){
            for (char a = 'A'; a < 'A' + i; a++ ){
                Console.Write(a);
            }
            Console.WriteLine();
        }
    }
}