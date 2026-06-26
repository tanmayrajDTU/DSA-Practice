class Solution {
    private void pattern2(int n)
    {
        for(int i=0; i < n; i++){
            for(int j=0; j<=i; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    private void pattern5(int n) {
        for(int i=1; i<=n; i++){
            for(int j=1;j<=n-i+1; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        } 
    }
    public void pattern10(int n) {
        Solution sol = new Solution();
        sol.pattern2(n);
        sol.pattern5(n-1);
    }
}