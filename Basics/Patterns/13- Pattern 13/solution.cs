class Solution {
    public void pattern13(int n) {
        int counter = 1;
        for (int i = 1; i <= n; i++){
            for ( int j = 1; j <= i; j++){
                Console.Write(counter + " ");
                counter++;
            }
            Console.WriteLine();
        }
    }
}