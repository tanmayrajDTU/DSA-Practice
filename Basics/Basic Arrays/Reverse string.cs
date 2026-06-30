public class Solution
{
    public void reverseString(char[] s)
    {
        //your code goes here
        int start =0, end = s.Length-1;
        while ( start< end)
        {
            s[start]= (char)(s[start]+ s[end]);
            s[end]= (char)(s[start]- s[end]);
            s[start] = (char)(s[start]- s[end]);
            start++;
            end--;
        }
    }
}
