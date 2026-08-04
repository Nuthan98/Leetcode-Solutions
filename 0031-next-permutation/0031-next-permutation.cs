public class Solution {
    public int[] NextPermutation(int[] nums) {
        int ind = -1;
        for(int i=nums.Length-2; i>=0; i--)
        {
            if(nums[i]<nums[i+1])
            {
                ind = i;
                break;
            }    
        }
        if(ind == -1)
        {
            Array.Reverse(nums); 
            return nums;
        }
        for(int i=nums.Length-1; i>ind; i--)
        {
            if(nums[i]>nums[ind])
            {
                int temp = nums[i];
                nums[i] = nums[ind];
                nums[ind] = temp;
                break;
            }
        }
        Array.Reverse(nums, ind + 1, nums.Length - ind - 1);
        return nums;
    }
 
}