public class Solution
{
    public void Pattern22(int n)
    {
        for ( int i = 0; i < ((2*n) -1) ; i++ ){
            for(int j = 0; j < ((2*n) -1); j++ ){
                int top = i, bottom = 2*n - i-2, left = j, right = 2*n - j-2;
                Console.Write(n- Math.Min(top, Math.Min(left, Math.Min(right, bottom))) +" ");
            }
            Console.WriteLine();
        }
    }
}