class Solution {
    public static bool PalindromeCheck(string s) {
        int start = 0, end = s.Length-1;
        while(start < end){
            if(s[start] != s[end]){
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}