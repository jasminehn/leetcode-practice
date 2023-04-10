//PROBLEM: 205. Isomorphic Strings (https://leetcode.com/problems/isomorphic-strings/)

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        int[] m1 = new int[256];
        int[] m2 = new int[256];

        for (int i = 0; i < s.Length; i++) {
            if (m1[s[i]] != m2[t[i]]) return false;
            m1[s[i]] = i + 1;
            m2[t[i]] = i + 1;
        }
        return true;
    }
}
