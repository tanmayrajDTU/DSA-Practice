class Solution {
    public void pattern12(int n)
    {
        for ( int i = 1; i <= n ; i++ ){
            for ( int j = 1; j <= i; j++){
                Console.Write(j);
            }
            for ( int s = 1; s <= (2*n)-(2*i); s++){
                Console.Write(" ");
            }
            for ( int j = i; j >= 1; j--){
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}