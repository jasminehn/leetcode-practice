//PROBLEM: 724. Find Pivot Index (https://leetcode.com/problems/find-pivot-index/)

public class Solution {
    public int PivotIndex(int[] nums) {
        int[] sumL = new int[nums.Length];
        int[] sumR = new int[nums.Length];
        
        for(int i=1; i<nums.Length; i++){
            sumL[i] = nums[i - 1] + sumL[i-1];
        }
        for(int i=nums.Length-2; i>=0; i--){
            sumR[i] = nums[i + 1] + sumR[i+1];
        }

        for(int i=0; i<nums.Length; i++){
            if(sumL[i]==sumR[i]){
                return i;
            }
        }
        return -1;
    }
}
