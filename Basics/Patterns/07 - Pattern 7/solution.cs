class Solution
{
    public void Pattern7(int n)
    {
        for(int i=0; i<n; i++){
            for(int j=0; j<n-i-1; j++){
                Console.Write(" ");
            }
            for(int j=0; j<(2*i)+1; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}