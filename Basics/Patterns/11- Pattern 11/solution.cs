class Solution {
    public void pattern11(int n) {
        int k = 1;
        for ( int i = 1; i <= n; i++){
            if(i % 2 == 1){
                k = 1;
            }
            else{
                k = 0;
            }
            for ( int j = 1; j <= i; j++){
                Console.Write(k+" ");
                k = 1 - k;
            }
            Console.WriteLine();
        }
    }
}