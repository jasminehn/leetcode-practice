//PROBLEM: 2011. Final Value of Variable After Performing Operations (https://leetcode.com/problems/final-value-of-variable-after-performing-operations/)

public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int result = 0;
        foreach(string s in operations){
            if(s.Contains('+')){
                result++;
            }else{
                result--;
            }
        }
        return result;
    }
}
