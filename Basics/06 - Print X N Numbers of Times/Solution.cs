class Solution
{
    public static void PrintX(int X, int N)
    {
        for(int i = 0; i < N; i++){
            if(i == N-1){
                Console.Write($"{X}");
            }
            else{
                Console.Write($"{X} ");
            }
        }
        Console.WriteLine();
    }
}