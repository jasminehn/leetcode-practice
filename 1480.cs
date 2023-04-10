//PROBLEM: 1480. Running Sum of 1d Array (https://leetcode.com/problems/running-sum-of-1d-array/)

public class Solution {
    public int[] RunningSum(int[] nums) {
        for(int i=0; i<nums.Length-1; i++){
            nums[i+1] += nums[i];
        }
        return nums;
    }
}
