class Solution {
    public void pattern3(int n)
    {
        for(int i=0; i<n; i++){
            for(int j=0;j<=i; j++){
                Console.Write(j+1);
            }
            Console.WriteLine();
        }
    }
}