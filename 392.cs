//PROBLEM: 392. Is Subsequence (https://leetcode.com/problems/is-subsequence/)

public class Solution {
    public bool IsSubsequence(string s, string t) {
        int j = 0; //used to track how many matching characters were found
        for (int i = 0; i < t.Length && j < s.Length; i++){
            if (s[j] == t[i]){ //when a character is the same in both strings...
                j++; //adds when character found!
            }
        }
        return (j == s.Length); //if all characters are found, j will be the same length as orig string
    }
    
}
