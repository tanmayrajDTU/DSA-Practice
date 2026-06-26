public class Solution {
    public void pattern17(int n) {
        for ( int i = 0; i < n; i++ ) {
            char ch = 'A';
            for ( int j = 0; j < n-i-1; j++ ){
                Console.Write(" ");
            } 
            for ( int j = 0; j < (2*i)+1; j++ ){
                Console.Write(ch);
                if( j < i){
                    ch++;
                }
                else{
                    ch--;
                }
            }
            Console.WriteLine();
        }
    }
}