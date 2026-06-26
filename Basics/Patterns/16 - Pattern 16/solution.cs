class Solution {
    public void pattern16(int n) {
        char ch = 'A';
        for ( int i = 0; i < n; i++) {
            for ( int j = 0; j <= i; j++){
                Console.Write(ch);
            }
            ch++;
            Console.WriteLine();
        }
    }
}