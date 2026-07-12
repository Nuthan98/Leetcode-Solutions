public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();

        if(nums.Length <= 2)
            return res;
        
        Array.Sort(nums);

        int i = 0, j, k, I;
        while(i < nums.Length - 2)
        {
            I = nums[i] * -1;
            j = i + 1;
            k = nums.Length - 1;

            while(j<k)
            {
                if(nums[j] + nums[k] > I)
            {
                --k;
            }
            else if(nums[j] + nums[k] < I)
            {
                ++j;
            }
            else
            {
                IList<int> current_res = new List<int>(){nums[i], nums[j], nums[k]};
                res.Add(current_res);

                while(j<k && current_res[1] == nums[j])
                    j++;
                while(j<k && current_res[2] == nums[k])
                    k--;
            }
            
        }
        int current_start = nums[i];
        while(i < nums.Length - 2 && nums[i] == current_start)
            i++;
            
        }
        return res;
    }
}