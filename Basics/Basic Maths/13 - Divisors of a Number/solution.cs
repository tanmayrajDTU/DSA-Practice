public class Solution
{
    public List<int> Divisors(int n)
    {
        List<int> ans = new List<int>();
        for ( int i = 1; i * i <= n; i++ ){
            if (n % i == 0){
                ans.Add(i);
                if( i != (n/i)){
                    ans.Add(n/i);
                }
            }
        }
        ans.Sort();
        return ans;
    }
}