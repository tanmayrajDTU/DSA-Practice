class Solution
{
    public void pattern4(int n)
    {
        //your code goes here
        for(int i= 1; i<=n; i++){
            for (int j = 1; j<=i; j++){
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}